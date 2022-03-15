using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody09_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObsahujeCislici(string text, out int cifSoucet, out int soucetLichCif, out int soucetSudCif)
        {

            bool obsahuje = false;
            soucetSudCif = 0;
            soucetLichCif = 0;
            cifSoucet = 0;
            foreach (char pismeno in text)
            {
                if (char.IsDigit(pismeno))
                {
                    obsahuje = true;
                    cifSoucet += int.Parse(pismeno.ToString());
                    if (int.Parse(pismeno.ToString()) % 2 == 0) soucetSudCif += int.Parse(pismeno.ToString());
                    else soucetLichCif += int.Parse(pismeno.ToString());
                }
            }
            return obsahuje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cifSoucet = 0, soucetLichCif = 0, soucetSudCif = 0;
            if (ObsahujeCislici(textBox1.Text, out cifSoucet, out soucetLichCif, out soucetSudCif))
            {
                MessageBox.Show("Obsahuje cifru\nCiferný součet: " + cifSoucet + "\nSoučet lichých cifer: " + soucetLichCif + "\nSoučet sudých cifer: " + soucetSudCif);
            }
            else MessageBox.Show("Neobsahuje cifry");
        }
    }
}
