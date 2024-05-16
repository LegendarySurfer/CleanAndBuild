@echo off
echo Liberando espacio en disco no asignado...

REM Ejecuta la limpieza de disco con opciones avanzadas
cleanmgr /sagerun:1 > nul 2>&1

REM Verifica si la limpieza se realizó correctamente
if %errorlevel% equ 0 (
    echo La limpieza de disco se ha completado exitosamente.
    echo Detalles de la limpieza:
    echo -------------------------------------
    echo Archivos temporales eliminados:
    dir C:\Windows\Temp /A /S
    echo -------------------------------------
    echo Archivos de caché eliminados:
    dir C:\Windows\SoftwareDistribution /A /S
    echo -------------------------------------
    echo Espacio liberado:
    fsutil volume diskfree C:
    echo -------------------------------------
) else (
    echo Ha ocurrido un error durante la limpieza de disco.
)
pause