using System;
using System.Collections.Generic;
using dotnetCore_win_dashboard_Models;


namespace dotnetCore_win_dashboard_Factories
{
    class WindowDetailsFactory_dev_server
    {
        protected string _process1 = "explorer.exe";
        protected string _argument1 = @"C:\ProgramData\Microsoft\Windows\WER\ReportQueue\";
        protected string _windowTitle1 = "ReportQueue";
        protected WindowPosition _winPos1 = new WindowPosition() { X = -763, Y = 0, CX = 770, CY = 100 };  // -770, 0  (top right corner of left monitor)

        protected string _process2 = "explorer.exe";
        protected string _argument2 = @"E:\JobsQueue\";
        protected string _windowTitle2 = "JobsQueue";
        protected WindowPosition _winPos2 = new WindowPosition() { X = -763, Y = 236, CX = 770, CY = 100 };

        protected string _process3 = "explorer.exe";
        protected string _argument3 = @"E:\Compiled\jobQueueDriver\logs\";
        protected string _windowTitle3 = "logs";
        protected WindowPosition _winPos3 = new WindowPosition() { X = -763, Y = 472, CX = 770, CY = 100 };

        protected string _process4 = "explorer.exe";
        protected string _argument4 = @"E:\Compiled\serviceBusQueueDriver\logs\";
        protected string _windowTitle4 = "logs";
        protected WindowPosition _winPos4 = new WindowPosition() { X = -763, Y = 708, CX = 770, CY = 100 };

        protected string _process5 = "explorer.exe";
        protected string _argument5 = @"E:\Compiled\serviceAppsMonitor\logs\";
        protected string _windowTitle5 = "logs";
        protected WindowPosition _winPos5 = new WindowPosition() { X = -1519, Y = 803, CX = 770, CY = 100 };

        protected string _process6 = @"C:\Program Files\Mozilla Firefox\firefox.exe";
        protected string _argument6 = "";
        protected string _windowTitle6 = "Mozilla Firefox";
        protected WindowPosition _winPos6 = new WindowPosition() { X = -1924, Y = 0, CX = 900, CY = 750 };

        protected string _process7 = @"C:\Program Files\FileZilla FTP Client\filezilla.exe";
        protected string _argument7 = "";
        protected string _windowTitle7 = "FileZilla";
        protected WindowPosition _winPos7 = new WindowPosition() { X = -1650, Y = 0, CX = 900, CY = 780 };

        protected string _process8 = @"C:\Windows\system32\control.exe";
        protected string _argument8 = "schedtasks";
        protected string _windowTitle8 = "Task Scheduler";
        protected WindowPosition _winPos8 = new WindowPosition() { X = 425, Y = 0, CX = 1500, CY = 1000 };

        protected string _process9 = @"C:\Program Files (x86)\Microsoft SQL Server Management Studio 18\Common7\IDE\Ssms.exe";
        protected string _argument9 = "";
        protected string _windowTitle9 = "Microsoft SQL Server Management Studio (Administrator)";
        protected WindowPosition _winPos9 = new WindowPosition() { X = 1650, Y = 400, CX = 1200, CY = 1000 };

        protected string _process10 = @"C:\Program Files (x86)\Microsoft Azure Storage Explorer\StorageExplorer.exe";
        protected string _argument10 = " --verbosity=silent";
        protected string _windowTitle10 = "Microsoft Azure Storage Explorer";
        protected WindowPosition _winPos10 = new WindowPosition() { X = 50, Y = 180, CX = 1500, CY = 750 };

        
        public WindowDetailsFactory_dev_server()
        { 
            Console.WriteLine("WindowDetailsFactory_dev_server() - dev_server profile selected!");
        }


        public List<WindowDetails> GetWindowDetailsList()
        {
            WindowDetails winDetails1 = new WindowDetails() { Process = _process1, Argument = _argument1, WindowTitle = _windowTitle1, WindowPosition = _winPos1 };
            WindowDetails winDetails2 = new WindowDetails() { Process = _process2, Argument = _argument2, WindowTitle = _windowTitle2, WindowPosition = _winPos2 };
            WindowDetails winDetails3 = new WindowDetails() { Process = _process3, Argument = _argument3, WindowTitle = _windowTitle3, WindowPosition = _winPos3 };
            WindowDetails winDetails4 = new WindowDetails() { Process = _process4, Argument = _argument4, WindowTitle = _windowTitle4, WindowPosition = _winPos4 };
            WindowDetails winDetails5 = new WindowDetails() { Process = _process5, Argument = _argument5, WindowTitle = _windowTitle5, WindowPosition = _winPos5 };
            WindowDetails winDetails6 = new WindowDetails() { Process = _process6, Argument = _argument6, WindowTitle = _windowTitle6, WindowPosition = _winPos6 };
            WindowDetails winDetails7 = new WindowDetails() { Process = _process7, Argument = _argument7, WindowTitle = _windowTitle7, WindowPosition = _winPos7 };
            WindowDetails winDetails8 = new WindowDetails() { Process = _process8, Argument = _argument8, WindowTitle = _windowTitle8, WindowPosition = _winPos8 };
            WindowDetails winDetails9 = new WindowDetails() { Process = _process9, Argument = _argument9, WindowTitle = _windowTitle9, WindowPosition = _winPos9 };
            WindowDetails winDetails10 = new WindowDetails() { Process = _process10, Argument = _argument10, WindowTitle = _windowTitle10, WindowPosition = _winPos10 };

            List<WindowDetails> windowDetailsList = new List<WindowDetails>()
            {
                winDetails1, winDetails2, winDetails3, winDetails4, winDetails5, 
                winDetails6, winDetails7, winDetails8, winDetails9, winDetails10
            };

            // override for discrete testing
            // windowDetailsList = new List<WindowDetails>() { winDetails8 };

            return windowDetailsList;
        }

    }
}