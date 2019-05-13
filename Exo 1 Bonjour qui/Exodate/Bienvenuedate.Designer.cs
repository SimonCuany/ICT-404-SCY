namespace Test
{
    partial class frmBienvenue
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
            this.lblBienvenueTexte = new System.Windows.Forms.Label();
            this.lblBienvenueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenueTexte
            // 
            this.lblBienvenueTexte.AutoSize = true;
            this.lblBienvenueTexte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenueTexte.Location = new System.Drawing.Point(12, 60);
            this.lblBienvenueTexte.Name = "lblBienvenueTexte";
            this.lblBienvenueTexte.Size = new System.Drawing.Size(260, 25);
            this.lblBienvenueTexte.TabIndex = 0;
            this.lblBienvenueTexte.Text = "Bonjour, nous sommes le ";
            this.lblBienvenueTexte.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBienvenueDate
            // 
            this.lblBienvenueDate.AutoSize = true;
            this.lblBienvenueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenueDate.Location = new System.Drawing.Point(12, 127);
            this.lblBienvenueDate.Name = "lblBienvenueDate";
            this.lblBienvenueDate.Size = new System.Drawing.Size(30, 25);
            this.lblBienvenueDate.TabIndex = 1;
            this.lblBienvenueDate.Text = "...";
            this.lblBienvenueDate.DoubleClick += new System.EventHandler(this.lblBienvenueDate_DoubleClick);
            // 
            // frmBienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(387, 362);
            this.Controls.Add(this.lblBienvenueDate);
            this.Controls.Add(this.lblBienvenueTexte);
            this.Name = "frmBienvenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cours C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenueTexte;
        private System.Windows.Forms.Label lblBienvenueDate;
    }
}

