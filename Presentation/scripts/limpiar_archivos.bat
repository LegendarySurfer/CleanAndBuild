@echo off
cls
echo ===== LIMPIEZA DE ARCHIVOS TEMPORALES Y PAPELERA DE RECICLAJE =====

:: Metodo para limpiar la carpeta Temp del usuario
call :limpiar_carpeta "%TEMP%" "Carpeta Temp del usuario"

:: Metodo para limpiar la carpeta Temp del sistema
call :limpiar_carpeta "%SystemRoot%\Temp" "Carpeta Temp del sistema"

:: Metodo para limpiar la Papelera de Reciclaje
call :limpiar_papelera "Papelera de Reciclaje"

:: Añade mas llamadas a :limpiar_carpeta segun sea necesario

:: Espera 5 segundos antes de cerrar la ventana
timeout /t 5 /nobreak >nul

exit

:limpiar_carpeta
echo.
echo Limpiando la carpeta: %2
echo -----------------------------------

pushd "%~1"
del /q /f *.* 2>nul
popd

if exist "%~1\*.*" (
    echo No se pudo limpiar completamente la carpeta %2.
) else (
    echo Carpeta %2 limpia.
)
goto :eof

:limpiar_papelera
echo.
echo Limpiando la Papelera de Reciclaje
echo -----------------------------------

:: Vaciar la Papelera de Reciclaje
rd /s /q "%SystemDrive%\$Recycle.Bin" 2>nul
if exist "%SystemDrive%\$Recycle.Bin" (
    echo No se pudo vaciar completamente la Papelera de Reciclaje.
    echo Ruta esperada: %SystemDrive%\$Recycle.Bin
) else (
    echo Papelera de Reciclaje limpia.
)
goto :eof
