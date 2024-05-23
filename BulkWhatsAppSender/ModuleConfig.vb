Module ModuleConfig

    Public AccountURL As String = ""
    Public ServerURL As String = "http://192.168.1.30:8085/" 'you can host getlic on your server
    Public appversion As String = 1 ' 1 for basic and 2 for catelogue
    Public ApplicationTitle As String = ""
    Public ApplicationVersion As String = ""
    Public BuildDate As String = "19-04-2024 | 124 Chrome"
    Public Appv As String = "15.0"
    Public version As String = ""
    Public checkappversion As Boolean = True


    Public Structure Brand
        Public Shared CompanyName As String = "Trueline Solution"
        Public Shared SupportPhone As String = "+919913299862"
        Public Shared SupportEmail As String = "contact@truelinesolution.com"
        Public Shared HelpLink As String = ""
        Public Shared SupportURL As String = "https://api.whatsapp.com/send?phone=919913299862"
        Public Shared WebsiteURL As String = "https://www.truelinesolution.com/"
        Public Shared FaceBookURL As String = "https://www.facebook.com/truelinesolution"
        Public Shared TwitterURL As String = "https://twitter.com/TL_Solution"
        Public Shared InstagramUrl As String = "https://www.instagram.com/truelinesolution/"
    End Structure

    Public Structure API
        Public Shared IsLoggedIn As String
        Public Shared InitiateSender As String
        Public Shared InvalidExist As String
        Public Shared CloseInvalidMessage As String
        Public Shared messageboxid As String
        Public Shared captionmessageboxid As String
        Public Shared InitiateMessage As String
        Public Shared ClickSend As String
        Public Shared GetWAPI As String
        Public Shared messageboxidinnerText As String
        Public Shared IsCaptionLoaded As String
        Public Shared GetGroupContacts As String
        Public Shared GMBScroll As String
        Public Shared GMBname As String
        Public Shared GMBnumber As String
        Public Shared GMBback As String
        Public Shared GMBnextpage As String
        Public Shared GMBxpath As String
        Public Shared BlockNumber As String
        Public Shared JDScroll As String
        Public Shared JDUrl As String
        Public Shared JDCname As String
        Public Shared JDCnumber As String
        Public Shared JDCNext As String
        Public Shared JDpre As String
        Public Shared JDEnable As String
        Public Shared GMBEnable As String
        Public Shared version As String
        Public Shared GMBScript As String
        Public Shared isWAPIInjected As String


    End Structure

    Function InitAPI()
        Dim sciptURL = ServerURL & "getscriptbyid/"
        If appversion = 1 Then
            ApplicationTitle = "Bulk Whatsapp Marketing Software"
            ApplicationVersion = Appv & " | Trueline Solution"
            version = "1.4"
            Brand.HelpLink = "https://www.truelinesolution.com/bulk-whatsapp-marketing-software" 'basic
            API.version = getServerData(sciptURL & "38") 'Basic
        Else
            ApplicationTitle = "Bulk Whatsapp Marketing Software With Catalogue"
            ApplicationVersion = Appv & " | Trueline Solution"
            version = "1.5"
            Brand.HelpLink = "https://www.truelinesolution.com/bulk-whatsapp-marketing-software-with-catalogue" 'catelogue
            API.version = getServerData(sciptURL & "39") 'catelogue
        End If
        API.IsLoggedIn = getServerData(sciptURL & "1")
        API.InitiateSender = getServerData(sciptURL & "2")
        API.InvalidExist = getServerData(sciptURL & "3")
        API.CloseInvalidMessage = getServerData(sciptURL & "4")
        API.messageboxid = getServerData(sciptURL & "5")
        API.captionmessageboxid = getServerData(sciptURL & "24")
        API.InitiateMessage = getServerData(sciptURL & "6")
        API.ClickSend = getServerData(sciptURL & "7")
        API.GetWAPI = getServerData(ServerURL & "script", False)
        API.messageboxidinnerText = getServerData(sciptURL & "9")
        API.IsCaptionLoaded = getServerData(sciptURL & "10")
        API.GetGroupContacts = getServerData(sciptURL & "15")
        API.GMBScroll = getServerData(sciptURL & "11")
        API.GMBname = getServerData(sciptURL & "12")
        API.GMBnumber = getServerData(sciptURL & "13")
        API.GMBback = getServerData(sciptURL & "14")
        API.GMBnextpage = getServerData(sciptURL & "20")
        API.GMBxpath = getServerData(sciptURL & "22")
        API.GMBScript = getServerData(sciptURL & "46")
        API.BlockNumber = getServerData(sciptURL & "23")
        API.JDScroll = getServerData(sciptURL & "25")
        API.JDUrl = getServerData(sciptURL & "26")
        API.JDCname = getServerData(sciptURL & "27")
        API.JDCnumber = getServerData(sciptURL & "28")
        API.JDCNext = getServerData(sciptURL & "29")
        API.JDpre = getServerData(sciptURL & "30")
        API.JDEnable = getServerData(sciptURL & "31")
        API.GMBEnable = getServerData(sciptURL & "32")
        API.isWAPIInjected = getServerData(sciptURL & "49")
    End Function
    Function allloaded()
        If (API.isWAPIInjected IsNot vbNullString And API.GMBScript IsNot vbNullString And API.version IsNot vbNullString And API.JDEnable IsNot vbNullString And API.GMBEnable IsNot vbNullString And API.BlockNumber IsNot vbNullString And API.GetGroupContacts IsNot vbNullString And API.GMBnextpage IsNot vbNullString And API.GMBback IsNot vbNullString And API.GMBnumber IsNot vbNullString And API.GMBname IsNot vbNullString And API.GMBScroll IsNot vbNullString And API.IsCaptionLoaded IsNot vbNullString And API.messageboxidinnerText IsNot vbNullString And API.GetWAPI IsNot vbNullString And API.ClickSend IsNot vbNullString And API.InitiateMessage IsNot vbNullString And API.messageboxid IsNot vbNullString And API.CloseInvalidMessage IsNot vbNullString And API.InvalidExist IsNot vbNullString And API.InitiateSender IsNot vbNullString And API.IsLoggedIn IsNot vbNullString) Then
            Return True
        Else
            Return False
        End If
    End Function


    Public HeaderColor As Color = Color.FromArgb(0, 64, 0) ' Color Sequence R G B
    Public MenuColor As Color = Color.FromArgb(237, 248, 245) ' Color Sequence R G B

    Public DefaultHeaderColor As Color = Color.FromArgb(0, 64, 0) ' Color Sequence R G B
    Public DefaultMenuColor As Color = Color.FromArgb(237, 248, 245) ' Color Sequence R G B

    Public ShowAbout As Boolean = True
    Public ShowLanguageOption As Boolean = True
    Public ShowThemesOption As Boolean = False
    Public ShowHelp As Boolean = True
    Public ShowUpdateLicense As Boolean = True

End Module