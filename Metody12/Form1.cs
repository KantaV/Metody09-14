using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObsahujeSlovo(string text, out string nejdelsiSlovo, out string nejkratsiSlovo)
        {
            char[] oddelovac = { ' ' };
            string[] slova = text.Split(oddelovac, StringSplitOptions.RemoveEmptyEntries);
            nejkratsiSlovo = "";
            nejdelsiSlovo = "";
           
            bool obsahujeSlovo = slova.Length > 0;

            if (obsahujeSlovo)
            {
                nejdelsiSlovo = slova[0];
                nejkratsiSlovo = slova[0];

                foreach (string slovo in slova)
                {
                    if (slovo.Length < nejkratsiSlovo.Length) nejkratsiSlovo = slovo;
                    if (slovo.Length > nejdelsiSlovo.Length) nejdelsiSlovo = slovo;
                }
            }
            return obsahujeSlovo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string nejdelsi, nejkratsi;
            if (ObsahujeSlovo(text, out nejdelsi, out nejkratsi))
            {
                MessageBox.Show("Řetězec obsahuje alespoň jedno slovo\nNejdelší slovo - " + nejdelsi + "\nNejkratší slovo - " + nejkratsi);
            }
            else MessageBox.Show("Řetězec neobsahuje alespoň jedno slovo");
        }
    }
}
