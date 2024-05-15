@echo off
title Actualizador de Aplicaciones

:: Actualizar todas las aplicaciones disponibles mediante winget
echo Obteniendo lista de aplicaciones instaladas...
winget list --show 50 > "%TEMP%\app_list.txt"

echo.
echo Iniciando el proceso de actualizacion...

:: Procesar cada linea de la lista de aplicaciones
for /f "skip=1 tokens=*" %%a in ('type "%TEMP%\app_list.txt"') do (
    echo Actualizando: %%a
    winget upgrade -n "%%a" --exact > nul 2>&1
    echo.
)

echo Todas las aplicaciones han sido actualizadas.