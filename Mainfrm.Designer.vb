<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainfrm))
        Me.freqtimer = New System.Windows.Forms.Timer(Me.components)
        Me.TabParent = New System.Windows.Forms.TabControl()
        Me.TabFromPoint = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.usrlbl = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GoToProcessbtn = New System.Windows.Forms.Button()
        Me.HighLightBtnTab1 = New System.Windows.Forms.Button()
        Me.RdOnlyText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.classtxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TimerCtrlBtn = New System.Windows.Forms.Button()
        Me.proctxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.winh = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ytext = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xtext = New System.Windows.Forms.TextBox()
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.folderpathtxt = New System.Windows.Forms.TextBox()
        Me.folderlbl = New System.Windows.Forms.Label()
        Me.wintextbox = New System.Windows.Forms.TextBox()
        Me.SetTxtBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SetPropBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.windowoptions = New System.Windows.Forms.ComboBox()
        Me.TabFromWindow = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.folderpathtxt2 = New System.Windows.Forms.TextBox()
        Me.folderlbl2 = New System.Windows.Forms.Label()
        Me.childtxt = New System.Windows.Forms.TextBox()
        Me.setchildtxtbtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.setchildpropbtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.childpropcbox = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.usrlbl2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.HighLightBtn = New System.Windows.Forms.Button()
        Me.RefreshChildBtn = New System.Windows.Forms.Button()
        Me.childwindowlistvw = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.proccountlbl = New System.Windows.Forms.Label()
        Me.OnlySystemChkBox = New System.Windows.Forms.CheckBox()
        Me.KillProcBtn = New System.Windows.Forms.Button()
        Me.RefreshProcBtn = New System.Windows.Forms.Button()
        Me.proclistvw = New System.Windows.Forms.ListBox()
        Me.proclistsystemvw = New System.Windows.Forms.ListBox()
        Me.OpenBinaryDlg = New System.Windows.Forms.OpenFileDialog()
        Me.TabParent.SuspendLayout()
        Me.TabFromPoint.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GB1.SuspendLayout()
        Me.TabFromWindow.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'freqtimer
        '
        Me.freqtimer.Interval = 200
        '
        'TabParent
        '
        Me.TabParent.Controls.Add(Me.TabFromPoint)
        Me.TabParent.Controls.Add(Me.TabFromWindow)
        Me.TabParent.Location = New System.Drawing.Point(16, 15)
        Me.TabParent.Margin = New System.Windows.Forms.Padding(4)
        Me.TabParent.Name = "TabParent"
        Me.TabParent.SelectedIndex = 0
        Me.TabParent.Size = New System.Drawing.Size(1147, 689)
        Me.TabParent.TabIndex = 26
        '
        'TabFromPoint
        '
        Me.TabFromPoint.Controls.Add(Me.GroupBox2)
        Me.TabFromPoint.Controls.Add(Me.GB1)
        Me.TabFromPoint.Location = New System.Drawing.Point(4, 25)
        Me.TabFromPoint.Margin = New System.Windows.Forms.Padding(4)
        Me.TabFromPoint.Name = "TabFromPoint"
        Me.TabFromPoint.Padding = New System.Windows.Forms.Padding(4)
        Me.TabFromPoint.Size = New System.Drawing.Size(1139, 660)
        Me.TabFromPoint.TabIndex = 0
        Me.TabFromPoint.Text = "Window From Point"
        Me.TabFromPoint.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.usrlbl)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.GoToProcessbtn)
        Me.GroupBox2.Controls.Add(Me.HighLightBtnTab1)
        Me.GroupBox2.Controls.Add(Me.RdOnlyText)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.classtxt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TimerCtrlBtn)
        Me.GroupBox2.Controls.Add(Me.proctxt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.winh)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ytext)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.xtext)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 21)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(959, 224)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data "
        '
        'usrlbl
        '
        Me.usrlbl.AutoSize = True
        Me.usrlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrlbl.Location = New System.Drawing.Point(432, 73)
        Me.usrlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.usrlbl.Name = "usrlbl"
        Me.usrlbl.Size = New System.Drawing.Size(0, 17)
        Me.usrlbl.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(325, 73)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Username:"
        '
        'GoToProcessbtn
        '
        Me.GoToProcessbtn.Location = New System.Drawing.Point(795, 102)
        Me.GoToProcessbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.GoToProcessbtn.Name = "GoToProcessbtn"
        Me.GoToProcessbtn.Size = New System.Drawing.Size(135, 28)
        Me.GoToProcessbtn.TabIndex = 3
        Me.GoToProcessbtn.Text = "&Child Windows"
        Me.GoToProcessbtn.UseVisualStyleBackColor = True
        '
        'HighLightBtnTab1
        '
        Me.HighLightBtnTab1.Location = New System.Drawing.Point(795, 140)
        Me.HighLightBtnTab1.Margin = New System.Windows.Forms.Padding(4)
        Me.HighLightBtnTab1.Name = "HighLightBtnTab1"
        Me.HighLightBtnTab1.Size = New System.Drawing.Size(135, 28)
        Me.HighLightBtnTab1.TabIndex = 1
        Me.HighLightBtnTab1.Text = "&Flash Window"
        Me.HighLightBtnTab1.UseVisualStyleBackColor = True
        '
        'RdOnlyText
        '
        Me.RdOnlyText.Location = New System.Drawing.Point(145, 178)
        Me.RdOnlyText.Margin = New System.Windows.Forms.Padding(4)
        Me.RdOnlyText.Multiline = True
        Me.RdOnlyText.Name = "RdOnlyText"
        Me.RdOnlyText.ReadOnly = True
        Me.RdOnlyText.Size = New System.Drawing.Size(621, 25)
        Me.RdOnlyText.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 182)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Window Text: "
        '
        'classtxt
        '
        Me.classtxt.Location = New System.Drawing.Point(145, 139)
        Me.classtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.classtxt.Name = "classtxt"
        Me.classtxt.ReadOnly = True
        Me.classtxt.Size = New System.Drawing.Size(621, 22)
        Me.classtxt.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 143)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Class Name:"
        '
        'TimerCtrlBtn
        '
        Me.TimerCtrlBtn.Location = New System.Drawing.Point(795, 176)
        Me.TimerCtrlBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.TimerCtrlBtn.Name = "TimerCtrlBtn"
        Me.TimerCtrlBtn.Size = New System.Drawing.Size(135, 28)
        Me.TimerCtrlBtn.TabIndex = 0
        Me.TimerCtrlBtn.Text = "Start &Scan"
        Me.TimerCtrlBtn.UseVisualStyleBackColor = True
        '
        'proctxt
        '
        Me.proctxt.Location = New System.Drawing.Point(145, 105)
        Me.proctxt.Margin = New System.Windows.Forms.Padding(4)
        Me.proctxt.Name = "proctxt"
        Me.proctxt.ReadOnly = True
        Me.proctxt.Size = New System.Drawing.Size(621, 22)
        Me.proctxt.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 108)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Process:"
        '
        'winh
        '
        Me.winh.Location = New System.Drawing.Point(145, 69)
        Me.winh.Margin = New System.Windows.Forms.Padding(4)
        Me.winh.Name = "winh"
        Me.winh.ReadOnly = True
        Me.winh.Size = New System.Drawing.Size(137, 22)
        Me.winh.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Handle:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(325, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Y Cordinate:"
        '
        'ytext
        '
        Me.ytext.Location = New System.Drawing.Point(436, 33)
        Me.ytext.Margin = New System.Windows.Forms.Padding(4)
        Me.ytext.Name = "ytext"
        Me.ytext.ReadOnly = True
        Me.ytext.Size = New System.Drawing.Size(137, 22)
        Me.ytext.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "X Cordinate:"
        '
        'xtext
        '
        Me.xtext.Location = New System.Drawing.Point(145, 33)
        Me.xtext.Margin = New System.Windows.Forms.Padding(4)
        Me.xtext.Name = "xtext"
        Me.xtext.ReadOnly = True
        Me.xtext.Size = New System.Drawing.Size(137, 22)
        Me.xtext.TabIndex = 15
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.folderpathtxt)
        Me.GB1.Controls.Add(Me.folderlbl)
        Me.GB1.Controls.Add(Me.wintextbox)
        Me.GB1.Controls.Add(Me.SetTxtBtn)
        Me.GB1.Controls.Add(Me.Label4)
        Me.GB1.Controls.Add(Me.SetPropBtn)
        Me.GB1.Controls.Add(Me.Label5)
        Me.GB1.Controls.Add(Me.windowoptions)
        Me.GB1.Location = New System.Drawing.Point(21, 252)
        Me.GB1.Margin = New System.Windows.Forms.Padding(4)
        Me.GB1.Name = "GB1"
        Me.GB1.Padding = New System.Windows.Forms.Padding(4)
        Me.GB1.Size = New System.Drawing.Size(959, 110)
        Me.GB1.TabIndex = 3
        Me.GB1.TabStop = False
        Me.GB1.Text = "Manipulate Windows Controls "
        '
        'folderpathtxt
        '
        Me.folderpathtxt.Location = New System.Drawing.Point(145, 105)
        Me.folderpathtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.folderpathtxt.Name = "folderpathtxt"
        Me.folderpathtxt.Size = New System.Drawing.Size(621, 22)
        Me.folderpathtxt.TabIndex = 13
        Me.folderpathtxt.Text = "C:\Windows\*.*"
        Me.folderpathtxt.Visible = False
        '
        'folderlbl
        '
        Me.folderlbl.AutoSize = True
        Me.folderlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderlbl.Location = New System.Drawing.Point(24, 108)
        Me.folderlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.folderlbl.Name = "folderlbl"
        Me.folderlbl.Size = New System.Drawing.Size(97, 17)
        Me.folderlbl.TabIndex = 12
        Me.folderlbl.Text = "Folder Path:"
        Me.folderlbl.Visible = False
        '
        'wintextbox
        '
        Me.wintextbox.Location = New System.Drawing.Point(145, 23)
        Me.wintextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.wintextbox.Name = "wintextbox"
        Me.wintextbox.Size = New System.Drawing.Size(621, 22)
        Me.wintextbox.TabIndex = 8
        '
        'SetTxtBtn
        '
        Me.SetTxtBtn.Location = New System.Drawing.Point(795, 20)
        Me.SetTxtBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SetTxtBtn.Name = "SetTxtBtn"
        Me.SetTxtBtn.Size = New System.Drawing.Size(135, 28)
        Me.SetTxtBtn.TabIndex = 5
        Me.SetTxtBtn.Text = "Set &Text"
        Me.SetTxtBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "New Text:"
        '
        'SetPropBtn
        '
        Me.SetPropBtn.Location = New System.Drawing.Point(795, 59)
        Me.SetPropBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SetPropBtn.Name = "SetPropBtn"
        Me.SetPropBtn.Size = New System.Drawing.Size(135, 28)
        Me.SetPropBtn.TabIndex = 4
        Me.SetPropBtn.Text = "Set &Property"
        Me.SetPropBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 66)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Alter Property:"
        '
        'windowoptions
        '
        Me.windowoptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.windowoptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.windowoptions.FormattingEnabled = True
        Me.windowoptions.Items.AddRange(New Object() {"Show Window", "Hide Window", "Maximize Window", "Minimize Window", "Restore Window", "Enable", "Disable", "Make Editable", "Make ReadOnly", "Activate/Click", "Show Password", "List Files & Folders (For List Boxes)", "Add Scrolling (For List Boxes)"})
        Me.windowoptions.Location = New System.Drawing.Point(145, 62)
        Me.windowoptions.Margin = New System.Windows.Forms.Padding(4)
        Me.windowoptions.Name = "windowoptions"
        Me.windowoptions.Size = New System.Drawing.Size(621, 24)
        Me.windowoptions.TabIndex = 10
        '
        'TabFromWindow
        '
        Me.TabFromWindow.Controls.Add(Me.GroupBox4)
        Me.TabFromWindow.Controls.Add(Me.GroupBox3)
        Me.TabFromWindow.Controls.Add(Me.GroupBox1)
        Me.TabFromWindow.Location = New System.Drawing.Point(4, 25)
        Me.TabFromWindow.Margin = New System.Windows.Forms.Padding(4)
        Me.TabFromWindow.Name = "TabFromWindow"
        Me.TabFromWindow.Padding = New System.Windows.Forms.Padding(4)
        Me.TabFromWindow.Size = New System.Drawing.Size(1139, 660)
        Me.TabFromWindow.TabIndex = 1
        Me.TabFromWindow.Text = "Window From Process"
        Me.TabFromWindow.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.folderpathtxt2)
        Me.GroupBox4.Controls.Add(Me.folderlbl2)
        Me.GroupBox4.Controls.Add(Me.childtxt)
        Me.GroupBox4.Controls.Add(Me.setchildtxtbtn)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.setchildpropbtn)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.childpropcbox)
        Me.GroupBox4.Location = New System.Drawing.Point(371, 502)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(601, 102)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Manipulate Windows Controls "
        '
        'folderpathtxt2
        '
        Me.folderpathtxt2.Location = New System.Drawing.Point(145, 106)
        Me.folderpathtxt2.Margin = New System.Windows.Forms.Padding(4)
        Me.folderpathtxt2.Name = "folderpathtxt2"
        Me.folderpathtxt2.Size = New System.Drawing.Size(325, 22)
        Me.folderpathtxt2.TabIndex = 16
        Me.folderpathtxt2.Text = "C:\Windows\*.*"
        Me.folderpathtxt2.Visible = False
        '
        'folderlbl2
        '
        Me.folderlbl2.AutoSize = True
        Me.folderlbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderlbl2.Location = New System.Drawing.Point(24, 110)
        Me.folderlbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.folderlbl2.Name = "folderlbl2"
        Me.folderlbl2.Size = New System.Drawing.Size(97, 17)
        Me.folderlbl2.TabIndex = 15
        Me.folderlbl2.Text = "Folder Path:"
        Me.folderlbl2.Visible = False
        '
        'childtxt
        '
        Me.childtxt.Location = New System.Drawing.Point(145, 23)
        Me.childtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.childtxt.Name = "childtxt"
        Me.childtxt.Size = New System.Drawing.Size(325, 22)
        Me.childtxt.TabIndex = 8
        '
        'setchildtxtbtn
        '
        Me.setchildtxtbtn.Location = New System.Drawing.Point(480, 21)
        Me.setchildtxtbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.setchildtxtbtn.Name = "setchildtxtbtn"
        Me.setchildtxtbtn.Size = New System.Drawing.Size(113, 28)
        Me.setchildtxtbtn.TabIndex = 0
        Me.setchildtxtbtn.Text = "Set &Text"
        Me.setchildtxtbtn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "New Text:"
        '
        'setchildpropbtn
        '
        Me.setchildpropbtn.Location = New System.Drawing.Point(480, 60)
        Me.setchildpropbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.setchildpropbtn.Name = "setchildpropbtn"
        Me.setchildpropbtn.Size = New System.Drawing.Size(113, 28)
        Me.setchildpropbtn.TabIndex = 11
        Me.setchildpropbtn.Text = "Set &Property"
        Me.setchildpropbtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 66)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Alter Property:"
        '
        'childpropcbox
        '
        Me.childpropcbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.childpropcbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.childpropcbox.FormattingEnabled = True
        Me.childpropcbox.Items.AddRange(New Object() {"Show Window", "Hide Window", "Maximize Window", "Minimize Window", "Restore Window", "Enable", "Disable", "Make Editable", "Make ReadOnly", "Activate/Click", "Show Password", "List Files & Folders (For List Boxes)", "Add Scrolling (For List Boxes)"})
        Me.childpropcbox.Location = New System.Drawing.Point(145, 63)
        Me.childpropcbox.Margin = New System.Windows.Forms.Padding(4)
        Me.childpropcbox.Name = "childpropcbox"
        Me.childpropcbox.Size = New System.Drawing.Size(325, 24)
        Me.childpropcbox.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.usrlbl2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.HighLightBtn)
        Me.GroupBox3.Controls.Add(Me.RefreshChildBtn)
        Me.GroupBox3.Controls.Add(Me.childwindowlistvw)
        Me.GroupBox3.Location = New System.Drawing.Point(371, 21)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(601, 462)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Enumerated Child windows "
        '
        'usrlbl2
        '
        Me.usrlbl2.AutoSize = True
        Me.usrlbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrlbl2.Location = New System.Drawing.Point(100, 389)
        Me.usrlbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.usrlbl2.Name = "usrlbl2"
        Me.usrlbl2.Size = New System.Drawing.Size(0, 17)
        Me.usrlbl2.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 389)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 17)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Username:"
        '
        'HighLightBtn
        '
        Me.HighLightBtn.Location = New System.Drawing.Point(8, 418)
        Me.HighLightBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.HighLightBtn.Name = "HighLightBtn"
        Me.HighLightBtn.Size = New System.Drawing.Size(133, 28)
        Me.HighLightBtn.TabIndex = 3
        Me.HighLightBtn.Text = "&Highlight Window"
        Me.HighLightBtn.UseVisualStyleBackColor = True
        '
        'RefreshChildBtn
        '
        Me.RefreshChildBtn.Location = New System.Drawing.Point(459, 418)
        Me.RefreshChildBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RefreshChildBtn.Name = "RefreshChildBtn"
        Me.RefreshChildBtn.Size = New System.Drawing.Size(135, 28)
        Me.RefreshChildBtn.TabIndex = 2
        Me.RefreshChildBtn.Text = "&Refresh"
        Me.RefreshChildBtn.UseVisualStyleBackColor = True
        '
        'childwindowlistvw
        '
        Me.childwindowlistvw.FormattingEnabled = True
        Me.childwindowlistvw.HorizontalScrollbar = True
        Me.childwindowlistvw.ItemHeight = 16
        Me.childwindowlistvw.Location = New System.Drawing.Point(8, 23)
        Me.childwindowlistvw.Margin = New System.Windows.Forms.Padding(4)
        Me.childwindowlistvw.Name = "childwindowlistvw"
        Me.childwindowlistvw.Size = New System.Drawing.Size(584, 340)
        Me.childwindowlistvw.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.proccountlbl)
        Me.GroupBox1.Controls.Add(Me.OnlySystemChkBox)
        Me.GroupBox1.Controls.Add(Me.KillProcBtn)
        Me.GroupBox1.Controls.Add(Me.RefreshProcBtn)
        Me.GroupBox1.Controls.Add(Me.proclistvw)
        Me.GroupBox1.Controls.Add(Me.proclistsystemvw)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(329, 583)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Process List "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 487)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Process count: "
        '
        'proccountlbl
        '
        Me.proccountlbl.AutoSize = True
        Me.proccountlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proccountlbl.Location = New System.Drawing.Point(131, 487)
        Me.proccountlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.proccountlbl.Name = "proccountlbl"
        Me.proccountlbl.Size = New System.Drawing.Size(39, 17)
        Me.proccountlbl.TabIndex = 10
        Me.proccountlbl.Text = "NaN"
        '
        'OnlySystemChkBox
        '
        Me.OnlySystemChkBox.AutoSize = True
        Me.OnlySystemChkBox.Location = New System.Drawing.Point(8, 513)
        Me.OnlySystemChkBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OnlySystemChkBox.Name = "OnlySystemChkBox"
        Me.OnlySystemChkBox.Size = New System.Drawing.Size(266, 21)
        Me.OnlySystemChkBox.TabIndex = 3
        Me.OnlySystemChkBox.Text = "&Show NT Authority\System processes"
        Me.OnlySystemChkBox.UseVisualStyleBackColor = True
        '
        'KillProcBtn
        '
        Me.KillProcBtn.Location = New System.Drawing.Point(8, 542)
        Me.KillProcBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.KillProcBtn.Name = "KillProcBtn"
        Me.KillProcBtn.Size = New System.Drawing.Size(113, 28)
        Me.KillProcBtn.TabIndex = 2
        Me.KillProcBtn.Text = "&Kill Process"
        Me.KillProcBtn.UseVisualStyleBackColor = True
        '
        'RefreshProcBtn
        '
        Me.RefreshProcBtn.Location = New System.Drawing.Point(205, 542)
        Me.RefreshProcBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RefreshProcBtn.Name = "RefreshProcBtn"
        Me.RefreshProcBtn.Size = New System.Drawing.Size(113, 28)
        Me.RefreshProcBtn.TabIndex = 1
        Me.RefreshProcBtn.Text = "&Refresh"
        Me.RefreshProcBtn.UseVisualStyleBackColor = True
        '
        'proclistvw
        '
        Me.proclistvw.FormattingEnabled = True
        Me.proclistvw.HorizontalScrollbar = True
        Me.proclistvw.ItemHeight = 16
        Me.proclistvw.Location = New System.Drawing.Point(8, 23)
        Me.proclistvw.Margin = New System.Windows.Forms.Padding(4)
        Me.proclistvw.Name = "proclistvw"
        Me.proclistvw.Size = New System.Drawing.Size(309, 452)
        Me.proclistvw.TabIndex = 0
        '
        'proclistsystemvw
        '
        Me.proclistsystemvw.FormattingEnabled = True
        Me.proclistsystemvw.ItemHeight = 16
        Me.proclistsystemvw.Location = New System.Drawing.Point(8, 23)
        Me.proclistsystemvw.Margin = New System.Windows.Forms.Padding(4)
        Me.proclistsystemvw.Name = "proclistsystemvw"
        Me.proclistsystemvw.Size = New System.Drawing.Size(309, 452)
        Me.proclistsystemvw.TabIndex = 4
        Me.proclistsystemvw.Visible = False
        '
        'OpenBinaryDlg
        '
        Me.OpenBinaryDlg.FileName = "*.exe"
        Me.OpenBinaryDlg.Filter = "Executable files | *.exe | All files | *.*"
        '
        'Mainfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 710)
        Me.Controls.Add(Me.TabParent)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Mainfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WinManipulate"
        Me.TabParent.ResumeLayout(False)
        Me.TabFromPoint.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.TabFromWindow.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents freqtimer As System.Windows.Forms.Timer
    Friend WithEvents TabParent As System.Windows.Forms.TabControl
    Friend WithEvents TabFromPoint As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents classtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TimerCtrlBtn As System.Windows.Forms.Button
    Friend WithEvents proctxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents winh As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ytext As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents xtext As System.Windows.Forms.TextBox
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents wintextbox As System.Windows.Forms.TextBox
    Friend WithEvents SetTxtBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SetPropBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents windowoptions As System.Windows.Forms.ComboBox
    Friend WithEvents TabFromWindow As System.Windows.Forms.TabPage
    Friend WithEvents RdOnlyText As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents childtxt As System.Windows.Forms.TextBox
    Friend WithEvents setchildtxtbtn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents setchildpropbtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents childpropcbox As System.Windows.Forms.ComboBox
    Friend WithEvents proclistvw As System.Windows.Forms.ListBox
    Friend WithEvents childwindowlistvw As System.Windows.Forms.ListBox
    Friend WithEvents RefreshProcBtn As System.Windows.Forms.Button
    Friend WithEvents KillProcBtn As System.Windows.Forms.Button
    Friend WithEvents RefreshChildBtn As System.Windows.Forms.Button
    Friend WithEvents HighLightBtn As System.Windows.Forms.Button
    Friend WithEvents HighLightBtnTab1 As System.Windows.Forms.Button
    Friend WithEvents GoToProcessbtn As System.Windows.Forms.Button
    Friend WithEvents OpenBinaryDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents usrlbl As System.Windows.Forms.Label
    Friend WithEvents usrlbl2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents OnlySystemChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents proclistsystemvw As System.Windows.Forms.ListBox
    Friend WithEvents folderpathtxt As System.Windows.Forms.TextBox
    Friend WithEvents folderlbl As System.Windows.Forms.Label
    Friend WithEvents folderpathtxt2 As System.Windows.Forms.TextBox
    Friend WithEvents folderlbl2 As System.Windows.Forms.Label
    Friend WithEvents proccountlbl As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
