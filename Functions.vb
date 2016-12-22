Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Management


Module Functions
    <DllImport("user32.dll")> _
    Public Function SetWindowText(hWnd As IntPtr, lpString As String) As Boolean
    End Function

    <DllImport("user32.dll", ExactSpelling:=True, CharSet:=CharSet.Auto)> _
    Public Function GetParent(ByVal hWnd As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")> _
    Public Function WindowFromPoint(ByVal p As Point) As IntPtr
    End Function

    <DllImport("user32.dll")> _
    Public Function ChildWindowFromPointEx(ByVal hWndParent As IntPtr, ByVal P As Point, ByVal uFlags As UInt32) As IntPtr
    End Function

    <DllImport("user32.dll", EntryPoint:="GetWindowText")> _
    Public Function GetWindowText(ByVal hwnd As Integer, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Function ShowWindow(ByVal hwnd As IntPtr, ByVal nCmdShow As ShowWindowCommands) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Function GetClassName(ByVal hWnd As System.IntPtr, ByVal lpClassName As System.Text.StringBuilder, ByVal nMaxCount As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)> _
    Public Function GetWindowThreadProcessId(ByVal hwnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> <PreserveSig()> _
    Public Function GetModuleFileName(<[In]()> ByVal hModule As IntPtr, <Out()> ByVal lpFilename As System.Text.StringBuilder, <[In]()> <MarshalAs(UnmanagedType.U4)> ByVal nSize As Integer) As UInteger
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Public Function SendMessageA(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As String) As IntPtr
        Dim h As IntPtr = Marshal.StringToHGlobalUni(lParam)
        SendMessageA = SendMessage(hWnd, msg, wParam, h)
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Function PostMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")> _
    Public Function EnableWindow(ByVal hWnd As IntPtr, ByVal bEnable As Boolean) As Boolean
    End Function

    <DllImport("user32.dll", EntryPoint:="GetWindowLong")> _
    Public Function GetWindowLong(ByVal hWnd As IntPtr, <MarshalAs(UnmanagedType.I4)> nIndex As WindowLongFlags) As Long
    End Function

    <DllImport("user32.dll")> _
    Public Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As WindowLongFlags, ByVal dwNewLong As Long) As Long
    End Function

    <DllImport("user32.dll")>
    Public Function UpdateWindow(ByVal hWnd As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll")> _
    Public Function GetWindowRect(ByVal hWnd As IntPtr, ByRef lpRect As Rect) As Boolean
    End Function

    <DllImport("user32.dll")> _
    Public Function InvalidateRect(ByVal hWnd As IntPtr, ByRef lpRect As IntPtr, bErase As Integer) As Boolean
    End Function

    <DllImport("user32.dll")> _
    Private Function RedrawWindow(hWnd As IntPtr, lprcUpdate As IntPtr, hrgnUpdate As IntPtr, flags As RedrawWindowFlags) As Boolean
    End Function

    <DllImport("user32.dll")> _
    Public Function GetWindowDC(ByVal hWnd As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")> _
    Public Function ReleaseDC(ByVal hWnd As IntPtr, hdc As IntPtr) As Boolean
    End Function

    <DllImport("kernel32.dll")> _
    Public Function OpenProcess(processAccess As Long, bInheritHandle As Boolean, processId As Integer) As IntPtr
    End Function

    Delegate Function EnumThreadDelegate(hWnd As IntPtr, lParam As IntPtr) As Boolean

    <DllImport("user32.dll")> _
    Public Function EnumThreadWindows(dwThreadId As UInteger, lpfn As EnumThreadDelegate, lParam As IntPtr) As Boolean
    End Function

    Public Function EnumThreadWndProc(ByVal hwnd As Long, ByVal lParam As Long) As Long
        'Static winnum As Integer
        ' winnum = winnum + 1
        Mainfrm.childwindowlistvw.Items.Add(hwnd.ToString)
        EnumChildWindows(hwnd, AddressOf EnumChildWindowsProc, IntPtr.Zero)
        EnumThreadWndProc = 0
    End Function


    Delegate Function EnumChildWindowsDelegate(hWnd As IntPtr, lParam As IntPtr) As Boolean

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Function EnumChildWindows(ByVal hWndParent As System.IntPtr, ByVal lpEnumFunc As EnumChildWindowsDelegate, ByVal lParam As Integer) As Boolean
    End Function

    Public Function EnumChildWindowsProc(ByVal hwnd As Long, ByVal lParam As Long) As Long
        Mainfrm.childwindowlistvw.Items.Add(hwnd.ToString & " - " & GetTextFromHandle(hwnd) & " [ " & GetClassNameFromHandle(hwnd) & "]")
        Return 1
    End Function

    Delegate Function EnumWindowsProcDelegate(hWnd As IntPtr, lParam As IntPtr) As Boolean

    <DllImport("user32.dll", CharSet:=CharSet.Unicode, ExactSpelling:=True, SetLastError:=True)> _
    Public Function EnumWindows(ByVal lpEnumFunc As EnumWindowsProcDelegate, ByVal lParam As IntPtr) As Long
    End Function

    Public Function EnumWindowsProc(ByVal hWnd As IntPtr, ByVal lParam As IntPtr) As Long
        Dim pid, opid As Integer
        GetWindowThreadProcessId(hWnd, pid)
        If Mainfrm.proclistvw.Visible = True Then
            opid = CInt(Mainfrm.proclistvw.SelectedItem.ToString.Split("[")(1).Split("]")(0))
        ElseIf Mainfrm.proclistsystemvw.Visible = True Then
            opid = CInt(Mainfrm.proclistsystemvw.SelectedItem.ToString.Split("[")(1).Split("]")(0))
        End If
        If pid = opid Then
            Mainfrm.childwindowlistvw.Items.Add(hWnd.ToString & " - " & GetTextFromHandle(hWnd) & " [ " & GetClassNameFromHandle(hWnd) & "]")
            EnumChildWindows(hWnd, AddressOf EnumChildWindowsProc, IntPtr.Zero)
        End If
        Return 1
    End Function

    Public GlobalPid As Long = 0
    Public ProcBtnClicked As Integer = 0
    Public GotoBinaryBtnClicked As Integer = 0

    Public PROCESS_ALL_ACCESS As Long = &HFFF

    Enum WindowLongFlags As Integer
        GWL_EXSTYLE = -20
        GWLP_HINSTANCE = -6
        GWLP_HWNDPARENT = -8
        GWL_ID = -12
        GWL_STYLE = -16
        GWL_USERDATA = -21
        GWL_WNDPROC = -4
        DWLP_USER = &H8
        DWLP_MSGRESULT = &H0
        DWLP_DLGPROC = &H4
    End Enum

    Enum ShowWindowCommands As Integer
        Hide = 0
        Normal = 1
        ShowMinimized = 2
        Maximize = 3
        ShowMaximized = 3
        ShowNoActivate = 4
        Show = 5
        Minimize = 6
        ShowMinNoActive = 7
        ShowNA = 8
        Restore = 9
        ShowDefault = 10
        ForceMinimize = 11
    End Enum

    Enum WindowMessages
        WM_SETTEXT = &HC
        WM_GETTEXT = &HD
        WM_GETTEXTLENGTH = &HE
        WM_ENABLED = &H8
        WM_ENABLE = &HA
        WM_COMMAND = &H111
        EM_SETREADONLY = &HCF
        EM_SETPASSWORDCHAR = &HCC
        LB_DIR = &H18D
        LB_SETHORIZONTALEXTENT = &H400 + 21
        LB_SETVERTICALEXTENT = &H200
    End Enum

    Enum WindowStyles
        WS_DISABLED = &H8000000
    End Enum

    Public Structure Rect
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer

        Public ReadOnly Property Width() As Integer
            Get
                Return right - left
            End Get
        End Property

        Public ReadOnly Property Height() As Integer
            Get
                Return bottom - top
            End Get
        End Property
    End Structure

    Private Enum RedrawWindowFlags As UInteger
        Invalidate = &H1
        InternalPaint = &H2
        [Erase] = &H4
        Validate = &H8
        NoInternalPaint = &H10
        NoErase = &H20
        NoChildren = &H40
        AllChildren = &H80
        UpdateNow = &H100
        EraseNow = &H200
        Frame = &H400
        NoFrame = &H800
    End Enum

    Function SendMessageHandler(opt As Integer, hwnd As IntPtr)
        If opt = 0 Then
            ShowWindow(hwnd, ShowWindowCommands.Show)
        ElseIf opt = 1 Then
            ShowWindow(hwnd, ShowWindowCommands.Hide)
        ElseIf opt = 2 Then
            ShowWindow(hwnd, ShowWindowCommands.Maximize)
        ElseIf opt = 3 Then
            ShowWindow(hwnd, ShowWindowCommands.Minimize)
        ElseIf opt = 4 Then
            ShowWindow(hwnd, ShowWindowCommands.Restore)
        ElseIf opt = 5 Then
            EnableWindow(hwnd, True)
        ElseIf opt = 6 Then
            EnableWindow(hwnd, False)
        ElseIf opt = 7 Then
            SendMessage(hwnd, WindowMessages.EM_SETREADONLY, 0, 0)
        ElseIf opt = 8 Then
            SendMessage(hwnd, WindowMessages.EM_SETREADONLY, 1, 0)
        ElseIf opt = 9 Then
            ActivateControl(hwnd)
        ElseIf opt = 10 Then
            SendMessage(hwnd, WindowMessages.EM_SETPASSWORDCHAR, 0, 0)
            ShowWindow(hwnd, ShowWindowCommands.Hide)
            ShowWindow(hwnd, ShowWindowCommands.Show)
            UpdateWindow(hwnd)
        ElseIf opt = 11 Then 'Populate list boxes with directory content. Find Window running as system.
            SendMessageA(hwnd, WindowMessages.LB_DIR, 0, Mainfrm.folderpathtxt.Text)
            UpdateWindow(hwnd)
        ElseIf opt = 12 Then 'Add scrolling
            SendMessageA(hwnd, WindowMessages.LB_SETVERTICALEXTENT, 2000, 0)
            UpdateWindow(hwnd)
        End If

        Return 0
    End Function

    

    Public Sub HighlightWindows(hWnd As IntPtr)
        Dim rc As New Rect()
        GetWindowRect(hWnd, rc)

        Dim hDC As IntPtr = GetWindowDC(hWnd)
        If hDC <> IntPtr.Zero Then
            Using pen As New Pen(Color.Black, 3)
                Using g As Graphics = Graphics.FromHdc(hDC)
                    g.DrawRectangle(pen, 0, 0, rc.right - rc.left - 3, rc.bottom - rc.top - 3)
                End Using
            End Using
        End If
        ReleaseDC(hWnd, hDC)
    End Sub

    Public Sub RefreshWindow(hWnd As IntPtr)
        InvalidateRect(hWnd, IntPtr.Zero, 1)
        UpdateWindow(hWnd)
        RedrawWindow(hWnd, IntPtr.Zero, IntPtr.Zero, RedrawWindowFlags.Frame Or RedrawWindowFlags.Invalidate Or RedrawWindowFlags.UpdateNow Or RedrawWindowFlags.AllChildren)
    End Sub

    Public Function GetTextFromHandle(hwnd As IntPtr) As String
        Dim h As IntPtr = Marshal.AllocHGlobal(512)
        Dim st As String = ""
        Dim num As Integer = SendMessage(hwnd, WindowMessages.WM_GETTEXT, 1024, h)
        st = Marshal.PtrToStringUni(h)
        'Marshal.FreeHGlobal(h) 'Causes unexplainable crashes
        Return st
    End Function

    Public Function SetTextToHandle(hwnd As IntPtr, st As String) As Long
        Dim s As IntPtr = Marshal.StringToHGlobalUni(st)
        SendMessage(hwnd, WindowMessages.WM_SETTEXT, 0, s)
        ShowWindow(hwnd, ShowWindowCommands.Hide)
        ShowWindow(hwnd, ShowWindowCommands.Show)
        UpdateWindow(hwnd)
        Return 0
    End Function

    Public Function GetClassNameFromHandle(hwnd As IntPtr) As String
        Dim classtext As New System.Text.StringBuilder(256)
        GetClassName(hwnd, classtext, classtext.Capacity)
        Return classtext.ToString
    End Function


    Public Function FlashWindow(hwnd As Long) As Long
        For i As Integer = 0 To 5
            HighlightWindows(hwnd)
            Threading.Thread.Sleep(50)
            RefreshWindow(hwnd)
            Threading.Thread.Sleep(50)
        Next
        Return 0
    End Function

    Public Function ActivateControl(hwnd As Long) As Long
        EnableWindow(hwnd, True)
        SendMessage(hwnd, WindowMessages.WM_ENABLE, 1, 0)

        Dim phwnd As IntPtr = GetParent(hwnd)
        If phwnd.ToInt64 > 0 Then
            PostMessage(phwnd, WindowMessages.WM_COMMAND, WindowMessages.WM_ENABLE, hwnd)
            PostMessage(hwnd, WindowMessages.WM_COMMAND, WindowMessages.WM_ENABLE, IntPtr.Zero)
        End If

        Return 0
    End Function

End Module
