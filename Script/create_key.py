import os
import sys
import winreg as reg

def deleteSubkey(key0, key1, key2=""):
    if key2=="":
        currentkey = key1
    else:
        currentkey = key1+ "\\" +key2

    open_key = reg.OpenKey(key0, currentkey ,0,reg.KEY_ALL_ACCESS)
    infokey = reg.QueryInfoKey(open_key)
    for x in range(0, infokey[0]):
        subkey = reg.EnumKey(open_key, 0)
        try:
            reg.DeleteKey(open_key, subkey)
        except:
            deleteSubkey( key0, currentkey, subkey )
    reg.DeleteKey(open_key,"")
    open_key.Close()
    return

def create():
    key_to_read = r'Directory\\Background\\shell\\Folder_Organizer'

    try:
        regR = ConnectRegistry(None, HKEY_LOCAL_MACHINE)
        k = OpenKey(regR, key_to_read)
    except Exception as ex:
        try:   
            cwd = os.getcwd()
            python_exe = sys.executable
            key_path = r"Directory\\Background\\shell\\Folder_Organizer"

            key = reg.CreateKey(reg.HKEY_CLASSES_ROOT, key_path)
            reg.SetValue(key, '', reg.REG_SZ, '&Organizar pasta')
            key1 = reg.CreateKey(key, r"command")
            reg.SetValue(key1, '', reg.REG_SZ, f"{os.environ['ProgramFiles(x86)']}\\PFO\\PFO.exe")
        except Exception as ex:
            print(ex)

def remove():
    deleteSubkey(reg.HKEY_CLASSES_ROOT, "Directory\\Background\\shell\\Folder_Organizer", "command")
    deleteSubkey(reg.HKEY_CLASSES_ROOT, "Directory\\Background\\shell\\Folder_Organizer")