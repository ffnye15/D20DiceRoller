Imports System.IO

Public Class Form1


    'defines variable for process scheck
    Dim applicaitonstatus() As Process

    'pulls current dir and assigns to a variable
    Dim wdir As String = My.Computer.FileSystem.CurrentDirectory

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Sizes the window to take up full screen
        sizing()

        ''fetches arguments, here for testing. Function needs... 
        ''to be added to statuschecker. Otherwise defining and importing global
        ''variables is a massive pain in the ass
        'fetcharguments()

        ''runs explorer killer
        explorerkill()

        ''runs check on startup. 
        statuschecker()

        ''starts timer
        Timer1.Start()


    End Sub

    Private Sub statuschecker()
        'Pulls the command line arguments and places into an array
        ''make a global variable
        Dim args = Environment.GetCommandLineArgs()

        'creates a string from arguments starting at 1 (position 0 is the watchdog filename)
        'Define a null string, to which we add the individual arguments
        Dim concatargs As String = ""

        'concatargs = """" & args(1) & """" & " "
        For i = 2 To args.Length - 1
            concatargs = concatargs & (args(i)) & " "
        Next

        ''------------------------------------
        'Timer1.Stop()
        'Dim pathcheck As String = args(1)
        ''Dim argcheck As String = args(2)
        'MessageBox.Show("pathcheck is" & pathcheck)
        ''MessageBox.Show(argcheck)
        'MessageBox.Show("concatenated path is" & concatargs)
        'Timer1.Stop()
        ''------------------------------------

        'check to see if Zamok is alive
        applicaitonstatus = Process.GetProcessesByName("zamok.exe")
        If applicaitonstatus.Count > 0 Then
            'do nothing
        Else
            Try
                Timer1.Stop()
                ''concantenates current direcotry And exe path
                '     MessageBox.Show(concatargs)
                Process.Start(args(1) & concatargs)

                Dim startInfo As New ProcessStartInfo(args(1))



                startInfo.Arguments = concatargs

                Process.Start(startInfo)


                ' Me.Close()
                Timer1.Start()
            Catch
                'resolves error state if Zamok cannot be found. Ends timer to prevent multiple error messages and allow exit.
                MessageBox.Show("Could not start program. Please check arguments. Closing application. There is no god, only your suffering")
                Timer1.Stop()
                Me.Close()
                End
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
        'Pulls the command line arguments
        Dim args = Environment.GetCommandLineArgs()

        'Define a null string, to wich we add the individual arguments
        Dim concatargs As String = ""

        For i = 1 To args.Length - 1
            concatargs = concatargs & (args(i)) & " "
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
