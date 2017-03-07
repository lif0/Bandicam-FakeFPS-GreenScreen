using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace FakeFPS
{
    public partial class Form1 : Form
    {
        public int a, i, b, count, fps;
        public string fpsS;
        public char thousand, hundred, ten, one;
        public Random rand = new Random();
        public ushort ExplorerCount=2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Повторений" || textBox4.Text == "Скорость(в мс)") { MessageBox.Show("Даун введи скорость и количество повторений."); textBox3.Text = Convert.ToString(100); textBox4.Text = Convert.ToString(100); }
            else
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                count = Convert.ToInt32(textBox3.Text);
                timer1.Interval = Convert.ToInt32(textBox4.Text);
                panel1.Location = new Point(2, 405);
                timer1.Enabled = true;
            }
        }
        public void tenMethod(int i)
        {
            switch(i)
            {
                case 0:
                    pictureBox2.Image = FakeFPS.Properties.Resources._0;
                    break;
                case 1:
                    pictureBox2.Image = FakeFPS.Properties.Resources._1;
                    break;
                case 2:
                    pictureBox2.Image = FakeFPS.Properties.Resources._2;
                    break;
                case 3:
                    pictureBox2.Image = FakeFPS.Properties.Resources._3;
                    break;
                case 4:
                    pictureBox2.Image = FakeFPS.Properties.Resources._4;
                    break;
                case 5:
                    pictureBox2.Image = FakeFPS.Properties.Resources._5;
                    break;
                case 6:
                    pictureBox2.Image = FakeFPS.Properties.Resources._6;
                    break;
                case 7:
                    pictureBox2.Image = FakeFPS.Properties.Resources._7;
                    break;
                case 8:
                    pictureBox2.Image = FakeFPS.Properties.Resources._8;
                    break;
                case 9:
                    pictureBox2.Image = FakeFPS.Properties.Resources._9;
                    break;
            }
        }
        public void oneMethod(int i)
        {
            switch (i)
            {
                case 0:
                    pictureBox3.Image = FakeFPS.Properties.Resources._0;
                    break;
                case 1:
                    pictureBox3.Image = FakeFPS.Properties.Resources._1;
                    break;
                case 2:
                    pictureBox3.Image = FakeFPS.Properties.Resources._2;
                    break;
                case 3:
                    pictureBox3.Image = FakeFPS.Properties.Resources._3;
                    break;
                case 4:
                    pictureBox3.Image = FakeFPS.Properties.Resources._4;
                    break;
                case 5:
                    pictureBox3.Image = FakeFPS.Properties.Resources._5;
                    break;
                case 6:
                    pictureBox3.Image = FakeFPS.Properties.Resources._6;
                    break;
                case 7:
                    pictureBox3.Image = FakeFPS.Properties.Resources._7;
                    break;
                case 8:
                    pictureBox3.Image = FakeFPS.Properties.Resources._8;
                    break;
                case 9:
                    pictureBox3.Image = FakeFPS.Properties.Resources._9;
                    break;
            }
        }
        public void hundredMethod(int i)
        {
            switch (i)
            {
                case 0:
                    pictureBox1.Image = FakeFPS.Properties.Resources._0;
                    break;
                case 1:
                    pictureBox1.Image = FakeFPS.Properties.Resources._1;
                    break;
                case 2:
                    pictureBox1.Image = FakeFPS.Properties.Resources._2;
                    break;
                case 3:
                    pictureBox1.Image = FakeFPS.Properties.Resources._3;
                    break;
                case 4:
                    pictureBox1.Image = FakeFPS.Properties.Resources._4;
                    break;
                case 5:
                    pictureBox1.Image = FakeFPS.Properties.Resources._5;
                    break;
                case 6:
                    pictureBox1.Image = FakeFPS.Properties.Resources._6;
                    break;
                case 7:
                    pictureBox1.Image = FakeFPS.Properties.Resources._7;
                    break;
                case 8:
                    pictureBox1.Image = FakeFPS.Properties.Resources._8;
                    break;
                case 9:
                    pictureBox1.Image = FakeFPS.Properties.Resources._9;
                    break;
            }
        }

        public void thousandMethod(int i)
        {
            switch (i)
            {
                case 0:
                    pictureBox4.Image = FakeFPS.Properties.Resources._0;
                    break;
                case 1:
                    pictureBox4.Image = FakeFPS.Properties.Resources._1;
                    break;
                case 2:
                    pictureBox4.Image = FakeFPS.Properties.Resources._2;
                    break;
                case 3:
                    pictureBox4.Image = FakeFPS.Properties.Resources._3;
                    break;
                case 4:
                    pictureBox4.Image = FakeFPS.Properties.Resources._4;
                    break;
                case 5:
                    pictureBox4.Image = FakeFPS.Properties.Resources._5;
                    break;
                case 6:
                    pictureBox4.Image = FakeFPS.Properties.Resources._6;
                    break;
                case 7:
                    pictureBox4.Image = FakeFPS.Properties.Resources._7;
                    break;
                case 8:
                    pictureBox4.Image = FakeFPS.Properties.Resources._8;
                    break;
                case 9:
                    pictureBox4.Image = FakeFPS.Properties.Resources._9;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
                fps = rand.Next(a, b);
                fpsS = fps.ToString();
                //hundred = fpsS[0];
                if (fpsS.Length == 4)
                {
                    thousand = fpsS[0];
                    hundred = fpsS[1];
                    ten = fpsS[2];
                    one = fpsS[3];
                    thousandMethod(Convert.ToInt32(thousand.ToString()));
                    hundredMethod(Convert.ToInt32(hundred.ToString()));
                    tenMethod(Convert.ToInt32(ten.ToString()));
                    oneMethod(Convert.ToInt32(one.ToString()));
                }
                else if (fpsS.Length == 3)
                {
                    hundred = fpsS[0];
                    ten = fpsS[1]; 
                    one = fpsS[2];
                    hundredMethod(Convert.ToInt32(hundred.ToString()));
                    tenMethod(Convert.ToInt32(ten.ToString()));
                    oneMethod(Convert.ToInt32(one.ToString()));
                }
                else if (fpsS.Length == 2) 
                {
                    ten = fpsS[0]; 
                    one = fpsS[1];
                    tenMethod(Convert.ToInt32(ten.ToString()));
                    oneMethod(Convert.ToInt32(one.ToString()));
                }
                else 
                { 
                    one = fpsS[0]; 
                    oneMethod(Convert.ToInt32(one.ToString())); 
                };
                if (i == count) { timer1.Enabled = false; panel1.Location = new Point(2, 378); count = 0; i = 0;}
        }

   }
}
