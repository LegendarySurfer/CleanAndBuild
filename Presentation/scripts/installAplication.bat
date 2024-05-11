@echo off

set "installPath=%USERPROFILE%\Desktop"

rem Inicializar la lista de programas
set "programs="

rem Concatenar todos los argumentos pasados al script por lotes
:concat_args
if "%~1"=="" goto end_concat_args
set "programs=%programs%%1-"
shift
goto concat_args
:end_concat_args

rem Eliminar el último guion ("-") de la lista de programas
set "programs=%programs:~0,-1%"

rem Descargar Ninite Installer con PowerShell
powershell -Command "& { Invoke-WebRequest -Uri 'https://ninite.com/%programs%/ninite.exe' -OutFile '%installPath%\NiniteInstaller.exe' }"

rem Verificar el estado de la descarga
if %errorlevel% neq 0 (
    echo Error al descargar Ninite Installer
    exit /b 1
)

rem Ejecutar Ninite Installer
start "Ninite Installer" "%installPath%\NiniteInstaller.exe"

echo Proceso de descarga e instalacion completo.
