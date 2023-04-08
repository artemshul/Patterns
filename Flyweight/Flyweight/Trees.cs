using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight
{
    public class Param
    {
        public Image img;
        public Size size;
    }
    public class Tree1 : Param
    {
        public Tree1()
        {
            size = new Size(30, 30);
            img = Image.FromFile("д1.png");
        }
    }
    public class Tree2 : Param
    {
        public Tree2()
        {
            size = new Size(30, 30);
            img = Image.FromFile("д2.png");
        }
    }
    public class Tree3 : Param
    {
        public Tree3()
        {
            size = new Size(30, 30);
            img = Image.FromFile("д3.png");
        }
    }

    public class Trees
    {
        public Point xy;
        public Param sp;
        public Rectangle rec;
        public int growCount = 0;

        public Trees(Point coordiantes, Param nsp)
        {
            sp = nsp;
            xy = coordiantes;
            rec = new Rectangle(xy, sp.size);
        }

        public void Grow()
        {
            if(growCount < 20)
            {
                rec.Width += 2;
                rec.Height += 2;
                rec.X -= 1;
                rec.Y -= 1;
                growCount++;
            }
        }
    }
}
