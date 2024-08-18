using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;
 


namespace SpeechRecognition
{
    public partial class Form1 : Form
    {

        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        public   Choices clist = new Choices();


     

        public Form1()
        {
            InitializeComponent();
        }

         

        private void Form1_Load(object sender, EventArgs e)
        {
            barVolume.Value = 10;
            barSpeed.Value = 0;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;




            clist.Add(new string[]
                {"Hello","How are you", "what is the current time", "Open Chrome", "Thank you", "Close"}
                );



            Grammar gr = new Grammar(new GrammarBuilder(clist));

            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += sre_speachrecognised;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);


            

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error");
            }




        }

        private void sre_speachrecognised(object sender, SpeechRecognizedEventArgs e)
        {
            //  "Hello","How are you", "what is the current time", "Open Chrome", "Thank you", "Close"
            try
            {

                switch (e.Result.Text.ToString())
            {

                case "Hello":
                    ss.SpeakAsync("Hello How are you? How can i help you?");

                    break;

                case "How are you":
                    ss.SpeakAsync("I am fine. Thank you.How are you? How can i help you?");

                    break;


                case "what is the current time":
                    ss.SpeakAsync("Current time is. " + DateTime.Now.ToLongTimeString()) ;

                    break;

                case "Thank you":
                    ss.SpeakAsync("You are welcome. Can i help you further?");

                    break;

                case "Open Chrome":
                    ss.SpeakAsync("Trying to open  chrome");
                    Process.Start("Chrome", "https://www.google.co.uk");

                    break;


                case "Close":
                    ss.SpeakAsync("Thank you. Catch you later. Bye.");

                    Application.Exit();

                    break;

                    default:

                 ss.SpeakAsync("Please explain it in detail.");
                      

                        break;


                }



            txtVoice.Text += e.Result.Text.ToString() + Environment.NewLine;



            

            }
                   
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error");
            }



}


       
        private void btnStop_Click(object sender, EventArgs e)
        {
            sre.RecognizeAsyncStop();
            btnStart.Enabled = true;

        }

        private void btnTextToAudio_Click(object sender, EventArgs e)
        {


            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume =barVolume.Value;
            synthesizer.Rate = barSpeed.Value  ;// -2;     
 

 
            synthesizer.SpeakAsync(txtVoice.Text.Trim());

        }
    }
}
