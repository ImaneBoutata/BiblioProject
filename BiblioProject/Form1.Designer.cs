namespace BiblioProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.ajouterBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prenomBox = new System.Windows.Forms.TextBox();
            this.cinBox = new System.Windows.Forms.TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 143);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // nomBox
            // 
            this.nomBox.Location = new System.Drawing.Point(305, 207);
            this.nomBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(150, 31);
            this.nomBox.TabIndex = 2;
            // 
            // ajouterBtn
            // 
            this.ajouterBtn.Location = new System.Drawing.Point(612, 304);
            this.ajouterBtn.Name = "ajouterBtn";
            this.ajouterBtn.Size = new System.Drawing.Size(112, 34);
            this.ajouterBtn.TabIndex = 3;
            this.ajouterBtn.Text = "ajouter";
            this.ajouterBtn.UseVisualStyleBackColor = true;
            this.ajouterBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "CIN";
            // 
            // prenomBox
            // 
            this.prenomBox.Location = new System.Drawing.Point(305, 303);
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.Size = new System.Drawing.Size(150, 31);
            this.prenomBox.TabIndex = 6;
            // 
            // cinBox
            // 
            this.cinBox.Location = new System.Drawing.Point(305, 382);
            this.cinBox.Name = "cinBox";
            this.cinBox.Size = new System.Drawing.Size(150, 31);
            this.cinBox.TabIndex = 7;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 550);
            this.Controls.Add(this.cinBox);
            this.Controls.Add(this.prenomBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ajouterBtn);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox nomBox;
        private Button ajouterBtn;
        private Label label2;
        private Label label3;
        private TextBox prenomBox;
        private TextBox cinBox;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}