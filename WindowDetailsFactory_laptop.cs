using System;
using System.Collections.Generic;
using dotnetCore_win_dashboard_Models;


namespace dotnetCore_win_dashboard_Factories
{
    class WindowDetailsFactory_laptop
    {
        // ----- File Explorer -----
        protected string _process1 = "explorer.exe";
        protected string _argument1 = @"V:\FileTransfers\";
        protected string _windowTitle1 = "FileTransfers";
        protected WindowPosition _winPos1 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        protected string _process2 = "explorer.exe";
        protected string _argument2 = @"V:\FileTransfers\abc\";
        protected string _windowTitle2 = "abc";
        protected WindowPosition _winPos2 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        protected string _process3 = "explorer.exe";
        protected string _argument3 = @"V:\FileTransfers\bcd\";
        protected string _windowTitle3 = "bcd";
        protected WindowPosition _winPos3 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        protected string _process4 = "explorer.exe";
        protected string _argument4 = @"V:\FileTransfers\cde\";
        protected string _windowTitle4 = "cde";
        protected WindowPosition _winPos4 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        protected string _process5 = "explorer.exe";
        protected string _argument5 = @"V:\FileTransfers\def\";
        protected string _windowTitle5 = "def";
        protected WindowPosition _winPos5 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        protected string _process6 = "explorer.exe";
        protected string _argument6 = @"V:\FileTransfers\efg\";
        protected string _windowTitle6 = "efg";
        protected WindowPosition _winPos6 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        protected string _process7 = "explorer.exe";
        protected string _argument7 = @"V:\FileTransfers\fgh\";
        protected string _windowTitle7 = "fgh";
        protected WindowPosition _winPos7 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        protected string _process8 = "explorer.exe";
        protected string _argument8 = @"V:\FileTransfers\ghi\";
        protected string _windowTitle8 = "ghi";
        protected WindowPosition _winPos8 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        protected string _process9 = "explorer.exe";
        protected string _argument9 = @"V:\FileTransfers\hij\";
        protected string _windowTitle9 = "hij";
        protected WindowPosition _winPos9 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        protected string _process10 = "explorer.exe";
        protected string _argument10 = @"V:\FileTransfers\ijk\";
        protected string _windowTitle10 = "ijk";
        protected WindowPosition _winPos10 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        protected string _process11 = "explorer.exe";
        protected string _argument11 = @"V:\FileTransfers\jkl\";
        protected string _windowTitle11 = "jkl";
        protected WindowPosition _winPos11 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        protected string _process12 = "explorer.exe";
        protected string _argument12 = @"V:\FileTransfers\klm\meetings\2023-06-20\";
        protected string _windowTitle12 = "2023-06-20";
        protected WindowPosition _winPos12 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        protected string _process13 = "explorer.exe";
        protected string _argument13 = @"V:\Site Documentation\server\Task Scheduler jobs\";
        protected string _windowTitle13 = "Task Scheduler jobs";
        protected WindowPosition _winPos13 = new WindowPosition() { X = -7, Y = 646, CX = 750, CY = 400 };

        // --- placeholder for more File Explorer windows ---
        // protected string _process = "explorer.exe";
        // protected string _argument = @"\";
        // protected string _windowTitle = "";
        // protected WindowPosition _winPos = new WindowPosition() {X = -7, Y = 646, CX = 750, CY = 400 };

        // ----- Notepad -----
        protected string _process14 = "notepad.exe";
        protected string _argument14 = @"V:\Employee\time\2023_time_tracking.txt";
        protected string _windowTitle14 = "2023_time_tracking.txt - Notepad";
        protected WindowPosition _winPos14 = new WindowPosition() { X = 450, Y = 80, CX = 650, CY = 900 };

        protected string _process15 = "notepad.exe";
        protected string _argument15 = @"V:\Employee\meeting_notes\2023-06-28_meeting.txt";
        protected string _windowTitle15 = "2023-06-28_meeting.txt - Notepad";
        protected WindowPosition _winPos15 = new WindowPosition() { X = 300, Y = 50, CX = 1300, CY = 800 };

        // ----- Other Apps -----
        protected string _process16 = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";
        protected string _argument16 = "";
        protected string _windowTitle16 = "New Tab - Brave";
        protected WindowPosition _winPos16 = new WindowPosition() { X = 0, Y = 0, CX = 1200, CY = 850 };

        protected string _process17 = @"C:\Program Files (x86)\Microsoft Office\root\Office16\OUTLOOK.EXE";
        protected string _argument17 = "/cleanclientrules";
        protected string _windowTitle17 = "Inbox - Outlook";
        protected WindowPosition _winPos17 = new WindowPosition() { X = 202, Y = 55, CX = 1710, CY = 985 };

        protected string _process18 = @"C:\Users\verboskyj\AppData\Local\Microsoft\Teams\Update.exe";
        protected string _argument18 = " --processStart \"Teams.exe\" --process-start-args \"--profile=AAD\"";
        protected string _windowTitle18 = "Microsoft Teams";
        protected WindowPosition _winPos18 = new WindowPosition() { X = 202, Y = 0, CX = 1710, CY = 985 };

        protected string _process19 = @"C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE";
        protected string _argument19 = @"V:\Accounts\list.xlsx";
        protected string _windowTitle19 = "list.xlsx | Excel";
        protected WindowPosition _winPos19 = new WindowPosition() { X = 425, Y = 0, CX = 1500, CY = 1000 };

        protected string _process20 = @"C:\Apps\mRemoteNG\1.76.20_portable\mRemoteNG.exe";
        protected string _argument20 = "";
        protected string _windowTitle20 = "mRemoteNG - confCons.xml";
        protected WindowPosition _winPos20 = new WindowPosition() { X = 425, Y = 0, CX = 1500, CY = 1000 };
        
        protected string _process21 = @"control";
        protected string _argument21 = "/name Microsoft.System";
        protected string _windowTitle21 = "Settings";
        protected WindowPosition _winPos21 = new WindowPosition() { X = 800, Y = 500, CX = 750, CY = 750 };


        public WindowDetailsFactory_laptop()
        { 
            Console.WriteLine("WindowDetailsFactory_laptop() - laptop profile selected!");
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
            WindowDetails winDetails11 = new WindowDetails() { Process = _process11, Argument = _argument11, WindowTitle = _windowTitle11, WindowPosition = _winPos11 };
            WindowDetails winDetails12 = new WindowDetails() { Process = _process12, Argument = _argument12, WindowTitle = _windowTitle12, WindowPosition = _winPos12 };
            WindowDetails winDetails13 = new WindowDetails() { Process = _process13, Argument = _argument13, WindowTitle = _windowTitle13, WindowPosition = _winPos13 };
            WindowDetails winDetails14 = new WindowDetails() { Process = _process14, Argument = _argument14, WindowTitle = _windowTitle14, WindowPosition = _winPos14 };
            WindowDetails winDetails15 = new WindowDetails() { Process = _process15, Argument = _argument15, WindowTitle = _windowTitle15, WindowPosition = _winPos15 };
            WindowDetails winDetails16 = new WindowDetails() { Process = _process16, Argument = _argument16, WindowTitle = _windowTitle16, WindowPosition = _winPos16 };
            WindowDetails winDetails17 = new WindowDetails() { Process = _process17, Argument = _argument17, WindowTitle = _windowTitle17, WindowPosition = _winPos17 };
            WindowDetails winDetails18 = new WindowDetails() { Process = _process18, Argument = _argument18, WindowTitle = _windowTitle18, WindowPosition = _winPos18 };
            WindowDetails winDetails19 = new WindowDetails() { Process = _process19, Argument = _argument19, WindowTitle = _windowTitle19, WindowPosition = _winPos19 };
            WindowDetails winDetails20 = new WindowDetails() { Process = _process20, Argument = _argument20, WindowTitle = _windowTitle20, WindowPosition = _winPos20 };
            WindowDetails winDetails21 = new WindowDetails() { Process = _process21, Argument = _argument21, WindowTitle = _windowTitle21, WindowPosition = _winPos21 };

            List<WindowDetails> windowDetailsList = new List<WindowDetails>()
            {
                winDetails1, winDetails2, winDetails3, winDetails4, winDetails5, 
                winDetails6, winDetails7, winDetails8, winDetails9, winDetails10,
                winDetails11, winDetails12, winDetails13, winDetails14, winDetails15,
                winDetails16, winDetails17, winDetails18, winDetails19, winDetails20,
                winDetails21
            };

            // override for discrete testing
            // windowDetailsList = new List<WindowDetails>() { winDetails21 };

            return windowDetailsList;
        }

    }
}