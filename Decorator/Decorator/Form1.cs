using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        public Burger burger;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "1": burger = new BaconDecorator(burger);
                    break;
                case "2": burger = new OnionDecorator(burger);
                    break;
                case "3": burger = new TomatoDecorator(burger);
                    break;
                case "4": burger = new LettuceDecorator(burger);
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            switch (comboBox1.Text)
            {
                case "Hamburger":
                    {
                        burger = new Hamburger();
                        pictureBox1.BackgroundImage = Image.FromFile("Hamburger.jpg");
                    }
                    break;
                case "VeggieBurger":
                    {
                        burger = new VeggieBurger(); 
                        pictureBox1.BackgroundImage = Image.FromFile("VeggieBurger.jpg");
                    }
                    break;
                case "ChickenBurger":
                    {
                        burger = new ChickenBurger();
                        pictureBox1.BackgroundImage = Image.FromFile("ChickenBurger.jpg");
                    }
                    break;
                case "Cheeseburger":
                    {
                        burger = new Cheeseburger();
                        pictureBox1.BackgroundImage = Image.FromFile("Cheeseburger.jpg");
                    }
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string chek = "";

            chek += "Burger: " + burger.GetDescription();
            chek += "\nPrice: " + burger.GetPrice().ToString();

            MessageBox.Show(chek);
        }
    }
}
