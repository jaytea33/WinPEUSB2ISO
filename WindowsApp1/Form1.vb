Public Class Form1
    
    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs)

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("C:\Program Files (x86)\Windows Kits\10\Assessment and Deployment Kit\Deployment Tools\amd64\Oscdimg\oscdimg.exe") Then
            'MessageBox.Show("Default oscdimg directory found!")
            oscdimgtext.Text = "C:\Program Files (x86)\Windows Kits\10\Assessment and Deployment Kit\Deployment Tools\amd64\Oscdimg\oscdimg.exe"
            finaloutputtext.Text = "C:\Program Files (x86)\Windows Kits\10\Assessment and Deployment Kit\Deployment Tools\amd64\Oscdimg\oscdimg.exe"
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If

        If oscdimgtext.Text.Contains(" ") Then
            oscdimgtext.Text = """" & oscdimgtext.Text & """"
            finaloutputtext.Text = """" & finaloutputtext.Text & """"
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub

    Private Sub OpenFileDialog1_FileOk_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles mountedrootbtn.Click
        Dim fld As New FolderBrowserDialog()
        If fld.ShowDialog() = Windows.Forms.DialogResult.OK Then
            mountedroottext.Text = fld.SelectedPath
            etfsbootcomtext.Text = fld.SelectedPath + "BOOT\etfsboot.com"
            efisysbintext.Text = fld.SelectedPath + "EFI\MICROSOFT\BOOT\efisys.bin"
            finaloutputtext.Text = fld.SelectedPath
        End If

        If My.Computer.FileSystem.FileExists(fld.SelectedPath + "BOOT\etfsboot.com") Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If

        If My.Computer.FileSystem.FileExists(fld.SelectedPath + "EFI\MICROSOFT\BOOT\efisys.bin") Then
            CheckBox3.Checked = True
        Else
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles oscdimgbtn.Click
        Dim oscdimgvar As String
        oscdimgvar = oscdimgtext.Text
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "OSCDIMG (*oscdimg.exe*)|*oscdimg.exe"
        ofd.InitialDirectory = "C:\Program Files (x86)\Windows Kits\10\Assessment and Deployment Kit\Deployment Tools\amd64\Oscdimg"
        OpenFileDialog1.Filter = "COM Files (*.com*)|*.com"
        If ofd.ShowDialog() = DialogResult.OK Then
            oscdimgtext.Text = ofd.FileName
            oscdimgvar = oscdimgtext.Text
            finaloutputtext.Text = ofd.FileName
        End If

        If oscdimgtext.Text.Contains(" ") Then
            oscdimgtext.Text = """" & oscdimgtext.Text & """"
            finaloutputtext.Text = ofd.FileName
        End If

        If My.Computer.FileSystem.FileExists(oscdimgvar) Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles oscdimgtext.TextChanged
        
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles mountedroottext.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles efisysbinbtn.Click
        Dim ofd As New OpenFileDialog()
        ofd.InitialDirectory = ("::{20D04FE0-3AEA-1069-A2D8-08002B30309D}")
        ofd.Filter = "EFISYS.BIN File (EFISYS.BIN)|EFISYS.BIN"
        If ofd.ShowDialog() = DialogResult.OK Then
            efisysbintext.Text = ofd.FileName
            finaloutputtext.Text = ofd.FileName
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles efisysbintext.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles destinationbtn.Click
        Dim isodestination As String
        isodestination = destinationtext.Text
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "ISO Files (*.iso*)|*.iso"
        sfd.FileName = "WinPE"
        sfd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        If sfd.ShowDialog() = DialogResult.OK Then
            destinationtext.Text = sfd.FileName
            isodestination = destinationtext.Text
            finaloutputtext.Text = sfd.FileName
        End If

        If destinationtext.Text.Contains(" ") Then
            destinationtext.Text = """" & destinationtext.Text & """"
            finaloutputtext.Text = sfd.FileName
        End If

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles destinationtext.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles makeisobtn.Click
        Dim finaloutput As String
        finaloutput = finaloutputtext.Text
        Process.Start("cmd", "/k " + finaloutput)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles etfsbootcombtn.Click
        Dim ofd As New OpenFileDialog()
        ofd.InitialDirectory = ("::{20D04FE0-3AEA-1069-A2D8-08002B30309D}")
        ofd.Filter = "ETFSBOOT.COM File (ETFSBOOT.COM)|ETFSBOOT.COM"
        If ofd.ShowDialog() = DialogResult.OK Then
            etfsbootcomtext.Text = ofd.FileName
            finaloutputtext.Text = ofd.FileName
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles etfsbootcomtext.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles finaloutputtext.TextChanged
        Dim oscdimgvar As String
        Dim etfsbootvar As String
        Dim efisysvar As String
        Dim mountedroot As String
        Dim isodestination As String
        Dim finaloutput As String
        Dim quote As String

        oscdimgvar = oscdimgtext.Text
        etfsbootvar = etfsbootcomtext.Text
        efisysvar = efisysbintext.Text
        mountedroot = mountedroottext.Text
        isodestination = destinationtext.Text
        finaloutput = finaloutputtext.Text
        quote = Chr(34)


        If oscdimgtext.Text.Contains(" ") And destinationtext.Text.Contains(" ") Then
            'MessageBox.Show("Save path cannot contain spaces due to syntax limitations. Please choose a directory to save the ISO without spaces")
            finaloutputtext.Text = quote + oscdimgvar + " " + "-m -o -u2 -udfver102 -bootdata:2#p0,e,b" + etfsbootvar + "#pEF,e,b" + efisysvar + " " + mountedroot + " " + isodestination + quote
        Else

            finaloutputtext.Text = oscdimgvar + " " + "-m -o -u2 -udfver102 -bootdata:2#p0,e,b" + etfsbootvar + "#pEF,e,b" + efisysvar + " " + mountedroot + " " + isodestination
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim finaloutput As String
        finaloutput = finaloutputtext.Text
        MessageBox.Show(finaloutput)
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Dim finaloutput As String
        finaloutput = finaloutputtext.Text
        Clipboard.SetText(finaloutput)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If CheckBox1.Checked = True Then
            MessageBox.Show("WTF are you doing? You already have the necessary oscdimg file! Quitting due to FUBAR exception")
            End
        End If

        If My.Computer.FileSystem.FileExists("C:\adk\adksetup.exe") Then
            MessageBox.Show("adksetup.exe already exists! Either delete the file or try installing oscdimg")
            'Application.Exit()
        Else
            MessageBox.Show("File will be downloaded to C:\adk. Approximately 2MB")
            My.Computer.Network.DownloadFile("https://download.microsoft.com/download/1/f/d/1fd2291e-c0e9-4ae0-beae-fbbe0fe41a5a/adk/adksetup.exe", "c:\adk\adksetup.exe")
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("File will be installed to C:\Program Files (x86)\Windows Kits\10. Download is approximately 96MB")
        Process.Start("cmd", "/c " + "C:\adk\adksetup.exe /installpath ""C:\Program Files (x86)\Windows Kits\10"" /features OptionId.DeploymentTools""")
        'C:\adk\adksetup.exe /quiet /installpath "C:\Program Files (x86)\Windows Kits\10" /features OptionId.DeploymentTools
    End Sub
End Class
