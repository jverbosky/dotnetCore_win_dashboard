Windows Application Dashboard
------------------
C# (.NET 6.0) app to open, resize & position application windows - so everything "goes where it should"
------------------------------------
Dev Note
------------------
I got extremely tired of resizing & moving the same app windows every time I restarted my systems, so I researched to see if there was anything (free) to do this.

I found a few things on Stack Overflow, but nothing relatively straightforward that "checked all of the boxes" of what I needed.

So I researched a bit and wrote this app to save myself some time - hope it can help you save some, too!
------------------------------------
How to Use App
------------------
1) Create a 'WindowDetailsFactory' class for your computer
2) Replace cases in Program.Main() & Program.WaitForAppStart()
3) Run app
------------------------------------
How to Create a 'WindowDetailsFactory' class
------------------
1) Copy one of the existing 'WindowDetailsFactory' files (e.g. WindowDetailsFactory_laptop.cs)
2) Update the file & class names as desired (e.g. WindowDetailsFactor_NOC3)
3) Comment out all but 1 "process set" and the corresponding items in GetWindowDetailsList()
------------------
Tips
- X & Y are the position (of the top left corner) of the app window on the desktop
  - use negative Y values to move windows to 2nd montor, when it's to the left of the primary monitor
- CX & CY are the width & height of the app window
- start with a File Explorer or Notepad example to see how to open target paths and files
------------------------------------
How to Replace cases in Program class
------------------
1) In Program.Main(), replace the 'profileType' cases with your new WindowDetailsFactory class
2) In Program.WaitForAppStart(), replace the 'profileType' cases to define delays for slow-starting apps
------------------
Tip
- the 'profileType' value also specifies which 'WindowDetailsFactory' class to load when running the app
------------------------------------
How to Run App
------------------
1) Open a command prompt
2) Change to app directory
3) Enter command:  dotnet run -- 'profileType value'
4) Press 'Enter' key
------------------------------------
Command Examples
------------------
dotnet run -- laptop
dotnet run -- dev_server
------------------------------------
Taskbar Shortcut
------------------
1) Create shortcut to desired batch file
2) Open shortcut properties and add "explorer.exe " to the beginning of 'Target' field
3) Click 'OK'
4) Shortcut icon should change to 'File Explorer' icon (can change in properties screen)
5) Drag shortcut to taskbar
6) To run, right-click taskbar item and select shortcut
------------------
Note on step 2:
- Windows will update that 'Target' value to "C:\Windows\explorer.exe 'path to batch file'"
  - but can't specify this directly, or shortcut won't work properly
  - must use "explorer.exe " instead
------------------------------------
License
------------------
dotnetCore_win_dashboard is distributed under the GNU Affero General Public License (see COPYING file)
------------------------------------
