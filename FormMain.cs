using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Group3_GameSnack
{
    public partial class FormMain : Form
    {
        SoundPlayer splayer = new SoundPlayer(@"D:\ITHCMUTE\Project\Project 1\sound.wav");
        public FormMain()
        {
            InitializeComponent();
            splayer.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splayer.PlayLooping();
            btnMute.Visible = true;
            btnPlay.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNormal a = new FormNormal();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdvancedMode b = new AdvancedMode();
            this.Hide();
            b.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FGuide a = new FGuide();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            splayer.Stop();
            btnMute.Visible = false;
            btnPlay.Visible = true;
        }

        private void btnPlay_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
