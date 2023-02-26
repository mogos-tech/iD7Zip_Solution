Public Class Form1
    'APPLICATION FILENAME FULL PATH
    Public Property AppFilename_FullPath As String '#ADD VARIABLE AS STRING
    'APPLICATION DIRECTORY FULL PATH
    Public Property AppDirectory_FullPath As String '#ADD VARIABLE AS STRING
    ' 7z.exe batch file filename full path part 1 (P1)
    Public Property ZipEngineFileName_FullPath_P1 As String '#ADD VARIABLE AS STRING
    'UserDirectoryPath (The directory path of the main folder that contains the folders to be zipped.)
    Public Property UserDirectoryPath As String '#ADD VARIABLE AS STRING
    ' batch file command part 1 (for %UserDirectoryPath%)
    Public Property cmdbatch_P1 As String '#ADD VARIABLE AS STRING
    'RUN (Engine.bat) command sequences
    Public Property cmdEngineSequence1 As String '#ADD VARIABLE AS STRING
    Public Property cmdEngineSequence2 As String '#ADD VARIABLE AS STRING
    Public Property PShellEngineSequence1 As String '#ADD VARIABLE AS STRING
    ' Success RUN (Engine.bat)
    Private Sub Button1_Click(sender As System.Object, e As EventArgs) Handles Button1.Click
        'Select 7z.exe and display the file path
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = OpenFileDialog1.FileName '#ADD VALUE
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As EventArgs) Handles Button2.Click
        'Select UserDirectoryPath (The directory path of the main folder that contains the folders to be zipped.)
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath '#ADD VALUE
            System.Diagnostics.Process.Start("cmd.exe", "/c break>Engine.bat") '# DELETE Engine.bat
            System.Diagnostics.Process.Start("cmd.exe", "/c break>7z_exe_Log.log") '# CLEAN 7z_exe_Log.txt
            'System.Diagnostics.Process.Start("cmd.exe", "/c break>7z_exe_Log_Log_Error.txt") ' CLEAN Engine_Log_Error.txt
        End If
    End Sub

    '---***---#---***---#---***---#---[ RUN (Engine.bat) ]---#---***---#---***---#---***---
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Button3.Enabled = False 'Disable the button after the user clicks on it
        Dim sb As New System.Text.StringBuilder
        '<STEP> Check if instruction set architecture, for 7z.exe, is x64 or x86.
        If (TextBox1.Text.Contains("C:\Program Files\")) Then
            ZipEngineFileName_FullPath_P1 = TextBox1.Text.Replace("C:\Program Files", """%ProgramFiles%""")
        ElseIf (TextBox1.Text.Contains("C:\Program Files (x86)\")) Then
            ZipEngineFileName_FullPath_P1 = TextBox1.Text.Replace("C:\Program Files (x86)", """%ProgramFiles(x86)%""")
        Else
            ZipEngineFileName_FullPath_P1 = TextBox1.Text.Replace("C:\Program Files", """%ProgramFiles%""")
        End If
        '<STEP> Contruct the %UserDirectoryPath% batch file variable
        cmdbatch_P1 = "set UserDirectoryPath="
        UserDirectoryPath = TextBox2.Text
        '<STEP> Write Engine.bat
        sb.AppendLine("@echo off")
        sb.AppendLine("cls()")
        sb.AppendLine(": begin()")
        sb.AppendLine("@echo ***************************************************************************************** ")
        sb.AppendLine("@echo                       Engine.bat RUNNING! Please wait...                                  ")
        sb.AppendLine("@echo  *****************************************************************************************")
        sb.AppendLine(String.Concat(cmdbatch_P1, UserDirectoryPath))
        sb.AppendLine("cd %UserDirectoryPath%")
        sb.AppendLine(String.Concat("for /d %%X in (*) do ", ZipEngineFileName_FullPath_P1, " a ""%%X.zip"" ""%%X"""))
        'sb.AppendLine(String.Concat("(for /d %%X in (*) do ", ZipEngineFileName_FullPath_P1, " a ""%%X.zip"" ""%%X"") 2>&1 | wtee 7z_exe_Log.txt")) '*** LOGGING ***
        sb.AppendLine("@echo ***************************************************************************************** ")
        sb.AppendLine("@echo                       Engine.bat DONE!                                                    ")
        sb.AppendLine("@echo ***************************************************************************************** ")
        sb.AppendLine("@pause")
        IO.File.WriteAllText("Engine.bat", sb.ToString()) '# WRITE

        '<STEP> RUN Engine.bat

        'cmdEngineSequence1 = "/c (Engine.bat)&&(exit)" '*** RUN Engine.bat***
        'cmdEngineSequence1 = "/k (Engine.bat)&&(exit)" '*** RUN Engine.bat***

        cmdEngineSequence1 = "/k (Engine.bat 2>&1 | wtee 7z_exe_Log.log)&&(exit)" '*** RUN COMMAND PARAMETERS***
        System.Diagnostics.Process.Start("cmd.exe", cmdEngineSequence1) '*** RUN COMMAND START ***

        'System.Diagnostics.Process.Start("Engine.bat")

        '********************************[ IN DEVELOPMENT (Open 7z_exe_Log.txt either inside the CMD or on external Notepad.exe process) ]*************************************

        ' CREATE DISPLAY LOG FILE INFO INSIDE THE CMD/NOTEPAD
        'Dim sbe As New System.Text.StringBuilder

        'sbe.AppendLine("@echo off")
        'sbe.AppendLine("cls()")
        'sbe.AppendLine(": begin()")
        'sbe.AppendLine(String.Concat(cmdbatch_P1, UserDirectoryPath))
        'sbe.AppendLine("cd %UserDirectoryPath%")
        'sbe.AppendLine("echo #########################[ RUN (Engine.bat) PROCESS LOG ]#########################")
        'sbe.AppendLine("notepad 7z_exe_Log.txt")
        'sbe.AppendLine("echo #########################[ END OF PROCESS LOG ]#########################")
        'sbe.AppendLine("@pause")

        'IO.File.WriteAllText("TypeLogToCMD.bat", sbe.ToString())

        'System.Diagnostics.Process.Start("TypeLogToCMD.bat")



        '*** Logging Process & Error (in development) ***

        'cmdEngineSequence1 = "/c (Engine.bat > Engine_Log.txt 2> Engine_Log_Error.txt)&&(exit)"
        'System.Diagnostics.Process.Start("cmd.exe", cmdEngineSequence1)

        'cmdEngineSequence2 = "/c (type Engine_Log.txt)&&(type Engine_Log_Error.txt)"
        'System.Diagnostics.Process.Start("cmd.exe", cmdEngineSequence2)

        'PShellEngineSequence1 = "get-content ./Engine_Log.txt; get-content ./Engine_Log_Error.txt; Read-Host -Prompt ""Press Enter to exit"""
        'System.Diagnostics.Process.Start("powershell.exe", PShellEngineSequence1)
        'Shell("powershell -noexit", PShellEngineSequence1)

    End Sub
    '---***---#---***---#---***---#---[ OPEN DIR. ]---#---***---#---***---#---***---
    Private Sub Button4_Click(sender As System.Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("explorer.exe", TextBox2.Text)
    End Sub
    '---***---#---***---#---***---#---[ CHECK LOG FILE ]---#---***---#---***---#---***---
    Private Sub Button6_Click(sender As System.Object, e As EventArgs) Handles Button6.Click
        'DISPLAY THE LOG FILE IN NOTEPAD.EXE
        System.Diagnostics.Process.Start("notepad.exe", "7z_exe_Log.log") ' OPEN WITH NOTEPAD
    End Sub


    '---***---#---***---#---***---#---[ EXIT ]---#---***---#---***---#---***---
    Private Sub Button5_Click(sender As System.Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("cmd.exe", "/c break>Engine.bat") '# DELETE Engine.bat
        Close() ' Close/Exit program
    End Sub
End Class