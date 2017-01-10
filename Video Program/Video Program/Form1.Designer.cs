namespace Video_Program
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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnVid1 = new System.Windows.Forms.Button();
            this.btnAud1 = new System.Windows.Forms.Button();
            this.btnVid3 = new System.Windows.Forms.Button();
            this.btnVid2 = new System.Windows.Forms.Button();
            this.btnAud3 = new System.Windows.Forms.Button();
            this.btnAud2 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVid4 = new System.Windows.Forms.Button();
            this.btnAud4 = new System.Windows.Forms.Button();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(720, 480);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // btnVid1
            // 
            this.btnVid1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVid1.Location = new System.Drawing.Point(756, 217);
            this.btnVid1.Name = "btnVid1";
            this.btnVid1.Size = new System.Drawing.Size(75, 23);
            this.btnVid1.TabIndex = 1;
            this.btnVid1.Text = "Video 1";
            this.btnVid1.UseVisualStyleBackColor = true;
            this.btnVid1.Click += new System.EventHandler(this.btnVid1_Click);
            // 
            // btnAud1
            // 
            this.btnAud1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAud1.Location = new System.Drawing.Point(838, 217);
            this.btnAud1.Name = "btnAud1";
            this.btnAud1.Size = new System.Drawing.Size(75, 23);
            this.btnAud1.TabIndex = 2;
            this.btnAud1.Text = "Sound 1";
            this.btnAud1.UseVisualStyleBackColor = true;
            this.btnAud1.Click += new System.EventHandler(this.btnAud1_Click);
            // 
            // btnVid3
            // 
            this.btnVid3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVid3.Location = new System.Drawing.Point(757, 275);
            this.btnVid3.Name = "btnVid3";
            this.btnVid3.Size = new System.Drawing.Size(75, 23);
            this.btnVid3.TabIndex = 3;
            this.btnVid3.Text = "Video 3";
            this.btnVid3.UseVisualStyleBackColor = true;
            this.btnVid3.Click += new System.EventHandler(this.btnVid3_Click);
            // 
            // btnVid2
            // 
            this.btnVid2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVid2.Location = new System.Drawing.Point(757, 246);
            this.btnVid2.Name = "btnVid2";
            this.btnVid2.Size = new System.Drawing.Size(75, 23);
            this.btnVid2.TabIndex = 4;
            this.btnVid2.Text = "Video 2";
            this.btnVid2.UseVisualStyleBackColor = true;
            this.btnVid2.Click += new System.EventHandler(this.btnVid2_Click);
            // 
            // btnAud3
            // 
            this.btnAud3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAud3.Location = new System.Drawing.Point(838, 275);
            this.btnAud3.Name = "btnAud3";
            this.btnAud3.Size = new System.Drawing.Size(75, 23);
            this.btnAud3.TabIndex = 5;
            this.btnAud3.Text = "Sound 3";
            this.btnAud3.UseVisualStyleBackColor = true;
            this.btnAud3.Click += new System.EventHandler(this.btnAud3_Click);
            // 
            // btnAud2
            // 
            this.btnAud2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAud2.Location = new System.Drawing.Point(838, 246);
            this.btnAud2.Name = "btnAud2";
            this.btnAud2.Size = new System.Drawing.Size(75, 23);
            this.btnAud2.TabIndex = 6;
            this.btnAud2.Text = "Sound 2";
            this.btnAud2.UseVisualStyleBackColor = true;
            this.btnAud2.Click += new System.EventHandler(this.btnAud2_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.Location = new System.Drawing.Point(757, 343);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(838, 343);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(589, 401);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(143, 44);
            this.axWindowsMediaPlayer2.TabIndex = 9;
            this.axWindowsMediaPlayer2.Visible = false;
            this.axWindowsMediaPlayer2.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer2_PlayStateChange);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(755, 401);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(739, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type in name:";
            // 
            // btnVid4
            // 
            this.btnVid4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVid4.Location = new System.Drawing.Point(757, 304);
            this.btnVid4.Name = "btnVid4";
            this.btnVid4.Size = new System.Drawing.Size(75, 23);
            this.btnVid4.TabIndex = 14;
            this.btnVid4.Text = "Video 4";
            this.btnVid4.UseVisualStyleBackColor = true;
            this.btnVid4.Click += new System.EventHandler(this.btnVid4_Click);
            // 
            // btnAud4
            // 
            this.btnAud4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAud4.Location = new System.Drawing.Point(838, 304);
            this.btnAud4.Name = "btnAud4";
            this.btnAud4.Size = new System.Drawing.Size(75, 23);
            this.btnAud4.TabIndex = 15;
            this.btnAud4.Text = "Sound 4";
            this.btnAud4.UseVisualStyleBackColor = true;
            this.btnAud4.Click += new System.EventHandler(this.btnAud4_Click);
            // 
            // btnFull
            // 
            this.btnFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFull.Location = new System.Drawing.Point(756, 372);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(75, 23);
            this.btnFull.TabIndex = 16;
            this.btnFull.Text = "Fullscreen";
            this.btnFull.UseVisualStyleBackColor = true;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnRes
            // 
            this.btnRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRes.Location = new System.Drawing.Point(838, 372);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 17;
            this.btnRes.Text = "Reset";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnNum
            // 
            this.btnNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNum.Location = new System.Drawing.Point(818, 142);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(75, 23);
            this.btnNum.TabIndex = 18;
            this.btnNum.Text = "Numbers";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnCat
            // 
            this.btnCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCat.Location = new System.Drawing.Point(818, 84);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(75, 23);
            this.btnCat.TabIndex = 19;
            this.btnCat.Text = "Categories";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnNam
            // 
            this.btnNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNam.Location = new System.Drawing.Point(818, 113);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(75, 23);
            this.btnNam.TabIndex = 20;
            this.btnNam.Text = "Names";
            this.btnNam.UseVisualStyleBackColor = true;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(739, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Button Names";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(795, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(739, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Choose button labels:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(739, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 38);
            this.label3.TabIndex = 27;
            this.label3.Text = "Choose four sound and\r\nvideo combinations:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(925, 504);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNam);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.btnAud4);
            this.Controls.Add(this.btnVid4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAud2);
            this.Controls.Add(this.btnAud3);
            this.Controls.Add(this.btnVid2);
            this.Controls.Add(this.btnVid3);
            this.Controls.Add(this.btnAud1);
            this.Controls.Add(this.btnVid1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Sound and Vision";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnVid1;
        private System.Windows.Forms.Button btnAud1;
        private System.Windows.Forms.Button btnVid3;
        private System.Windows.Forms.Button btnVid2;
        private System.Windows.Forms.Button btnAud3;
        private System.Windows.Forms.Button btnAud2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVid4;
        private System.Windows.Forms.Button btnAud4;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

