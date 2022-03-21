import winshell
import os
import win32com.client

def create_uninstall():
    try:
        desktop = winshell.desktop()
        path = os.path.join(desktop, 'PFO Uninstaller.lnk')
        target = os.environ['ProgramFiles(x86)'] + r'\PFO\PFO Uninstaller.exe'
        icon = f"{os.environ['ProgramFiles(x86)']}\\PFO\\icon\\uninstall.ico"

        shell = win32com.client.Dispatch("WScript.Shell")
        shortcut = shell.CreateShortCut(path)
        shortcut.Targetpath = target
        shortcut.IconLocation = icon
        shortcut.WindowStyle = 7
        shortcut.save()
    except Exception as ex:
        pass

def create_gui():
    try:
        desktop = winshell.desktop()
        path = os.path.join(desktop, 'PFO GUI.lnk')
        target = os.environ['ProgramFiles(x86)'] + r'\PFO\GUI\GUI\gui.exe'
        icon = f"{os.environ['ProgramFiles(x86)']}\\PFO\\icon\\gui.ico"

        shell = win32com.client.Dispatch("WScript.Shell")
        shortcut = shell.CreateShortCut(path)
        shortcut.Targetpath = target
        shortcut.IconLocation = icon
        shortcut.WindowStyle = 7
        shortcut.save()
    except Exception as ex:
        pass