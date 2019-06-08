//Project : Déduction fiscal
//Author  : Simon Cuany
//Date    : 13.05.2019
//Title   : Exo 2 Deductions

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
          float resultat;
            float jeunes;

           
    
          if (Annuelbox.Text == "")
          {
              MessageBox.Show("Veuillez entrez quelque chose dans la case revenu annuel ", "Erreur");
              return;
          }
    
          if (Coefficientbox.Text == "")
          {
                MessageBox.Show("Veuillez entrez quelque chose dans la case Coefficient famillal ", "Erreur");
                return;
          }
            jeunes = float.Parse(Lbljeune.Text);

            brut = float.Parse(Annuelbox.Text);
            label3.Visible = true;
            famillial = float.Parse(Coefficientbox.Text);

            resultat = brut / famillial;
            label4.Text = resultat.ToString ();
            label4.Visible = true;

            if (Jeunebox.Checked == true)
            {
                resultat = resultat.ToString() - jeunes;
            }

        }

        
        private void Annuelbox_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void Coefficientbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Jeunebox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void transportbox_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rabaisbox_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
