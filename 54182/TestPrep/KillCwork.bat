tasklist /fi "imagename eq Cwork.exe" |find ":" > nul
if errorlevel 1 taskkill /f /im "Cwork.exe"