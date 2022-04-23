<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.mountedrootbtn = New System.Windows.Forms.Button()
        Me.oscdimgbtn = New System.Windows.Forms.Button()
        Me.oscdimgtext = New System.Windows.Forms.TextBox()
        Me.mountedroottext = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.efisysbintext = New System.Windows.Forms.TextBox()
        Me.efisysbinbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.destinationtext = New System.Windows.Forms.TextBox()
        Me.destinationbtn = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.makeisobtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.etfsbootcomtext = New System.Windows.Forms.TextBox()
        Me.etfsbootcombtn = New System.Windows.Forms.Button()
        Me.finaloutputtext = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(640, 511)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(300, 96)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'mountedrootbtn
        '
        Me.mountedrootbtn.Location = New System.Drawing.Point(659, 89)
        Me.mountedrootbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mountedrootbtn.Name = "mountedrootbtn"
        Me.mountedrootbtn.Size = New System.Drawing.Size(162, 41)
        Me.mountedrootbtn.TabIndex = 2
        Me.mountedrootbtn.Text = "Browse"
        Me.mountedrootbtn.UseVisualStyleBackColor = True
        '
        'oscdimgbtn
        '
        Me.oscdimgbtn.Location = New System.Drawing.Point(658, 30)
        Me.oscdimgbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.oscdimgbtn.Name = "oscdimgbtn"
        Me.oscdimgbtn.Size = New System.Drawing.Size(162, 42)
        Me.oscdimgbtn.TabIndex = 3
        Me.oscdimgbtn.Text = "Browse"
        Me.oscdimgbtn.UseVisualStyleBackColor = True
        '
        'oscdimgtext
        '
        Me.oscdimgtext.AcceptsTab = True
        Me.oscdimgtext.Location = New System.Drawing.Point(128, 31)
        Me.oscdimgtext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.oscdimgtext.Name = "oscdimgtext"
        Me.oscdimgtext.Size = New System.Drawing.Size(523, 26)
        Me.oscdimgtext.TabIndex = 4
        '
        'mountedroottext
        '
        Me.mountedroottext.Location = New System.Drawing.Point(128, 96)
        Me.mountedroottext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mountedroottext.Name = "mountedroottext"
        Me.mountedroottext.Size = New System.Drawing.Size(523, 26)
        Me.mountedroottext.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Path to oscdimg.exe"
        '
        'efisysbintext
        '
        Me.efisysbintext.Location = New System.Drawing.Point(126, 239)
        Me.efisysbintext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.efisysbintext.Name = "efisysbintext"
        Me.efisysbintext.Size = New System.Drawing.Size(523, 26)
        Me.efisysbintext.TabIndex = 8
        '
        'efisysbinbtn
        '
        Me.efisysbinbtn.Location = New System.Drawing.Point(659, 223)
        Me.efisysbinbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.efisysbinbtn.Name = "efisysbinbtn"
        Me.efisysbinbtn.Size = New System.Drawing.Size(162, 42)
        Me.efisysbinbtn.TabIndex = 7
        Me.efisysbinbtn.Text = "Browse"
        Me.efisysbinbtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(520, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Path to efisys.bin on USB (*USB*\EFI\MICROSOFT\BOOT\EFISYS.BIN)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Select letter of USB (i.e. G:\)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(122, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(336, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Enter Path where generated ISO will be stored"
        '
        'destinationtext
        '
        Me.destinationtext.Location = New System.Drawing.Point(126, 320)
        Me.destinationtext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.destinationtext.Name = "destinationtext"
        Me.destinationtext.Size = New System.Drawing.Size(523, 26)
        Me.destinationtext.TabIndex = 12
        '
        'destinationbtn
        '
        Me.destinationbtn.Location = New System.Drawing.Point(658, 319)
        Me.destinationbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.destinationbtn.Name = "destinationbtn"
        Me.destinationbtn.Size = New System.Drawing.Size(162, 42)
        Me.destinationbtn.TabIndex = 11
        Me.destinationbtn.Text = "Save"
        Me.destinationbtn.UseVisualStyleBackColor = True
        '
        'makeisobtn
        '
        Me.makeisobtn.Location = New System.Drawing.Point(126, 511)
        Me.makeisobtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.makeisobtn.Name = "makeisobtn"
        Me.makeisobtn.Size = New System.Drawing.Size(294, 96)
        Me.makeisobtn.TabIndex = 14
        Me.makeisobtn.Text = "Make ISO"
        Me.makeisobtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(454, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Path to etfsboot.com on USB (*USB*\BOOT\ETFSBOOT.COM)"
        '
        'etfsbootcomtext
        '
        Me.etfsbootcomtext.Location = New System.Drawing.Point(128, 161)
        Me.etfsbootcomtext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.etfsbootcomtext.Name = "etfsbootcomtext"
        Me.etfsbootcomtext.Size = New System.Drawing.Size(522, 26)
        Me.etfsbootcomtext.TabIndex = 16
        '
        'etfsbootcombtn
        '
        Me.etfsbootcombtn.Location = New System.Drawing.Point(658, 156)
        Me.etfsbootcombtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.etfsbootcombtn.Name = "etfsbootcombtn"
        Me.etfsbootcombtn.Size = New System.Drawing.Size(162, 42)
        Me.etfsbootcombtn.TabIndex = 15
        Me.etfsbootcombtn.Text = "Browse"
        Me.etfsbootcombtn.UseVisualStyleBackColor = True
        '
        'finaloutputtext
        '
        Me.finaloutputtext.Location = New System.Drawing.Point(126, 404)
        Me.finaloutputtext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.finaloutputtext.Name = "finaloutputtext"
        Me.finaloutputtext.Size = New System.Drawing.Size(525, 26)
        Me.finaloutputtext.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(123, 379)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Final CMD Output"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(828, 385)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 52)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Show Full Command"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(659, 385)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 52)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Copy to Clipboard"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoCheck = False
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(850, 40)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(106, 24)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.Text = "File Exists"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoCheck = False
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(850, 163)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(106, 24)
        Me.CheckBox2.TabIndex = 23
        Me.CheckBox2.Text = "File Exists"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoCheck = False
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(850, 233)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(106, 24)
        Me.CheckBox3.TabIndex = 24
        Me.CheckBox3.Text = "File Exists"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 91)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Download ADK"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 156)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 101)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Install oscdimg"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 728)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.finaloutputtext)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.etfsbootcomtext)
        Me.Controls.Add(Me.etfsbootcombtn)
        Me.Controls.Add(Me.makeisobtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.destinationtext)
        Me.Controls.Add(Me.destinationbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.efisysbintext)
        Me.Controls.Add(Me.efisysbinbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mountedroottext)
        Me.Controls.Add(Me.oscdimgtext)
        Me.Controls.Add(Me.oscdimgbtn)
        Me.Controls.Add(Me.mountedrootbtn)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "WinPE USB to ISO Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents mountedrootbtn As Button
    Friend WithEvents oscdimgbtn As Button
    Friend WithEvents oscdimgtext As TextBox
    Friend WithEvents mountedroottext As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents efisysbintext As TextBox
    Friend WithEvents efisysbinbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents destinationtext As TextBox
    Friend WithEvents destinationbtn As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents makeisobtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents etfsbootcomtext As TextBox
    Friend WithEvents etfsbootcombtn As Button
    Friend WithEvents finaloutputtext As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
