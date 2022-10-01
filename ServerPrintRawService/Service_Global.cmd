@echo off
if "%KEYHACK%" == "" (
	echo Error 100
	goto :EOF
)

SET INSTALLUTILDIR=
for /F "tokens=1,2*" %%i in ('reg query "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full" /v "InstallPath"') DO (
    if "%%i"=="InstallPath" (
        SET "INSTALLUTILDIR=%%k"
    )
)

if "!INSTALLUTILDIR!" == "" (
	echo.
	echo ERROR: NO SE HA DETECTADO FRAMEWORK 4 INSTALADO EN EL SISTEMA
	echo.
	pause
)