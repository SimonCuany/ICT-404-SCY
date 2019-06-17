namespace Exo_4_Commande_de_pizza
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Xfine = new System.Windows.Forms.RadioButton();
            this.Fine = new System.Windows.Forms.RadioButton();
            this.Normale = new System.Windows.Forms.RadioButton();
            this.Epaisse = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Anchois = new System.Windows.Forms.CheckBox();
            this.Câpres = new System.Windows.Forms.CheckBox();
            this.Jambons = new System.Windows.Forms.CheckBox();
            this.Crevettes = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Commande = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Xfine
            // 
            this.Xfine.AutoSize = true;
            this.Xfine.Location = new System.Drawing.Point(40, 64);
            this.Xfine.Name = "Xfine";
            this.Xfine.Size = new System.Drawing.Size(69, 17);
            this.Xfine.TabIndex = 0;
            this.Xfine.Text = "Extra-fine";
            this.Xfine.UseVisualStyleBackColor = true;
            // 
            // Fine
            // 
            this.Fine.AutoSize = true;
            this.Fine.Location = new System.Drawing.Point(40, 87);
            this.Fine.Name = "Fine";
            this.Fine.Size = new System.Drawing.Size(45, 17);
            this.Fine.TabIndex = 1;
            this.Fine.Text = "Fine";
            this.Fine.UseVisualStyleBackColor = true;
            // 
            // Normale
            // 
            this.Normale.AutoSize = true;
            this.Normale.Location = new System.Drawing.Point(40, 110);
            this.Normale.Name = "Normale";
            this.Normale.Size = new System.Drawing.Size(64, 17);
            this.Normale.TabIndex = 2;
            this.Normale.Text = "Normale";
            this.Normale.UseVisualStyleBackColor = true;
            // 
            // Epaisse
            // 
            this.Epaisse.AutoSize = true;
            this.Epaisse.Location = new System.Drawing.Point(40, 133);
            this.Epaisse.Name = "Epaisse";
            this.Epaisse.Size = new System.Drawing.Size(62, 17);
            this.Epaisse.TabIndex = 3;
            this.Epaisse.Text = "Epaisse";
            this.Epaisse.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Anchois
            // 
            this.Anchois.AutoSize = true;
            this.Anchois.Location = new System.Drawing.Point(211, 64);
            this.Anchois.Name = "Anchois";
            this.Anchois.Size = new System.Drawing.Size(64, 17);
            this.Anchois.TabIndex = 6;
            this.Anchois.Text = "Anchois";
            this.Anchois.UseVisualStyleBackColor = true;
            // 
            // Câpres
            // 
            this.Câpres.AutoSize = true;
            this.Câpres.Location = new System.Drawing.Point(211, 87);
            this.Câpres.Name = "Câpres";
            this.Câpres.Size = new System.Drawing.Size(59, 17);
            this.Câpres.TabIndex = 7;
            this.Câpres.Text = "Câpres";
            this.Câpres.UseVisualStyleBackColor = true;
            // 
            // Jambons
            // 
            this.Jambons.AutoSize = true;
            this.Jambons.Location = new System.Drawing.Point(211, 110);
            this.Jambons.Name = "Jambons";
            this.Jambons.Size = new System.Drawing.Size(63, 17);
            this.Jambons.TabIndex = 8;
            this.Jambons.Text = "Jambon";
            this.Jambons.UseVisualStyleBackColor = true;
            // 
            // Crevettes
            // 
            this.Crevettes.AutoSize = true;
            this.Crevettes.Location = new System.Drawing.Point(211, 133);
            this.Crevettes.Name = "Crevettes";
            this.Crevettes.Size = new System.Drawing.Size(71, 17);
            this.Crevettes.TabIndex = 9;
            this.Crevettes.Text = "Crevettes";
            this.Crevettes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Commander";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Commande
            // 
            this.Commande.BackColor = System.Drawing.Color.Yellow;
            this.Commande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commande.Location = new System.Drawing.Point(40, 270);
            this.Commande.Multiline = true;
            this.Commande.Name = "Commande";
            this.Commande.Size = new System.Drawing.Size(299, 55);
            this.Commande.TabIndex = 11;
            this.Commande.TextChanged += new System.EventHandler(this.Commande_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Commande";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pâte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 358);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Commande);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Crevettes);
            this.Controls.Add(this.Jambons);
            this.Controls.Add(this.Câpres);
            this.Controls.Add(this.Anchois);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Epaisse);
            this.Controls.Add(this.Normale);
            this.Controls.Add(this.Fine);
            this.Controls.Add(this.Xfine);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Xfine;
        private System.Windows.Forms.RadioButton Fine;
        private System.Windows.Forms.RadioButton Normale;
        private System.Windows.Forms.RadioButton Epaisse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Anchois;
        private System.Windows.Forms.CheckBox Câpres;
        private System.Windows.Forms.CheckBox Jambons;
        private System.Windows.Forms.CheckBox Crevettes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Commande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

