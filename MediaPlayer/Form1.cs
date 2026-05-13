using System;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wmpVideo.uiMode = "none";
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WMV files (*.wmv)|*.wmv|MP4 files (*.mp4)|*.mp4|AVI files (*.avi)|*.avi|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                wmpVideo.URL = ofd.FileName;
                wmpVideo.Ctlcontrols.stop();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
        }
    }
}