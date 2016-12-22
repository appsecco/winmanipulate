Imports System.Runtime.InteropServices
Imports System.Security
Imports System.ComponentModel

Module ProcessFunctions
    <DllImport("kernel32.dll")> _
    Public Function OpenProcess(processAccess As ProcessAccessFlags, bInheritHandle As Boolean, processId As Integer) As Integer
    End Function

    <DllImport("advapi32.dll", SetLastError:=True)> _
    Public Function OpenProcessToken(ByVal ProcessHandle As IntPtr, ByVal DesiredAccess As Integer, ByRef TokenHandle As IntPtr) As Boolean
    End Function

    <DllImport("advapi32.dll", SetLastError:=True)> _
    Public Function GetTokenInformation(ByVal TokenHandle As IntPtr, ByVal TokenInformationClass As TOKEN_INFORMATION_CLASS, _
                                        ByVal TokenInformation As IntPtr, ByVal TokenInformationLength As System.UInt32, ByRef ReturnLength As System.UInt32) As Boolean
    End Function

    <DllImport("advapi32.dll", SetLastError:=True)> _
    Public Function ConvertSidToStringSid(ByVal psid As IntPtr, ByRef pStringSid As String) As Boolean
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Public Function GetExitCodeProcess(ByVal hProcess As IntPtr, ByRef lpExitCode As System.UInt32) As Boolean
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Public Function CreateToolhelp32Snapshot(ByVal dwFlags As SnapshotFlags, ByVal th32ProcessID As UInteger) As IntPtr
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Public Function Module32First(ByVal hSnapShot As Long, ByVal lpMe32 As MODULEENTRY32) As Long
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Public Function Module32Next(ByVal hSnapShot As Long, ByVal lpMe32 As MODULEENTRY32) As Long
    End Function

    Public Structure SID_AND_ATTRIBUTES
        Public Sid As IntPtr
        Public Attributes As Int32
    End Structure

    Public Structure TOKEN_USER
        Public User As SID_AND_ATTRIBUTES
    End Structure

    Enum ProcessAccessFlags
        All = &H1F0FFF
        Terminate = &H1
        CreateThread = &H2
        VirtualMemoryOperation = &H8
        VirtualMemoryRead = &H10
        VirtualMemoryWrite = &H20
        DuplicateHandle = &H40
        CreateProcess = &H80
        SetQuota = &H100
        SetInformation = &H200
        QueryInformation = &H400
        QueryLimitedInformation = &H1000
        Synchronize = &H100000
    End Enum

    Enum TOKEN_INFORMATION_CLASS
        TokenUser = 1
        TokenGroups
        TokenPrivileges
        TokenOwner
        TokenPrimaryGroup
        TokenDefaultDacl
        TokenSource
        TokenType
        TokenImpersonationLevel
        TokenStatistics
        TokenRestrictedSids
        TokenSessionId
        TokenGroupsAndPrivileges
        TokenSessionReference
        TokenSandBoxInert
        TokenAuditPolicy
        TokenOrigin
    End Enum

    Enum SnapshotFlags
        HeapList = &H1
        Process = &H2
        Thread = &H4
        M = &H8
        M32 = &H10
        Inherit = &H80000000
        All = &H1F
        NoHeaps = &H40000000
    End Enum

    Structure MODULEENTRY32
        Dim U32Size As UInteger
        Dim Th32ModuleId As UInteger
        Dim Th32ProcessId As UInteger
        Dim GlblcntUsage As UInteger
        Dim ProccntUsage As UInteger
        Dim ModBaseAddr As Byte
        Dim ModBaseSize As IntPtr
        Dim HModule As IntPtr
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)> Dim SzModule As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> Dim SzeExePath As String
    End Structure


    Public Function GetUsernameFromProcess(pid As Long) As String
        Try
            If pid = 0 Then
                Return "NT Authority\System"
            End If
            Dim phnd As Integer = OpenProcess(ProcessAccessFlags.QueryLimitedInformation, False, pid)
            'If pid = 1700 Then
            '    MsgBox(pid)
            'End If
            If phnd <> 0 Then
                Dim Thnd As Integer
                OpenProcessToken(phnd, Principal.TokenAccessLevels.Query, Thnd)
                Dim TokenUser As TOKEN_USER
                Dim TokenInfLength As Integer = 0
                Dim sUserSid As String = ""
                Dim TokenInformation As IntPtr
                Dim username As String = "<access denied>"

                GetTokenInformation(Thnd, TOKEN_INFORMATION_CLASS.TokenUser, IntPtr.Zero, 0, TokenInfLength)
                TokenInformation = Marshal.AllocHGlobal(TokenInfLength)
                GetTokenInformation(Thnd, TOKEN_INFORMATION_CLASS.TokenUser, TokenInformation, TokenInfLength, TokenInfLength)

                TokenUser = DirectCast(Marshal.PtrToStructure(TokenInformation, TokenUser.GetType), TOKEN_USER)

                ConvertSidToStringSid(TokenUser.User.Sid, sUserSid)

                If sUserSid.StartsWith("S") = True Then
                    username = New Principal.SecurityIdentifier(sUserSid).Translate(GetType(Principal.NTAccount)).ToString()
                Else

                End If
                Return username.ToLower
            Else : Return "<access denied>"
            End If
        Catch ex As Exception
            Return "<access denied>"
        End Try
    End Function

    Public Function isValidProcess(pid As Long) As Boolean
        Dim status As UInteger
        GetExitCodeProcess(OpenProcess(ProcessAccessFlags.QueryInformation, False, pid), status)
        'MsgBox(New Win32Exception(Marshal.GetLastWin32Error).Message)
        If status <> 1 Then
            Return True
        Else : Return False
        End If
    End Function

    Private Function GetModulesPointer(id As Integer) As Integer
        Return 1
    End Function
End Module
