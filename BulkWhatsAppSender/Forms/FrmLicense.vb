Imports System.ComponentModel
Imports System.Web

Public Class FrmLicense
    Private Sub FrmLicense_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
        Me.Dispose()
    End Sub
    Private Sub FrmLicense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Activate Application"
        Dim ordernumber = GetSetting(ApplicationTitle, "request", "key", "")
        Dim ordernumberExist = ChackOrderNumberExist()
        If (ordernumber <> "0" And ordernumber <> "" And ordernumberExist) Then
            If appversion = 1 Then
                requestkeyTextBox.Text = "BWMS - " + ordernumber
            Else
                requestkeyTextBox.Text = "BWMSCAT - " + ordernumber
            End If
            Show()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles copyButton.Click
        Clipboard.SetText(requestkeyTextBox.Text)
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles licensekeyTextBox.TextChanged
        Dim licenseData = CheckCurrentLicence(Trim(licensekeyTextBox.Text))
        If licenseData("status").ToString() = "1" Then
            licensestatusLabel.Text = GetTranslation("BWS_VALID_UNTILL") & licenseData("exp_date")
        Else
            licensestatusLabel.Text = GetTranslation("BWS_INVALID_LICENSE") & " : " & licenseData("description")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        On Error Resume Next
        Application.Exit()
        Application.ExitThread()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles activateButton.Click
        Dim licenseData = CheckCurrentLicence(Trim(licensekeyTextBox.Text))
        If licenseData("status").ToString() = "1" Then
            licensestatusLabel.Text = GetTranslation("BWS_VALID_UNTILL") & licenseData("exp_date")
            SaveSetting(ApplicationTitle, "license", "key", Trim(licensekeyTextBox.Text))
            MsgBox(GetTranslation("BWS_LICENSE_ACTIVATED"), MsgBoxStyle.Information, ApplicationTitle)
            FrmMain.Label3.Text = GetTranslation("BWS_LICENSE_VALID") & licenseData("exp_date") & vbNewLine & "Licence Number : " & Trim(licensekeyTextBox.Text)
            Me.Hide()
        Else
            licensestatusLabel.Text = GetTranslation("BWS_INVALID_LICENSE") & " : " & licenseData("description")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mobile = Trim(TextBox1.Text).Replace("+", "")
        TextBox1.Text = mobile
        If (mobile <> "" And IsNumeric(mobile)) Then
            Dim req = GetDriveSerialNumber(mobile)
            If (IsNumeric(req) And req <> 0) Then
                If appversion = 1 Then
                    requestkeyTextBox.Text = "BWMS - " + req
                Else
                    requestkeyTextBox.Text = "BWMSCAT - " + req
                End If
                SaveSetting(ApplicationTitle, "request", "key", req)
                Show()
            Else
                Label5.Text = "Something Went Wrong"
            End If
        Else
            Label5.Text = "Please Enter Valid Mobile Number"
        End If
    End Sub
    Private Sub Show()
        Label1.Visible = True
        requestkeyTextBox.Visible = True
        Label2.Visible = True
        copyButton.Visible = True
        Button2.Visible = True
        Label3.Visible = True
        licensekeyTextBox.Visible = True
        cancelButton.Visible = True
        activateButton.Visible = True
        licensestatusLabel.Visible = True
        Label4.Visible = False
        TextBox1.Visible = False
        Button1.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start(Brand.SupportURL + "&text=My Order Number Is " + requestkeyTextBox.Text + " Please Provide license")
    End Sub
End Class