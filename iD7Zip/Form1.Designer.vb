<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Button2 = New Button()
        TextBox2 = New TextBox()
        Label2 = New Label()
        GroupBox4 = New GroupBox()
        LinkLabel4 = New LinkLabel()
        LinkLabel3 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        LinkLabel1 = New LinkLabel()
        GroupBox5 = New GroupBox()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        HelpProvider1 = New HelpProvider()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        Set7zexePATHToolStripMenuItem = New ToolStripMenuItem()
        SelectDirPATHToolStripMenuItem = New ToolStripMenuItem()
        OpenDirPATHToolStripMenuItem = New ToolStripMenuItem()
        ViewEnginecmdoutputlogToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HowToToolStripMenuItem = New ToolStripMenuItem()
        EnginebatToolStripMenuItem = New ToolStripMenuItem()
        EnginecmdoutputlogToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ID7ZipToolStripMenuItem = New ToolStripMenuItem()
        ZipToolStripMenuItem = New ToolStripMenuItem()
        WteeToolStripMenuItem = New ToolStripMenuItem()
        CopyrightToolStripMenuItem = New ToolStripMenuItem()
        LICENSEToolStripMenuItem = New ToolStripMenuItem()
        Httpswwwgnuorglicensesoldlicenseslgpl21enhtmlToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 102)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "7-Zip"' 
        ' Button1
        ' 
        Button1.Location = New Point(695, 44)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Select"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(80, 44)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(609, 23)
        TextBox1.TabIndex = 2
        TextBox1.Text = "C:\Program Files\7-Zip\7z.exe"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 0
        Label1.Text = "7z.exe PATH:"' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(12, 135)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(776, 102)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Folder Select"' 
        ' Button2
        ' 
        HelpProvider1.SetHelpString(Button2, "Select the full path for the main folder containing the folders to be archived/zipped.")
        Button2.Location = New Point(695, 40)
        Button2.Name = "Button2"
        HelpProvider1.SetShowHelp(Button2, True)
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "Select"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(80, 40)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(609, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 0
        Label2.Text = "Dir. PATH:"' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(LinkLabel4)
        GroupBox4.Controls.Add(LinkLabel3)
        GroupBox4.Controls.Add(LinkLabel2)
        GroupBox4.Controls.Add(LinkLabel1)
        GroupBox4.Location = New Point(12, 243)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(385, 102)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "GroupBox4"' 
        ' LinkLabel4
        ' 
        LinkLabel4.AutoSize = True
        LinkLabel4.Location = New Point(7, 68)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.Size = New Size(307, 15)
        LinkLabel4.TabIndex = 3
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "https://github.com/ZHDJ85ZUBPBG3H8/iD7Zip_Solution"' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.Location = New Point(6, 51)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(258, 15)
        LinkLabel3.TabIndex = 2
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "https://www.linkedin.com/in/mihaidanmogos/"' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Location = New Point(6, 34)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(198, 15)
        LinkLabel2.TabIndex = 1
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "https://en.wikipedia.org/wiki/7-Zip/"' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(6, 19)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(129, 15)
        LinkLabel1.TabIndex = 0
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "https://www.7-zip.org/"' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(Button6)
        GroupBox5.Controls.Add(Button5)
        GroupBox5.Controls.Add(Button4)
        GroupBox5.Controls.Add(Button3)
        GroupBox5.Location = New Point(403, 243)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(385, 102)
        GroupBox5.TabIndex = 4
        GroupBox5.TabStop = False
        GroupBox5.Text = "Engine"' 
        ' Button6
        ' 
        Button6.Enabled = False
        Button6.Location = New Point(201, 43)
        Button6.Name = "Button6"
        Button6.Size = New Size(97, 23)
        Button6.TabIndex = 3
        Button6.Text = "Check .log file"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(304, 43)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 2
        Button5.Text = "Exit"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(87, 43)
        Button4.Name = "Button4"
        Button4.Size = New Size(108, 23)
        Button4.TabIndex = 1
        Button4.Text = "Open Dir."
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(6, 43)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 0
        Button3.Text = "Run"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "7z.exe"' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem, AboutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(799, 24)
        MenuStrip1.TabIndex = 5
        MenuStrip1.Text = "MenuStrip1"' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Set7zexePATHToolStripMenuItem, SelectDirPATHToolStripMenuItem, OpenDirPATHToolStripMenuItem, ViewEnginecmdoutputlogToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"' 
        ' Set7zexePATHToolStripMenuItem
        ' 
        Set7zexePATHToolStripMenuItem.Name = "Set7zexePATHToolStripMenuItem"
        Set7zexePATHToolStripMenuItem.Size = New Size(228, 22)
        Set7zexePATHToolStripMenuItem.Text = "Set 7z.exe PATH"' 
        ' SelectDirPATHToolStripMenuItem
        ' 
        SelectDirPATHToolStripMenuItem.Name = "SelectDirPATHToolStripMenuItem"
        SelectDirPATHToolStripMenuItem.Size = New Size(228, 22)
        SelectDirPATHToolStripMenuItem.Text = "Select Dir. PATH"' 
        ' OpenDirPATHToolStripMenuItem
        ' 
        OpenDirPATHToolStripMenuItem.Name = "OpenDirPATHToolStripMenuItem"
        OpenDirPATHToolStripMenuItem.Size = New Size(228, 22)
        OpenDirPATHToolStripMenuItem.Text = "Open Dir. PATH"' 
        ' ViewEnginecmdoutputlogToolStripMenuItem
        ' 
        ViewEnginecmdoutputlogToolStripMenuItem.Name = "ViewEnginecmdoutputlogToolStripMenuItem"
        ViewEnginecmdoutputlogToolStripMenuItem.Size = New Size(228, 22)
        ViewEnginecmdoutputlogToolStripMenuItem.Text = "View engine_cmd_output.log"' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(228, 22)
        ExitToolStripMenuItem.Text = "Exit"' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HowToToolStripMenuItem, EnginebatToolStripMenuItem, EnginecmdoutputlogToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"' 
        ' HowToToolStripMenuItem
        ' 
        HowToToolStripMenuItem.Name = "HowToToolStripMenuItem"
        HowToToolStripMenuItem.Size = New Size(266, 22)
        HowToToolStripMenuItem.Text = "How To Guide"' 
        ' EnginebatToolStripMenuItem
        ' 
        EnginebatToolStripMenuItem.Name = "EnginebatToolStripMenuItem"
        EnginebatToolStripMenuItem.Size = New Size(266, 22)
        EnginebatToolStripMenuItem.Text = "engine.bat Information"' 
        ' EnginecmdoutputlogToolStripMenuItem
        ' 
        EnginecmdoutputlogToolStripMenuItem.Name = "EnginecmdoutputlogToolStripMenuItem"
        EnginecmdoutputlogToolStripMenuItem.Size = New Size(266, 22)
        EnginecmdoutputlogToolStripMenuItem.Text = "engine_cmd_output.log Information"' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ID7ZipToolStripMenuItem, ZipToolStripMenuItem, WteeToolStripMenuItem, CopyrightToolStripMenuItem})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(52, 20)
        AboutToolStripMenuItem.Text = "About"' 
        ' ID7ZipToolStripMenuItem
        ' 
        ID7ZipToolStripMenuItem.Name = "ID7ZipToolStripMenuItem"
        ID7ZipToolStripMenuItem.Size = New Size(113, 22)
        ID7ZipToolStripMenuItem.Text = "iD7Zip"' 
        ' ZipToolStripMenuItem
        ' 
        ZipToolStripMenuItem.Name = "ZipToolStripMenuItem"
        ZipToolStripMenuItem.Size = New Size(113, 22)
        ZipToolStripMenuItem.Text = "7-Zip"' 
        ' WteeToolStripMenuItem
        ' 
        WteeToolStripMenuItem.Name = "WteeToolStripMenuItem"
        WteeToolStripMenuItem.Size = New Size(113, 22)
        WteeToolStripMenuItem.Text = "wintee"' 
        ' CopyrightToolStripMenuItem
        ' 
        CopyrightToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LICENSEToolStripMenuItem, Httpswwwgnuorglicensesoldlicenseslgpl21enhtmlToolStripMenuItem})
        CopyrightToolStripMenuItem.Name = "CopyrightToolStripMenuItem"
        CopyrightToolStripMenuItem.Size = New Size(113, 22)
        CopyrightToolStripMenuItem.Text = "License"' 
        ' LICENSEToolStripMenuItem
        ' 
        LICENSEToolStripMenuItem.Name = "LICENSEToolStripMenuItem"
        LICENSEToolStripMenuItem.Size = New Size(389, 22)
        LICENSEToolStripMenuItem.Text = "LICENSE"' 
        ' Httpswwwgnuorglicensesoldlicenseslgpl21enhtmlToolStripMenuItem
        ' 
        Httpswwwgnuorglicensesoldlicenseslgpl21enhtmlToolStripMenuItem.Name = "Httpswwwgnuorglicensesoldlicenseslgpl21enhtmlToolStripMenuItem"
        Httpswwwgnuorglicensesoldlicenseslgpl21enhtmlToolStripMenuItem.Size = New Size(389, 22)
        Httpswwwgnuorglicensesoldlicenseslgpl21enhtmlToolStripMenuItem.Text = "https://www.gnu.org/licenses/old-licenses/lgpl-2.1.en.html"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(799, 355)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        HelpButton = True
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "iD7Zip"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox5.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Button6 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Set7zexePATHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectDirPATHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenDirPATHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ID7ZipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyrightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnginebatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewEnginecmdoutputlogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnginecmdoutputlogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LICENSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Httpswwwgnuorglicensesoldlicenseslgpl21enhtmlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WteeToolStripMenuItem As ToolStripMenuItem
End Class
