Public Class Form1
    '****************************************************************************************
    '                                     [###]                                     
    '****************************************************************************************
    'APPLICATION FILENAME FULL PATH
    Public Property AppFilename_FullPath As String '# ADD VARIABLE AS STRING

    'APPLICATION DIRECTORY FULL PATH
    Public Property AppDirectory_FullPath As String '# ADD VARIABLE AS STRING

    ' 7z.exe filename full path part 1 (P1 - engine.bat)
    Public Property ZipEngineFileName_FullPath_P1 As String '# ADD VARIABLE AS STRING

    'UserDirectoryPath (The directory path of the main folder that contains the folders to be zipped - engine.bat)
    Public Property UserDirectoryPath As String '#ADD VARIABLE AS STRING

    ' batch file command part 1 (for %UserDirectoryPath%)
    Public Property cmdbatch_P1 As String '# ADD VARIABLE AS STRING

    'RUN (engine.bat) command sequences
    Public Property cmdEngineSequence1 As String '# ADD VARIABLE AS STRING
    Public Property cmdEngineSequence2 As String '# ADD VARIABLE AS STRING
    Public Property PShellEngineSequence1 As String '# ADD VARIABLE AS STRING

    '****************************************************************************************
    '                     [Get 7z.exe filename path - user selection]                                     
    '****************************************************************************************

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Set7zexePATHToolStripMenuItem.Click
        'Select 7z.exe and display the file path
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = OpenFileDialog1.FileName '# ADD VALUE
        End If
    End Sub

    '****************************************************************************************
    '          [Get main directory containing folders to archive - user selection]                                     
    '****************************************************************************************

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, SelectDirPATHToolStripMenuItem.Click
        'Select UserDirectoryPath (The directory path of the main folder that contains the folders to be zipped.)
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath '#ADD VALUE
            System.Diagnostics.Process.Start("cmd.exe", "/c break>engine.bat") '# CLEAN engine.bat [!background process]
            System.Diagnostics.Process.Start("cmd.exe", "/c break>engine_cmd_output.log") '# CLEAN engine_cmd_output.txt [!background process]
        End If
    End Sub

    '****************************************************************************************
    '                                     [engine.bat]                                     
    '****************************************************************************************

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Button3.Enabled = False ' Disable the button after the user clicks on it (tested, not in release version)
        Button6.Enabled = True ' Activate the button after the user clicks on it (make the .log file accessible)
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
        '<STEP> Write engine.bat
        sb.AppendLine("@echo off")
        sb.AppendLine("cls()")
        sb.AppendLine(": begin()")
        sb.AppendLine("@echo ***************************************************************************************** ")
        sb.AppendLine("@echo                       engine.bat RUNNING! Please wait...                                  ")
        sb.AppendLine("@echo  *****************************************************************************************")
        sb.AppendLine(String.Concat(cmdbatch_P1, UserDirectoryPath))
        sb.AppendLine("cd %UserDirectoryPath%")
        sb.AppendLine(String.Concat("for /d %%X in (*) do ", ZipEngineFileName_FullPath_P1, " a ""%%X.zip"" ""%%X"""))
        'sb.AppendLine(String.Concat("(for /d %%X in (*) do ", ZipEngineFileName_FullPath_P1, " a ""%%X.zip"" ""%%X"") 2>&1 | wtee engine_cmd_output.txt")) '*** LOGGING ***
        sb.AppendLine("@echo ***************************************************************************************** ")
        sb.AppendLine("@echo                       engine.bat DONE!                                                    ")
        sb.AppendLine("@echo ***************************************************************************************** ")
        sb.AppendLine("@pause")
        IO.File.WriteAllText("engine.bat", sb.ToString()) '# WRITE

        '<STEP> RUN engine.bat
        'cmdEngineSequence1 = "/c (engine.bat)&&(exit)" '*** RUN engine.bat*** (not in release version)
        'cmdEngineSequence1 = "/k (engine.bat)&&(exit)" '*** RUN engine.bat*** (not in release version)
        cmdEngineSequence1 = "/k (engine.bat 2>&1 | wtee engine_cmd_output.log)&&(exit)" '*** RUN COMMAND PARAMETER S***
        System.Diagnostics.Process.Start("cmd.exe", cmdEngineSequence1) '*** RUN COMMAND START ***
        'System.Diagnostics.Process.Start("engine.bat") (not in release version)

        '****************************************************************************************
        '                         [TESTED CODE (Keeping this for future ideas)]                                     
        '****************************************************************************************

        '***[ IN DEVELOPMENT (Open engine_cmd_output.txt either inside the CMD or on external Notepad.exe process) ]

        ' CREATE DISPLAY LOG FILE INFO INSIDE THE CMD/NOTEPAD
        'Dim sbe As New System.Text.StringBuilder

        'sbe.AppendLine("@echo off")
        'sbe.AppendLine("cls()")
        'sbe.AppendLine(": begin()")
        'sbe.AppendLine(String.Concat(cmdbatch_P1, UserDirectoryPath))
        'sbe.AppendLine("cd %UserDirectoryPath%")
        'sbe.AppendLine("echo #########################[ RUN (engine.bat) PROCESS LOG ]#########################")
        'sbe.AppendLine("notepad engine_cmd_output.txt")
        'sbe.AppendLine("echo #########################[ END OF PROCESS LOG ]#########################")
        'sbe.AppendLine("@pause")
        'IO.File.WriteAllText("TypeLogToCMD.bat", sbe.ToString())
        'System.Diagnostics.Process.Start("TypeLogToCMD.bat")

        '*** Logging Process & Error (in development) ***

        'cmdEngineSequence1 = "/c (engine.bat > Engine_Log.txt 2> Engine_Log_Error.txt)&&(exit)"
        'System.Diagnostics.Process.Start("cmd.exe", cmdEngineSequence1)

        'cmdEngineSequence2 = "/c (type Engine_Log.txt)&&(type Engine_Log_Error.txt)"
        'System.Diagnostics.Process.Start("cmd.exe", cmdEngineSequence2)

        'PShellEngineSequence1 = "get-content ./Engine_Log.txt; get-content ./Engine_Log_Error.txt; Read-Host -Prompt ""Press Enter to exit"""
        'System.Diagnostics.Process.Start("powershell.exe", PShellEngineSequence1)
        'Shell("powershell -noexit", PShellEngineSequence1)
    End Sub

    '****************************************************************************************
    '                                     [OPEN DIR.]                                     
    '****************************************************************************************

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, OpenDirPATHToolStripMenuItem.Click
        System.Diagnostics.Process.Start("explorer.exe", TextBox2.Text)
    End Sub

    '****************************************************************************************
    '                     [VIEW .LOG FILE (engine_cmd_output.log)]                                     
    '****************************************************************************************

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click, ViewEnginecmdoutputlogToolStripMenuItem.Click
        'DISPLAY THE LOG FILE IN NOTEPAD.EXE
        System.Diagnostics.Process.Start("notepad.exe", "engine_cmd_output.log") ' OPEN WITH NOTEPAD
    End Sub

    '****************************************************************************************
    '                                     [EXIT]                                     
    '****************************************************************************************

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click, ExitToolStripMenuItem.Click
        System.Diagnostics.Process.Start("cmd.exe", "/c break>engine.bat") '# DELETE engine.bat
        Close() ' Close/Exit program
    End Sub

    Private Sub ID7ZipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ID7ZipToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe", "_app_info.txt") ' _app_info.txt
    End Sub

    Private Sub ZipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZipToolStripMenuItem.Click, LinkLabel1.Click
        System.Diagnostics.Process.Start(New ProcessStartInfo("cmd", $"/c start microsoft-edge:https://www.7-zip.org/"))
    End Sub

    Private Sub LICENSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LICENSEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe", "LICENSE.txt") ' LICENSE.txt
    End Sub

    Private Sub Httpswwwgnuorglicensesoldlicenseslgpl21enhtmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Httpswwwgnuorglicensesoldlicenseslgpl21enhtmlToolStripMenuItem.Click
        System.Diagnostics.Process.Start(New ProcessStartInfo("cmd", $"/c start microsoft-edge:https://www.gnu.org/licenses/old-licenses/lgpl-2.1.en.html"))
    End Sub

    Private Sub HowToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe", "_how_to_info.txt") ' _how_to_info.txt
    End Sub

    Private Sub EnginebatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnginebatToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe", "_engine_bat_info.txt") ' _engine_bat_info.txt
    End Sub

    Private Sub EnginecmdoutputlogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnginecmdoutputlogToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe", "_engine_cmd_output_log_info.txt") ' _engine_cmd_output_log_info.txt
    End Sub

    Private Sub WteeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WteeToolStripMenuItem.Click
        System.Diagnostics.Process.Start(New ProcessStartInfo("cmd", $"/c start microsoft-edge:https://code.google.com/archive/p/wintee/"))
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start(New ProcessStartInfo("cmd", $"/c start microsoft-edge:https://en.wikipedia.org/wiki/7-Zip"))
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start(New ProcessStartInfo("cmd", $"/c start microsoft-edge:https://www.linkedin.com/in/mihaidanmogos/"))
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        System.Diagnostics.Process.Start(New ProcessStartInfo("cmd", $"/c start microsoft-edge:https://github.com/ZHDJ85ZUBPBG3H8/iD7Zip_Solution"))
    End Sub
End Class