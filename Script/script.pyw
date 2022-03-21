import json
import os
import shutil
import sys
#import win10toast
from os import listdir
from os import path
from os.path import isfile, join

files = [f for f in listdir("./") if isfile(join("./", f))] #get files in current working directory
json_path = f"{os.environ['ProgramFiles(x86)']}\\PFO\\Extensions\\extensions.json"
#json_path = "./new_extensions.json"

def rename(n, p):
    name_holder = n
    counter = 0
    fe = name_holder.split(".")[len(name_holder.split(".")) - 1] #getting the extension of the file
    new_name = name_holder[:-(len(fe) + 1)] #getting the name without the last dot and the extension
    while True:
        counter += 1
        final_name = f"{new_name}({counter}).{fe}"#mount a new name with a number so it won't exist
        if not os.path.exists(os.path.join(p, final_name)): #if the renamed file doesn't exist
            os.rename(n, final_name) #rename the file
            n = final_name #replace the old name in the current array position
            break
        else:
            continue   
    return n

def c(src, dest):
    shutil.copy(src, dest)
    os.remove(src)

def main():
    try:
        if f"{os.environ['ProgramFiles(x86)']}\\PFO" not in f"{os.getcwd()}":
            with open(json_path) as jf:
                jf.flush()
                d = json.load(jf)
                size = len(d) - 1
                data = d
            for i in range(len(files)):
                curr_ext = "." + str(files[i]).split(".")[len(str(files[i]).split(".")) - 1]
                name = str(files[i])[:-len(curr_ext)]
                for j in range(size):            
                    if name not in data[j -1]["exceptions"].split("/"):
                        if curr_ext in data[j -1]["extensions"].split("/"):
                            if os.path.exists(os.path.join(os.getcwd(), data[j -1]["foldername"])):
                                if not os.path.exists(os.path.join(os.path.join(os.getcwd(), data[j -1]["foldername"]), files[i])):
                                    c(os.path.join(os.getcwd(), files[i]), os.path.join(os.getcwd(), data[j -1]["foldername"]))
                                else:
                                    new_name = rename(files[i], os.path.join(os.getcwd(), data[j -1]["foldername"]))
                                    files[i] = new_name
                                    c(os.path.join(os.getcwd(), files[i]), os.path.join(os.getcwd(), data[j -1]["foldername"]))
                            else:
                                os.mkdir(os.path.join(os.getcwd(), data[j -1]["foldername"]))
                                if not os.path.exists(os.path.join(os.path.join(os.getcwd(), data[j -1]["foldername"]), files[i])):
                                    c(os.path.join(os.getcwd(), files[i]), os.path.join(os.getcwd(), data[j -1]["foldername"]))
                                else:
                                    new_name = rename(files[i], os.path.join(os.getcwd(), data[j -1]["foldername"]))
                                    files[i] = new_name
                                    c(os.path.join(os.getcwd(), files[i]), os.path.join(os.getcwd(), data[j -1]["foldername"]))
                    else:
                        continue
        else:
            pass
            #win10toast.ToastNotifier().show_toast("Failed", "Error! This folder is blocked from being organized with this program!", duration=7)
    except Exception as ex:
        input(f"{ex}")

if __name__ == "__main__":
    main()