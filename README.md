# OrganizeFolders
Program to organize diverse files into folders.

This program uses as source of info a json file that has an array of objects, and each object has an keyword with it's value, in this case
"extensions": ".docx/.doc/..."
"foldername": "Word Files"
"exceptions": ""

Extensions is the extensions of files that the python script will look for to move them to a folder with the name that's inside of "foldername", and it will create the folder if it doesn't exist.

Exceptions is the files the user don't want to be pushed to inside the folder.

Using python to read the json file and do the hard work with the files.
Using c# for the GUI and to insert or edit the data on the json file.

Took me about a month and half to do it because i had some dumb problems, but i finally resolved them.

If you want to use this program just run the "PFO Installer.exe" and wait until it's done installing, when done, you can either start using it (it will having some basic extensions already inserted), or you can open "PFO GUI" that will be in your desktop and add more extensions, exceptions, etc... , edit the ones that already exist or delete some.

To use it's super simple, just open the folder you want to organize, right click inside it, and search for the option "Organize Folder", and hit it, it will then organize the files that the script recognizes from the json to the respective folder.

gx
