# iD7Zip_Solution
***************************************************************
		ABOUT THIS APPLICATION
***************************************************************

iD7Zip means individual Directory 7-Zip

iD7Zip v.1.0.0-alpha.1

2023

Copyright (c) 2023 Mihai-Dan M.

iD7Zip is free software

***************************************************************
			IMPORTANT
***************************************************************

This application uses the command line functionality of 7-Zip. 

7-Zip is licensed under the GNU LGPL license.
www.7-zip.org
Copyright (C) 2022 Igor Pavlov

********************************************************************
                   HOW TO use iD7Zip application
********************************************************************

1. The application is set, by default, to work with 7-Zip for Microsoft Windows x64 instruction set architecture.
   If the 7-Zip install is on x86 the user can change the path to 7z.exe in the 7z.EXE PATH field by pressing Select button to the right.
   IMPORTANT: This version supports only 7-Zip software installed in the default Microsoft Windows C:\ drive (C:\Program Files for x64 or C:\Program Files (x86) for x86)

2. Select Dir. PATH (Click Select on the right) - This is the folder that contains the folders that should be archived in .zip format

3. Click Run (engine.bat file is generated and run). Once the process completes, the user can check the generated .log file by pressing the Check .log file button

4. Open Dir. - opens the folder selected at step 2 (Open Dir.) - the .zip files will be available here

5. Either select another directory that contains folder to process (the engine.bat and engine_cmd_output.log file are reset) or Press Exit to exit program.

********************************************************************
engine.bat Information
********************************************************************

NOTE:
engine.bat is the main "engine" of iD7Zip application.
engine.bat calls 7z.exe (7-Zip https://www.7-zip.org/) file archiving process of the selected main Dir. (Folder Select UI section), via command line,
and after completion, it will generate , using wintee.exe (https://code.google.com/archive/p/wintee/), a .log file called engine_cmd_output.log and the .zip archive files.

BATCH SCRIPT (example for 7-Zip x86):

@echo off
cls()
: begin()
@echo ***************************************************************************************** 
@echo                       engine.bat RUNNING! Please wait...                                  
@echo  *****************************************************************************************
set UserDirectoryPath=...
cd %UserDirectoryPath%
for /d %%X in (*) do "%ProgramFiles(x86)%"\7-Zip\7z.exe a "%%X.zip" "%%X"
@echo ***************************************************************************************** 
@echo                       engine.bat DONE!                                                    
@echo ***************************************************************************************** 
@pause

****************************************************
       engine_cmd_output.log Information
****************************************************

This is a .log file that records the command line arguments and processes of the engine.bat file.
When selecting the main directory (Select Dir. PATH) this file is reset ("empty").

****************************************************
       OTHER INFO
****************************************************

https://code.google.com/archive/p/wintee/
