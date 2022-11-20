namespace BiblioProject
{
    partial class LivreView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editeurBox = new System.Windows.Forms.TextBox();
            this.titreBox = new System.Windows.Forms.TextBox();
            this.auteurBox = new System.Windows.Forms.TextBox();
            this.ajouterBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioProject.Properties.Resources.Ajouter_un_client;
            this.pictureBox1.Location = new System.Drawing.Point(46, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(946, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // editeurBox
            // 
            this.editeurBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editeurBox.Location = new System.Drawing.Point(723, 244);
            this.editeurBox.Name = "editeurBox";
            this.editeurBox.Size = new System.Drawing.Size(138, 24);
            this.editeurBox.TabIndex = 1;
            // 
            // titreBox
            // 
            this.titreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titreBox.Location = new System.Drawing.Point(462, 244);
            this.titreBox.Name = "titreBox";
            this.titreBox.Size = new System.Drawing.Size(131, 24);
            this.titreBox.TabIndex = 2;
            // 
            // auteurBox
            // 
            this.auteurBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.auteurBox.Location = new System.Drawing.Point(214, 244);
            this.auteurBox.Name = "auteurBox";
            this.auteurBox.Size = new System.Drawing.Size(136, 24);
            this.auteurBox.TabIndex = 3;
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.BorderRadius = 10;
            this.ajouterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ajouterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ajouterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ajouterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ajouterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.ajouterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ajouterBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ajouterBtn.Location = new System.Drawing.Point(390, 326);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.Size = new System.Drawing.Size(143, 56);
            this.ajouterBtn.TabIndex = 9;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
            // 
            // LivreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 579);
            this.Controls.Add(this.ajouterBtn);
            this.Controls.Add(this.auteurBox);
            this.Controls.Add(this.titreBox);
            this.Controls.Add(this.editeurBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LivreView";
            this.Text = "LivreView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox editeurBox;
        private TextBox titreBox;
        private TextBox auteurBox;
        private Guna.UI2.WinForms.Guna2Button ajouterBtn;
    }
}