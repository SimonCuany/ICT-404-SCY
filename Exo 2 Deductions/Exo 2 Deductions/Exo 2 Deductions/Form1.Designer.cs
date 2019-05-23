namespace Exo_2_Deductions
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
            this.label1 = new System.Windows.Forms.Label();
            this.Jeunebox = new System.Windows.Forms.CheckBox();
            this.transportbox = new System.Windows.Forms.CheckBox();
            this.rabaisbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Annuelbox = new System.Windows.Forms.TextBox();
            this.Coefficientbox = new System.Windows.Forms.TextBox();
            this.cmdcalcul = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenu annuel brut";
            // 
            // Jeunebox
            // 
            this.Jeunebox.AutoSize = true;
            this.Jeunebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jeunebox.Location = new System.Drawing.Point(118, 215);
            this.Jeunebox.Name = "Jeunebox";
            this.Jeunebox.Size = new System.Drawing.Size(133, 22);
            this.Jeunebox.TabIndex = 1;
            this.Jeunebox.Text = "Déduction jeune";
            this.Jeunebox.UseVisualStyleBackColor = true;
            this.Jeunebox.CheckedChanged += new System.EventHandler(this.Jeunebox_CheckedChanged);
            // 
            // transportbox
            // 
            this.transportbox.AutoSize = true;
            this.transportbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportbox.Location = new System.Drawing.Point(118, 243);
            this.transportbox.Name = "transportbox";
            this.transportbox.Size = new System.Drawing.Size(157, 22);
            this.transportbox.TabIndex = 2;
            this.transportbox.Text = "Déduction transport";
            this.transportbox.UseVisualStyleBackColor = true;
            this.transportbox.CheckedChanged += new System.EventHandler(this.transportbox_CheckedChanged);
            // 
            // rabaisbox
            // 
            this.rabaisbox.AutoSize = true;
            this.rabaisbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabaisbox.Location = new System.Drawing.Point(118, 271);
            this.rabaisbox.Name = "rabaisbox";
            this.rabaisbox.Size = new System.Drawing.Size(145, 22);
            this.rabaisbox.TabIndex = 3;
            this.rabaisbox.Text = "Rabais fidélité (%)";
            this.rabaisbox.UseVisualStyleBackColor = true;
            this.rabaisbox.CheckedChanged += new System.EventHandler(this.rabaisbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coefficient familial";
            // 
            // Annuelbox
            // 
            this.Annuelbox.Location = new System.Drawing.Point(261, 61);
            this.Annuelbox.Name = "Annuelbox";
            this.Annuelbox.Size = new System.Drawing.Size(100, 20);
            this.Annuelbox.TabIndex = 5;
            this.Annuelbox.TextChanged += new System.EventHandler(this.Annuelbox_TextChanged);
            // 
            // Coefficientbox
            // 
            this.Coefficientbox.Location = new System.Drawing.Point(314, 102);
            this.Coefficientbox.Name = "Coefficientbox";
            this.Coefficientbox.Size = new System.Drawing.Size(47, 20);
            this.Coefficientbox.TabIndex = 6;
            this.Coefficientbox.TextChanged += new System.EventHandler(this.Coefficientbox_TextChanged);
            // 
            // cmdcalcul
            // 
            this.cmdcalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcalcul.Location = new System.Drawing.Point(137, 331);
            this.cmdcalcul.Name = "cmdcalcul";
            this.cmdcalcul.Size = new System.Drawing.Size(104, 30);
            this.cmdcalcul.TabIndex = 7;
            this.cmdcalcul.Text = "Calcul";
            this.cmdcalcul.UseVisualStyleBackColor = true;
            this.cmdcalcul.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(314, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "900";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 271);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(314, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "650";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Revenu imposable : fr.";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "...";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 428);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Annuelbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdcalcul);
            this.Controls.Add(this.Coefficientbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rabaisbox);
            this.Controls.Add(this.transportbox);
            this.Controls.Add(this.Jeunebox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Déductions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Jeunebox;
        private System.Windows.Forms.CheckBox transportbox;
        private System.Windows.Forms.CheckBox rabaisbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Annuelbox;
        private System.Windows.Forms.TextBox Coefficientbox;
        private System.Windows.Forms.Button cmdcalcul;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

