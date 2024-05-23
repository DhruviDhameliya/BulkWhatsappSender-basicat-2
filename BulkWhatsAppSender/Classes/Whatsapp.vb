Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports System
Imports System.Threading
Imports OpenQA.Selenium.Support.UI
Imports System.Timers

Public Class Whatsapp
    Dim scriptCheckTimer As New System.Windows.Forms.Timer
    Dim scriptCheckTimerTickRunning = False

    Private ChromeDrv As ChromeDriver

    Public Message As String
    Public Caption As String
    Public MessageType As Integer

    Private SendingThread As Thread

    Public Destinations As String
    Public Messages As New List(Of String)
    Public FileName As String
    Public Friends As New List(Of String)
    Public FriendsMessage As New List(Of String)
    Public MediaFiles As New List(Of ListViewItem)
    Public Speed As Long
    Public MessageDelay As Integer
    Public ActivateDialog As Boolean
    Public DialogAfter As Integer
    Public DialogWait As Integer
    Public DialoCount As Integer
    Public ActivateSleep As Boolean
    Public SleepAfter As Integer
    Public SleepFor As Integer
    Public SendingMode As Boolean
    Public DeleteAfterSending As Boolean
    Public NewSession As Boolean
    Public SessionPath As String
    Dim SuccessSent As Boolean = False
    Dim NumberExistOrNot As Boolean = False
    Public Event OnSending As EventHandler
    Public Event OnBulkEnd As EventHandler
    Public Event OnChromeError As EventHandler

    Public DelayStart As Integer
    Public DelayEnd As Integer

    Public DstListTx As New List(Of String)
    Public DstListNum As New List(Of String)
    Public DstListNames As New List(Of String)
    Public DstListVar1 As New List(Of String)
    Public DstListVar2 As New List(Of String)
    Public DstListVar3 As New List(Of String)
    Public DstListVar4 As New List(Of String)
    Public DstListVar5 As New List(Of String)

    Public acctypeMode As Integer
    Public accRotationLimitation As Integer

    Public Accsingle As String
    Public accmulti As String

    Public MessageCounting As Integer
    Public catalogue As String


    Public TurboMode As Boolean

    Dim chnCounter As Integer = 0
    Public Sub StartSending()
        Dim _dst As String = Destinations
        Dim _Msg As String = Message
        SendingThread = New Thread(AddressOf DoSending)
        SendingThread.Start()
    End Sub
    Public Sub StopBulk()
        Try
            IsStoped = True
            IsSending = False
            SendingThread.Abort()
            ChromeDrv.Quit()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DoSending()
        Try
            NumbersSent = ""
            TotalSent = 0
            TotalFailed = 0
            CurrentPercentage = 0
            MessageCounting = 0
            Try
                Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
                DriverService.HideCommandPromptWindow = True
                Dim Woptions As New ChromeOptions
                Select Case acctypeMode
                    Case 0
                    Case 1
                        Woptions.AddArguments("user-data-dir=" & Accsingle)
                    Case 2
                        Dim aaaa() As String = Split(accmulti, "||")
                        Woptions.AddArguments("user-data-dir=" & aaaa(chnCounter))
                        chnCounter = chnCounter + 1
                End Select


                ChromeDrv = New ChromeDriver(DriverService, Woptions)
            Catch ex As Exception
                If Not NewSession Then
                    If ex.Message.Contains("Chrome failed to start") Then
                        Dim ChromeError As New EventArgs
                        RaiseEvent OnChromeError(Me, ChromeError)
                        Exit Sub
                        Try
                            ChromeDrv.Quit()
                        Catch

                        End Try
                    End If
                End If
                IsStoped = True
                IsSending = False
                BulkIsEnd = True
                Try
                    ChromeDrv.Quit()
                Catch ex2 As Exception

                End Try

                EndReport()
                Exit Sub
            End Try

            starttime = Now.ToString("dd MMMM yyyy HH:mm")
            TotalFailed = 0
            TotalSent = 0
            Attachments = ""
            IsSending = True

            MaxValue = DstListNum.Count
            total = MaxValue

            Dim NumberDst As New List(Of String)
            Dim NameDst As New List(Of String)
            Dim TxIdList As New List(Of String)

            Numbers = ""
            'Dim MainScript As String = LoadInjector()
            Dim Dst As String = ""
            Try
                ChromeDrv.Navigate().GoToUrl("https://web.whatsapp.com/")
                ChromeDrv.Manage.Window.Maximize()

            Catch ex As Exception
                MsgBox("Unable to access Chrome")
            End Try
            Thread.Sleep(1200)
            AddLog("Wait for: WhatsApp Login...")
            Do
                Thread.Sleep(10)
                Application.DoEvents()
            Loop Until WA.IsLoggedIn(ChromeDrv)
            AddLog("Wait for: WhatsApp Login Done")
            If CBool(GetSetting(ApplicationTitle, "SendingConfig", "HideChromeMsg", "true")) Then
                ' ChromeDrv.Manage.Window.Position = New Point(-10000, -10000)
            End If
            WA.InjectWapi(ChromeDrv)
StartBulk:
            WaitTocompleteLoading(4)
            Dim DialogCount As Integer = 0
            Dim SleepCount As Integer = 0

            Dim _ff As ListViewItem
            Attachments = ""
            For Each _ff In MediaFiles
                Attachments = Attachments & "<tr><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & _ff.Tag.ToString & "<br>" & _ff.SubItems(2).Text & "</span></td></tr>"
            Next
            MessageSent = ""
            For Each _msg In Messages
                MessageSent = MessageSent & "<tr><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & _msg & "</span></td></tr>"
            Next
            Dim var1 As String = ""
            Dim var2 As String = ""
            Dim var3 As String = ""
            Dim var4 As String = ""
            Dim var5 As String = ""
            AddLog("Wait for: WhatsApp Sync...")
            Thread.Sleep(1200)
            WA.recheckScript(ChromeDrv, True)
            AddLog("WhatsApp Sync Done")
            scriptCheckTimer.Interval = 1000
            AddHandler scriptCheckTimer.Tick, AddressOf scriptCheckTimerTick
            scriptCheckTimer.Enabled = True

            For i = 0 To DstListNum.Count - 1
                var1 = ""
                var2 = ""
                var3 = ""
                var4 = ""
                var5 = ""
                If DstListVar1.Count > i Then
                    If Not IsNothing(DstListVar1.Item(i)) Then
                        var1 = DstListVar1.Item(i)
                    End If
                End If

                If DstListVar2.Count > i Then
                    If Not IsNothing(DstListVar2.Item(i)) Then
                        var2 = DstListVar2.Item(i)
                    End If
                End If

                If DstListVar3.Count > i Then
                    If Not IsNothing(DstListVar3.Item(i)) Then
                        var3 = DstListVar3.Item(i)
                    End If
                End If

                If DstListVar4.Count > i Then
                    If Not IsNothing(DstListVar4.Item(i)) Then
                        var4 = DstListVar4.Item(i)
                    End If
                End If


                If DstListVar5.Count > i Then
                    If Not IsNothing(DstListVar5.Item(i)) Then
                        var5 = DstListVar5.Item(i)
                    End If
                End If


                DialogCount = DialogCount + 1
                SleepCount = SleepCount + 1

                If ActivateDialog Then
                    If DialogCount = DialogAfter Then
                        Dim FriendMessageSelector As Integer
                        DialogCount = 0
                        Dim t As String
                        Dim k As Integer = 0
                        For Each t In Friends
                            k = k + 1
                            If k = DialoCount Then
                                Exit For
                            End If
                            Try
                                Randomize()
                                FriendMessageSelector = Int(Rnd() * FriendsMessage.Count)
                                WA.SendMessage(ChromeDrv, CleanNumber(t), FriendsMessage(FriendMessageSelector))
                            Catch ex As Exception

                            End Try
                            WaitTocompleteLoading(3)
                            Thread.Sleep(DialogWait)
                        Next
                    End If
                End If


                If ActivateSleep Then
                    If SleepCount = SleepAfter + 1 Then
                        SleepCount = 0
                        AddLog("Sleep for:" & SleepFor / 1000 & " Seconds")
                        Thread.Sleep(SleepFor)

                    End If
                End If

                Application.DoEvents()
                Dst = CleanNumber(DstListNum.Item(i))
                Dim _msg As String
                Try
                    Randomize()
                    Dim MessageSelector As Integer = Int(Rnd() * Messages.Count)
                    _msg = Messages(MessageSelector)
                Catch ex As Exception
                    _msg = ""
                End Try
                If _msg = "" Then
                    _msg = "{{{emplty}}}"
                End If
                If Not TurboMode Then
                    Dim cDelay As Long = GetDelay(DelayStart, DelayEnd)
                    AddLog("Wait for:" & cDelay \ 1000 & " Seconds ")
                    Thread.Sleep(cDelay)
                End If
                CurrentPercentage = CurrentPercentage + 1
                If _msg <> "" Then
                    Dim ee As New EventArgs
                    Dim Msg As String = _msg

                    Msg = ApplySpinText(Msg)
                    Dim FullName As String

                    System.Threading.Thread.Sleep(100)

                    Msg = Msg.Replace("[[randomtag]]", RandomTag)
                    Msg = Msg.Replace("[[VAR1]]", var1)
                    Msg = Msg.Replace("[[VAR2]]", var2)
                    Msg = Msg.Replace("[[VAR3]]", var3)
                    Msg = Msg.Replace("[[VAR4]]", var4)
                    Msg = Msg.Replace("[[VAR5]]", var5)
                    FullName = DstListNames.Item(i)
                    If FullName = "" Or FullName = "N/A" Then
                        Msg = Msg.Replace("[[fullname]]", "")
                    Else
                        Msg = Msg.Replace("[[fullname]]", FullName)
                    End If
                    Dim Fname() As String = Split(FullName, " ")
                    If Fname.Count > 1 Then
                        Msg = Msg.Replace("[[firstname]]", Fname(0))
                        Msg = Msg.Replace("[[lastname]]", Fname(1))
                    Else
                        Msg = Msg.Replace("[[firstname]]", "")
                        Msg = Msg.Replace("[[lastname]]", "")
                    End If
                    If SendingMode Then
                        Dim strings = Msg.Split(vbNewLine)
                        Dim status = False
                        For Each stringmsg In strings
                            If WA.SendMessage(ChromeDrv, CleanNumber(Dst), stringmsg) Then
                                status = True
                            End If

                        Next
                        If status Then
                            NumberExistOrNot = True
                            NumbersSent = NumbersSent & "<tr><td class='IconSuccessEncoded' style='width: 15px'></td><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & CleanNumber(Dst) & "</span></td><td style='width: 63px'>Sent</td><td class='auto-style2' style='width: 246px'><span class='auto-style1'></span></td></tr>"
                            RaiseEvent OnSending(DstListTx.Item(i) & "|1", ee)
                            TotalSent = TotalSent + 1
                        Else
                            NumberExistOrNot = False
                            NumbersSent = NumbersSent & "<tr><td class='IconErrorEncoded' style='width: 15px'></td><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & CleanNumber(Dst) & "</span></td><td style='width: 63px'>Failed</td><td class='auto-style2' style='width: 246px'><span class='auto-style1'>Invalid Number</span></td></tr>"
                            RaiseEvent OnSending(DstListTx.Item(i) & "|0", ee)
                            TotalFailed = TotalFailed + 1
                        End If

                    Else
                        If WA.SendMessage(ChromeDrv, CleanNumber(Dst), Msg) Then
                            NumberExistOrNot = True
                            NumbersSent = NumbersSent & "<tr><td class='IconSuccessEncoded' style='width: 15px'></td><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & CleanNumber(Dst) & "</span></td><td style='width: 63px'>Sent</td><td class='auto-style2' style='width: 246px'><span class='auto-style1'></span></td></tr>"
                            RaiseEvent OnSending(DstListTx.Item(i) & "|1", ee)
                            TotalSent = TotalSent + 1
                        Else
                            NumberExistOrNot = False
                            NumbersSent = NumbersSent & "<tr><td class='IconErrorEncoded' style='width: 15px'></td><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & CleanNumber(Dst) & "</span></td><td style='width: 63px'>Failed</td><td class='auto-style2' style='width: 246px'><span class='auto-style1'>Invalid Number</span></td></tr>"
                            RaiseEvent OnSending(DstListTx.Item(i) & "|0", ee)
                            TotalFailed = TotalFailed + 1
                        End If
                    End If




                End If

                Dim _TempCaption As String
                If Not TurboMode Then
                    If _msg = "" Then
                        If Not WA.NumberExist(ChromeDrv, CleanNumber(Dst), True) Then
                            NumberExistOrNot = False
                            Dim ee As New EventArgs
                            NumbersSent = NumbersSent & "<tr><td class='IconErrorEncoded' style='width: 15px'></td><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & CleanNumber(Dst) & "</span></td><td style='width: 63px'>Failed</td><td class='auto-style2' style='width: 246px'><span class='auto-style1'>Invalid Number</span></td></tr>"
                            RaiseEvent OnSending(DstListTx.Item(i) & "|0", ee)
                            TotalFailed = TotalFailed + 1
                        Else
                            NumberExistOrNot = True
                        End If
                    End If


                    If NumberExistOrNot Then
                        If MediaFiles.Count > 0 Then
                            For Each fileli In MediaFiles
                                System.Threading.Thread.Sleep(100)
                                _TempCaption = fileli.SubItems(2).Text
                                _TempCaption = _TempCaption.Replace("||||", vbNewLine)
                                _TempCaption = _TempCaption.Replace("[[randomtag]]", RandomTag)
                                Dim FullName = DstListNames.Item(i)
                                If FullName = "" Or DstListNames.Item(i) = "N/A" Then
                                    _TempCaption = _TempCaption.Replace("[[fullname]]", "")
                                Else
                                    _TempCaption = _TempCaption.Replace("[[fullname]]", FullName)
                                End If

                                Dim Fname() As String = Split(FullName, " ")
                                If Fname.Count > 1 Then
                                    _TempCaption = _TempCaption.Replace("[[firstname]]", Fname(0))
                                    _TempCaption = _TempCaption.Replace("[[lastname]]", Fname(1))
                                Else
                                    _TempCaption = _TempCaption.Replace("[[firstname]]", "")
                                    _TempCaption = _TempCaption.Replace("[[lastname]]", "")
                                End If
                                WA.SendFile(ChromeDrv, fileli.Tag, Dst, _TempCaption)
                            Next
                        End If
                    End If
                End If
                If Trim(catalogue) IsNot "" Then
                    ChromeDrv.ExecuteScript($"tlsbot.openChat('{CleanNumber(Dst)}@c.us')")
                    System.Threading.Thread.Sleep(100)
                    Sendcalalogue()
                End If
                Do : Thread.Sleep(10) : Loop While IsPaused
skipMessage:

                If acctypeMode = 2 Then
                    MessageCounting = MessageCounting + 1
                    If accRotationLimitation <= MessageCounting - 1 Then
                        MessageCounting = 0
                        AddLog("Switch account...")
                        System.Threading.Thread.Sleep(1000)

                        Try
                            ChromeDrv.Quit()
                        Catch ex As Exception

                        End Try
                        Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
                        DriverService.HideCommandPromptWindow = True
                        Dim Woptions As New ChromeOptions

                        Select Case acctypeMode
                            Case 0
                            Case 1
                            Case 2
                                Dim aaaa() As String = Split(accmulti, "||")
                                Woptions.AddArguments("user-data-dir=" & aaaa(chnCounter))
                                chnCounter = chnCounter + 1
                                If chnCounter >= UBound(aaaa) + 1 Then
                                    chnCounter = 0
                                End If
                        End Select

                        ChromeDrv = New ChromeDriver(DriverService, Woptions)

                        Try
                            ChromeDrv.Navigate().GoToUrl("https://web.whatsapp.com/")
                        Catch

                        End Try
                        Thread.Sleep(1200)

                        Do
                            Thread.Sleep(10)
                        Loop Until WA.IsLoggedIn(ChromeDrv)

                        Try
                            WA.InjectWapi(ChromeDrv)
                            WaitTocompleteLoading(4)
                            WA.InitiateSender(ChromeDrv)
                        Catch ex As Exception
                            MsgBox("Unable to load API")
                        End Try
                    End If
                End If
            Next
            EndReport()
            scriptCheckTimer.Enabled = False
        Catch ex As Exception
        End Try
    End Sub
    Sub scriptCheckTimerTick()
        If Not scriptCheckTimerTickRunning Then
            scriptCheckTimerTickRunning = True
            WA.recheckScript(ChromeDrv, False)
            scriptCheckTimerTickRunning = False
        End If
    End Sub
    Public Sub Sendcalalogue()
        Try
            ChromeDrv.ExecuteScript("window.sendcat='null';tlsbot.sendCatalogue('" + catalogue + "').then((e)=>{window.sendcat=e});")
            System.Threading.Thread.Sleep(100)
            Dim result = ChromeDrv.ExecuteScript("return window.sendcat;")
            Do
                System.Threading.Thread.Sleep(100)
                result = ChromeDrv.ExecuteScript("return window.sendcat;")
            Loop While (result.ToString() = "null")
            Thread.Sleep(Speed)
        Catch ex As Exception
            Console.WriteLine("Sendcalalogue outer")
        End Try
    End Sub
    Public Sub CloseChome()
        Try
            ChromeDrv.Quit()
        Catch ex As Exception
        End Try
    End Sub
    Public Structure BulkResult
        Public EndTime As String
    End Structure
    Public Sub EndReport()
        Dim EndBulkResult As New BulkResult
        endtime = Now.ToString("dd MMMM yyyy HH:mm")
        EndBulkResult.EndTime = endtime
        IsSending = False
        BulkIsEnd = True
        CurrentReportFile = GenerateReport()
        Dim e As New EventArgs
        RaiseEvent OnBulkEnd(EndBulkResult, e)
    End Sub
    Private Function GetMsgType(ByVal FileName As String) As Integer
        Dim a() As String = Split(FileName, ".")
        Select Case LCase(a(UBound(a)))
            Case "jpg"
                Return 2
            Case "gif"
                Return 2
            Case "png"
                Return 2
            Case "mp4"
                Return 2
            Case Else
                Return 3
        End Select
    End Function
    Public Function ExecuteChromeScript(ByVal Script As String) As String
        Try
            Return ChromeDrv.ExecuteScript(Script).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function
    Private Function RandomTag() As String
        Randomize()
        Return Int(Rnd() * 10000000)
    End Function
    Private Function CleanNumber(ByVal Number As String) As String
        Number = Number.Replace("+", "").Trim
        Number = Number.Replace("-", "")
        Number = Number.Replace("(", "")
        Number = Number.Replace(")", "")
        Number = Number.Replace(" ", "")
        Number = Number.Replace("/", "")
        Number = Number.Replace("\", "")
        Number = Number.Replace(vbTab, "")
        Return Number.Trim
    End Function
    Private Function WaitTocompleteLoading(ByVal TimerOutInSecond As Integer) As Boolean
        Try
            ChromeDrv.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimerOutInSecond)
            Dim counter As Long = 0
            Do
                System.Threading.Thread.Sleep(1)
                If counter >= TimerOutInSecond * 1000 Then
                    Return False
                    Exit Function
                End If
            Loop Until ChromeDrv.ExecuteScript("return document.readyState").Equals("complete")
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Public Sub AddLog(ByVal Log As String)
        CurrentLog = CurrentLog & Now.ToString("hh:mm:ss") & ">" & Log & vbNewLine
    End Sub
    Public Function GetDelay(ByVal startDelay As Integer, ByVal EndDelay As Integer) As Long
        Randomize()
        Return (startDelay + Int(Rnd() * EndDelay)) * 1000
    End Function
    Public Function ApplySpinText(ByVal Text As String) As String
        Dim _text As String = Text
        Dim dicEntry As DictionaryEntry
        Dim SpinTextDictionary As New List(Of DictionaryEntry)
        _text = _text.Replace("{{", "||{{") : _text = _text.Replace("}}", "}}||")
        Dim SpintextArr() As String = Split(_text, "||")
        For Each Spintext As String In SpintextArr
            If Spintext.Trim.StartsWith("{{") And Spintext.Trim.EndsWith("}}") Then
                Dim cSpin As String = Spintext
                cSpin = cSpin.Replace("{{", "") : cSpin = cSpin.Replace("}}", "")
                Dim rWords() As String = cSpin.Split("|")
                If rWords.Count > 0 Then
                    Randomize()
                    Dim selector As Integer = 0
                    For i As Integer = 0 To 30 : selector = Int(Rnd() * rWords.Count)
                    Next
                    dicEntry = New DictionaryEntry(Spintext, rWords(selector)) : SpinTextDictionary.Add(dicEntry)
                End If
            End If
        Next
        Dim Result As String = Text
        For Each dicEntry In SpinTextDictionary
            Result = Result.Replace(dicEntry.Key, dicEntry.Value)
        Next
        Return Result
    End Function
End Class
