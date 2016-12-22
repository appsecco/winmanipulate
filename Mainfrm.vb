Imports System.Runtime.InteropServices
Imports System.ComponentModel


Public Class Mainfrm

    Dim hWnd As IntPtr
    'Dim wintext As New System.Text.StringBuilder(256)
    Dim proctext As New System.Text.StringBuilder(256)

    Private Sub freqtimer_Tick(sender As Object, e As EventArgs) Handles freqtimer.Tick
        Dim pid As IntPtr
        Dim px As Point = MousePosition()
        xtext.Text = px.X.ToString
        ytext.Text = px.Y.ToString
        Dim i As IntPtr = WindowFromPoint(px)
        HighlightWindows(i)

        winh.Text = i.ToString

        classtxt.Text = GetClassNameFromHandle(i)

        wintextbox.Text = GetTextFromHandle(i)
        RdOnlyText.Text = wintextbox.Text

        GetWindowThreadProcessId(i, pid)

        'GetModuleFileName(pid, proctext, proctext.Capacity)
        GlobalPid = pid.ToInt64.ToString
        proctxt.Text = Process.GetProcessById(pid).ProcessName + " [" + pid.ToString + "]"

        'Think of an alternative. This is important.
        usrlbl.Text = GetUsernameFromProcess(pid)

        RefreshWindow(i)

    End Sub

    Private Sub SetTxtBtn_Click(sender As Object, e As EventArgs) Handles SetTxtBtn.Click
        SetTextToHandle(CInt(winh.Text), wintextbox.Text)
        'SetWindowText(CInt(winh.Text), wintextbox.Text)
    End Sub

    Private Sub TimerCtrlBtn_Click(sender As Object, e As EventArgs) Handles TimerCtrlBtn.Click
        If TimerCtrlBtn.Text = "Stop &Scan" Then
            TimerCtrlBtn.Text = "Start &Scan"
            freqtimer.Enabled = False
            'GB1.Enabled = False
        Else
            TimerCtrlBtn.Text = "Stop &Scan"
            freqtimer.Enabled = True
            'GB1.Enabled = True
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator)) = False Then
            If MsgBox("Please run this application as Administrator to use all it's features. Do you want to restart with elevated privileges?" & vbCrLf & vbCrLf & "Clicking 'No' will start the application with limited rights.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Need privileges") = vbYes Then
                Dim proc As New ProcessStartInfo
                proc.UseShellExecute = True
                proc.WorkingDirectory = Environment.CurrentDirectory
                proc.FileName = Application.ExecutablePath
                proc.Verb = "runas"

                Try
                    Process.Start(proc)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                    End
                    Return
                End Try
            End If
            ' MsgBox(My.User.IsAuthenticated)
        End If
        windowoptions.Text = windowoptions.Items(0)
        Me.Height = 400
        Me.Width = 800
        Me.Text = Me.Text + " - v" + Application.ProductVersion + " [" + My.User.Name.ToString + "]"
    End Sub

    Private Sub SetPropBtn_Click(sender As Object, e As EventArgs) Handles SetPropBtn.Click
        SendMessageHandler(windowoptions.SelectedIndex, CInt(winh.Text))
    End Sub

    Private Sub TabFromPoint_Enter(sender As Object, e As EventArgs) Handles TabFromPoint.Enter
        'freqtimer.Enabled = True
        TimerCtrlBtn.Text = "Start &Scan"
        Me.Height = 400
        Me.Width = 800
        TabParent.Height = 338
        TabParent.Width = 760
    End Sub

    Private Sub TabFromWindow_Enter(sender As Object, e As EventArgs) Handles TabFromWindow.Enter
        Me.Height = 600
        Me.Width = 800
        freqtimer.Enabled = False
        TimerCtrlBtn.Text = "Start &Scan"
        TabParent.Height = 540
        TabParent.Width = 760
        If childpropcbox.Items.Count > 0 Then
            childpropcbox.SelectedIndex = 0
        End If

        EnumProcesses()
    End Sub

    Private Sub EnumProcesses()
        'On Error Resume Next
        proclistvw.Items.Clear()
        proclistsystemvw.Items.Clear()
        Dim plist As Process() = Process.GetProcesses
        For i As Integer = 0 To (plist.Count - 1)
            proclistvw.Items.Add(plist(i).ProcessName.ToString & " [" & plist(i).Id.ToString & "]") '"] [" & GetUsernameFromProcess(plist(i).Id).ToString & "]")
            If GetUsernameFromProcess(plist(i).Id).ToLower = "nt authority\system" Then
                proclistsystemvw.Items.Add(plist(i).ProcessName.ToString & " [" & plist(i).Id.ToString & "]")
            End If
        Next
        proclistvw.Sorted = True
        proclistsystemvw.Sorted = True
        If ProcBtnClicked = 1 Then
            ProcBtnClicked = 0
            proclistvw.SelectedIndex = proclistvw.FindString(proctxt.Text)
        Else
            proclistvw.SelectedIndex = 0
        End If
        proccountlbl.Text = proclistvw.Items.Count.ToString
        'EnumChildWindowsFromList(CInt(proclistvw.Items(proclistvw.SelectedIndex).ToString.Split("[")(1).Split("]")(0)))

    End Sub

    Private Sub RefreshProcBtn_Click(sender As Object, e As EventArgs) Handles RefreshProcBtn.Click
        EnumProcesses()
    End Sub

    Private Sub KillProcBtn_Click(sender As Object, e As EventArgs) Handles KillProcBtn.Click
        Dim pid As Integer = CInt(proclistvw.SelectedItem.ToString.Split("[")(1).Split("]")(0))
        Dim p As Process = Process.GetProcessById(pid)

        Try
            p.Kill()
            p.WaitForExit()
            MsgBox("Process with PID: " & CStr(pid) & " killed.", MsgBoxStyle.Information, "Process Killed")
        Catch ex As Win32Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        EnumProcesses()

    End Sub

    Private Sub EnumChildWindowsFromList(pid As Integer)
        childwindowlistvw.Items.Clear()
        If isValidProcess(pid) = True Then
            Dim a = Process.GetProcessById(pid).Threads.Count
            EnumWindows(AddressOf EnumWindowsProc, IntPtr.Zero)
            childtxt.Text = ""
            If childwindowlistvw.Items.Count > 0 Then
                childwindowlistvw.SelectedIndex = 0
            End If
        Else
            MsgBox("Invalid process! Refreshing window...", MsgBoxStyle.Exclamation, "Error!")
            RefreshProcBtn.PerformClick()
        End If
    End Sub

    
    Private Sub HighLightBtnTab1_Click(sender As Object, e As EventArgs) Handles HighLightBtnTab1.Click
        FlashWindow(CInt(winh.Text))
    End Sub

    Private Sub GoToProcessbtn_Click(sender As Object, e As EventArgs) Handles GoToProcessbtn.Click
        TabParent.SelectedIndex = 1
        ProcBtnClicked = 1
        OnlySystemChkBox.Checked = False
        EnumProcesses()
    End Sub

    Private Sub proclistvw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles proclistvw.SelectedIndexChanged
        Dim spid As Integer = CInt(proclistvw.Items(proclistvw.SelectedIndex).ToString.Split("[")(1).Split("]")(0))
        If isValidProcess(spid) = True Then
            usrlbl2.Text = GetUsernameFromProcess(spid)
            EnumChildWindowsFromList(spid)
        Else
            MsgBox("Invalid process! Refreshing window...", MsgBoxStyle.Exclamation, "Error!")
            RefreshProcBtn.PerformClick()
        End If
    End Sub


    Private Sub HighLightBtn_Click(sender As Object, e As EventArgs) Handles HighLightBtn.Click
        If childwindowlistvw.SelectedIndex > -1 Then
            Dim hWnd As Long = CLng(childwindowlistvw.Items(childwindowlistvw.SelectedIndex).ToString.Split(" - ")(0))
            FlashWindow(hWnd)
        End If
    End Sub

    Private Sub childwindowlistvw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles childwindowlistvw.SelectedIndexChanged
        If childwindowlistvw.SelectedIndex > -1 Then
            Dim hWnd As Long = CLng(childwindowlistvw.Items(childwindowlistvw.SelectedIndex).ToString.Split(" - ")(0))
            FlashWindow(hWnd)
            childtxt.Text = GetTextFromHandle(hWnd)
        End If
    End Sub

    Private Sub RefreshChildBtn_Click(sender As Object, e As EventArgs) Handles RefreshChildBtn.Click
        If childwindowlistvw.SelectedIndex > -1 Then
            Dim spid As Integer = CInt(proclistvw.Items(proclistvw.SelectedIndex).ToString.Split("[")(1).Split("]")(0))
            EnumChildWindowsFromList(spid)
        End If
    End Sub

    Private Sub setchildtxtbtn_Click(sender As Object, e As EventArgs) Handles setchildtxtbtn.Click
        If childwindowlistvw.SelectedIndex > -1 Then
            Dim hWnd As Long = CLng(childwindowlistvw.Items(childwindowlistvw.SelectedIndex).ToString.Split(" - ")(0))
            SetTextToHandle(hWnd, childtxt.Text)
        End If
    End Sub

    Private Sub setchildpropbtn_Click(sender As Object, e As EventArgs) Handles setchildpropbtn.Click
        If childwindowlistvw.SelectedIndex > -1 Then
            Dim hWnd As Long = CLng(childwindowlistvw.Items(childwindowlistvw.SelectedIndex).ToString.Split(" - ")(0))
            SendMessageHandler(childpropcbox.SelectedIndex, hWnd)
        End If
    End Sub

    Private Sub BrowseFileBtn_Click(sender As Object, e As EventArgs)
        OpenBinaryDlg.FileName = "*.exe"
        OpenBinaryDlg.ShowDialog()
    End Sub


    Private Sub GotoProcessAnalysisSecondBtn_Click(sender As Object, e As EventArgs)
        GotoBinaryBtnClicked = 1
        GlobalPid = CInt(proclistvw.SelectedItem.ToString.Split("[")(1).Split("]")(0))
        TabParent.SelectedIndex = 2
    End Sub


    Private Sub OnlySystemChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles OnlySystemChkBox.CheckedChanged
        If OnlySystemChkBox.Checked = True Then
            proclistvw.Visible = False
            proclistsystemvw.Visible = True
            If proclistsystemvw.Items.Count > 0 Then
                proclistsystemvw.SelectedIndex = 0
            End If
            proccountlbl.Text = proclistsystemvw.Items.Count.ToString
            childwindowlistvw.Items.Clear()
        Else
            proclistvw.Visible = True
            proclistsystemvw.Visible = False
            proccountlbl.Text = proclistvw.Items.Count.ToString
        End If
    End Sub

    Private Sub proclistsystemvw_SelectedIndexChanged(sender As Object, e As EventArgs) Handles proclistsystemvw.SelectedIndexChanged
        Dim spid As Integer = CInt(proclistsystemvw.Items(proclistsystemvw.SelectedIndex).ToString.Split("[")(1).Split("]")(0))
        usrlbl2.Text = GetUsernameFromProcess(spid)
        EnumChildWindowsFromList(spid)
    End Sub

    Private Sub windowoptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles windowoptions.SelectedIndexChanged
        If windowoptions.SelectedIndex = 11 Then
            Me.Height = 420
            TabParent.Height = 360
            GB1.Height = 120
            folderlbl.Visible = True
            folderpathtxt.Visible = True
            folderpathtxt.Text = Environment.CurrentDirectory + "\*.*"
        Else
            Me.Height = 400
            TabParent.Height = 338
            GB1.Height = 89
            folderlbl.Visible = False
            folderpathtxt.Visible = False
        End If
    End Sub

    Private Sub childpropcbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles childpropcbox.SelectedIndexChanged
        If childpropcbox.SelectedIndex = 11 Then
            Me.Height = 615
            TabParent.Height = 560
            GroupBox1.Height = 511
            GroupBox4.Height = 120
            folderlbl2.Visible = True
            folderpathtxt2.Visible = True
            folderpathtxt2.Text = Environment.CurrentDirectory + "\*.*"
        Else
            Me.Height = 600
            Me.Width = 800
            GroupBox1.Height = 474
            GroupBox4.Height = 83
            TabParent.Height = 540
            TabParent.Width = 760
            'childpropcbox.SelectedIndex = 0
        End If
    End Sub

End Class

