setlocal ENABLEDELAYEDEXPANSION
mkdir C:\CworkTestAuto\ImportFAO
for /l %%v in (1, 1,%1-1) do (
	echo %%v
	copy /y ..\..\TestPrep\prg.cnc C:\CworkTestAuto\ImportFAO\png%%v.cnc
)
