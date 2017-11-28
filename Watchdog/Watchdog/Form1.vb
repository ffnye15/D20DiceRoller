Public Class Form1

    ''' <summary>
    ''' the below is main form load event, which initates the importer module, runs 1st round of watchdog, and sets visual settings
    ''' </summary>

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'runs the importer module, that pulls target data from the INI, assigns 2 global variables from the system settings
        importermodule.iniimporter()
        'this is the target the application will run
        watchdogtarget = My.Settings.watchdogtargetsetting
        'this is the process name the application will check to see if is running
        processname = My.Settings.processname_setting

        Try
            'if explorer is the defined target, then we will exit the application
            If processname = "explorer.exe" Then
                Process.Start("explorer.exe")
                Try
                    Process.Start(kioskassistantpath)
                Catch ex As Exception
                    MsgBox("error starting autostarter")
                End Try
                End
            Else
                Try
                    Process.Start(watchdogtarget)
                Catch ex As Exception
                    MsgBox("Error starting the target applicaiton. If you have selected a custom path, please ensure you have selected a path that exists.")
                End Try

            End If
        Catch
        End Try
        ' sets as watchdog as fullscreen, but should load under the target application
        Call CenterToScreen()
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.Cursor = Cursors.Arrow
        'executes the watchdog routine
        'Watchdog()
        Timer2.Start()
    End Sub


    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick
        'this is the escape function
        Timer1.Stop()
        Timer2.Stop()
        'starts explorer, starts kiosk assistant, kills watchdog
        frmPasswordEntry.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'timer is set to run every 6000 miliseconds, on timer tick it will execute the watchdog routine. This replaces a looping function
        processstarter()
    End Sub

    Public Sub processstarter()
        'Starts the target. this is a little fucky because the target application needs to be run maximized. this also starts the 
        Dim processwithargs As New ProcessStartInfo(watchdogtarget)
        processwithargs.WindowStyle = ProcessWindowStyle.Maximized
        Timer2.Start()
        Process.Start(processwithargs)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'runs the watchdog process checking routine every second. this has its own timer because the watchdog needs to be paused for the password entry screen. This keeps you from 
        '...trying to exit just as the timer ticks over. It's a quality of life feature to keep users from being frustrated. 
        Watchdog()
    End Sub

    Public Sub Watchdog()
        ' looks for defined process, defines the result as a variable
        Dim p() As Process
        p = Process.GetProcessesByName(processname)
        If p.Count > 0 Then
            'application is running, do nuffin
            Timer1.Stop()
        Else
            Try
                'If processname = "explorer.exe" Then
                '    End

                'Else
                Timer1.Start()
                'End If

            Catch
                'stops the timer while you read the error
                Try
                    Timer1.Stop()
                    MsgBox("Error running applicaiton")
                    Timer1.Start()
                Catch
                End Try
            End Try
        End If
    End Sub

End Class
