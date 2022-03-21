import os
import shutil
import sys
import create_key
import traceback
import shortcut
import zipfile

def create():
    shortcut.create_uninstall()
    shortcut.create_gui()

def main():
    try:
        path_to_install = f"{os.environ['ProgramFiles(x86)']}\\PFO"    

        ext_folder = f"{path_to_install}\\Extensions"
        ext_file = f"{sys._MEIPASS}\\ext\\extensions.json"

        main_file = f"{sys._MEIPASS}\\main\\PFO.exe"
        uninstaller_file = f"{sys._MEIPASS}\\unin\\PFO Uninstaller.exe"

        icon_folder = f"{path_to_install}\\icon"
        icon_file = f"{sys._MEIPASS}\\icon\\uninstall.ico"
        icon_file2 = f"{sys._MEIPASS}\\icon\\gui.ico"

        gui_folder = f"{path_to_install}\\GUI"
        gui_file = f"{sys._MEIPASS}\\GUI\\GUI.zip"

        if not os.path.exists(path_to_install):
            os.mkdir(path_to_install)
        if not os.path.exists(ext_folder):
            os.mkdir(ext_folder)
        if not os.path.exists(icon_folder):
            os.mkdir(icon_folder)
        if not os.path.exists(gui_folder):
            os.mkdir(gui_folder)

        print("Copying files...")
        shutil.copy(ext_file, ext_folder)
        shutil.copy(main_file, path_to_install)
        shutil.copy(uninstaller_file, path_to_install)
        shutil.copy(icon_file, icon_folder)
        shutil.copy(icon_file2, icon_folder)
        shutil.copy(gui_file, gui_folder)

        print("Extracting GUI files...")
        with zipfile.ZipFile(os.path.join(gui_folder, "GUI.zip"), 'r') as zip_ref:
            zip_ref.extractall(gui_folder)
        os.remove(os.path.join(gui_folder, "GUI.zip"))

        print("Adding shortcut to context menu...")
        create_key.create()

        print("Creating uninstall shortcut in desktop...")
        create()

        print("Creating GUI shortcut in desktop...")


        input("All done...\nPress any key to continue...")
    except Exception as ex:
        input(f"<========Error========>\n\n{traceback.print_exc()}\n\n<========Error========>")

if __name__ == "__main__":
    main()
