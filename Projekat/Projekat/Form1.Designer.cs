namespace Projekat
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
            this.labelIme = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(168, 66);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(93, 20);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Unesite ime";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Location = new System.Drawing.Point(168, 172);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(117, 20);
            this.labelLozinka.TabIndex = 2;
            this.labelLozinka.Text = "Unesite lozinku";
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(358, 172);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.PasswordChar = '*';
            this.textBoxLozinka.Size = new System.Drawing.Size(197, 26);
            this.textBoxLozinka.TabIndex = 4;
            this.textBoxLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(358, 66);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(197, 26);
            this.textBoxIme.TabIndex = 6;
            this.textBoxIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Location = new System.Drawing.Point(172, 256);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(175, 47);
            this.buttonPrijava.TabIndex = 7;
            this.buttonPrijava.Text = "Log In";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(472, 256);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(141, 47);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(168, 120);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(124, 20);
            this.labelPrezime.TabIndex = 9;
            this.labelPrezime.Text = "Unesite prezime";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(358, 117);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(197, 26);
            this.textBoxPrezime.TabIndex = 10;
            this.textBoxPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.labelIme);
            this.Name = "Form1";
            this.Text = "Logovanje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox textBoxPrezime;
    }
}

