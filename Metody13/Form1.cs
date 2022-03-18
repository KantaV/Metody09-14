using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool JeAlfanum(string text, out int pocetMalych, out int pocetVelkych, out int neAlfanumPocet)
        {
            bool jeAlfanum = true;
            pocetMalych = 0;
            pocetVelkych = 0;
            neAlfanumPocet=0;
            foreach (char pismeno in text)
            {
                if (char.IsLower(pismeno)) ++pocetMalych;
                else if (char.IsUpper(pismeno)) ++pocetVelkych;
                else if (!char.IsDigit(pismeno))
                {
                    neAlfanumPocet++;
                    jeAlfanum = false;
                }
            }
            return jeAlfanum;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pocMal = 0, pocVel = 0, pocNeAlf = 0;
            bool jeAlf = JeAlfanum(textBox1.Text, out pocMal, out pocVel, out pocNeAlf);
            if (jeAlf) MessageBox.Show("Text je alfanumerický\nPočet malých písmen: " + pocMal + "\nPočet velkých písmen: " + pocVel);
            else MessageBox.Show("Text není alfanumerický\nPočet malých písmen: " + pocMal + "\nPočet velkých písmen: " + pocVel + "\nPočet nealfanumerických znaků: " + pocNeAlf); ;
        }
    }
}
