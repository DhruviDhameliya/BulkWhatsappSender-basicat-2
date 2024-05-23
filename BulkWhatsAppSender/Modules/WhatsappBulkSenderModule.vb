Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Text
Imports System.Web
Imports Newtonsoft
Imports Newtonsoft.Json


Module WhatsappBulkSenderModule
    Public IsDemoMode As Boolean

    Public CurrentPercentage As Integer = 0
    Public MaxValue As Integer = 0

    Public IsPaused As Boolean
    Public IsStoped As Boolean
    Public IsVerificationPaused As Boolean
    Public IsVerificationStoped As Boolean

    Public CurrentLog As String
    Public LastLog As String
    Public BulkIsEnd As Boolean = False

    Public DelayBetweenSend As Integer

    Public IsSending As Boolean = False
    Public SentTillNow As String = ""

    Public total As String
    Public starttime As String
    Public endtime As String
    Public MessageSent As String
    Public Numbers As String
    Public CurrentFileName As String
    Public CurrentReportFile As String
    Public ValidNumber As String = ""
    Public InvalidNumber As String = ""
    Public SendingSetting As New ClsSendingConfig
    Public Attachments As String

    Public _SAccountName As String
    Public _SAccountPath As String
    Public _SUseExsisting As Boolean
    Public _SdialogResult As Integer = 0

    Public CriticalError As String

    Public TotalSent As Integer
    Public TotalFailed As Integer
    Public NumbersSent As String


    Public TypeMode As Integer
    Public TypeLimit As Integer
    Public TypeAccount As String
    Public TypeAccounts As String


    Sub RestBulk()
        CurrentPercentage = 0
        MaxValue = 0

        IsPaused = False
        IsStoped = False

        CurrentLog = ""
        LastLog = ""
        BulkIsEnd = False

        DelayBetweenSend = 0

        IsSending = False
        SentTillNow = ""

        total = ""
        starttime = ""
        endtime = ""
        MessageSent = ""
        Numbers = ""
        CurrentFileName = ""
    End Sub

    Public Class Messages
        Public Shared DELETE_NUMBER As String = GetTranslation("BWS_DELETE_NUMBERS")
        Public Shared CLEAR_LIST As String = GetTranslation("BWS_CLEAR_LIST")
        Public Shared NEW_BULK As String = GetTranslation("BWS_NEW_BULK")
        Public Shared NO_NUMBERS As String = GetTranslation("BWS_NO_NUMBERS")
        Public Shared NO_MESSAGE As String = GetTranslation("BWS_NO_MESSAGE")
        Public Shared STOP_BULK As String = GetTranslation("BWS_STOP_BULK")
    End Class
    Public Structure ValidateMobileNumberResult
        Public IsValid As Boolean
        Public MobileNumber As String
    End Structure
    Public Function ValidateMobileNumber(ByVal Number As String) As ValidateMobileNumberResult
        Dim _result As New ValidateMobileNumberResult

        If Number.StartsWith("+") Then
            Number = Number.Replace(" ", "")
            Number = Number.Replace("+", "")
            Number = Number.Replace("\", "")
            Number = Number.Replace("/", "")
            Number = Number.Replace("-", "")
            Number = Number.Replace("_", "")
            Number = Number.Replace(".", "")
        End If

        If IsNumeric(Number) Then
            If Number.Length > 5 And Number.Length < 27 Then

                _result.IsValid = True
                _result.MobileNumber = Number

                Return _result
            Else
                _result.IsValid = False
                _result.MobileNumber = Number
            End If
        Else
            _result.IsValid = False
            _result.MobileNumber = Number
        End If
        Return _result
    End Function
    Public Delegate Sub AppendTextBoxDelegate(ByVal TB As TextBox, ByVal txt As String)
    Public Sub AppendTextBox(ByVal TB As TextBox, ByVal txt As String)
        On Error Resume Next
        If TB.InvokeRequired Then
            TB.Invoke(New AppendTextBoxDelegate(AddressOf AppendTextBox), New Object() {TB, txt})
        Else
            TB.AppendText(txt)
        End If
    End Sub
    Public Function TxtID() As String
        Randomize()
        Return "MSG" & Now.ToString("yyyyMMddhhmmss") & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10)
    End Function
    Public Function GenerateReport() As String
        Dim html As String = My.Resources.Report

        html = html.Replace("{{DATE}}", starttime)
        html = html.Replace("{{TOTAL}}", total)
        html = html.Replace("{{SUCCESS}}", TotalSent)
        html = html.Replace("{{FAILED}}", TotalFailed)
        html = html.Replace("{{MESSAGES}}", MessageSent)
        html = html.Replace("{{ATTACHMENTS}}", Attachments)
        html = html.Replace("{{NUMBERS}}", NumbersSent)

        Randomize()
        CurrentFileName = Now.ToString("yyyyMMddhhmmss") & Int(Rnd() * 99999) & ".html"
        Try
            Dim sw As New IO.StreamWriter(IO.Path.GetTempPath & CurrentFileName)
            sw.Write(html)
            sw.Close()

        Catch ex As Exception

        End Try

        Try
            Dim b As Image = My.Resources.logo
            b.Save(IO.Path.GetTempPath & "logo.png")
        Catch ex As Exception

        End Try
        Return IO.Path.GetTempPath & CurrentFileName
    End Function
    Public Function GetUserSettingsFolder() As String


        Dim MainSettingsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim ApplicationFolder As String = MainSettingsFolder & "\Local Settings\" & ApplicationTitle

        If Not Directory.Exists(ApplicationFolder) Then
            Directory.CreateDirectory(ApplicationFolder)
        End If
        Return ApplicationFolder

    End Function
    Public Function CheckCurrentLicence() As Boolean
        Try
            Dim mac = getMac()
            Dim license As String = GetSetting(ApplicationTitle, "license", "key", "")
            If (license <> "") Then
                Dim ordernumber = GetSetting(ApplicationTitle, "request", "key", "")
                Dim licenseJson As String = getServerData(ServerURL + "isvalidlicense/" + ordernumber + "/" + license + "/" + appversion + "/" + mac, False)
                Dim licenseData = jsonParse(licenseJson)
                Return CBool(licenseData("status"))
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function CheckCurrentLicence(ByVal License As String) As Object
        Console.WriteLine("License : " & License)
        Try
            Dim mac = getMac()
            If (License <> "") Then
                Dim ordernumber = GetSetting(ApplicationTitle, "request", "key", "")
                Dim licenseJson As String = getServerData(ServerURL + "isvalidlicense/" + ordernumber + "/" + License + "/" + appversion + "/" + mac, False)
                Dim licenseData = jsonParse(licenseJson)
                Return licenseData
            Else
                Dim licenseData As New Dictionary(Of String, String)
                licenseData("status") = "0"
                licenseData("description") = ""
                Return licenseData
            End If
        Catch ex As Exception
            Dim licenseData As New Dictionary(Of String, String)
            licenseData("status") = "0"
            licenseData("description") = ex.Message
        End Try
    End Function
    Public Sub SaveAccounts(ByVal lst As ListView)
        Try
            Dim li As ListViewItem
            Dim ds As New DataSet
            Dim dt As New DataTable
            dt.TableName = "Accounts"
            Dim AccountName As New DataColumn("AccountName", Type.GetType("System.String"))
            Dim AccountPath As New DataColumn("AccountPath", Type.GetType("System.String"))

            dt.Columns.Add(AccountName)
            dt.Columns.Add(AccountPath)
            Dim dr As DataRow
            For Each li In lst.Items
                dr = dt.NewRow
                dr("AccountName") = li.Text
                dr("AccountPath") = li.Tag
                dt.Rows.Add(dr)
            Next
            ds.DataSetName = "WhatsApp"
            ds.Tables.Add(dt)
            ds.WriteXml(GetDataProfile() & "\Accounts.xml")

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, ApplicationTitle)
        End Try
    End Sub
    Public Function LoadAccount() As List(Of AccountDetails)
        Try

            Dim ds As New DataSet
            ds.ReadXml(GetDataProfile() & "\Accounts.xml")
            Dim dr As DataRow
            Dim _accDetails As AccountDetails
            Dim accList As New List(Of AccountDetails)
            For Each dr In ds.Tables(0).Rows
                _accDetails = New AccountDetails
                _accDetails.AccountName = dr("AccountName").ToString
                _accDetails.AccountPath = dr("AccountPath").ToString
                accList.Add(_accDetails)
            Next
            Return accList
        Catch ex As Exception
            '    MsgBox(ex.Message, vbCritical, ApplicationTitle)
            Return New List(Of AccountDetails)
        End Try
    End Function
    Public Structure AccountDetails
        Public AccountName As String
        Public AccountPath As String
    End Structure
    Public Structure AccountSwticherDetails
        Public AccountName As String
        Public AccountPath As String
        Public UseExsisting As Boolean
        Public dialogResult As Integer
        Public rotationList As List(Of AccountDetails)
        Public limitbetweenswitch As Integer
    End Structure
    Public Function AccountSwticher() As AccountSwticherDetails
        FrmAccountSwticher.ShowDialog()
        Dim ret As New AccountSwticherDetails
        ret.dialogResult = _SdialogResult
        ret.AccountName = _SAccountName
        ret.AccountPath = _SAccountPath
        ret.UseExsisting = _SUseExsisting
        Return ret
    End Function
    Public Function CheckConnection() As Boolean
        Try
            Dim wc As New WebClient
            'wc.DownloadString(ServerURL)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function GetDataProfile()
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, ApplicationTitle)
            End Try

        End If
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender\Accounts") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender\accounts")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, ApplicationTitle)
            End Try
        End If
        'Environment.SpecialFolder.LocalApplicationData
        Return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender"

    End Function
    Public Function GetDriveSerialNumber(mobile As String) As String
        Try
            Dim mac = getMac()
            Dim Json = getServerData(ServerURL + "insertorderdata/" + mobile + "/" + appversion + "/" + HttpUtility.UrlEncode(mac) + "/", False)
            Dim orderData = jsonParse(Json)
            If orderData("status") = "1" Then
                Return orderData("data")
            Else
                Return orderData("description")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return "Something Went Wrong, Try Again"
        End Try
    End Function
    Public Function getMac() As String
        Try
            Dim DriveSerial As Integer
            Dim fso As Object = CreateObject("Scripting.FileSystemObject")
            Dim Drv As Object = fso.GetDrive(fso.GetDriveName(Application.StartupPath))
            With Drv
                If .IsReady Then
                    DriveSerial = .SerialNumber
                Else    '"Drive Not Ready!"
                    DriveSerial = -1
                End If
            End With
            Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
            Dim mac = nics(0).GetPhysicalAddress.ToString()
            If (mac = "") Then
                mac = DriveSerial.ToString("X2")
            End If
            Console.WriteLine("mac : " & mac)
            Return mac
        Catch ex As Exception
            Return "Invalid Mac"
        End Try
    End Function
    Public Function getServerData(url As String, Optional concate As Boolean = True) As String
        Try
            Dim webClient As New Net.WebClient
            Dim data = ""
            If concate Then
                data = webClient.DownloadString(url & "&l=" & Now.ToString("yyyyMMddhhmmss"))
            Else
                data = webClient.DownloadString(url & "?l=" & Now.ToString("yyyyMMddhhmmss"))
            End If

            Return data
        Catch ex As Exception
            MsgBox("Not able to connect with Server check your Internet Connection" & ex.Message)
            Return "Something Went Wrong, Try Again"
        End Try
    End Function
    Public Function jsonParse(Json As String) As Object
        Try
            Return JsonConvert.DeserializeObject(Json)
        Catch ex As Exception
            Return "Data Parsing Error"
        End Try
    End Function
End Module
