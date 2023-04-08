using System.Threading;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace Flyweight
{
    public partial class Form1 : Form
    {
        public Graphics g;
        public Random random;

        public List<Trees> trees = new();
        public Param[] TreeP = new Param[3];

        Bitmap img = new Bitmap(1000, 1000);
        Graphics g2;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            random = new Random();
            TreeP[0] = new Tree1();
            TreeP[1] = new Tree2();
            TreeP[2] = new Tree3();
            g2 = Graphics.FromImage(img);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled= true;
        }
        public void CreateTree()
        {
            g2.Clear(SystemColors.Control); 
            for (int i = 0; i < trees.Count(); i++)
            {
                trees[i].Grow();
                g2.DrawImage(trees[i].sp.img, trees[i].rec);
            }
            g.DrawImage(img, 0, 0);
            //img.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (trees.Count() == 200)
            {
                timer1.Enabled = false;
            }

            Point StartPosition = new(random.Next(0, 1000), random.Next(0, 1000));
            Trees NewTree = new(StartPosition, TreeP[random.Next(0, 3)]);

            trees.Add(NewTree);
            CreateTree();
        }
    }
}