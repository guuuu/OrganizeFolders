@ECHO OFF
if not "%1"=="am_admin" (powershell start -verb runas '%0' am_admin & exit /b)
SETLOCAL
@RD /S /Q "%ProgramFiles(x86)%\PFO"
FOR /F "usebackq" %%f IN (`PowerShell -NoProfile -Command "Write-Host([Environment]::GetFolderPath('Desktop'))"`) DO (
  SET "DESKTOP_FOLDER=%%f"
  )
del "%DESKTOP_FOLDER%\PFO Uninstaller.lnk"
del "%DESKTOP_FOLDER%\PFO GUI.lnk"
ECHO "This script will now self-destruct."
DEL "%~f0"