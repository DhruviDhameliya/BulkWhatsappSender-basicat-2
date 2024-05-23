Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Support.UI

Public Class FrmFilter

    Private ChromeDrv As OpenQA.Selenium.Chrome.ChromeDriver
    Dim counterNumber As Integer = 0
    Private Sub BtnFromFile_Click(sender As Object, e As EventArgs) Handles BtnFromFile.Click

        Dim _openDlg As New OpenFileDialog
        _openDlg.Filter = "*.txt;*.csv|*.txt;*.csv"

        If _openDlg.ShowDialog = DialogResult.OK Then
            If LstAll.Items.Count > 0 Then
                If MsgBox(GetTranslation("BWS_APPEND_LIST"), vbYesNo + vbQuestion, ApplicationTitle) = vbNo Then
                    LstAll.Items.Clear()
                End If
            End If
            LstAll.Visible = False
            Dim sr As New IO.StreamReader(_openDlg.FileName)
            Dim Fl As String = sr.ReadToEnd
            sr.Close()
            sr.Dispose()
            Dim dsts() As String = Split(Fl, vbNewLine)
            Dim dst As String
            For Each dst In dsts
                If ValidateNumber(dst) Then
                    LstAll.Items.Add(dst)
                End If
            Next
            LstAll.Visible = True
            LblAllTotal.Text = LstAll.Items.Count
        End If
    End Sub


    Private Function ValidateNumber(ByVal num As String) As Boolean
        If num.Length > 16 Then
            Return False
            Exit Function
        End If
        If Not IsNumeric(num) Then
            Return False
            Exit Function
        End If
        Return True
    End Function
    Private Sub BtnManual_Click(sender As Object, e As EventArgs) Handles BtnManual.Click
        FrmManualFilterImport.ShowDialog()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        If MsgBox(GetTranslation("BWS_CLEAR_LIST"), vbQuestion + vbYesNo, ApplicationTitle) = vbYes Then
            LstAll.Items.Clear()
        End If
    End Sub

    Private Sub BtnNumberGenegrator_Click(sender As Object, e As EventArgs) Handles BtnNumberGenegrator.Click
        Dim _imp As New FrmNumberGenerator
        _imp.ShowDialog()

        If _imp.ImportResults.Count > 0 Then
            Dim li As ListViewItem
            If LstAll.Items.Count > 0 Then
                If MsgBox(GetTranslation("BWS_APPEND_LIST"), vbYesNo + vbQuestion, ApplicationTitle) = vbNo Then
                    LstAll.Items.Clear()
                End If

            End If
            LstAll.Visible = False
            For Each li In _imp.ImportResults
                LstAll.Items.Add(li.SubItems(1).Text)
            Next
            LstAll.Visible = True
            LblAllTotal.Text = LstAll.Items.Count
        End If
        _imp.Dispose()
    End Sub



    Public Sub SaveList(ByVal ListtoSave As ListBox)
        If ListtoSave.Items.Count > 0 Then
            Dim savedlg As New SaveFileDialog
            savedlg.Filter = "*.txt|*.txt"
            If savedlg.ShowDialog = DialogResult.OK Then
                Try
                    Dim sw As New IO.StreamWriter(savedlg.FileName)
                    Dim a As String
                    Dim all As String = ""
                    For Each a In ListtoSave.Items
                        all = all & a & vbNewLine
                    Next
                    sw.Write(all)
                    sw.Close()
                    sw.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, ApplicationTitle)
                End Try

            End If
        End If
    End Sub
    Private Sub BtnWhatsaAppWeb_Click(sender As Object, e As EventArgs) Handles BtnWhatsaAppWeb.Click
        If LstAll.Items.Count > 0 Then
            BtnStop.Visible = True
            BtnWhatsaAppWeb.Visible = False
            DoFilter()
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveList(LstAll)
    End Sub

    Private Sub BtnSaveWhatsapp_Click(sender As Object, e As EventArgs) Handles BtnSaveWhatsapp.Click
        SaveList(LstWhatsApp)
    End Sub

    Private Sub BtnSaveNonWhatsapp_Click(sender As Object, e As EventArgs) Handles BtnSaveNonWhatsapp.Click
        SaveList(LstNonWhatsapp)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox(GetTranslation("BWS_CLEAR_LIST"), vbQuestion + vbYesNo, ApplicationTitle) = vbYes Then
            ValidNumber = ""
            LstWhatsApp.Items.Clear()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox(GetTranslation("BWS_CLEAR_LIST"), vbQuestion + vbYesNo, ApplicationTitle) = vbYes Then
            InvalidNumber = ""
            LstNonWhatsapp.Items.Clear()
        End If
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        isStop = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim a As String
        Dim li As ListViewItem
        FrmMain.LstNumbers.Visible = False
        For Each a In LstWhatsApp.Items
            li = New ListViewItem
            li.Tag = TxtID()
            li.Text = "N/A"
            li.SubItems.Add(a)
            li.SubItems.Add("Pending")
            li.ImageIndex = 0
            FrmMain.LstNumbers.Items.Add(li)
        Next
        FrmMain.LstNumbers.Visible = True

    End Sub

    Private Sub FrmFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.BackColor = HeaderColor


        ''''''''''''''''''''''''Filter Frm'''''''''''''''''''''''''''''''''''
        Me.Text = GetValueFromlanguage("FrmFilter", "BWS_TITLE")
        LblNumbers.Text = GetValueFromlanguage("FrmFilter", "BWS_WHATSAPP_FILTER")
        Label4.Text = GetValueFromlanguage("FrmFilter", "BWS_FILTER_NUMBERS")
        Label1.Text = GetValueFromlanguage("FrmFilter", "BWS_ALL_NUMBERS")
        Label2.Text = GetValueFromlanguage("FrmFilter", "BWS_WHATSAPP_ACC")
        Label3.Text = GetValueFromlanguage("FrmFilter", "BWS_NONWHATSAPP_ACC")
        BtnFromFile.Text = GetValueFromlanguage("FrmFilter", "BWS_FROM_FILE")
        BtnManual.Text = GetValueFromlanguage("FrmFilter", "BWS_MANUAL")
        BtnNumberGenegrator.Text = GetValueFromlanguage("FrmFilter", "BWS_NUMBER_GENERATOR")
        Button4.Text = GetValueFromlanguage("FrmFilter", "BWS_ADD_TOSENDER")
        BtnClear.Text = GetValueFromlanguage("FrmFilter", "BWS_CLEAR")
        Button3.Text = GetValueFromlanguage("FrmFilter", "BWS_SAVE")
        Label6.Text = GetValueFromlanguage("FrmFilter", "BWS_FAST")
        Label7.Text = GetValueFromlanguage("FrmFilter", "BWS_ACCURATE")
        BtnStop.Text = GetValueFromlanguage("FrmFilter", "BWS_STOP")
        BtnWhatsaAppWeb.Text = GetValueFromlanguage("FrmFilter", "BWS_START")
        Label5.Text = GetValueFromlanguage("FrmFilter", "BWS_PROGRESS")
        Button1.Text = GetValueFromlanguage("FrmFilter", "BWS_CLEAR")
        BtnSaveWhatsapp.Text = GetValueFromlanguage("FrmFilter", "BWS_SAVE")
        Button2.Text = GetValueFromlanguage("FrmFilter", "BWS_CLEAR")
        BtnSaveNonWhatsapp.Text = GetValueFromlanguage("FrmFilter", "BWS_SAVE")

    End Sub

    Private isStop As Boolean = False

    Private Sub DoFilter()
        isStop = False
        ProgressBar1.BeginInvoke(Sub()
                                     ProgressBar1.Maximum = LstAll.Items.Count
                                 End Sub)
        Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
        DriverService.HideCommandPromptWindow = True
        ChromeDrv = New ChromeDriver(DriverService, New ChromeOptions())
        ChromeDrv.Navigate.GoToUrl("https://web.whatsapp.com")
        System.Threading.Thread.Sleep(2000)
        Do
            Application.DoEvents()
        Loop Until WA.IsLoggedIn(ChromeDrv)
        ChromeDrv.Manage.Window.Maximize()
        ChromeDrv.ExecuteScript(API.GetWAPI)
        System.Threading.Thread.Sleep(500)
        'ChromeDrv.Manage.Window.Position = New Point(-10000, -10000)

        Label8.Text = "Waiting For WhatsApp Sync..."
        Application.DoEvents()
        WA.recheckScript(ChromeDrv, True)
        Label8.Text = ""
        counterNumber = 0
        System.Threading.Thread.Sleep(1000)
        For Each num As String In LstAll.Items
            WA.recheckScript(ChromeDrv, False)
            Task.Factory.StartNew(Sub() WA.NumberExist_old(ChromeDrv, num,
                                                 Sub(status As Boolean)
                                                     Me.Invoke(Sub()
                                                                   Application.DoEvents()
                                                                   NumberVerified(num, status)
                                                               End Sub)
                                                 End Sub))
            Application.DoEvents()
            System.Threading.Thread.Sleep(1000)

            If isStop Then
                Exit For
            End If
        Next



    End Sub

    Public Sub NumberVerified(num As String, status As Boolean)
        Try
            Console.WriteLine(num & " : " & status.ToString)
            If Not isStop Then
                Application.DoEvents()
                If status Then
                    LstWhatsApp.Items.Add(num)
                Else
                    LstNonWhatsapp.Items.Add(num)
                End If

                counterNumber += 1
                ProgressBar1.BeginInvoke(Sub()
                                             ProgressBar1.Value = counterNumber
                                         End Sub)
                LblAllWhatsApp.Text = LstWhatsApp.Items.Count
                LblAllNonWhatsapp.Text = LstNonWhatsapp.Items.Count

                If LstAll.Items.Count = counterNumber Then
                    ChromeDrv.Quit()
                    BtnStop.Visible = False
                    BtnWhatsaAppWeb.Visible = True
                End If

            End If
            If isStop Then
                ChromeDrv.Quit()
                BtnStop.Visible = False
                BtnWhatsaAppWeb.Visible = True
            End If

        Catch ex As Exception

        End Try
    End Sub


End Class