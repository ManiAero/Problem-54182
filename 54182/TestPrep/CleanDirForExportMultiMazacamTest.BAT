if not exist "C:\CworkTestAuto\EXPORT\SOLO" mkdir C:\CworkTestAuto\EXPORT\SOLO
if not exist "C:\CworkTestAuto\EXPORT\MULTI" mkdir C:\CworkTestAuto\EXPORT\MULTI
del /f/s/q C:\CworkTestAuto\ImportFAO\*
del /f/s/q "C:\CworkTestAuto\EXPORT\MULTI"*
del /f/s/q C:\CworkTestAuto\EXPORT\SOLO*
Exit