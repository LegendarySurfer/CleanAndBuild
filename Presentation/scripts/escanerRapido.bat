@echo off
setlocal enabledelayedexpansion

REM Define la unidad que deseas recorrer (por ejemplo, C:)
set "unidad=C:"

REM Establecer una bandera para indicar si se ha encontrado un archivo potencialmente malicioso
set "virusEncontrado=false"

REM Recorre todos los archivos del disco duro y muéstralos por pantalla de forma recursiva
for /r "%unidad%" /d %%i in (*) do (
    echo %%i
    REM Extrae la extensión del archivo
    set "filename=%%~nxi"
    set "extension=!filename:*.=!"
    REM Verifica si la extensión del archivo es una extensión de ejecutable
    if /i "!extension!"==".exe" (
        echo ¡Alerta! El archivo %%i podría ser un virus.
        set "virusEncontrado=true"
    )
)

REM Verificar si se ha encontrado algún archivo potencialmente malicioso
if "%virusEncontrado%"=="true" (
    echo Se han encontrado archivos potencialmente maliciosos.
) else (
    echo Todo ha ido bien, no se han encontrado archivos con extensiones de ejecutable.
)

pause