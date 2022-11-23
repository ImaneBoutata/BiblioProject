namespace BiblioProject
{
    partial class LivreInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LivreInterface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textForm = new System.Windows.Forms.Label();
            this.titreBox = new System.Windows.Forms.TextBox();
            this.auteurBox = new System.Windows.Forms.TextBox();
            this.ediBox = new System.Windows.Forms.TextBox();
            this.ajouterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.annulerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.textForm);
            this.panel1.Location = new System.Drawing.Point(500, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 56);
            this.panel1.TabIndex = 11;
            // 
            // textForm
            // 
            this.textForm.AutoSize = true;
            this.textForm.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textForm.ForeColor = System.Drawing.Color.White;
            this.textForm.Location = new System.Drawing.Point(51, -8);
            this.textForm.Name = "textForm";
            this.textForm.Size = new System.Drawing.Size(305, 52);
            this.textForm.TabIndex = 0;
            this.textForm.Text = "Ajouter un livre";
            // 
            // titreBox
            // 
            this.titreBox.BackColor = System.Drawing.Color.White;
            this.titreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titreBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titreBox.Location = new System.Drawing.Point(551, 101);
            this.titreBox.Name = "titreBox";
            this.titreBox.PlaceholderText = "Titre";
            this.titreBox.Size = new System.Drawing.Size(293, 38);
            this.titreBox.TabIndex = 12;
            // 
            // auteurBox
            // 
            this.auteurBox.BackColor = System.Drawing.Color.White;
            this.auteurBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.auteurBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.auteurBox.Location = new System.Drawing.Point(551, 210);
            this.auteurBox.Name = "auteurBox";
            this.auteurBox.PlaceholderText = "Auteur";
            this.auteurBox.Size = new System.Drawing.Size(308, 38);
            this.auteurBox.TabIndex = 13;
            // 
            // ediBox
            // 
            this.ediBox.BackColor = System.Drawing.Color.White;
            this.ediBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ediBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ediBox.Location = new System.Drawing.Point(551, 321);
            this.ediBox.Name = "ediBox";
            this.ediBox.PlaceholderText = "Editeur";
            this.ediBox.Size = new System.Drawing.Size(308, 38);
            this.ediBox.TabIndex = 14;
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.BackColor = System.Drawing.Color.Transparent;
            this.ajouterBtn.BorderColor = System.Drawing.Color.Transparent;
            this.ajouterBtn.BorderRadius = 10;
            this.ajouterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ajouterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ajouterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ajouterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ajouterBtn.FillColor = System.Drawing.Color.Transparent;
            this.ajouterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ajouterBtn.ForeColor = System.Drawing.Color.White;
            this.ajouterBtn.Location = new System.Drawing.Point(537, 414);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.PressedColor = System.Drawing.Color.Transparent;
            this.ajouterBtn.Size = new System.Drawing.Size(128, 32);
            this.ajouterBtn.TabIndex = 15;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtncd_Click);
            // 
            // annulerBtn
            // 
            this.annulerBtn.BackColor = System.Drawing.Color.Transparent;
            this.annulerBtn.BorderColor = System.Drawing.Color.Transparent;
            this.annulerBtn.BorderRadius = 10;
            this.annulerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.annulerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.annulerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.annulerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.annulerBtn.FillColor = System.Drawing.Color.Transparent;
            this.annulerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.annulerBtn.ForeColor = System.Drawing.Color.White;
            this.annulerBtn.Location = new System.Drawing.Point(748, 414);
            this.annulerBtn.Name = "annulerBtn";
            this.annulerBtn.PressedColor = System.Drawing.Color.Transparent;
            this.annulerBtn.Size = new System.Drawing.Size(128, 32);
            this.annulerBtn.TabIndex = 16;
            this.annulerBtn.Text = "Annuler";
            this.annulerBtn.Click += new System.EventHandler(this.annulerBtn_Click);
            // 
            // LivreInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 494);
            this.Controls.Add(this.annulerBtn);
            this.Controls.Add(this.ajouterBtn);
            this.Controls.Add(this.ediBox);
            this.Controls.Add(this.auteurBox);
            this.Controls.Add(this.titreBox);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LivreInterface";
            this.Text = "LivreInterface";
            this.Load += new System.EventHandler(this.LivreInterface_Load);
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
        private TextBox ediBox;
        private Guna.UI2.WinForms.Guna2Button ajouterBtn;
        private Guna.UI2.WinForms.Guna2Button annulerBtn;
    }
}