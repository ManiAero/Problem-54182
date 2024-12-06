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
timeout 10
rmdir /S /Q C:\CworkTestAuto
xcopy /E /I C:\SaveCworkTestAuto C:\CworkTestAuto\
