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
    class FoodforAdvanced : Matrix
    {
        Random rd = new Random();
        int l;
        int t;
        //foodforadvancedmod
        public void TaoThucAn(Panel b, List<PictureBox> c)
        {
            matran();
            do
            {
                l = rd.Next(1, 51);
                t = rd.Next(1, 31);
            } while (arr[t, l] == 1);
            PictureBox a = new PictureBox();
            a.Width = 10;
            a.Height = 10;
            a.Left = l * 10;
            a.Top = t * 10;
            a.BackgroundImage = Properties.Resources.appleCapture;
            a.BackgroundImageLayout = ImageLayout.Stretch;
            b.Controls.Add(a);
            c.Add(a);
        }
    }
}
