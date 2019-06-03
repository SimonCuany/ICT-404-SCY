using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fond : Form
   {
        int couleur;
        int locate;

        public fond()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            couleur++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit ();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.Red;
            couleur++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 0);
            locate++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Location = new Point(50,0);
            locate++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width , Screen.PrimaryScreen.Bounds.Height - this.Height);
            locate++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Location = new Point(50, Screen.PrimaryScreen.Bounds.Height - this.Height);
            locate++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(locate + " déplacements " + couleur + " changements de couleurs");
        }
    }
}

