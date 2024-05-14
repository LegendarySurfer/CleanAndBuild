@echo off
echo Ejecutando sfc /scannow...
sfc /scannow

echo.
echo Ejecutando DISM para restaurar la integridad del sistema de archivos...
DISM /Online /Cleanup-Image /RestoreHealth