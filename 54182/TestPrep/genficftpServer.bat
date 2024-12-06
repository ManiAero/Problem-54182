setlocal ENABLEDELAYEDEXPANSION
mkdir C:\CworkTestAuto\FtpServer
for /l %%v in (1, 1,%1-1) do (
	echo %%v
	copy /y ..\..\TestPrep\prg.cnc C:\CworkTestAuto\FtpServer\png%%v.cnc
)
copy /y ..\..\TestPrep\ftpserverconfig.xml C:\CworkTestAuto\FtpServer\ftpserverconfig.xml
