tasklist /fi "imagename eq Cwork.exe" |find ":" > nul
if errorlevel 1 taskkill /f /im "Cwork.exe"
tasklist /fi "imagename eq CNetDNC.exe" |find ":" > nul
if errorlevel 1 taskkill /f /im "CNetDNC.exe"
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
net stop filezilla-server
rmdir /S /Q C:\CworkTestAuto
mkdir C:\CworkTestAuto
mkdir C:\CworkTestAuto\CNET
mkdir C:\CworkTestAuto\SMB\CNC1\Charg
mkdir C:\CworkTestAuto\SMB\CNC1\Decharg
xcopy  "C:\Program Files (x86)\Smcom Software\Cwork\bin\CNetDNC\*" C:\CworkTestAuto\CNET
copy ..\..\TestPrep\CNetDNC.ini C:\CworkTestAuto\CNET



