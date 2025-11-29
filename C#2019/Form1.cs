using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            axSpeechRecognition1.InitControl();

            int iCount = axSpeechRecognition1.GetVoiceCount();
            for (i = 0; i < iCount; i++)
                cboVoice.Items.Add(axSpeechRecognition1.GetVoiceName(i));

            if (cboVoice.Items.Count > 0)
                cboVoice.SelectedIndex = 0;

             iCount = axSpeechRecognition1.GetOutputWaveFormatCount();
            for (i = 0; i < iCount; i++)
                cbowaveformat.Items.Add(axSpeechRecognition1.GetOutputWaveFormatName(i));

            if(cbowaveformat.Items.Count >0)
                cbowaveformat.SelectedIndex = 0;



        }

        private void btnspeak_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter the text");
                return;
            }

            axSpeechRecognition1.SetSelectedVoice(cboVoice.SelectedIndex);
            axSpeechRecognition1.Speak(richTextBox1.Text);
        }

        private void btnSavetoWAV_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter the text");
                return;
            }
            axSpeechRecognition1.SetSelectedVoice(cboVoice.SelectedIndex);

            this.saveFileDialog1.Filter = "Wave File (*.wav)|*.wav";
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                axSpeechRecognition1.SetSelectedOutputWaveFormat(cbowaveformat.SelectedIndex);
                axSpeechRecognition1.SpeakToWave(richTextBox1.Text, saveFileDialog1.FileName);
                MessageBox.Show("Save Completed");

                //axSpeechRecognition1.spe
            }
        }

        private void btnspeakfromtext_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Text File (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();

                axSpeechRecognition1.SetSelectedVoice(cboVoice.SelectedIndex);
                axSpeechRecognition1.SpeakFromText(openFileDialog1.FileName);
            }
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            axSpeechRecognition1.Pause();
        }

        private void btnresume_Click(object sender, EventArgs e)
        {
            axSpeechRecognition1.Resume();
        }

        private void btnspeakfromtexttowave_Click(object sender, EventArgs e)
        {
              this.openFileDialog1.Filter = "Text File (*.txt)|*.txt";
              if (openFileDialog1.ShowDialog() == DialogResult.OK)
              {
                  System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                  richTextBox1.Text = sr.ReadToEnd();
                  sr.Close();
              }

                this.saveFileDialog1.Filter = "Wave File (*.wav)|*.wav";
            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                axSpeechRecognition1.SetSelectedVoice(cboVoice.SelectedIndex);
                axSpeechRecognition1.SpeakFromTextToWave(openFileDialog1.FileName,saveFileDialog1.FileName);
            }
        }

        private void btnplaywav_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Wave File (*.wav)|*.wav";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axSpeechRecognition1.SpeakFromWaveFile(openFileDialog1.FileName);
            }
        }

        private void btnchangeplaybackrate_Click(object sender, EventArgs e)
        {
            axSpeechRecognition1.Rate = Int32.Parse(txtplaybackrate.Text);
        }

        private void btnvolume_Click(object sender, EventArgs e)
        {
            axSpeechRecognition1.Volume = Int32.Parse(txtvolume.Text);
        }

        private void axSpeechRecognition1_SpeakComplete(object sender, EventArgs e)
        {
            MessageBox.Show("Speak Completed");
        }

        private void axSpeechRecognition1_VoiceSentenceStatus(object sender, AxSpeechRecognitionLib._DSpeechRecognitionEvents_VoiceSentenceStatusEvent e)
        {

           
        }

        private void axSpeechRecognition1_VoiceWordsStatus(object sender, AxSpeechRecognitionLib._DSpeechRecognitionEvents_VoiceWordsStatusEvent e)
        {
           
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            axSpeechRecognition1.Stop();
        }

      
       
    }
}
