using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Diskriminant(double a, double b, double c)
        {
            return Math.Sqrt((b * b) - 4 * a * c);
        }

        private bool KvadratickaRovnice(double diskriminant,double a, double b, double c,out double x1, out double x2)
        {
            bool maKoreny = true;
            x1 = 0;
            x2 = 0;
            if (diskriminant > 0)
            {
                x1 = -b + diskriminant / 2 * a;
                x2 = -b - diskriminant / 2 * a;
            }
            else if (diskriminant == 0)
            {
                x1 = -b + diskriminant / 2 * a;
            }
            else maKoreny = false;
            return maKoreny; 
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text), b = double.Parse(textBox2.Text), c = double.Parse(textBox3.Text),x1,x2;
            if (KvadratickaRovnice(Diskriminant(a, b, c), a, b, c, out x1, out x2))
            {
                MessageBox.Show("x1: " + x1 + "\nx2: " + x2);
            }
            else if (Diskriminant(a, c, b) == 0) MessageBox.Show("Diskriminant vyšel 0\nx1: " + x1);
            else MessageBox.Show("Diskriminant vyšel záporný");
        }
    }
}
