@ECHO OFF
SET FILE1="C:\CworkTestAuto\EXPORT\MULTI\%1"
SET FILE2="C:\CworkTestAuto\EXPORT\SOLO\%1"
ECHO %FILE1%
ECHO %FILE2%

SET HASH1 = ''
certutil -hashfile %FILE1% SHA256 >> HASH_1.txt
certutil -hashfile %FILE2% SHA256 >> HASH_2.txt
set "xprvar1="
for /F "skip=1 delims=" %%i in (HASH_1.txt) do if not defined xprvar1 set "xprvar1=%%i"
set "xprvar2="
for /F "skip=1 delims=" %%i in (HASH_2.txt) do if not defined xprvar2 set "xprvar2=%%i"
ECHO %xprvar1%
ECHO %xprvar2%
DEL HASH_1.txt
DEL HASH_2.txt

IF %xprvar1% == %xprvar2% (
	exit 0 ) ELSE ( TIMEOUT 5)
	
	

