@echo off
cls
cd /d "%~dp0"
if NOT "%cd%"=="%cd: =%" (
   echo El directorio actual contine espacios en el path.
   echo Este comando debe estar en un path que no contenga espacios. 
   rundll32.exe cmdext.dll,MessageBeepStub
   pause
   echo.
   goto :EOF
)

if {%1} EQU {[adm]} goto :data
REG QUERY HKU\S-1-5-19\Environment >NUL 2>&1 && goto :data

set command="""%~f0""" [adm] %*
setlocal enabledelayedexpansion
set "command=!command:'=''!"

powershell -NoProfile Start-Process -FilePath '%COMSPEC%' -ArgumentList '/c """!command!"""' -Verb RunAs 2>NUL
goto :EOF

:data
setlocal enabledelayedexpansion
if {%1} EQU {[adm]} (
   set adm=%1
   shift
) ELSE (set adm=)
set KEYHACK="1980"

:cuerpo
REM ==============================================


SET INSTALLUTILDIR=
@Call Service_Global.cmd

if "!INSTALLUTILDIR!" == "" goto :EOF 

echo.
echo INICIANDO DESINSTALACION...
echo.
!INSTALLUTILDIR!\installutil.exe ServerPrintRawService.exe /u


REM ==============================================
:fin
if {%adm%} EQU {[adm]} (
   echo.
   pause
)


REM https://jmtella.com/foro/forum/ejercicios-y-ejemplos/41147-tip-ejecutar-cualquier-script-cmd-o-bat-con-permisos-de-administrador
rem %SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\InstallUtil.exe D:\Source\vBoxService\vBoxService\bin\Debug\vBoxService.exe /u