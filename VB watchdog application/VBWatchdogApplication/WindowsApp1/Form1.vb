Public Class Form1
    Dim applicaitonstatus() As Process
    Dim explorerprocess() As Process = System.Diagnostics.Process.GetProcessesByName("explorer")

    'pulls current dir and assigns to a variable
    Dim wdir As String = My.Computer.FileSystem.CurrentDirectory

    Private Sub statuschecker()
        'check to see if Zamok is alive
        applicaitonstatus = Process.GetProcessesByName("zamok.exe")
        If applicaitonstatus.Count > 0 Then
            'do nothing
        Else
            Try
                'concantenates current direcotry and exe path
                Process.Start(wdir + "\Zamok.exe")
            Catch
                MessageBox.Show("Could not start Zamok.exe! Please check application path.")
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'runs check on timer tick
        statuschecker()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'kills explorer immediately
        'kill explorer
        'System.Diagnostics.Process.Start("taskkill.exe", " /f /im explorer.exe")
        'For Each pkill As Process In explorerprocess
        '    pkill.Kill()
        'Next
        'handles visuals of application
        PictureBox1.Top = (Me.ClientSize.Height / 2) - (PictureBox1.Height / 2)
        PictureBox1.Left = (Me.ClientSize.Width / 2) - (PictureBox1.Width / 2)
        Call CenterToScreen()
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Cursor = Cursors.Arrow



        'runs check on startup. 
        statuschecker()

        'starts timer
        Timer1.Start()
    End Sub



End Class
