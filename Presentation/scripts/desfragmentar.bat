@echo off
title Desfragmentacion de Disco

:inicio
cls
echo ===============================
echo    Desfragmentacion de Disco
echo ===============================
echo.

set "disco=%1"
set "existe=0"

rem Comprobar si el disco existe
for /f "skip=1" %%d in ('wmic logicaldisk where "caption='%disco%'" get caption 2^>nul') do (
    if "%%d" neq "" set "existe=1"
)

if %existe% equ 0 (
    echo El disco "%disco%" no existe.
    pause
    exit /b 1
)

echo Desfragmentando Disco %disco%...
defrag %disco% /A
if errorlevel 1 (
    echo.
    echo Ha ocurrido un error durante la desfragmentación.
    exit /b 1
)

echo.
echo Desfragmentacion completada.
pause
exit /b 0
