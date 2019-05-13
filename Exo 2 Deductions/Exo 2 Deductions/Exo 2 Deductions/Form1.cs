//Project: Déduction fiscal
//Author : Simon Cuany
//Date   : 13.05.2019
//Title  : Exo 2 Deductions

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo_2_Deductions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float brut;
            float famillial;

            float total = Annuelbox / Coefficientbox;
            label3.Text = "Revenue Imposable : " + total.ToString();

          

        }

        private void rabaisbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Annuelbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Coefficientbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
