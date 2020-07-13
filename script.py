import json
import os
import shutil
import traceback
import sys
import winreg as reg
from os import listdir
from os import path
from os.path import isfile, join

# try:
#     cwd = os.getcwd()
#     pe = sys.executable
#     kp = r"Directory\\Background\\shell\\Organizer"
#     key = reg.CreateKeyEx(reg.HKEY_CLASSES_ROOT, kp)
#     reg.SetValue(key, '', reg.REG_SZ, 'Organizar pasta')
#     key1 = reg.CreateKeyEx(key, r"command")
#     reg.SetValue(key1, reg.REG_SZ, pe, f'"{cwd}\\script.py"')
# except Exception as ex:
#     traceback.print_exc()
#     pass

# files = [f for f in listdir("./") if isfile(join("./", f))] #get files in current working directory

# bundle_dir = getattr(sys, '_MEIPASS', path.abspath(path.dirname(__file__)))
# json_path = path.join(bundle_dir, 'extensions.json')

#json_path = os.path.join(os.path.abspath("."), "extensions.json")

with open(json_path) as jf:#load the json file
    d = json.load(jf) 
    try:
        for k, v in d.items(): #for each keyword in the json file
            expt = []
            for i in range(len(files)): #for each file in the current working directory
                for j in range(len(str(d[k]["extensions"]).split("/"))): #for each extension in the key value of json file
                    if "." + str(files[i]).split(".")[len(str(files[i]).split(".")) - 1] == str(d[k]["extensions"]).split("/")[j]: #if the file extension is the same as the json extension of the key word
                        for n in range(len(str(d[k]["exceptions"]).split("/"))): #for each exception in the json file
                            expt.append(str(d[k]["exceptions"]).split("/")[n] + str(d[k]["extensions"]).split("/")[j]) #append to array for easy verification of exception files
                        if files[i] not in expt : #if the file that is being iterated is NOT an exception
                            if not os.path.exists("./" + d[k]["foldername"]): #check if the folder is already created
                                os.mkdir("./" + d[k]["foldername"]) #create the folder
                                if not os.path.exists("./" + d[k]["foldername"] + "/" + files[i]): #check if the file is NOT in the folder
                                    shutil.copy("./" + files[i], "./" + d[k]["foldername"]) #copy the file to the folder
                                    os.remove("./" + files[i])
                                else:
                                    pass
                            else: #if the folder already exists
                                if not os.path.exists("./" + d[k]["foldername"] + "/" + files[i]): #check if the file is NOT in the folder
                                    shutil.copy("./" + files[i], "./" + d[k]["foldername"]) #copy the file to the folder
                                    os.remove("./" + files[i])
                                else:
                                    pass
    except Exception as ex:
        traceback.print_exc()
        input()
        pass       