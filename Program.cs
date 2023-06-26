using System;
using System.Collections.Generic;
using System.Diagnostics;  // support for Process
using System.Runtime.InteropServices;  // support for DllImport
using System.Threading;
using dotnetCore_win_dashboard_Factories;
using dotnetCore_win_dashboard_Models;


namespace dotnetCore_win_dashboard
{
    class Program
    {
        public const int SWP_NOZORDER = 0x0004;  //ignores Z-ordering of windows

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


        static void Main(string[] args)
        {
            List<WindowDetails> windowDetailsList = new List<WindowDetails>();
            string profileType = args[0];

            switch (profileType)
            {
                case "laptop":
                    WindowDetailsFactory_laptop wdf_laptop = new WindowDetailsFactory_laptop();
                    windowDetailsList = wdf_laptop.GetWindowDetailsList();
                    break;

                case "dev_server":
                    WindowDetailsFactory_dev_server wdf_dev_server = new WindowDetailsFactory_dev_server();
                    windowDetailsList = wdf_dev_server.GetWindowDetailsList();
                    break;

                default:
                    break;
            }

            ProcessWindowDetailsList(windowDetailsList, profileType);

            // in case any sluggish apps keep command prompt open
            Environment.Exit(0);
        }


        static void ProcessWindowDetailsList(List<WindowDetails> windowDetailsList, string profileType)
        {
            foreach (WindowDetails wd in windowDetailsList)
            {
                using (Process process = Process.Start(wd.Process, wd.Argument))
                {
                    WaitForAppStart(profileType, wd.WindowTitle);

                    IntPtr handle = FindWindow(null, wd.WindowTitle);

                    SetWindowPos(handle, IntPtr.Zero, wd.WindowPosition.X, wd.WindowPosition.Y, wd.WindowPosition.CX, wd.WindowPosition.CY, SWP_NOZORDER);
                };
            }
        }


        static void WaitForAppStart(string profileType, string windowTitle)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Program.WaitForAppStart() - waiting for app to start - windowTitle: {windowTitle}");

            switch (profileType)
            {
                case "laptop":
                    switch(windowTitle)
                    {
                        case "Inbox - Outlook":
                        case "Microsoft Teams":
                            Thread.Sleep(30000);
                            break;

                        default:
                            Thread.Sleep(3000);
                            break;
                    }
                    break;

                case "dev_server":
                    switch(windowTitle)
                    {
                        case "Microsoft Azure Storage Explorer":
                            Thread.Sleep(5000);
                            break;

                        default:
                            Thread.Sleep(1000);
                            break;
                    }
                    break;

                default:
                    Console.WriteLine($"Program.WaitForAppStart() - Invalid profileType: {profileType}");
                    break;
            }
        }

    }
}