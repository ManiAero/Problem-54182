@echo off
setlocal
set resError=F

if "%1"=="" (
    echo Usage: %0 ^<fileToCheck^> ^<GeneratedFile^>
    goto :EOF
)

if "%2"==""   (
    echo Usage: %0 ^<fileToCheck^> ^<GeneratedFile^>
    goto :EOF
)

set param1=%1
set param2=%2
set TNCcmdPlus="C:\Program Files (x86)\HEIDENHAIN\TNCremo\TNCcmdPlus.exe"

if not exist ""%TNCcmdPlus%"" (
    echo Error: TNCcmdPlus.exe not found at %TNCcmdPlus%
    goto :EOF
)

%TNCcmdPlus% -I10.1.0.187 "FileInfo %param1%">%param2%"
