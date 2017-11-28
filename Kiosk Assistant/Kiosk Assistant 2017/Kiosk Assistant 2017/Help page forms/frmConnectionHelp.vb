Public Class frmConnectionHelp

    Private Sub subloadwebbrowser()
        'this will pull the path defined from the INI and create a working path for the file it tries to load. File must be some kind of HTML.
        Dim mynameisurl As String = My.Application.Info.DirectoryPath + "\" + btnInternettarget
        Try
            Me.WebBrowser1.Navigate(mynameisurl)
        Catch
            MsgBox("Error loading content. This should not show, as the browser should instead 404")
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub browserZamokConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'basic display stuff, runs above routine
        Call CenterToScreen()
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        subloadwebbrowser()
    End Sub
End Class