Module mainModule
    Public Function CCADLogin() As String
        Dim WshNetwork
        Dim objSysInfo
        Dim objUser

        WshNetwork = CreateObject("WScript.Network")
        objSysInfo = CreateObject("ADSystemInfo")
        objUser = GetObject("LDAP://" & objSysInfo.USERNAME)
        CCADLogin = WshNetwork.USERNAME
    End Function
    Public Function CCADFullName() As String
        Dim WshNetwork
        Dim objSysInfo
        Dim objUser

        WshNetwork = CreateObject("WScript.Network")
        objSysInfo = CreateObject("ADSystemInfo")
        objUser = GetObject("LDAP://" & objSysInfo.USERNAME)
        'CCADLogin = WshNetwork.USERNAME
        CCADFullName = objUser.FullName
    End Function
End Module
