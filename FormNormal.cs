using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Group3_GameSnack
{
    public partial class FormNormal : Form
    {
        int score = 0;
        Graphics gp;
        DrawSnake snake = new DrawSnake();
        Boolean trai = false, phai = true, len = false, xuong = false;
        public Random r = new Random();
        private void FormNormal_Paint(object sender, PaintEventArgs e)
        {
            gp = e.Graphics;
            snake.drawSnake(gp);
        }
        void gamestart()
        {
            trai = false; phai = true; len = false; xuong = false;
        }
        private void FormNormal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                timer1.Start();
                xuong = false;
                len = false;
                trai = false;
                pictureBox3.Visible = false;
                phai = false;
            }
            if (e.KeyData == Keys.P)
            {
                timer1.Stop();
                xuong = false;
                len = false;
                trai = false;
                pictureBox3.Visible = false;
                phai = false;
            }
            if (e.KeyData == Keys.Up && xuong == false)
            {
                len = true; xuong = false;
                trai = false;
                phai = false;
            }
            if (e.KeyData == Keys.Down && len == false)
            {
                len = false; xuong = true;
                trai = false;
                phai = false;
            }
            if (e.KeyData == Keys.Left && phai == false)
            {
                len = false; xuong = false;
                trai = true;
                phai = false;

            }
            if (e.KeyData == Keys.Right && trai == false)
            {
                len = false; xuong = false;
                trai = false;
                phai = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = r.Next(140, 630);
            int y = r.Next(80, 370);
            //pictureBox2.Location = new Point(snake.SnakeRec[0].X, snake.SnakeRec[0].Y);
            //pictureBox2.Top = snake.SnakeRec[0].Y-5;
            //pictureBox2.Left = snake.SnakeRec[0].X+10;
            label2.Text = score.ToString();
            if (xuong == true)
            {
                snake.movedown();
                Image image = Image.FromFile("D:\\ITHCMUTE\\Project\\Project 1\\Headdown.PNG");
                pictureBox2.Image = image;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Location = new Point(snake.SnakeRec[0].X -1, snake.SnakeRec[0].Y + 11);
            }
            if (len == true)
            {
                snake.moveup();
                Image image = Image.FromFile("D:\\ITHCMUTE\\Project\\Project 1\\Headup.PNG");
                pictureBox2.Image = image;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Location = new Point(snake.SnakeRec[0].X - 1, snake.SnakeRec[0].Y - 14);
            }
            if (trai == true)
            {
                snake.moveleft();
                Image image = Image.FromFile("D:\\ITHCMUTE\\Project\\Project 1\\Headleft.PNG");
                pictureBox2.Image = image;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Location = new Point(snake.SnakeRec[0].X - 13, snake.SnakeRec[0].Y - 1);
            }
            if (phai == true)
            {
                snake.moveright();
                Image image = Image.FromFile("D:\\ITHCMUTE\\Project\\Project 1\\Headright.PNG");
                pictureBox2.Image = image;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Location = new Point(snake.SnakeRec[0].X + 11, snake.SnakeRec[0].Y - 1);
            }
            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds) || snake.SnakeRec[i].IntersectsWith(pictureBox1.Bounds))
                {
                    score += 10;
                    snake.growSnake();
                    pictureBox1.Top = y;
                    pictureBox1.Left = x;
                }
            }
            vacham();
            this.Invalidate();
        }
        public void vacham()
        {
            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if (pictureBox2.Bounds.IntersectsWith(snake.SnakeRec[i]))
                {
                    snakedie();
                }
                if (pictureBox2.Location.Y < 68)
                {
                    snake.SnakeRec[0].Y = 373;
                }
                if (pictureBox2.Location.Y > 373)
                {
                    snake.SnakeRec[0].Y = 68;
                }
                if (pictureBox2.Location.X < 129)
                {
                    snake.SnakeRec[0].X = 636;
                }
                if (pictureBox2.Location.X > 636)
                {
                    snake.SnakeRec[0].X = 129;
                }
            }
        }
        void snakedie()
        {
            timer1.Enabled = false;
            pictureBox3.Visible = true;
            MessageBox.Show("You die! Your score is: " + score.ToString());
            score = 0;
            snake = new DrawSnake();
        }

        private void FormNormal_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        SoundPlayer splayer = new SoundPlayer(@"D:\ITHCMUTE\Project\Project 1\sound.wav");
        public FormNormal()
        {
            InitializeComponent();
            splayer.Play();
        }
        private void FormNormal_Load(object sender, EventArgs e)
        {
        }
    }
}
