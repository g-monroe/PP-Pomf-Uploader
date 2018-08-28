Imports Pomf_Uploader
Imports System.IO
Imports Microsoft.Win32

Public Class Main
    Dim File As String = ""
    Dim UpdateLink As String = ""
    Private Sub btnCancel_ButtonClicked(Checked As Boolean) Handles btnCancel.ButtonClicked
        'Close Application
        Environment.Exit(0)
    End Sub
    Function ValidImage(filepath As String) As Boolean
        Try
            'Check if Image can be an Image in GDI+.
            Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(filepath)
        Catch imgEX As OutOfMemoryException
            Return False
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Public Sub CreateContextMenu()
        'Move EXE to known "safe" Directory.
        Dim newPath As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Pomf Uploader\"
        Dim newpathEXE As String = newPath & "Pomf Uploader.exe"
        Dim myApp As String = Application.ExecutablePath
        'Check if Directory Exists
        If Not Directory.Exists(newPath) Then
            If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
                'Create new Path
                IO.Directory.CreateDirectory(newPath)
                'Copy EXE to new Path.
                IO.File.Copy(myApp, newpathEXE)
                'Create Registry
                My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Classes\*\shell\Pomf Upload")
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Classes\*\shell\Pomf Upload", "Icon", newpathEXE)
                My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Classes\*\shell\Pomf Upload\Command")
                Dim CommandReg As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Classes\*\shell\Pomf Upload\Command", True)
                CommandReg.SetValue("", Chr(34) & newpathEXE & Chr(34) & " " & Chr(34) & "%1" & Chr(34))
            Else
                MessageBox.Show("To create the registry for the application; We ask you to run the application in admin for the first time running Pomf Uploader.", "Please run application as Admin!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub
    Public Async Function CheckUpdate() As Task(Of Boolean)
        Using Updater = New UpdateProvider
            Dim response = Await (Updater.Update)
            If Not response.Contains("http") Then
                Return False
            Else
                UpdateLink = response
                Return True
            End If
        End Using
    End Function
    Private Async Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Set Location.
        Dim screenSize As Size = Screen.PrimaryScreen.WorkingArea.Size
        Dim screenLocation As Point = Screen.PrimaryScreen.WorkingArea.Location
        Dim formSize As Size = Me.Size
        Me.Location = New Point(screenLocation.X + (screenSize.Width - formSize.Width), screenLocation.Y + (screenSize.Height - formSize.Height))

        ' CreateContextMenu()
        'Get File Path
        For Each sArg As String In My.Application.CommandLineArgs
            File &= sArg & ""
        Next
        'If File = "" Then
        'Environment.Exit(0)
        ' End If

        'Check For Update.
        If Await CheckUpdate() Then
            Alert.Type = sNotification.Types.Warning
            Alert.Refresh()
            btnUpdate.Visible = True
        End If
        'Check File Path.
        ' If Not File = "" Then
        'Validate that its an Image.
        'If ValidImage(File) Then
        'Upload Image
        Using pomf As New PomfProvider
                    Dim response = Await (pomf.UploadBytes(File))
                    'Error Uploading Image
                    If Not response.Contains("http") Then
                    tblink.Text = "Error!"
                    MsgBox(response)
                    Alert.Type = sNotification.Types.Error_
                    Else
                        'Successful Upload
                        tblink.LeftButtonClickable = True
                        tblink.RightButtonClickable = True
                        tblink.Text = response
                        Alert.Type = sNotification.Types.Success
                        Alert.Refresh()
                    End If
                End Using
        ' Else
        'This is a File
        'Using pomf As New PomfProvider
        '        Dim response = Await (pomf.UploadFile(File))
        '        'Error Uploading File
        '        If response.Contains("false") Then
        '        tblink.Text = "Error!"
        '        MsgBox(response)
        '        Alert.Type = sNotification.Types.Error_
        '        Else
        '            'Successful Upload
        '            tblink.LeftButtonClickable = True
        '            tblink.RightButtonClickable = True
        '            tblink.Text = response
        '            Alert.Type = sNotification.Types.Success
        '            Alert.Refresh()
        '        End If
        '    End Using
        'End If
        '  End If
    End Sub

    Private Sub tblink_LeftbtnClicked(Type As sTextbox._Type, data As String) Handles tblink.LeftbtnClicked
        My.Computer.Clipboard.SetText(tblink.Text)
        Environment.Exit(0)
    End Sub

    Private Sub tblink_RightbtnClicked(Type As sTextbox._Type, data As String) Handles tblink.RightbtnClicked
        If tblink.Text.Contains("http") Then
            Process.Start(tblink.Text)
            Environment.Exit(0)
        End If
    End Sub

    Private Sub btnUpdate_ButtonClicked(Checked As Boolean) Handles btnUpdate.ButtonClicked
        If UpdateLink.Contains("http") Then
            Process.Start(UpdateLink)
            Environment.Exit(0)
        End If
    End Sub
End Class
