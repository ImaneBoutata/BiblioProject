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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textForm = new System.Windows.Forms.Label();
            this.annulerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomBox
            // 
            this.nomBox.BackColor = System.Drawing.Color.White;
            this.nomBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomBox.Location = new System.Drawing.Point(141, 199);
            this.nomBox.Name = "nomBox";
            this.nomBox.PlaceholderText = "Nom";
            this.nomBox.Size = new System.Drawing.Size(308, 38);
            this.nomBox.TabIndex = 2;
            this.nomBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // prenomBox
            // 
            this.prenomBox.BackColor = System.Drawing.Color.White;
            this.prenomBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenomBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prenomBox.Location = new System.Drawing.Point(455, 199);
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.PlaceholderText = "Prenom";
            this.prenomBox.Size = new System.Drawing.Size(308, 38);
            this.prenomBox.TabIndex = 6;
            // 
            // cinBox
            // 
            this.cinBox.BackColor = System.Drawing.Color.White;
            this.cinBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cinBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cinBox.Location = new System.Drawing.Point(568, 360);
            this.cinBox.Name = "cinBox";
            this.cinBox.PlaceholderText = "CIN";
            this.cinBox.Size = new System.Drawing.Size(301, 38);
            this.cinBox.TabIndex = 7;
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
            this.ajouterBtn.Location = new System.Drawing.Point(546, 460);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.PressedColor = System.Drawing.Color.Transparent;
            this.ajouterBtn.Size = new System.Drawing.Size(128, 32);
            this.ajouterBtn.TabIndex = 8;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.textForm);
            this.panel1.Location = new System.Drawing.Point(485, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 56);
            this.panel1.TabIndex = 9;
            // 
            // textForm
            // 
            this.textForm.AutoSize = true;
            this.textForm.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textForm.ForeColor = System.Drawing.Color.White;
            this.textForm.Location = new System.Drawing.Point(87, 0);
            this.textForm.Name = "textForm";
            this.textForm.Size = new System.Drawing.Size(321, 52);
            this.textForm.TabIndex = 0;
            this.textForm.Text = "Ajouter un client";
            this.textForm.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // annulerBtn
            // 
            this.annulerBtn.BackColor = System.Drawing.Color.Transparent;
            this.annulerBtn.BorderColor = System.Drawing.Color.Transparent;
            this.annulerBtn.BorderRadius = 10;
            this.annulerBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.annulerBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.annulerBtn.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.annulerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.annulerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.annulerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.annulerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.annulerBtn.FillColor = System.Drawing.Color.Transparent;
            this.annulerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.annulerBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.annulerBtn.Location = new System.Drawing.Point(770, 460);
            this.annulerBtn.Name = "annulerBtn";
            this.annulerBtn.Size = new System.Drawing.Size(118, 35);
            this.annulerBtn.TabIndex = 10;
            this.annulerBtn.Text = "Annuler";
            this.annulerBtn.Click += new System.EventHandler(this.annulerBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(426, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 33);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Text";
            // 
            // ClientInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 550);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.annulerBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ajouterBtn);
            this.Controls.Add(this.cinBox);
            this.Controls.Add(this.prenomBox);
            this.Controls.Add(this.nomBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientInterface";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox nomBox;
        private TextBox prenomBox;
        private TextBox cinBox;
        private Guna.UI2.WinForms.Guna2Button ajouterBtn;
        private Panel panel1;
        private Label textForm;
        private Guna.UI2.WinForms.Guna2Button annulerBtn;
        private ComboBox comboBox1;
    }
}