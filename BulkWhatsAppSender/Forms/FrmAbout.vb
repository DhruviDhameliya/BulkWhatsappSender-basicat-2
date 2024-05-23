Public Class FrmAbout
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductNameLabel.Text = ApplicationTitle
        CompanyNameLabel.Text = Brand.CompanyName
        VersionLabel.Text = "Version" + Appv
        BuildLabel.Text = "Build " + BuildDate
        WebSiteLinkLabel.Text = Brand.WebsiteURL
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles FaceBookPictureBox.Click
        Process.Start(Brand.FaceBookURL)
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles WhatsAppPictureBox.Click
        Process.Start(Brand.SupportURL)
    End Sub
    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles WebSiteLinkLabel.LinkClicked
        Process.Start(Brand.WebsiteURL)
    End Sub

    Private Sub EmailPictureBox_Click(sender As Object, e As EventArgs) Handles EmailPictureBox.Click
        Process.Start("mailto:" + Brand.SupportEmail)
    End Sub



    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles TwitterPictureBox.Click
        Process.Start(Brand.TwitterURL)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles InstagramPictureBox.Click
        Process.Start(Brand.InstagramUrl)
    End Sub
End Class