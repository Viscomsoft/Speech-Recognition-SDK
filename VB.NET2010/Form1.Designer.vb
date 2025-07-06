<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxSpeechRecognition1 = New AxSpeechRecognitionLib.AxSpeechRecognition()
        Me.btnplaywav = New System.Windows.Forms.Button()
        Me.btnspeakfromtexttowave = New System.Windows.Forms.Button()
        Me.btnspeakfromtext = New System.Windows.Forms.Button()
        Me.btnSavetoWAV = New System.Windows.Forms.Button()
        Me.cbowaveformat = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cboVoice = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btnspeak = New System.Windows.Forms.Button()
        Me.btnpause = New System.Windows.Forms.Button()
        Me.btnresume = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtvolume = New System.Windows.Forms.TextBox()
        Me.btnvolume = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtplaybackrate = New System.Windows.Forms.TextBox()
        Me.btnchangeplaybackrate = New System.Windows.Forms.Button()
        CType(Me.AxSpeechRecognition1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxSpeechRecognition1
        '
        Me.AxSpeechRecognition1.Enabled = True
        Me.AxSpeechRecognition1.Location = New System.Drawing.Point(802, 204)
        Me.AxSpeechRecognition1.Name = "AxSpeechRecognition1"
        Me.AxSpeechRecognition1.OcxState = CType(resources.GetObject("AxSpeechRecognition1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxSpeechRecognition1.Size = New System.Drawing.Size(183, 171)
        Me.AxSpeechRecognition1.TabIndex = 0
        '
        'btnplaywav
        '
        Me.btnplaywav.Location = New System.Drawing.Point(497, 351)
        Me.btnplaywav.Name = "btnplaywav"
        Me.btnplaywav.Size = New System.Drawing.Size(175, 41)
        Me.btnplaywav.TabIndex = 32
        Me.btnplaywav.Text = "Play From Wave File"
        Me.btnplaywav.UseVisualStyleBackColor = True
        '
        'btnspeakfromtexttowave
        '
        Me.btnspeakfromtexttowave.Location = New System.Drawing.Point(497, 284)
        Me.btnspeakfromtexttowave.Name = "btnspeakfromtexttowave"
        Me.btnspeakfromtexttowave.Size = New System.Drawing.Size(175, 41)
        Me.btnspeakfromtexttowave.TabIndex = 31
        Me.btnspeakfromtexttowave.Text = "Speak to Wave From Text File"
        Me.btnspeakfromtexttowave.UseVisualStyleBackColor = True
        '
        'btnspeakfromtext
        '
        Me.btnspeakfromtext.Location = New System.Drawing.Point(497, 227)
        Me.btnspeakfromtext.Name = "btnspeakfromtext"
        Me.btnspeakfromtext.Size = New System.Drawing.Size(175, 41)
        Me.btnspeakfromtext.TabIndex = 30
        Me.btnspeakfromtext.Text = "Speak From Text File"
        Me.btnspeakfromtext.UseVisualStyleBackColor = True
        '
        'btnSavetoWAV
        '
        Me.btnSavetoWAV.Location = New System.Drawing.Point(497, 167)
        Me.btnSavetoWAV.Name = "btnSavetoWAV"
        Me.btnSavetoWAV.Size = New System.Drawing.Size(175, 41)
        Me.btnSavetoWAV.TabIndex = 29
        Me.btnSavetoWAV.Text = "Speak to Wave"
        Me.btnSavetoWAV.UseVisualStyleBackColor = True
        '
        'cbowaveformat
        '
        Me.cbowaveformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbowaveformat.FormattingEnabled = True
        Me.cbowaveformat.Location = New System.Drawing.Point(31, 424)
        Me.cbowaveformat.Name = "cbowaveformat"
        Me.cbowaveformat.Size = New System.Drawing.Size(423, 23)
        Me.cbowaveformat.TabIndex = 28
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(28, 396)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(151, 15)
        Me.label3.TabIndex = 27
        Me.label3.Text = "Output Wave Format"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(28, 78)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(119, 15)
        Me.label2.TabIndex = 26
        Me.label2.Text = "enter the text"
        '
        'richTextBox1
        '
        Me.richTextBox1.Location = New System.Drawing.Point(20, 106)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(462, 239)
        Me.richTextBox1.TabIndex = 25
        Me.richTextBox1.Text = ""
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(47, 15)
        Me.label1.TabIndex = 24
        Me.label1.Text = "Voice"
        '
        'cboVoice
        '
        Me.cboVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVoice.FormattingEnabled = True
        Me.cboVoice.Location = New System.Drawing.Point(101, 23)
        Me.cboVoice.Name = "cboVoice"
        Me.cboVoice.Size = New System.Drawing.Size(381, 23)
        Me.cboVoice.TabIndex = 23
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(8, 118)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(167, 15)
        Me.label5.TabIndex = 19
        Me.label5.Text = "Volume (from 0 -100)"
        '
        'btnspeak
        '
        Me.btnspeak.Location = New System.Drawing.Point(8, 23)
        Me.btnspeak.Name = "btnspeak"
        Me.btnspeak.Size = New System.Drawing.Size(167, 41)
        Me.btnspeak.TabIndex = 14
        Me.btnspeak.Text = "Speak"
        Me.btnspeak.UseVisualStyleBackColor = True
        '
        'btnpause
        '
        Me.btnpause.Location = New System.Drawing.Point(226, 24)
        Me.btnpause.Name = "btnpause"
        Me.btnpause.Size = New System.Drawing.Size(85, 40)
        Me.btnpause.TabIndex = 15
        Me.btnpause.Text = "Pause"
        Me.btnpause.UseVisualStyleBackColor = True
        '
        'btnresume
        '
        Me.btnresume.Location = New System.Drawing.Point(345, 24)
        Me.btnresume.Name = "btnresume"
        Me.btnresume.Size = New System.Drawing.Size(77, 40)
        Me.btnresume.TabIndex = 16
        Me.btnresume.Text = "Resume"
        Me.btnresume.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(4, 86)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(335, 15)
        Me.label4.TabIndex = 19
        Me.label4.Text = "Playback rate (from -10 to 10, default 0)"
        '
        'txtvolume
        '
        Me.txtvolume.Location = New System.Drawing.Point(345, 115)
        Me.txtvolume.Name = "txtvolume"
        Me.txtvolume.Size = New System.Drawing.Size(66, 25)
        Me.txtvolume.TabIndex = 22
        Me.txtvolume.Text = "100"
        '
        'btnvolume
        '
        Me.btnvolume.Location = New System.Drawing.Point(451, 118)
        Me.btnvolume.Name = "btnvolume"
        Me.btnvolume.Size = New System.Drawing.Size(78, 22)
        Me.btnvolume.TabIndex = 23
        Me.btnvolume.Text = "Change"
        Me.btnvolume.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtplaybackrate)
        Me.groupBox1.Controls.Add(Me.btnchangeplaybackrate)
        Me.groupBox1.Controls.Add(Me.btnvolume)
        Me.groupBox1.Controls.Add(Me.txtvolume)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.btnresume)
        Me.groupBox1.Controls.Add(Me.btnpause)
        Me.groupBox1.Controls.Add(Me.btnspeak)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Location = New System.Drawing.Point(497, 2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(582, 159)
        Me.groupBox1.TabIndex = 35
        Me.groupBox1.TabStop = False
        '
        'txtplaybackrate
        '
        Me.txtplaybackrate.Location = New System.Drawing.Point(345, 78)
        Me.txtplaybackrate.Name = "txtplaybackrate"
        Me.txtplaybackrate.Size = New System.Drawing.Size(66, 25)
        Me.txtplaybackrate.TabIndex = 35
        Me.txtplaybackrate.Text = "0"
        '
        'btnchangeplaybackrate
        '
        Me.btnchangeplaybackrate.Location = New System.Drawing.Point(451, 77)
        Me.btnchangeplaybackrate.Name = "btnchangeplaybackrate"
        Me.btnchangeplaybackrate.Size = New System.Drawing.Size(78, 22)
        Me.btnchangeplaybackrate.TabIndex = 36
        Me.btnchangeplaybackrate.Text = "Change"
        Me.btnchangeplaybackrate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1423, 495)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnplaywav)
        Me.Controls.Add(Me.btnspeakfromtexttowave)
        Me.Controls.Add(Me.btnspeakfromtext)
        Me.Controls.Add(Me.btnSavetoWAV)
        Me.Controls.Add(Me.cbowaveformat)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cboVoice)
        Me.Controls.Add(Me.AxSpeechRecognition1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxSpeechRecognition1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxSpeechRecognition1 As AxSpeechRecognitionLib.AxSpeechRecognition
    Private WithEvents btnplaywav As System.Windows.Forms.Button
    Private WithEvents btnspeakfromtexttowave As System.Windows.Forms.Button
    Private WithEvents btnspeakfromtext As System.Windows.Forms.Button
    Private WithEvents btnSavetoWAV As System.Windows.Forms.Button
    Private WithEvents cbowaveformat As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cboVoice As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents btnspeak As System.Windows.Forms.Button
    Private WithEvents btnpause As System.Windows.Forms.Button
    Private WithEvents btnresume As System.Windows.Forms.Button
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtvolume As System.Windows.Forms.TextBox
    Private WithEvents btnvolume As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txtplaybackrate As System.Windows.Forms.TextBox
    Private WithEvents btnchangeplaybackrate As System.Windows.Forms.Button

End Class
