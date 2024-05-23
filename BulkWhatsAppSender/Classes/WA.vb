
Imports System.Threading
Imports System.Web
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports OpenQA.Selenium.Chrome
Public Class WA
    Dim wc As New Net.WebClient


    Public Shared Function IsLoggedIn(ByVal Driver As ChromeDriver) As Boolean
        Try
            Return CBool(Driver.ExecuteScript(API.IsLoggedIn))
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function IsInjectWapi(ByVal Driver As ChromeDriver) As Boolean
        Try
            Return CBool(Driver.ExecuteScript(API.isWAPIInjected))
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function recheckScript(ByVal Driver As ChromeDriver, ByVal checkIsSync As Boolean) As Boolean
        Try
            If Not WA.IsInjectWapi(Driver) Then
                Console.WriteLine("1")
                Do
                    If Not WA.IsLoggedIn(Driver) Then
                        Console.WriteLine("2")
                        Do
                            Console.WriteLine("3")
                            Thread.Sleep(100)
                            Application.DoEvents()
                        Loop Until WA.IsLoggedIn(Driver)
                    End If
                    Console.WriteLine("4")
                    Thread.Sleep(500)
                    Application.DoEvents()
                    WA.InjectWapi(Driver)
                Loop Until WA.IsInjectWapi(Driver)
                Console.WriteLine("5")
            End If
            If checkIsSync Then
                Do
                    Thread.Sleep(10)
                    Application.DoEvents()
                    Console.WriteLine("6")
                    If Not WA.IsInjectWapi(Driver) Then
                        Console.WriteLine("6.6")
                        recheckScript(Driver, False)
                    End If
                Loop Until WA.isSync(Driver)
                Console.WriteLine("7")
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Sub InjectWapi(ByVal Driver As ChromeDriver)
        Try
            Driver.ExecuteScript(API.GetWAPI)
        Catch ex As Exception
            MsgBox("Engine Error")
        End Try

    End Sub
    Public Shared Sub InitiateSender(ByVal Driver As ChromeDriver)
        Try
            Driver.ExecuteScript(API.InitiateSender)
        Catch ex As Exception
            MsgBox("Initiate Sender Error")
        End Try
    End Sub


    Public Shared Sub ClickSend(ByVal Driver As ChromeDriver)
        Driver.ExecuteScript(API.ClickSend)
    End Sub
    Public Shared Function SendMessage(ByVal Driver As ChromeDriver, ByVal Destination As String, ByVal Message As String) As Boolean
        Try
            Dim IsSafe As Boolean = False
            Driver.ExecuteScript($"tlsbot.SendMessagestatus='null';tlsbot.sendMessage('{Destination}@c.us', '{WAEscape(Message)}' ,{IsSafe.ToString.ToLower}).then(e=>tlsbot.SendMessagestatus=e.sentStatus)")
            System.Threading.Thread.Sleep(100)
            Dim result = Driver.ExecuteScript("return tlsbot.SendMessagestatus;")
            Do
                System.Threading.Thread.Sleep(100)
                result = Driver.ExecuteScript("return tlsbot.SendMessagestatus;")
            Loop While (result.ToString() = "null")
            Return CBool(Driver.ExecuteScript("return tlsbot.SendMessagestatus;"))
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function isSync(ByVal Driver As ChromeDriver) As Boolean
        Try
            Driver.ExecuteScript($"tlsbot.isSyncStatus='null';tlsbot.isSync('919913299818@c.us').then(e=>tlsbot.isSyncStatus=e)")
            System.Threading.Thread.Sleep(100)
            Dim result = Driver.ExecuteScript("return tlsbot.isSyncStatus;")
            Do
                System.Threading.Thread.Sleep(100)
                result = Driver.ExecuteScript("return tlsbot.isSyncStatus;")
            Loop While (result.ToString() = "null")
            Return CBool(Driver.ExecuteScript("return tlsbot.isSyncStatus;"))
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function NumberExist(ByVal Driver As ChromeDriver, num As String, returnType As Boolean) As Boolean
        Try
            Console.WriteLine("tlsbot.NumberExistStatus=[];tlsbot.NumberExistStatus['" & num & "']='null';tlsbot.checkNumberStatus('" & num & "@c.us').then((e)=>{if(e.status==200){tlsbot.NumberExistStatus['" & num & "']=true;}else {tlsbot.NumberExistStatus['" & num & "']=false;}});")
            Driver.ExecuteScript("tlsbot.NumberExistStatus=[];tlsbot.NumberExistStatus['" & num & "']='null';tlsbot.checkNumberStatus('" & num & "@c.us').then((e)=>{if(e.status==200){tlsbot.NumberExistStatus['" & num & "']=true;}else {tlsbot.NumberExistStatus['" & num & "']=false;}});")
            System.Threading.Thread.Sleep(100)
            Dim result = Driver.ExecuteScript("return tlsbot.NumberExistStatus['" & num & "'];")
            Do
                Application.DoEvents()
                System.Threading.Thread.Sleep(100)
                result = Driver.ExecuteScript("return tlsbot.NumberExistStatus['" & num & "'];")
            Loop While (result.ToString() = "null")
            If Not returnType Then
                FrmFilter.NumberVerified(num, CBool(Driver.ExecuteScript("return tlsbot.NumberExistStatus['" & num & "'];")))
            Else
                Return CBool(Driver.ExecuteScript("return tlsbot.NumberExistStatus['" & num & "'];"))
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message.ToString)
            Return False
        End Try
    End Function
    Public Shared Sub NumberExist_old(ByVal Driver As ChromeDriver, num As String, callback As Action(Of Boolean))
        Try
            Console.WriteLine("if(tlsbot.NumberExistStatus == undefined){tlsbot.NumberExistStatus=[];}tlsbot.NumberExistStatus['" & num & "']='null';tlsbot.checkNumberStatus('" & num & "@c.us').then((e)=>{if(e.status==200){tlsbot.NumberExistStatus['" & num & "']=true;}else {tlsbot.NumberExistStatus['" & num & "']=false;}});")
            Driver.ExecuteScript("if(tlsbot.NumberExistStatus == undefined){tlsbot.NumberExistStatus=[];}tlsbot.NumberExistStatus['" & num & "']='null';tlsbot.checkNumberStatus('" & num & "@c.us').then((e)=>{if(e.status==200){tlsbot.NumberExistStatus['" & num & "']=true;}else {tlsbot.NumberExistStatus['" & num & "']=false;}});")
            System.Threading.Thread.Sleep(100)
            Dim result = Driver.ExecuteScript("return tlsbot.NumberExistStatus['" & num & "'];")
            Do
                Application.DoEvents()
                System.Threading.Thread.Sleep(100)
                result = Driver.ExecuteScript("return tlsbot.NumberExistStatus['" & num & "'];")
            Loop While (result.ToString() = "null")
            Console.WriteLine(num & " :::: " & CBool(Driver.ExecuteScript("return tlsbot.NumberExistStatus['" & num & "'];")).ToString)
            callback(CBool(Driver.ExecuteScript("return tlsbot.NumberExistStatus['" & num & "'];")))
        Catch ex As Exception
            Console.WriteLine("Catch......")
            Console.WriteLine(ex)
            Console.WriteLine(ex.Message.ToString)

        End Try
    End Sub
    Public Shared Function WAEscape(ByVal str As String) As String
        Return HttpUtility.JavaScriptStringEncode(str)
    End Function
    Public Shared Function isInvalid(ByVal Driver As ChromeDriver) As Boolean
        Try
            Return CBool(Driver.ExecuteScript(My.Resources.IsInvalid))
        Catch
            Return False
        End Try
    End Function
    Public Shared Sub CloseInvalid(ByVal Driver As ChromeDriver)
        Try
            Driver.ExecuteScript(My.Resources.CloseInvalid)
        Catch

        End Try

    End Sub
    Public Shared Sub CaptionSender(ByVal Driver As ChromeDriver, ByVal Caption As String)
        Caption = WAEscape(Caption)
        Try
            Driver.ExecuteScript(My.Resources.CaptionSendert.Replace("{{Body}}", Caption))
        Catch ex As Exception

        End Try

    End Sub
    Public Shared Sub SendFile(ByVal Driver As ChromeDriver, ByVal FileName As String, ByVal WhatsAppAccount As String, ByVal Caption As String)
        Try
            Dim Base64converter As New ClsBase64
            Dim Base64File As String = Base64converter.ConvertFileToBase64(FileName)
            Dim a() As String = Split(FileName, "\")
            Caption = SafeJavaScript(Caption)
            Dim _filename As String = a(UBound(a))
            Driver.ExecuteScript("tlsbot.sendFile('" & Base64File & "','" & WhatsAppAccount & "@c.us','" & _filename & "','" & Caption & "')")
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Function SafeJavaScript(ByVal str As String) As String
        Return HttpUtility.JavaScriptStringEncode(str)
    End Function

End Class
