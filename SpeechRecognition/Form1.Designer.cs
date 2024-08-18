
namespace SpeechRecognition
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVoice = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTextToAudio = new System.Windows.Forms.Button();
            this.barVolume = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barSpeed = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVoice
            // 
            this.txtVoice.Location = new System.Drawing.Point(31, 112);
            this.txtVoice.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoice.Multiline = true;
            this.txtVoice.Name = "txtVoice";
            this.txtVoice.Size = new System.Drawing.Size(1009, 484);
            this.txtVoice.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(31, 638);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(165, 73);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(212, 638);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(165, 73);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "For Evana, Joana and Meera";
            // 
            // btnTextToAudio
            // 
            this.btnTextToAudio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTextToAudio.Location = new System.Drawing.Point(886, 638);
            this.btnTextToAudio.Margin = new System.Windows.Forms.Padding(4);
            this.btnTextToAudio.Name = "btnTextToAudio";
            this.btnTextToAudio.Size = new System.Drawing.Size(156, 73);
            this.btnTextToAudio.TabIndex = 4;
            this.btnTextToAudio.Text = "Text to Audio";
            this.btnTextToAudio.UseVisualStyleBackColor = true;
            this.btnTextToAudio.Click += new System.EventHandler(this.btnTextToAudio_Click);
            // 
            // barVolume
            // 
            this.barVolume.Location = new System.Drawing.Point(118, 734);
            this.barVolume.Margin = new System.Windows.Forms.Padding(4);
            this.barVolume.Name = "barVolume";
            this.barVolume.Size = new System.Drawing.Size(923, 45);
            this.barVolume.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 734);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Volume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 818);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Speed";
            // 
            // barSpeed
            // 
            this.barSpeed.Location = new System.Drawing.Point(118, 818);
            this.barSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.barSpeed.Minimum = -10;
            this.barSpeed.Name = "barSpeed";
            this.barSpeed.Size = new System.Drawing.Size(923, 45);
            this.barSpeed.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(712, 889);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Speech to text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 946);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barVolume);
            this.Controls.Add(this.btnTextToAudio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtVoice);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Speech recognition";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoice;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTextToAudio;
        private System.Windows.Forms.TrackBar barVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar barSpeed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbVoice;
    }
}

