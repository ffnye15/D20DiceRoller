Public Class Form1

    'defines variable for process scheck
    Dim applicaitonstatus() As Process

    'pulls current dir and assigns to a variable
    Dim wdir As String = My.Computer.FileSystem.CurrentDirectory

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Sizes the window to take up full screen
        'sizing()

        ''runs explorer killer
        'explorerkill()

        ''runs check on startup. 
        'statuschecker()

        ''starts timer
        'Timer1.Start()

        'fetches arguments, here for testing
        fetcharguments()
    End Sub

    Private Sub statuschecker()

        'check to see if Zamok is alive
        applicaitonstatus = Process.GetProcessesByName("zamok.exe")
        If applicaitonstatus.Count > 0 Then
            'do nothing
        Else
            Try
                'concantenates current direcotry and exe path
                'Process.Start(wdir + "\Zamok.exe", "--kiosk-printing")
                Process.Start(concat)
            Catch
                'resolves error state if Zamok cannot be found. Ends timer to prevent multiple error messages and allow exit.
                MessageBox.Show("Could not start Zamok.exe! Please check application path.")
                Timer1.Stop()
            End Try
        End If
    End Sub

    Private Sub explorerkill()
        'gets process by name and kills dat shit yo
        Shell("taskkill /f /im explorer.exe")
    End Sub

    Sub RestartExplorer()
        'restarts explorer
        Process.Start("c:\windows\explorer.exe")

    End Sub

    'Private Sub btnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
    '    'test function. remove from final build
    '    'Me.Close()
    'End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'handles closing event of the application. on proper shutdown, this will restart explorer. 
        RestartExplorer()
    End Sub

    Public Sub fetcharguments()
        Dim concatargs As String = ""
        Dim clArgs() As String = Environment.GetCommandLineArgs()
        ' Hold the command line values

        For Each arg As String In clArgs = {1 To 3}
            concatargs = concatargs & " " & arg
        Next

        MessageBox.Show(concatargs)
    End Sub

    Private Sub sizing()
        'centers button in middle of window
        btnKill.Top = (Me.ClientSize.Height / 2) - (btnKill.Height / 2)
        btnKill.Left = (Me.ClientSize.Width / 2) - (btnKill.Width / 2)

        'sets sizing and layout of application
        Call CenterToScreen()
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'runs check on timer tick
        statuschecker()
    End Sub
End Class
