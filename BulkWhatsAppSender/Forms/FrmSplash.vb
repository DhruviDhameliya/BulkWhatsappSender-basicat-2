Imports OpenQA.Selenium.Chrome
Public Class FrmSplash
    Private Sub FrmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblVersion.Text = "v " + Appv
        LblBuidDate.Text = "Build:" + BuildDate

    End Sub

    Private Sub FrmSplash_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Application.DoEvents()
        Try
            InitAPI()
            Do
                System.Threading.Thread.Sleep(100)
                Application.DoEvents()
            Loop Until allloaded()

        Catch ex As Exception

            System.Threading.Thread.Sleep(1000)
        End Try

    End Sub

End Class