namespace Exercice_Bonjour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textboxnom = new System.Windows.Forms.TextBox();
            this.lblbjr = new System.Windows.Forms.Label();
            this.bienvenu = new System.Windows.Forms.Button();
            this.cross = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre nom";
            // 
            // textboxnom
            // 
            this.textboxnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxnom.Location = new System.Drawing.Point(139, 153);
            this.textboxnom.Name = "textboxnom";
            this.textboxnom.Size = new System.Drawing.Size(119, 30);
            this.textboxnom.TabIndex = 1;
            this.textboxnom.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblbjr
            // 
            this.lblbjr.AutoSize = true;
            this.lblbjr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbjr.Location = new System.Drawing.Point(12, 222);
            this.lblbjr.Name = "lblbjr";
            this.lblbjr.Size = new System.Drawing.Size(30, 25);
            this.lblbjr.TabIndex = 2;
            this.lblbjr.Text = "...";
            this.lblbjr.Visible = false;
            this.lblbjr.Click += new System.EventHandler(this.label2_Click);
            // 
            // bienvenu
            // 
            this.bienvenu.Enabled = false;
            this.bienvenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenu.Location = new System.Drawing.Point(139, 267);
            this.bienvenu.Name = "bienvenu";
            this.bienvenu.Size = new System.Drawing.Size(119, 36);
            this.bienvenu.TabIndex = 3;
            this.bienvenu.Text = "Bienvenue ! ";
            this.bienvenu.UseVisualStyleBackColor = true;
            this.bienvenu.Click += new System.EventHandler(this.bienvenu_Click);
            // 
            // cross
            // 
            this.cross.Image = ((System.Drawing.Image)(resources.GetObject("cross.Image")));
            this.cross.Location = new System.Drawing.Point(299, 267);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(38, 36);
            this.cross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cross.TabIndex = 4;
            this.cross.TabStop = false;
            this.cross.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 351);
            this.Controls.Add(this.cross);
            this.Controls.Add(this.bienvenu);
            this.Controls.Add(this.lblbjr);
            this.Controls.Add(this.textboxnom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bonjour Qui ?";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cross)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxnom;
        private System.Windows.Forms.Label lblbjr;
        private System.Windows.Forms.Button bienvenu;
        private System.Windows.Forms.PictureBox cross;
    }
}

