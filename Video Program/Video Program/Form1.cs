using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Program
{
    public partial class Form1 : Form
    {
        int aCounter = 0, vCounter = 0, endCount = 0;
        bool vflag1 = false, vflag2 = false, aflag1 = false, aflag2 = false;
        string[] audRecord = new string[4];
        string[] vidRecord = new string[4];

        public Form1()
        {
            InitializeComponent();

            //resizes video player as window resizes
            axWindowsMediaPlayer1.Location = new Point(12, 12);
            axWindowsMediaPlayer1.Size = new Size(this.ClientSize.Width - 209, this.ClientSize.Height - 51 + SystemInformation.CaptionHeight);
            axWindowsMediaPlayer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //plays media if four audio and video files are selected
            if (aCounter >= 4 && vCounter >= 4)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("You must pick four video and four sound clips before pressing play.", "Error");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //stop both media players
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            //sets the videoplayer to fullscreen if it is playing content
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            //resets the program back to original state mid-playing
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            if (axWindowsMediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer2.Ctlcontrols.stop();
            }
            reset();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //sets a flag if the video player finishes it's current content
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                vflag1 = true;
                endCount++;
                if (endCount >= 8)
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(".\\Records\\UserRecord.txt", true);
                    writer.WriteLine();
                    writer.WriteLine();
                    writer.WriteLine(txtName.Text);
                    for (int loop = 0; loop < 4; loop++)
                    {
                        writer.WriteLine(vidRecord[loop] + " " + audRecord[loop]);
                    }
                    writer.Close();
                    writer.Dispose();
                    reset();
                }
            }
            //determines if video player should keep playing and resume stopped audio player or stop to wait for audio player to end
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying && vflag1 == true)
            {
                if (aflag2 == true)
                {
                    vflag1 = false;
                    aflag2 = false;
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    vflag1 = false;
                    vflag2 = true;
                }
            }
        }

        private void axWindowsMediaPlayer2_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //sets a flag if the audio player finishes it's current content
            if (axWindowsMediaPlayer2.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                aflag1 = true;
            }
            //determines if audio player should keep playing and resume stopped video player or stop to wait for video player to end
            if (axWindowsMediaPlayer2.playState == WMPLib.WMPPlayState.wmppsPlaying && aflag1 == true)
            {
                if (vflag2 == true)
                {
                    aflag1 = false;
                    vflag2 = false;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                else
                {
                    axWindowsMediaPlayer2.Ctlcontrols.stop();
                    aflag1 = false;
                    aflag2 = true;
                }
            }
        }

        private void reset()
        {
            //function to reset most of program values to original state
            axWindowsMediaPlayer1.currentPlaylist.clear();
            axWindowsMediaPlayer2.currentPlaylist.clear();
            listBox1.Items.Clear();
            txtName.Clear();
            aCounter = 0;
            vCounter = 0;
            endCount = 0;
            vflag1 = false;
            vflag2 = false;
            aflag1 = false;
            aflag2 = false;
        }

        private void videoButton(int ident)
        {
            //function to add items to video playlist depending on what button is pressed
            if (vCounter < 4)
            {
                axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(".\\Videos\\intro" + (vCounter + 1) + ".mp4"));
                axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(".\\Videos\\vid" + ident + ".mp4"));
                switch (ident)
                {
                    case 1:
                        listBox1.Items.Add(btnVid1.Text + " added");
                        vidRecord[vCounter] = btnVid1.Text;
                        break;
                    case 2:
                        listBox1.Items.Add(btnVid2.Text + " added");
                        vidRecord[vCounter] = btnVid2.Text;
                        break;
                    case 3:
                        listBox1.Items.Add(btnVid3.Text + " added");
                        vidRecord[vCounter] = btnVid3.Text;
                        break;
                    case 4:
                        listBox1.Items.Add(btnVid4.Text + " added");
                        vidRecord[vCounter] = btnVid4.Text;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("4 videos already selected", "Error");
            }
            vCounter++;
        }

        private void audioButton(int ident)
        {
            //function to add items to audio playlist depending on what button is pressed
            if (aCounter < 4)
            {
                axWindowsMediaPlayer2.currentPlaylist.appendItem(axWindowsMediaPlayer2.newMedia(".\\Audio\\filler" + (aCounter + 1) + ".m4a"));
                axWindowsMediaPlayer2.currentPlaylist.appendItem(axWindowsMediaPlayer2.newMedia(".\\Audio\\aud" + ident + ".m4a"));
                switch (ident)
                {
                    case 1:
                        listBox1.Items.Add(btnAud1.Text + " added.");
                        audRecord[aCounter] = btnAud1.Text;
                        break;
                    case 2:
                        listBox1.Items.Add(btnAud2.Text + " added.");
                        audRecord[aCounter] = btnAud2.Text;
                        break;
                    case 3:
                        listBox1.Items.Add(btnAud3.Text + " added.");
                        audRecord[aCounter] = btnAud3.Text;
                        break;
                    case 4:
                        listBox1.Items.Add(btnAud4.Text + " added.");
                        audRecord[aCounter] = btnAud4.Text;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("4 videos already selected", "Error");
            }
            aCounter++;
        }

        private void btnVid1_Click(object sender, EventArgs e)
        {
            videoButton(1);
        }

        private void btnVid2_Click(object sender, EventArgs e)
        {
            videoButton(2);
        }

        private void btnVid3_Click(object sender, EventArgs e)
        {
            videoButton(3);
        }

        private void btnVid4_Click(object sender, EventArgs e)
        {
            videoButton(4);
        }

        private void btnAud1_Click(object sender, EventArgs e)
        {
            audioButton(1);
        }

        private void btnAud2_Click(object sender, EventArgs e)
        {
            audioButton(2);
        }

        private void btnAud3_Click(object sender, EventArgs e)
        {
            audioButton(3);
        }

        private void btnAud4_Click(object sender, EventArgs e)
        {
            audioButton(4);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            //changes names of buttons
            btnVid1.Text = "Natural";
            btnVid2.Text = "Mystical";
            btnVid3.Text = "Social";
            btnVid4.Text = "Commercial";

            btnAud1.Text = "Natural";
            btnAud2.Text = "Mystical";
            btnAud3.Text = "Social";
            btnAud4.Text = "Commercial";
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            //changes names of buttons
            btnVid1.Text = "1";
            btnVid2.Text = "2";
            btnVid3.Text = "3";
            btnVid4.Text = "4";

            btnAud1.Text = "1";
            btnAud2.Text = "2";
            btnAud3.Text = "3";
            btnAud4.Text = "4";
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            //changes names of buttons
            btnVid1.Text = "Close";
            btnVid2.Text = "Expanse";
            btnVid3.Text = "Divert";
            btnVid4.Text = "Horror";

            btnAud1.Text = "Life";
            btnAud2.Text = "Chant";
            btnAud3.Text = "Connect";
            btnAud4.Text = "Pachinko";
        }
    }
}