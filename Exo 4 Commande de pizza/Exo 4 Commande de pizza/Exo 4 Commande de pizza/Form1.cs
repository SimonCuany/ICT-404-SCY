using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo_4_Commande_de_pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Xfine.Checked == true)

            {
                Commande.Text = "Pour la " + textBox1.Text + ": " + "pâte Extra-fine";
            }
            if (Fine.Checked == true)

            {
                Commande.Text = "Pour la " + textBox1.Text + ": " + "pâte fine";
            }
            if (Normale.Checked == true)

            {
                Commande.Text = "Pour la " + textBox1.Text + ": " + "pâte normale";
            }
            if (Epaisse.Checked == true)

            {
                Commande.Text = "Pour la " + textBox1.Text + ": " + "pâte epaisse" ;
            }

            if (Anchois.Checked == true)
            {
                Commande.Text +=  " avec " + Anchois.Text + ",";
            } 

        }

        private void Commande_TextChanged(object sender, EventArgs e)
        {

        }
    }
}