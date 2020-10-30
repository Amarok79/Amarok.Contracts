@ECHO OFF

nuget.exe pack Amarok.Contracts.nuspec -OutputDirectory bin\lib

ECHO.
ECHO ====================================================================================================
ECHO	Batch execution finished. Press any key to quit!
ECHO ====================================================================================================
PAUSE
