using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spojeny_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cislo = int.Parse(textBox1.Text);
                int cifra = 0;
                int soucetcifer = 0;

                for(int cislo1 = cislo; cislo1 > 0;)
                {
                    cifra = cislo1 % 10;
                    soucetcifer += cifra;
                    cislo1 /= 10;
                }
                MessageBox.Show("Ciferny soucet :" + soucetcifer);

                int delitel = 1;
                while(cislo >= delitel)
                {
                    if(cislo % delitel == 0)
                    {
                        listBox1.Items.Add(delitel.ToString());
                    }

                    delitel++;
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void vymazatlistbox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
