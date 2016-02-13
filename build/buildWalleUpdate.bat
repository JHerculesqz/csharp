echo ======changeDir start=====
rem %1 is DirPathSolution
cd %1
echo ======changeDir end=====

echo ======app start=====
rem walle.update
set DIR_PATH_walleUpdate=walle\walle.update\bin\Debug
rem app(%2 is DirPathAppPrj)
set DIR_PATH_app=%2\bin\Debug\data\walle.update\
rmdir %DIR_PATH_app% /q /s
xcopy %DIR_PATH_walleUpdate% %DIR_PATH_app% /y /s
echo ======app end=====

pause