net stop smmCEngine
net stop smmCompc
net stop smmCprod
net stop smmCftp
net stop smmCApi
net stop smmDashboard2
net stop smmCNFS
net stop smmCRemoteDNC
net stop smmCsmb
net stop smmPortmap
net stop smmWorker
tasklist /fi "imagename eq Cwork.exe" |find ":" > nul
if errorlevel 1 taskkill /f /im "Cwork.exe"
rmdir /S /Q C:\SaveCworkTestAuto
xcopy /E /I  C:\CworkTestAuto C:\SaveCworkTestAuto\

