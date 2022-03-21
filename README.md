<h1 align="center">Welcome to Organize Folders 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-1.0.0-blue.svg?cacheSeconds=2592000" />
  <a href="https://github.com/guuuu/blob/main/readme.md" target="_blank">
    <img alt="Documentation" src="https://img.shields.io/badge/documentation-yes-brightgreen.svg" />
  </a>
  <a href="https://github.com/guuuu/OrganizeFolders/blob/main/LICENSE" target="_blank">
    <img alt="License: GNU GPLv3" src="https://img.shields.io/badge/License-GNU GPLv3-yellow.svg" />
  </a>
</p>

> Program to organize diverse files into folders.

>This program uses as source of info a json file that has an array of objects, and each object has an keyword with it's value, in this case "extensions": ".docx/.doc/..." "foldername": "Word Files" "exceptions": ""

>Extensions is the extensions of files that the python script will look for to move them to a folder with the name that's inside of "foldername", and it will create the folder if it doesn't exist.

>Exceptions is the files the user don't want to be pushed to inside the folder.

>Using python to read the json file and do the hard work with the files. Using c# for the GUI and to insert or edit the data on the json file.

>Took me about a month and half to do it because i had some dumb problems, but i finally resolved them.

>If you want to use this program just run the "PFO Installer.exe" and wait until it's done installing, when done, you can either start using it (it will having some basic extensions already inserted), or you can open "PFO GUI" that will be in your desktop and add more extensions, exceptions, etc... , edit the ones that already exist or delete some.

>To use it's super simple, just open the folder you want to organize, right click inside it, and search for the option "Organize Folder", and hit it, it will then organize the files that the script recognizes from the json to the respective folder.

>Note: This project was done 2 years ago from this re-upload (2020) but i didn't had the right files uploaded because i didn't really know how github worked at the time

## Install

> All of the following commands need to be done inside the Script folder

#### 1

```
pyinstaller --onefile -n="PFO.exe" script.pyw
```

#### 2

```
pyinstaller --onefile -n="PFO Uninstaller.exe" uninstaller.pyw
```

#### 3

> Create a .zip folder called GUI with a GUI folder inside, the content of the GUI folder is the files inside the GUI/bin/debug

#### 4

```
pyinstaller --onefile --add-data="extensions.json;ext" --add-data="PFO.exe;main" --add-data="PFO Uninstaller.exe;unin" --add-data="uninstall.ico;icon" --add-data="gui.ico;icon" --add-data="GUI.zip;GUI" --add-data="uninstall pfo.bat;bat" -n="PFO Installer" installer.py
```

## Author

👤 **Gustavo Nascimento**

* Website: https://guuuu.github.io/gxdev
* Github: [@guuuu](https://github.com/guuuu)

## 🤝 Contributing

Contributions, issues and feature requests are welcome!<br />Feel free to check [issues page](https://github.com/guuuu/OrganizeFolders/issues). 

## Show your support

Give a ⭐️ if this project helped you!

## 📝 License

Copyright © 2022 [Gustavo Nascimento](https://github.com/guuuu).<br />
This project is [GNU GPLv3](https://github.com/guuuu/OrganizeFolders/blob/main/LICENSE) licensed.

***
_This README was generated with ❤️ by [readme-md-generator](https://github.com/kefranabg/readme-md-generator)_