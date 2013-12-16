Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.Text

Public Class LocalHostSQLInstancesReader

    ''' <summary>
    '''  get local sql server instance names from registry, search both WOW64 and WOW3264 hives
    ''' </summary>
    ''' <returns>a list of local sql server instance names</returns>
    Public Shared Function GetLocalSqlServerInstanceNames() As IList(Of String)
        Dim registryValueDataReader As New LocalHostSQLInstancesReader()

        Dim instances64Bit As String() = registryValueDataReader.ReadRegistryValueData(RegistryHive.Wow64, Registry.LocalMachine, "SOFTWARE\Microsoft\Microsoft SQL Server", "InstalledInstances")

        Dim instances32Bit As String() = registryValueDataReader.ReadRegistryValueData(RegistryHive.Wow6432, Registry.LocalMachine, "SOFTWARE\Microsoft\Microsoft SQL Server", "InstalledInstances")

        'FormatLocalSqlInstanceNames(instances64Bit)
        'FormatLocalSqlInstanceNames(instances32Bit)

        Dim localInstanceNames As IList(Of String) = New List(Of String)(instances64Bit)

        localInstanceNames = localInstanceNames.Union(instances32Bit).ToList()

        Return localInstanceNames
    End Function



    Private Shared ReadOnly KEY_WOW64_32KEY As Integer = &H200
    Private Shared ReadOnly KEY_WOW64_64KEY As Integer = &H100

    Private Shared ReadOnly HKEY_LOCAL_MACHINE As UIntPtr = CType(&H80000002UI, UIntPtr)

    Private Shared ReadOnly KEY_QUERY_VALUE As Integer = &H1

    <DllImport("advapi32.dll", CharSet:=CharSet.Unicode, EntryPoint:="RegOpenKeyEx")> _
    Private Shared Function RegOpenKeyEx(hKey As UIntPtr, subKey As String, options As UInteger, sam As Integer, ByRef phkResult As IntPtr) As Integer
    End Function


    <DllImport("advapi32.dll", SetLastError:=True)> _
    Private Shared Function RegQueryValueEx(hKey As IntPtr, lpValueName As String, lpReserved As Integer, ByRef lpType As UInteger, lpData As IntPtr, ByRef lpcbData As UInteger) As Integer
    End Function

    Private Shared Function GetRegistryHiveKey(registryHive__1 As RegistryHive) As Integer
        Return If(registryHive__1 = RegistryHive.Wow64, KEY_WOW64_64KEY, KEY_WOW64_32KEY)
    End Function

    Private Shared Function GetRegistryKeyUIntPtr(registry__1 As RegistryKey) As UIntPtr
        If registry__1 Is Registry.LocalMachine Then
            Return HKEY_LOCAL_MACHINE
        End If

        Return UIntPtr.Zero
    End Function

    Public Function ReadRegistryValueData(registryHive As RegistryHive, registryKey As RegistryKey, subKey As String, valueName As String) As String()
        Dim instanceNames As String() = New String(-1) {}

        Dim key As Integer = GetRegistryHiveKey(registryHive)
        Dim registryKeyUIntPtr As UIntPtr = GetRegistryKeyUIntPtr(registryKey)

        Dim hResult As IntPtr

        Dim res As Integer = RegOpenKeyEx(registryKeyUIntPtr, subKey, 0, KEY_QUERY_VALUE Or key, hResult)

        If res = 0 Then
            Dim type As UInteger
            Dim dataLen As UInteger = 0

            RegQueryValueEx(hResult, valueName, 0, type, IntPtr.Zero, dataLen)

            Dim databuff As Byte() = New Byte(dataLen - 1) {}
            Dim temp As Byte() = New Byte(dataLen - 1) {}

            Dim values As List(Of [String]) = New List(Of String)()

            Dim handle As GCHandle = GCHandle.Alloc(databuff, GCHandleType.Pinned)
            Try
                RegQueryValueEx(hResult, valueName, 0, type, handle.AddrOfPinnedObject(), dataLen)
            Finally
                handle.Free()
            End Try

            Dim i As Integer = 0
            Dim j As Integer = 0

            While i < databuff.Length
                If databuff(i) = Nothing Then
                    j = 0
                    Dim str As String = Encoding.[Default].GetString(temp).Trim(ControlChars.NullChar)

                    If Not String.IsNullOrEmpty(str) Then
                        values.Add(str)
                    End If

                    temp = New Byte(dataLen - 1) {}
                Else
                    temp(System.Math.Max(System.Threading.Interlocked.Increment(j), j - 1)) = databuff(i)
                End If

                i += 1
            End While

            instanceNames = New String(values.Count - 1) {}
            values.CopyTo(instanceNames)
        End If

        Return instanceNames
    End Function
End Class
