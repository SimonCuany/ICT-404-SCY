﻿//Author : Simon Cuany / Date : 09.05.2019 / Project : Exo Bonjour / Title : Exercice bonjour
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_Bonjour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            bienvenu.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bienvenu_Click(object sender, EventArgs e)
        {
            lblbjr.Visible = true;
            bienvenu.Visible = true;
            lblbjr.Text = "Bonjour " + textboxnom.Text;
            textboxnom.Text = "";
            bienvenu.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
