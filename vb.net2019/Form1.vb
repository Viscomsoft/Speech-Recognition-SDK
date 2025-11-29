Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim iCount As Integer
        Dim i As Integer
        AxSpeechRecognition1.InitControl()

        iCount = AxSpeechRecognition1.GetVoiceCount()
        For i = 0 To iCount - 1
            cboVoice.Items.Add(AxSpeechRecognition1.GetVoiceName(i))

        Next
        If cboVoice.Items.Count > 0 Then
            cboVoice.SelectedIndex = 0
        End If

        iCount = AxSpeechRecognition1.GetOutputWaveFormatCount()
        For i = 0 To iCount - 1
            cbowaveformat.Items.Add(AxSpeechRecognition1.GetOutputWaveFormatName(i))
        Next

        If cbowaveformat.Items.Count > 0 Then
            cbowaveformat.SelectedIndex = 0
        End If
       


    End Sub

    Private Sub btnspeak_Click(sender As System.Object, e As System.EventArgs) Handles btnspeak.Click
        If richTextBox1.Text.Length = 0 Then

            MessageBox.Show("Please enter the text")
            Exit Sub
        End If


        AxSpeechRecognition1.SetSelectedVoice(cboVoice.SelectedIndex)
        AxSpeechRecognition1.Speak(richTextBox1.Text)
    End Sub

    Private Sub btnpause_Click(sender As System.Object, e As System.EventArgs) Handles btnpause.Click
        AxSpeechRecognition1.Pause()
    End Sub

    Private Sub btnresume_Click(sender As System.Object, e As System.EventArgs) Handles btnresume.Click
        AxSpeechRecognition1.Resume()
    End Sub

    Private Sub btnchangeplaybackrate_Click(sender As System.Object, e As System.EventArgs) Handles btnchangeplaybackrate.Click
        AxSpeechRecognition1.Rate = Int32.Parse(txtplaybackrate.Text)
    End Sub

    Private Sub btnvolume_Click(sender As System.Object, e As System.EventArgs) Handles btnvolume.Click
        AxSpeechRecognition1.Volume = Int32.Parse(txtvolume.Text)
    End Sub

    Private Sub btnSavetoWAV_Click(sender As System.Object, e As System.EventArgs) Handles btnSavetoWAV.Click
        If richTextBox1.Text.Length = 0 Then
            MessageBox.Show("Please enter the text")
            Return
        End If

        AxSpeechRecognition1.SetSelectedVoice(cboVoice.SelectedIndex)

        SaveFileDialog1.Filter = "Wave File (*.wav)|*.wav"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            AxSpeechRecognition1.SetSelectedOutputWaveFormat(cbowaveformat.SelectedIndex)
            AxSpeechRecognition1.SpeakToWave(richTextBox1.Text, SaveFileDialog1.FileName)
            MessageBox.Show("Save Completed")

        End If

    End Sub

    Private Sub btnspeakfromtext_Click(sender As System.Object, e As System.EventArgs) Handles btnspeakfromtext.Click
        OpenFileDialog1.Filter = "Text File (*.txt)|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(OpenFileDialog1.FileName)
            richTextBox1.Text = sr.ReadToEnd()
            sr.Close()

            AxSpeechRecognition1.SetSelectedVoice(cboVoice.SelectedIndex)
            AxSpeechRecognition1.SpeakFromText(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub btnspeakfromtexttowave_Click(sender As System.Object, e As System.EventArgs) Handles btnspeakfromtexttowave.Click
        OpenFileDialog1.Filter = "Text File (*.txt)|*.txt"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(OpenFileDialog1.FileName)
            richTextBox1.Text = sr.ReadToEnd()
            sr.Close()
        End If


        SaveFileDialog1.Filter = "Wave File (*.wav)|*.wav"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            AxSpeechRecognition1.SetSelectedVoice(cboVoice.SelectedIndex)
            AxSpeechRecognition1.SetSelectedOutputWaveFormat(cbowaveformat.SelectedIndex)

            AxSpeechRecognition1.SpeakFromTextToWave(OpenFileDialog1.FileName, SaveFileDialog1.FileName)
            MessageBox.Show("Save Completed")
        End If

    End Sub

    Private Sub btnplaywav_Click(sender As System.Object, e As System.EventArgs) Handles btnplaywav.Click
        OpenFileDialog1.Filter = "Wave File (*.wav)|*.wav"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            AxSpeechRecognition1.SpeakFromWaveFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub AxSpeechRecognition1_SpeakComplete(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxSpeechRecognition1.SpeakComplete
        MessageBox.Show("Speak Completed")
    End Sub

    Private Sub BtnStop_Click(sender As System.Object, e As System.EventArgs) Handles BtnStop.Click
        AxSpeechRecognition1.Stop()
    End Sub
End Class
