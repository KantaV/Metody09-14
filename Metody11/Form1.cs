using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "pes kočka   vlk liška";
        }

        private int PocetSlov(string text,out string upravenyText)
        {
            int pocetSlov = 0;
            char[] separator = { ' ' };
            string[] slova= text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            pocetSlov = slova.Count();
            int i = 0;
            while (i<text.Length)
            {
                if (char.IsDigit(text[i]))
                {
                    text = text.Remove(i, 1);
                }
                else i++;
            }
            upravenyText = text;
            return pocetSlov;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string upraveno;
            int pocetSlov = PocetSlov(textBox1.Text,out upraveno);
            MessageBox.Show("Počet slov: "+pocetSlov+"\nŘetězec bez čísel: " + upraveno);
        }
    }
}
