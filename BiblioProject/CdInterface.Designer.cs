namespace BiblioProject
{
    partial class CdInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CdInterface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textForm = new System.Windows.Forms.Label();
            this.titreBox = new System.Windows.Forms.TextBox();
            this.auteurBox = new System.Windows.Forms.TextBox();
            this.ajouterBtncd = new Guna.UI2.WinForms.Guna2Button();
            this.annulerBtncd = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.textForm);
            this.panel1.Location = new System.Drawing.Point(497, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 56);
            this.panel1.TabIndex = 10;
            // 
            // textForm
            // 
            this.textForm.AutoSize = true;
            this.textForm.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textForm.ForeColor = System.Drawing.Color.White;
            this.textForm.Location = new System.Drawing.Point(74, 0);
            this.textForm.Name = "textForm";
            this.textForm.Size = new System.Drawing.Size(271, 52);
            this.textForm.TabIndex = 0;
            this.textForm.Text = "Ajouter un CD";
            this.textForm.Click += new System.EventHandler(this.textForm_Click);
            // 
            // titreBox
            // 
            this.titreBox.BackColor = System.Drawing.Color.White;
            this.titreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titreBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titreBox.Location = new System.Drawing.Point(565, 160);
            this.titreBox.Name = "titreBox";
            this.titreBox.PlaceholderText = "Titre";
            this.titreBox.Size = new System.Drawing.Size(293, 38);
            this.titreBox.TabIndex = 11;
            // 
            // auteurBox
            // 
            this.auteurBox.BackColor = System.Drawing.Color.White;
            this.auteurBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.auteurBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.auteurBox.Location = new System.Drawing.Point(565, 274);
            this.auteurBox.Name = "auteurBox";
            this.auteurBox.PlaceholderText = "Auteur";
            this.auteurBox.Size = new System.Drawing.Size(308, 38);
            this.auteurBox.TabIndex = 12;
            // 
            // ajouterBtncd
            // 
            this.ajouterBtncd.BackColor = System.Drawing.Color.Transparent;
            this.ajouterBtncd.BorderColor = System.Drawing.Color.Transparent;
            this.ajouterBtncd.BorderRadius = 10;
            this.ajouterBtncd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ajouterBtncd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ajouterBtncd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ajouterBtncd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ajouterBtncd.FillColor = System.Drawing.Color.Transparent;
            this.ajouterBtncd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ajouterBtncd.ForeColor = System.Drawing.Color.White;
            this.ajouterBtncd.Location = new System.Drawing.Point(536, 414);
            this.ajouterBtncd.Name = "ajouterBtncd";
            this.ajouterBtncd.PressedColor = System.Drawing.Color.Transparent;
            this.ajouterBtncd.Size = new System.Drawing.Size(128, 32);
            this.ajouterBtncd.TabIndex = 13;
            this.ajouterBtncd.Text = "Ajouter";
            this.ajouterBtncd.Click += new System.EventHandler(this.ajouterBtncd_Click);
            // 
            // annulerBtncd
            // 
            this.annulerBtncd.BackColor = System.Drawing.Color.Transparent;
            this.annulerBtncd.BorderColor = System.Drawing.Color.Transparent;
            this.annulerBtncd.BorderRadius = 10;
            this.annulerBtncd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.annulerBtncd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.annulerBtncd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.annulerBtncd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.annulerBtncd.FillColor = System.Drawing.Color.Transparent;
            this.annulerBtncd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.annulerBtncd.ForeColor = System.Drawing.Color.White;
            this.annulerBtncd.Location = new System.Drawing.Point(745, 414);
            this.annulerBtncd.Name = "annulerBtncd";
            this.annulerBtncd.PressedColor = System.Drawing.Color.Transparent;
            this.annulerBtncd.Size = new System.Drawing.Size(128, 32);
            this.annulerBtncd.TabIndex = 14;
            this.annulerBtncd.Text = "Annuler";
            this.annulerBtncd.Click += new System.EventHandler(this.annulerBtncd_Click);
            // 
            // CdInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 494);
            this.Controls.Add(this.annulerBtncd);
            this.Controls.Add(this.ajouterBtncd);
            this.Controls.Add(this.auteurBox);
            this.Controls.Add(this.titreBox);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CdInterface";
            this.Text = "CdInterface";
            this.Load += new System.EventHandler(this.CdInterface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label textForm;
        private TextBox titreBox;
        private TextBox auteurBox;
        private Guna.UI2.WinForms.Guna2Button ajouterBtncd;
        private Guna.UI2.WinForms.Guna2Button annulerBtncd;
    }
}