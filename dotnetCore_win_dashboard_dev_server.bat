set _timestring=%TIME: =0%
set _timestamp=%date:~-4,4%-%date:~-10,2%-%date:~-7,2%_%_timestring:~0,2%-%_timestring:~3,2%-%_timestring:~6,2%

E:
cd E:\Scratch\dotnetCore_win_dashboard
dotnet run -- dev_server > .\debug\dotnetCore_win_dashboard-debug_%_timestamp%.txt