namespace BiblioProject
{
    partial class ClientInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInterface));
            this.nomBox = new System.Windows.Forms.TextBox();
            this.prenomBox = new System.Windows.Forms.TextBox();
            this.cinBox = new System.Windows.Forms.TextBox();
            this.ajouterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // nomBox
            // 
            this.nomBox.BackColor = System.Drawing.Color.White;
            this.nomBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomBox.Location = new System.Drawing.Point(158, 213);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(150, 24);
            this.nomBox.TabIndex = 2;
            this.nomBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // prenomBox
            // 
            this.prenomBox.BackColor = System.Drawing.Color.White;
            this.prenomBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenomBox.Location = new System.Drawing.Point(461, 213);
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.Size = new System.Drawing.Size(150, 24);
            this.prenomBox.TabIndex = 6;
            // 
            // cinBox
            // 
            this.cinBox.BackColor = System.Drawing.Color.White;
            this.cinBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cinBox.Location = new System.Drawing.Point(764, 213);
            this.cinBox.Name = "cinBox";
            this.cinBox.Size = new System.Drawing.Size(150, 24);
            this.cinBox.TabIndex = 7;
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
            this.ajouterBtn.Location = new System.Drawing.Point(392, 327);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.Size = new System.Drawing.Size(154, 60);
            this.ajouterBtn.TabIndex = 8;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
            // 
            // ClientInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1005, 550);
            this.Controls.Add(this.ajouterBtn);
            this.Controls.Add(this.cinBox);
            this.Controls.Add(this.prenomBox);
            this.Controls.Add(this.nomBox);
            this.DoubleBuffered = true;
            this.Name = "ClientInterface";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox nomBox;
        private TextBox prenomBox;
        private TextBox cinBox;
        private Guna.UI2.WinForms.Guna2Button ajouterBtn;
    }
}