# CleanAndBuild

## GUÍA DE OPCIONES - Clean And Build

¡Importante!

- Este script debe ejecutarse en modo administrador para garantizar que tenga los privilegios necesarios para realizar las tareas de optimización y limpieza.

1. **Reparar Sistema:**
   - *Descripción:* Esta opción ejecuta el script "repair.bat" que utiliza la herramienta de reparación de Windows (DISM y SFC) para abordar problemas operativos como archivos de sistema dañados o faltantes.

2. **Actualizar Comandos:**
   - *Descripción:* Actualiza la lista de comandos del sistema ejecutando el comando "help" para refrescar y mostrar información actualizada sobre los comandos disponibles.

3. **Actualizar Aplicaciones:**
   - *Descripción:* Utiliza el comando "winget" para buscar actualizaciones de todas las aplicaciones instaladas en el sistema. Asegúrate de tener "winget" habilitado en tu sistema.

4. **Desfragmentar Disco:**
   - *Descripción:* Ejecuta el script "desfragment.bat" que utiliza la herramienta de desfragmentación de Windows para optimizar el espacio en disco y mejorar el rendimiento del sistema.

5. **Limpiar Sistema:**
   - *Descripción:* Limpia archivos temporales, incluyendo la papelera de reciclaje, para liberar espacio de almacenamiento. También ejecuta la desfragmentación del disco después de la limpieza.

6. **Liberador de espacio en disco:**
   - *Descripción:* Ejecuta la utilidad de Liberador de Espacio en Disco de Windows, que elimina archivos temporales y liberar espacio en disco.

7. **Escanear con Emsisoft:**
   - *Descripción:* Ejecuta Emsisoft Emergency Kit Portable para realizar un análisis rápido en busca de malware. Esta herramienta externa se encuentra en la carpeta "herramientas\EmsisoftEmergencyKitPortable".

8. **Instalar Aplicaciones:**
   - *Descripción:* Ejecuta el script "aplication.bat" que descarga e instala aplicaciones útiles como Google Chrome, VLC Media Player y Adobe Acrobat Reader y algunas mas. Asegúrate de tener conexión a Internet para descargar las aplicaciones.

9. **Salir del Programa:**
   - *Descripción:* Elimina el contenido de "herramientas\aplicaciones" y sale del programa. Antes de salir, realiza una limpieza de archivos temporales y muestra un mensaje de despedida.

¡Precaución!

- Algunas acciones realizadas por este script pueden afectar la configuración del sistema. Asegúrate de respaldar datos importantes y entender las consecuencias de cada acción antes de ejecutarlas.

## OPTIONS GUIDE - CLEAN AND BUILD

¡Important!

- This script must be run as an administrator to ensure it has the necessary privileges to perform optimization and cleanup tasks.

1. **Repair System:**
   - *Description:* This option runs the "repair.bat" script, utilizing the Windows repair tool (DISM and SFC) to address operational issues like damaged or missing system files.

2. **Update Commands:**
   - *Description:* Updates the system command list by running the "help" command to refresh and display up-to-date information about available commands.

3. **Update Applications:**
   - *Description:* Uses the "winget" command to check for updates for all installed applications on the system. Make sure "winget" is enabled on your system.

4. **Defragment Disk:**
   - *Description:* Executes the "defragment.bat" script, utilizing the Windows defragmentation tool to optimize disk space and improve system performance.

5. **Clean System:**
   - *Description:* Cleans temporary files, including the recycle bin, to free up storage space. It also runs disk defragmentation after the cleanup.

6. **Disk Cleanup:**
   - *Description:* Runs the Windows Disk Cleanup utility, which removes temporary files and frees up disk space.

7. **Scan with Emsisoft:**
   - *Description:* Runs Emsisoft Emergency Kit Portable to perform a quick scan for malware. This external tool is located in the "tools\EmsisoftEmergencyKitPortable" folder.

8. **Install Applications:**
   - *Description:* Runs the "application.bat" script to download and install useful applications such as Google Chrome, VLC Media Player, and Adobe Acrobat Reader. Ensure you have an internet connection to download the applications.

9. **Exit the Program:**
   - *Description:* Deletes the contents of the "tools\applications" folder and exits the program. Before exiting, it performs a cleanup of temporary files and displays a farewell message.

Caution!

- Some actions performed by this script may impact system settings. Ensure you back up important data and understand the consequences of each action before executing them.

