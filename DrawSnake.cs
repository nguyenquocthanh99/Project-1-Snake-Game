using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Group3_GameSnack
{
    class DrawSnake
    {
        private Rectangle[] snakeRec;
        public Rectangle[] SnakeRec
        {
            get
            {
                return snakeRec;
            }
        }
        private int x, y, whidth, height;
        public DrawSnake()
        {
            snakeRec = new Rectangle[3];
            x = 180; y = 100; whidth = 10; height = 10;
            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, whidth, height);
                x -= 13;
            }
        }
        public void drawSnake(Graphics paper)
        {
            //ham ve ran        
            foreach (Rectangle rec in snakeRec)
            {
                Image img = Image.FromFile("D:\\ITHCMUTE\\Project\\Project 1\\Snakebody.png");
                Bitmap bimage = new Bitmap(img);
                TextureBrush tb = new TextureBrush(bimage);
                paper.FillRectangle(tb, rec);
            }
        }
        public void drawSnakerun()
        {
            for (int i = snakeRec.Length-1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }
        public void movedown()
        {
            drawSnakerun();
            snakeRec[0].Y += 10;
        }
        public void moveup()
        {
            drawSnakerun();
            snakeRec[0].Y -= 10;
        }
        public void moveright()
        {
            drawSnakerun();
            snakeRec[0].X += 10;
        }
        public void moveleft()
        {
            drawSnakerun();
            snakeRec[0].X -= 10;
        }
        public void growSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();  
            rec.Add(new Rectangle(snakeRec[snakeRec.Length-1].X, snakeRec[snakeRec.Length -1 ].Y, whidth, height));
            snakeRec = rec.ToArray();
        }
    }
}
