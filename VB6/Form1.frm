VERSION 5.00
Object = "{362DD430-5322-4C89-870A-FC7E4475524B}#1.0#0"; "SpeechRecognition.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "comdlg32.ocx"
Begin VB.Form Form1 
   Caption         =   "Speech Recognition Demo"
   ClientHeight    =   5970
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   8250
   LinkTopic       =   "Form1"
   ScaleHeight     =   5970
   ScaleWidth      =   8250
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command5 
      Caption         =   "Play from wave file"
      Height          =   375
      Left            =   3720
      TabIndex        =   20
      Top             =   4080
      Width           =   2415
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Speak to wave file from text file"
      Height          =   375
      Left            =   3720
      TabIndex        =   19
      Top             =   3600
      Width           =   2415
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Speak from text file"
      Height          =   375
      Left            =   3720
      TabIndex        =   18
      Top             =   3120
      Width           =   2415
   End
   Begin VB.ComboBox cbowaveformat 
      Height          =   315
      Left            =   240
      Style           =   2  'Dropdown List
      TabIndex        =   16
      Top             =   4200
      Width           =   3255
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   360
      Top             =   4680
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton cmdspeaktowave 
      Caption         =   "Speak to Wave"
      Height          =   375
      Left            =   3720
      TabIndex        =   15
      Top             =   2640
      Width           =   2415
   End
   Begin VB.Frame Frame1 
      Height          =   1935
      Left            =   3720
      TabIndex        =   5
      Top             =   600
      Width           =   4455
      Begin VB.CommandButton cmdstop 
         Caption         =   "Stop"
         Height          =   375
         Left            =   3600
         TabIndex        =   21
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton Command4 
         Caption         =   "Change"
         Height          =   255
         Left            =   2520
         TabIndex        =   14
         Top             =   1560
         Width           =   975
      End
      Begin VB.TextBox txtvolume 
         Height          =   285
         Left            =   1920
         TabIndex        =   13
         Text            =   "100"
         Top             =   1560
         Width           =   495
      End
      Begin VB.CommandButton Command3 
         Caption         =   "Change"
         Height          =   255
         Left            =   1080
         TabIndex        =   11
         Top             =   1200
         Width           =   855
      End
      Begin VB.TextBox txtplaybackrate 
         Height          =   285
         Left            =   120
         TabIndex        =   10
         Text            =   "0"
         Top             =   1200
         Width           =   735
      End
      Begin VB.CommandButton cmdresume 
         Caption         =   "Resume"
         Height          =   375
         Left            =   2400
         TabIndex        =   8
         Top             =   240
         Width           =   1095
      End
      Begin VB.CommandButton cmdpause 
         Caption         =   "Pause"
         Height          =   375
         Left            =   1320
         TabIndex        =   7
         Top             =   240
         Width           =   975
      End
      Begin VB.CommandButton cmdspeak 
         Caption         =   "Speak"
         Height          =   375
         Left            =   120
         TabIndex        =   6
         Top             =   240
         Width           =   1095
      End
      Begin VB.Label Label4 
         Caption         =   "Volume (from 0 -100)"
         Height          =   255
         Left            =   120
         TabIndex        =   12
         Top             =   1560
         Width           =   1695
      End
      Begin VB.Label Label3 
         Caption         =   "Playback rate ( from -10 to 10) default is 0"
         Height          =   255
         Left            =   120
         TabIndex        =   9
         Top             =   840
         Width           =   3255
      End
   End
   Begin VB.TextBox txtText 
      Height          =   2295
      Left            =   120
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   3
      Top             =   1440
      Width           =   3375
   End
   Begin VB.ComboBox cboVoice 
      Height          =   315
      Left            =   120
      Style           =   2  'Dropdown List
      TabIndex        =   2
      Top             =   600
      Width           =   3255
   End
   Begin SpeechRecognitionLib.SpeechRecognition SpeechRecognition1 
      Height          =   1695
      Left            =   6240
      TabIndex        =   0
      Top             =   3120
      Width           =   1215
      _Version        =   65536
      _ExtentX        =   2143
      _ExtentY        =   2990
      _StockProps     =   0
   End
   Begin VB.Label Label5 
      Caption         =   "Output Wave Format"
      Height          =   255
      Left            =   240
      TabIndex        =   17
      Top             =   3840
      Width           =   2655
   End
   Begin VB.Label Label2 
      Caption         =   "Enter your text"
      Height          =   255
      Left            =   120
      TabIndex        =   4
      Top             =   1080
      Width           =   1095
   End
   Begin VB.Label Label1 
      Caption         =   "Voice"
      Height          =   255
      Left            =   120
      TabIndex        =   1
      Top             =   240
      Width           =   855
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdpause_Click()
  SpeechRecognition1.Pause
End Sub

Private Sub cmdresume_Click()
  SpeechRecognition1.Resume
End Sub

Private Sub cmdspeak_Click()

If Me.txtText.Text = "" Then
 MsgBox "Please enter the text"
Exit Sub
 
End If

   SpeechRecognition1.SetSelectedVoice cboVoice.ListIndex
   
   SpeechRecognition1.Speak txtText.Text
End Sub

Private Sub cmdstop_Click()
SpeechRecognition1.Stop

End Sub

Private Sub Command1_Click()

 Dim iFile As Long
 Dim strFilename As String
 Dim strTheData As String
 Dim bResult As Boolean


  iFile = FreeFile

  
Me.CommonDialog1.Filter = "Text Files (*.txt)|*.txt"
CommonDialog1.ShowOpen
strFilename = CommonDialog1.FileName

If strFilename <> "" Then

Open strFilename For Input As #iFile
strTheData = StrConv(InputB(LOF(iFile), iFile), vbUnicode)
  Close #iFile
txtText.Text = strTheData
 
  
SpeechRecognition1.SetSelectedVoice cboVoice.ListIndex


bResult = SpeechRecognition1.SpeakFromText(CommonDialog1.FileName)
            
Else
    MsgBox "Please enter the text"
End If
           
End Sub

Private Sub cmdspeaktowave_Click()
Dim bResult As Boolean
 
If Me.txtText.Text = "" Then
    MsgBox "Please enter the text"
    Exit Sub
End If


 Me.CommonDialog1.Filter = "Wave Files (*.wav)|*.wav"

CommonDialog1.ShowSave

SpeechRecognition1.SetSelectedVoice cboVoice.ListIndex
  
SpeechRecognition1.SetSelectedOutputWaveFormat cbowaveformat.ListIndex
bResult = SpeechRecognition1.SpeakToWave(txtText.Text, CommonDialog1.FileName)
 
If bResult Then
    MsgBox "Save Completed"
Else
    MsgBox "Save Failed"
    
End If

End Sub

Private Sub Command2_Click()
Dim iFile As Long
Dim strFilename As String
Dim strTheData As String
Dim bResult As Boolean


iFile = FreeFile
  
Me.CommonDialog1.Filter = "Text Files (*.txt)|*.txt"
CommonDialog1.ShowOpen
strFilename = CommonDialog1.FileName

If strFilename <> "" Then

Open strFilename For Input As #iFile
strTheData = StrConv(InputB(LOF(iFile), iFile), vbUnicode)
  Close #iFile
txtText.Text = strTheData
 
 
CommonDialog1.Filter = "Wave Files (*.wav)|*.wav"
CommonDialog1.ShowSave

SpeechRecognition1.SetSelectedVoice cboVoice.ListIndex
SpeechRecognition1.SetSelectedOutputWaveFormat cbowaveformat.ListIndex
bResult = SpeechRecognition1.SpeakFromTextToWave(txtText.Text, CommonDialog1.FileName)

If bResult Then
    MsgBox "Save Completed"
Else
    MsgBox "Save Failed"
End If


  

End If



 
End Sub

Private Sub Command5_Click()

  
Me.CommonDialog1.Filter = "Wave Files (*.wav)|*.wav"
CommonDialog1.ShowOpen
SpeechRecognition1.SpeakFromWaveFile CommonDialog1.FileName
End Sub

Private Sub Form_Load()
Dim iCount As Integer
Dim i As Integer

Me.SpeechRecognition1.InitControl

 iCount = SpeechRecognition1.GetVoiceCount()
        For i = 0 To iCount - 1
            cboVoice.AddItem SpeechRecognition1.GetVoiceName(i)

        Next
        
 If cboVoice.ListCount > 0 Then
     cboVoice.ListIndex = 0
 End If

 iCount = SpeechRecognition1.GetOutputWaveFormatCount()
        For i = 0 To iCount - 1
            cbowaveformat.AddItem SpeechRecognition1.GetOutputWaveFormatName(i)
        Next

  If cbowaveformat.ListCount > 0 Then
       cbowaveformat.ListIndex = 0
  End If
       



End Sub

Private Sub SpeechRecognition1_SpeakComplete()
MsgBox "Speak Completed"
End Sub
