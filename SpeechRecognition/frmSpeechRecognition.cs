using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Recognition;


namespace SpeechRecognition
{
    public partial class frmSpeechRecognition : Form
    {

        private SpeechRecognitionEngine recognizer;
        private bool isRecognitionRunning = true; // Track whether recognition is currently running


        public frmSpeechRecognition()
        {
            InitializeComponent();
        }

        private void frmSpeechRecognition_Load(object sender, EventArgs e)
        {

            recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-UK"));
            recognizer.SetInputToDefaultAudioDevice();
            Grammar grammar = new DictationGrammar();
            recognizer.LoadGrammar(grammar);
            recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(VoiceRecognizer);
            recognizer.RecognizeAsync(RecognizeMode.Multiple);


        }

        private void VoiceRecognizer(object sender, SpeechRecognizedEventArgs e)
        {
            txtText.Text += e.Result.Text + "\r\n";
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (isRecognitionRunning)
            {
                recognizer.RecognizeAsyncCancel();
                btnStartStop.Text = "Start Speech Recognition";
            }
            else
            {
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
                btnStartStop.Text = "Stop Speech Recognition";
            }

            isRecognitionRunning = !isRecognitionRunning; // Toggle the recognition state

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtText.Clear();

        }
    }
}
