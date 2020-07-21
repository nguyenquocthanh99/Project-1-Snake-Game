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
    public partial class AdvancedMode : Form
    {
        Point Toado;
        Point Toadoran;

        Obstacle obstacle;
        FoodforAdvanced food;
        Vacham vacham;
        ReleaseData releasedata;
        int score = 0;
        bool U = false;
        bool D = false;
        bool L = false;
        bool R = true;
        public AdvancedMode()
        {
            InitializeComponent();
        }
        List<PictureBox> SnakeHeads = new List<PictureBox>();
        List<PictureBox> SnakeBodies = new List<PictureBox>();
        List<PictureBox> listthucan = new List<PictureBox>();
        List<PictureBox> tuong = new List<PictureBox>();

        private void taothanconran(int a, int b, int c, int d, PictureBox e, Panel f, List<PictureBox> g)
        {
            e.Width = a;
            e.Height = b;
            e.Left = c;
            e.Top = d;
            g.Add(e);
            f.Controls.Add(e);
        }
        private void taodauconran(int a, int b, int c, int d, PictureBox e, Panel f, List<PictureBox> g)
        {
            e.Width = a;
            e.Height = b;
            e.Left = c;
            e.Top = d;
            g.Add(e);
            f.Controls.Add(e);
        }
        void load()
        {
            // Tạo ra đầu con rắn do mình điều khiển và 1 phần đuôi của nó
            PictureBox snakehead = new PictureBox();
            taodauconran(10, 10, 20, 20, snakehead, panel1, SnakeHeads);
            PictureBox than = new PictureBox();
            taothanconran(10, 10, SnakeHeads[0].Left - 10, SnakeHeads[0].Top, than, panel1, SnakeBodies);
            button2.Enabled = true;
            button1.Enabled = false;
        }
        private void AdvancedMode_Load(object sender, EventArgs e)
        {

        }

        private void HeadMove_Tick(object sender, EventArgs e)
        {
            Toado = new Point(SnakeHeads[0].Location.X, SnakeHeads[0].Location.Y);
            if (U == true)
            {
                SnakeHeads[0].Top -= 10;
                SnakeHeads[0].BackgroundImage = Properties.Resources.Headup;
                SnakeHeads[0].BackgroundImageLayout = ImageLayout.Stretch;
                for (int i = 0; i < SnakeBodies.Count; i++)
                {
                    SnakeBodies[i].BackgroundImage = Properties.Resources.bodydownup;
                    SnakeBodies[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            else if (D == true)
            {
                SnakeHeads[0].Top += 10;
                SnakeHeads[0].BackgroundImage = Properties.Resources.Headdown;
                SnakeHeads[0].BackgroundImageLayout = ImageLayout.Stretch;
                for (int i = 0; i < SnakeBodies.Count; i++)
                {
                    SnakeBodies[i].BackgroundImage = Properties.Resources.bodydownup;
                    SnakeBodies[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            else if (L == true)
            {
                SnakeHeads[0].Left -= 10;
                SnakeHeads[0].BackgroundImage = Properties.Resources.headleft;
                SnakeHeads[0].BackgroundImageLayout = ImageLayout.Stretch;
                for (int i = 0; i < SnakeBodies.Count; i++)
                {
                    SnakeBodies[i].BackgroundImage = Properties.Resources.bodyleftright;
                    SnakeBodies[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            else
            {
                SnakeHeads[0].Left += 10;
                SnakeHeads[0].BackgroundImage = Properties.Resources.Headright;
                SnakeHeads[0].BackgroundImageLayout = ImageLayout.Stretch;
                for (int i = 0; i < SnakeBodies.Count; i++)
                {
                    SnakeBodies[i].BackgroundImage = Properties.Resources.bodyleftright;
                    SnakeBodies[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            for (int i = SnakeBodies.Count - 1; i > 0; i--)
            {
                Toadoran = new Point(SnakeBodies[i - 1].Location.X, SnakeBodies[i - 1].Location.Y);
                SnakeBodies[i].Location = Toadoran;
            }
            SnakeBodies[0].Location = Toado;

        }

        private void BodyMove_Tick(object sender, EventArgs e)
        {
            PictureBox than = new PictureBox();
            taothanconran(10, 10, SnakeBodies[0].Left, SnakeBodies[0].Top, than, panel1, SnakeBodies);
            BodyMove.Stop();
        }

        private void Eat_Tick(object sender, EventArgs e)
        {
            if (listthucan[0].Location == SnakeHeads[0].Location)
            {
                panel1.Controls.Remove(listthucan[0]);
                listthucan.RemoveAt(0);
                food = new FoodforAdvanced();
                food.TaoThucAn(panel1, listthucan);
                score += 10;
                label2.Text = score.ToString();
                BodyMove.Start();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Focus();
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Up && D == false)
            {
                U = true;
                D = false;
                L = false;
                R = false;
            }
            else if (e.KeyCode == Keys.Down && U == false)
            {
                U = false;
                D = true;
                L = false;
                R = false;
            }
            else if (e.KeyCode == Keys.Left && R == false)
            {
                U = false;
                D = false;
                L = true;
                R = false;
            }
            else if (e.KeyCode == Keys.Right && L == false)
            {
                U = false;
                D = false;
                L = false;
                R = true;
            }
            if (e.KeyCode == Keys.P && button2.Enabled == true)
            {

                HeadMove.Stop();
                Eat.Stop();
                BodyMove.Stop();
                button2.Text = "Tiếp Tục";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            restart();
            startgame();
            label2.Text = score.ToString();
        }

        void restart()
        {
            releasedata = new ReleaseData();
            releasedata.restart(SnakeBodies, panel1);
            releasedata.restart(SnakeHeads, panel1);
            releasedata.restart(listthucan, panel1);
            releasedata.restart(tuong, panel1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMain b = new FormMain();
            this.Hide();
            b.ShowDialog();
            this.Close();
        }

        private void Panel_Tick(object sender, EventArgs e)
        {

            // Frame of map
            if (SnakeHeads[0].Left > 512) 
                SnakeHeads[0].Left = 0;
            if (SnakeHeads[0].Top > 309)
                SnakeHeads[0].Top = 0;
            if (SnakeHeads[0].Left < 0)
                SnakeHeads[0].Left = 512;
            if (SnakeHeads[0].Top < 0)
                SnakeHeads[0].Top = 309;
            // Check touch
            vacham = new Vacham();
            if (vacham.kiemtravacham(SnakeHeads, SnakeBodies) == true)
            {
                die();
                MessageBox.Show("You ate yourself @@!");
            }
            else if (vacham.xetvachamtuong(SnakeHeads) == true)
            {
                die();
                MessageBox.Show("You hit the rock @@!");
            }
        }
        void startgame()
        {
            R = true;
            L = false;
            D = false;
            U = false;
            score = 0;
            load();
            obstacle = new Obstacle();
            obstacle.taovatcan(panel1, tuong);
            HeadMove.Start();
            Eat.Start();
            BodyMove.Start();
            food = new FoodforAdvanced();
            food.TaoThucAn(panel1, listthucan);
            Panel.Start();
        }
        void die()
        {
            HeadMove.Stop();
            Eat.Stop();
            BodyMove.Stop();
            Panel.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
            MessageBox.Show("Your score is : " + score.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Stop (P)")
            {
                button2.Text = "Continue";
                HeadMove.Stop();
                Eat.Stop();
                BodyMove.Stop();
            }
            else
            {
                button2.Text = "Stop (P)";
                HeadMove.Start();
                Eat.Start();
                BodyMove.Start();
            }
        }
    }
}