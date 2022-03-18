using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool Identicke(string text1, string text2, out int pocetOdlis, out int prvniIndexOdlis)
        {
            bool jsouIdenticke=(string.Compare(text1,text2))==0;
            pocetOdlis = 0;
            prvniIndexOdlis = -1;
            if (!jsouIdenticke)
            {
                if (text1.Length < text2.Length)
                {
                    string kyblik = text1;
                    text1 = text2;
                    text2 = kyblik;
                }
                for (int i = 0; i < text1.Length; ++i)
                {
                    if (i < text2.Length)
                    {
                        if (text1[i] != text2[i])
                        {
                            if (pocetOdlis==0)
                            {
                                prvniIndexOdlis = i;
                            }
                            ++pocetOdlis;
                        }
                    }
                    else
                    {
                        if (pocetOdlis==0)
                        {
                            prvniIndexOdlis = i-1;
                        }
                    }
                }
                int rozdilVDelce = text1.Length - text2.Length;
                pocetOdlis += rozdilVDelce;
            }
            return jsouIdenticke;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pocOdlis = 0, prvIndexOdlis = 0;
            if (Identicke(textBox1.Text, textBox2.Text, out pocOdlis, out prvIndexOdlis)) MessageBox.Show("Jsou stejné");
            else MessageBox.Show("Nejsou stejné\nIndex první odlišnosti: " + prvIndexOdlis + "\nPočet odlišností: " + pocOdlis);
        }
    }
}
