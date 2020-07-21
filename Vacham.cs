using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Group3_GameSnack
{
    class Vacham : Matrix
    {
        public bool kiemtravacham(List<PictureBox> SnakeHeads, List<PictureBox> SnakeBodies)
        {
            bool t = false;
            for (int i = 0; i < SnakeBodies.Count; i++)
            {
                if (SnakeHeads[0].Location == SnakeBodies[i].Location)
                {
                    t = true;
                }
            }
            return t;
        }
        public bool xetvachamtuong(List<PictureBox> SnakeHeads)
        {
            bool t = false;
            matran();
            if (arr[SnakeHeads[0].Location.Y / 10, SnakeHeads[0].Location.X / 10] == 1)
            {
                t = true;
            }
            return t;
        }
    }
}
