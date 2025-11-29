namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axSpeechRecognition1 = new AxSpeechRecognitionLib.AxSpeechRecognition();
            this.cboVoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbowaveformat = new System.Windows.Forms.ComboBox();
            this.btnSavetoWAV = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnspeakfromtext = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnspeakfromtexttowave = new System.Windows.Forms.Button();
            this.btnplaywav = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnvolume = new System.Windows.Forms.Button();
            this.txtvolume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnresume = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnspeak = new System.Windows.Forms.Button();
            this.btnchangeplaybackrate = new System.Windows.Forms.Button();
            this.txtplaybackrate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axSpeechRecognition1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axSpeechRecognition1
            // 
            this.axSpeechRecognition1.Enabled = true;
            this.axSpeechRecognition1.Location = new System.Drawing.Point(854, 289);
            this.axSpeechRecognition1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.axSpeechRecognition1.Name = "axSpeechRecognition1";
            this.axSpeechRecognition1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSpeechRecognition1.OcxState")));
            this.axSpeechRecognition1.Size = new System.Drawing.Size(756, 302);
            this.axSpeechRecognition1.TabIndex = 0;
            this.axSpeechRecognition1.SpeakComplete += new System.EventHandler(this.axSpeechRecognition1_SpeakComplete);
            this.axSpeechRecognition1.VoiceWordsStatus += new AxSpeechRecognitionLib._DSpeechRecognitionEvents_VoiceWordsStatusEventHandler(this.axSpeechRecognition1_VoiceWordsStatus);
            this.axSpeechRecognition1.VoiceSentenceStatus += new AxSpeechRecognitionLib._DSpeechRecognitionEvents_VoiceSentenceStatusEventHandler(this.axSpeechRecognition1_VoiceSentenceStatus);
            // 
            // cboVoice
            // 
            this.cboVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoice.FormattingEnabled = true;
            this.cboVoice.Location = new System.Drawing.Point(72, 40);
            this.cboVoice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboVoice.Name = "cboVoice";
            this.cboVoice.Size = new System.Drawing.Size(287, 21);
            this.cboVoice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voice";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 112);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 208);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "enter the text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output Wave Format";
            // 
            // cbowaveformat
            // 
            this.cbowaveformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbowaveformat.FormattingEnabled = true;
            this.cbowaveformat.Location = new System.Drawing.Point(20, 387);
            this.cbowaveformat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbowaveformat.Name = "cbowaveformat";
            this.cbowaveformat.Size = new System.Drawing.Size(318, 21);
            this.cbowaveformat.TabIndex = 9;
            // 
            // btnSavetoWAV
            // 
            this.btnSavetoWAV.Location = new System.Drawing.Point(369, 165);
            this.btnSavetoWAV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSavetoWAV.Name = "btnSavetoWAV";
            this.btnSavetoWAV.Size = new System.Drawing.Size(131, 36);
            this.btnSavetoWAV.TabIndex = 10;
            this.btnSavetoWAV.Text = "Speak to Wave";
            this.btnSavetoWAV.UseVisualStyleBackColor = true;
            this.btnSavetoWAV.Click += new System.EventHandler(this.btnSavetoWAV_Click);
            // 
            // btnspeakfromtext
            // 
            this.btnspeakfromtext.Location = new System.Drawing.Point(369, 217);
            this.btnspeakfromtext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnspeakfromtext.Name = "btnspeakfromtext";
            this.btnspeakfromtext.Size = new System.Drawing.Size(131, 36);
            this.btnspeakfromtext.TabIndex = 11;
            this.btnspeakfromtext.Text = "Speak From Text File";
            this.btnspeakfromtext.UseVisualStyleBackColor = true;
            this.btnspeakfromtext.Click += new System.EventHandler(this.btnspeakfromtext_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnspeakfromtexttowave
            // 
            this.btnspeakfromtexttowave.Location = new System.Drawing.Point(369, 266);
            this.btnspeakfromtexttowave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnspeakfromtexttowave.Name = "btnspeakfromtexttowave";
            this.btnspeakfromtexttowave.Size = new System.Drawing.Size(131, 36);
            this.btnspeakfromtexttowave.TabIndex = 14;
            this.btnspeakfromtexttowave.Text = "Speak to Wave From Text File";
            this.btnspeakfromtexttowave.UseVisualStyleBackColor = true;
            this.btnspeakfromtexttowave.Click += new System.EventHandler(this.btnspeakfromtexttowave_Click);
            // 
            // btnplaywav
            // 
            this.btnplaywav.Location = new System.Drawing.Point(369, 324);
            this.btnplaywav.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnplaywav.Name = "btnplaywav";
            this.btnplaywav.Size = new System.Drawing.Size(131, 36);
            this.btnplaywav.TabIndex = 15;
            this.btnplaywav.Text = "Play From Wave File";
            this.btnplaywav.UseVisualStyleBackColor = true;
            this.btnplaywav.Click += new System.EventHandler(this.btnplaywav_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Volume (from 0 -100)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnstop);
            this.groupBox1.Controls.Add(this.btnvolume);
            this.groupBox1.Controls.Add(this.txtvolume);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnresume);
            this.groupBox1.Controls.Add(this.btnpause);
            this.groupBox1.Controls.Add(this.btnspeak);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(369, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(436, 130);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(309, 20);
            this.btnstop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(64, 35);
            this.btnstop.TabIndex = 24;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnvolume
            // 
            this.btnvolume.Location = new System.Drawing.Point(338, 102);
            this.btnvolume.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnvolume.Name = "btnvolume";
            this.btnvolume.Size = new System.Drawing.Size(58, 19);
            this.btnvolume.TabIndex = 23;
            this.btnvolume.Text = "Change";
            this.btnvolume.UseVisualStyleBackColor = true;
            this.btnvolume.Click += new System.EventHandler(this.btnvolume_Click);
            // 
            // txtvolume
            // 
            this.txtvolume.Location = new System.Drawing.Point(259, 100);
            this.txtvolume.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtvolume.Name = "txtvolume";
            this.txtvolume.Size = new System.Drawing.Size(50, 20);
            this.txtvolume.TabIndex = 22;
            this.txtvolume.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Playback rate (from -10 to 10, default 0)";
            // 
            // btnresume
            // 
            this.btnresume.Location = new System.Drawing.Point(232, 21);
            this.btnresume.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnresume.Name = "btnresume";
            this.btnresume.Size = new System.Drawing.Size(64, 35);
            this.btnresume.TabIndex = 16;
            this.btnresume.Text = "Resume";
            this.btnresume.UseVisualStyleBackColor = true;
            this.btnresume.Click += new System.EventHandler(this.btnresume_Click);
            // 
            // btnpause
            // 
            this.btnpause.Location = new System.Drawing.Point(152, 21);
            this.btnpause.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(64, 35);
            this.btnpause.TabIndex = 15;
            this.btnpause.Text = "Pause";
            this.btnpause.UseVisualStyleBackColor = true;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnspeak
            // 
            this.btnspeak.Location = new System.Drawing.Point(6, 20);
            this.btnspeak.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnspeak.Name = "btnspeak";
            this.btnspeak.Size = new System.Drawing.Size(125, 36);
            this.btnspeak.TabIndex = 14;
            this.btnspeak.Text = "Speak";
            this.btnspeak.UseVisualStyleBackColor = true;
            this.btnspeak.Click += new System.EventHandler(this.btnspeak_Click);
            // 
            // btnchangeplaybackrate
            // 
            this.btnchangeplaybackrate.Location = new System.Drawing.Point(707, 97);
            this.btnchangeplaybackrate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnchangeplaybackrate.Name = "btnchangeplaybackrate";
            this.btnchangeplaybackrate.Size = new System.Drawing.Size(58, 19);
            this.btnchangeplaybackrate.TabIndex = 21;
            this.btnchangeplaybackrate.Text = "Change";
            this.btnchangeplaybackrate.UseVisualStyleBackColor = true;
            this.btnchangeplaybackrate.Click += new System.EventHandler(this.btnchangeplaybackrate_Click);
            // 
            // txtplaybackrate
            // 
            this.txtplaybackrate.Location = new System.Drawing.Point(641, 95);
            this.txtplaybackrate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtplaybackrate.Name = "txtplaybackrate";
            this.txtplaybackrate.Size = new System.Drawing.Size(37, 20);
            this.txtplaybackrate.TabIndex = 20;
            this.txtplaybackrate.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 380);
            this.Controls.Add(this.btnchangeplaybackrate);
            this.Controls.Add(this.txtplaybackrate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnplaywav);
            this.Controls.Add(this.btnspeakfromtexttowave);
            this.Controls.Add(this.btnspeakfromtext);
            this.Controls.Add(this.btnSavetoWAV);
            this.Controls.Add(this.cbowaveformat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboVoice);
            this.Controls.Add(this.axSpeechRecognition1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axSpeechRecognition1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxSpeechRecognitionLib.AxSpeechRecognition axSpeechRecognition1;
        private System.Windows.Forms.ComboBox cboVoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbowaveformat;
        private System.Windows.Forms.Button btnSavetoWAV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnspeakfromtext;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnspeakfromtexttowave;
        private System.Windows.Forms.Button btnplaywav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnvolume;
        private System.Windows.Forms.TextBox txtvolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnresume;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnspeak;
        private System.Windows.Forms.Button btnchangeplaybackrate;
        private System.Windows.Forms.TextBox txtplaybackrate;
        private System.Windows.Forms.Button btnstop;
    }
}

