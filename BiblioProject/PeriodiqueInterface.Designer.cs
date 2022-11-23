namespace BiblioProject
{
    partial class PeriodiqueInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeriodiqueInterface));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textForm = new System.Windows.Forms.Label();
            this.ajouterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.annulerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.numBox = new System.Windows.Forms.TextBox();
            this.perBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.textForm);
            this.panel1.Location = new System.Drawing.Point(499, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 56);
            this.panel1.TabIndex = 10;
            // 
            // textForm
            // 
            this.textForm.AutoSize = true;
            this.textForm.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textForm.ForeColor = System.Drawing.Color.White;
            this.textForm.Location = new System.Drawing.Point(4, 0);
            this.textForm.Name = "textForm";
            this.textForm.Size = new System.Drawing.Size(432, 52);
            this.textForm.TabIndex = 0;
            this.textForm.Text = "Ajouter une periodique";
            this.textForm.Click += new System.EventHandler(this.textForm_Click);
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
            this.ajouterBtn.Location = new System.Drawing.Point(535, 413);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.PressedColor = System.Drawing.Color.Transparent;
            this.ajouterBtn.Size = new System.Drawing.Size(128, 32);
            this.ajouterBtn.TabIndex = 9;
            this.ajouterBtn.Text = "Ajouter";
            this.ajouterBtn.Click += new System.EventHandler(this.ajouterBtn_Click);
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
            this.annulerBtn.Location = new System.Drawing.Point(749, 412);
            this.annulerBtn.Name = "annulerBtn";
            this.annulerBtn.Size = new System.Drawing.Size(118, 35);
            this.annulerBtn.TabIndex = 11;
            this.annulerBtn.Text = "Annuler";
            this.annulerBtn.Click += new System.EventHandler(this.annulerBtn_Click);
            // 
            // nomBox
            // 
            this.nomBox.BackColor = System.Drawing.Color.White;
            this.nomBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomBox.Location = new System.Drawing.Point(547, 99);
            this.nomBox.Name = "nomBox";
            this.nomBox.PlaceholderText = "Nom";
            this.nomBox.Size = new System.Drawing.Size(308, 38);
            this.nomBox.TabIndex = 12;
            // 
            // numBox
            // 
            this.numBox.BackColor = System.Drawing.Color.White;
            this.numBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numBox.Location = new System.Drawing.Point(547, 212);
            this.numBox.Name = "numBox";
            this.numBox.PlaceholderText = "Numero";
            this.numBox.Size = new System.Drawing.Size(308, 38);
            this.numBox.TabIndex = 13;
            this.numBox.TextChanged += new System.EventHandler(this.prenomBox_TextChanged);
            // 
            // perBox
            // 
            this.perBox.BackColor = System.Drawing.Color.White;
            this.perBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.perBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.perBox.Location = new System.Drawing.Point(547, 321);
            this.perBox.Name = "perBox";
            this.perBox.PlaceholderText = "Periodicité";
            this.perBox.Size = new System.Drawing.Size(301, 38);
            this.perBox.TabIndex = 14;
            // 
            // PeriodiqueInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 494);
            this.Controls.Add(this.perBox);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.annulerBtn);
            this.Controls.Add(this.ajouterBtn);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PeriodiqueInterface";
            this.Text = "PeriodiqueInterface";
            this.Load += new System.EventHandler(this.PeriodiqueInterface_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label textForm;
        private Guna.UI2.WinForms.Guna2Button ajouterBtn;
        private Guna.UI2.WinForms.Guna2Button annulerBtn;
        private TextBox nomBox;
        private TextBox numBox;
        private TextBox perBox;
    }
}