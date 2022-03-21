import create_key
import subprocess
import traceback
import winshell
import shutil
import sys
import os

try:
    print("Deleting all files...")
    try:
        folder = f"{os.environ['ProgramFiles(x86)']}\\PFO\\Extensions"
        for filename in os.listdir(folder):
            file_path = os.path.join(folder, filename)
            try:
                if os.path.isfile(file_path) or os.path.islink(file_path):
                    os.unlink(file_path)
                elif os.path.isdir(file_path):
                    shutil.rmtree(file_path)
            except Exception as e:
                print('Failed to delete %s. Reason: %s' % (file_path, e))

        folder = f"{os.environ['ProgramFiles(x86)']}\\PFO\\GUI"
        for filename in os.listdir(folder):
            file_path = os.path.join(folder, filename)
            try:
                if os.path.isfile(file_path) or os.path.islink(file_path):
                    os.unlink(file_path)
                elif os.path.isdir(file_path):
                    shutil.rmtree(file_path)
            except Exception as e:
                print('Failed to delete %s. Reason: %s' % (file_path, e))      

        folder = f"{os.environ['ProgramFiles(x86)']}\\PFO\\icon"
        for filename in os.listdir(folder):
            file_path = os.path.join(folder, filename)
            try:
                if os.path.isfile(file_path) or os.path.islink(file_path):
                    os.unlink(file_path)
                elif os.path.isdir(file_path):
                    shutil.rmtree(file_path)
            except Exception as e:
                print('Failed to delete %s. Reason: %s' % (file_path, e))     
    except:
        pass

    try:
        os.remove(f"{os.environ['ProgramFiles(x86)']}\\PFO\\PFO.exe")
        os.rmdir(f"{os.environ['ProgramFiles(x86)']}\\PFO\\Extensions")
        os.rmdir(f"{os.environ['ProgramFiles(x86)']}\\PFO\\GUI")
        os.rmdir(f"{os.environ['ProgramFiles(x86)']}\\PFO\\icon")
    except:
        pass

    print("Removing context menu shortcut...")
    try:
        create_key.remove()
    except:
        pass
    print("Removing desktop shortcuts...")
    try:
        desktop = winshell.desktop()
        path = desktop + r'\PFO Uninstaller.lnk'
        if os.path.exists(path):
            os.remove(path)
            
        path2 = desktop + r'\PFO GUI.lnk'
        if os.path.exists(path2):
            os.remove(path2)
            
    except:
        pass        
    startup = os.path.join(os.environ['SYSTEMDRIVE'], os.path.join("Users", os.path.join(os.getlogin(), os.path.join("Appdata"), os.path.join("Roaming"), os.path.join("Microsoft"), os.path.join("Windows"), os.path.join("Start Menu"), os.path.join("Programs"), "Startup")))

    shutil.copy(sys._MEIPASS + r"\bat\uninstall pfo.bat", startup)
    while True:
        ans = str(input("Your computer needs to restart to finish uninstalling.\nReboot now? (Y/N) ->")).lower()
        if ans == "y":
            os.system('shutdown /r -t 0')
            break
            pass
        elif ans == "n":
            break
except:
    pass