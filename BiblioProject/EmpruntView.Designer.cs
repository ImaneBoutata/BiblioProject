namespace BiblioProject
{
    partial class EmpruntView
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
            this.livreCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ClientCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cdCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.periodiqueCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // livreCombo
            // 
            this.livreCombo.BackColor = System.Drawing.Color.Transparent;
            this.livreCombo.BorderRadius = 20;
            this.livreCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.livreCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.livreCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.livreCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.livreCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.livreCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.livreCombo.ItemHeight = 30;
            this.livreCombo.Location = new System.Drawing.Point(818, 153);
            this.livreCombo.Name = "livreCombo";
            this.livreCombo.Size = new System.Drawing.Size(210, 36);
            this.livreCombo.TabIndex = 4;
            this.livreCombo.Tag = "Client";
            // 
            // ClientCombo
            // 
            this.ClientCombo.BackColor = System.Drawing.Color.Transparent;
            this.ClientCombo.BorderRadius = 20;
            this.ClientCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ClientCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ClientCombo.ItemHeight = 30;
            this.ClientCombo.Location = new System.Drawing.Point(530, 153);
            this.ClientCombo.Name = "ClientCombo";
            this.ClientCombo.Size = new System.Drawing.Size(210, 36);
            this.ClientCombo.TabIndex = 5;
            this.ClientCombo.SelectedIndexChanged += new System.EventHandler(this.ClientCombo_SelectedIndexChanged);
            this.ClientCombo.TextChanged += new System.EventHandler(this.ClientCombo_TextChanged);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.Blue;
            this.guna2DateTimePicker1.BorderRadius = 20;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(540, 240);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(261, 47);
            this.guna2DateTimePicker1.TabIndex = 6;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 11, 22, 23, 6, 37, 621);
            // 
            // cdCombo
            // 
            this.cdCombo.BackColor = System.Drawing.Color.Transparent;
            this.cdCombo.BorderRadius = 20;
            this.cdCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cdCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cdCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cdCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cdCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cdCombo.ItemHeight = 30;
            this.cdCombo.Location = new System.Drawing.Point(554, 333);
            this.cdCombo.Name = "cdCombo";
            this.cdCombo.Size = new System.Drawing.Size(210, 36);
            this.cdCombo.TabIndex = 7;
            this.cdCombo.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox3_SelectedIndexChanged);
            // 
            // periodiqueCombo
            // 
            this.periodiqueCombo.BackColor = System.Drawing.Color.Transparent;
            this.periodiqueCombo.BorderRadius = 20;
            this.periodiqueCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.periodiqueCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodiqueCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.periodiqueCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.periodiqueCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.periodiqueCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.periodiqueCombo.ItemHeight = 30;
            this.periodiqueCombo.Location = new System.Drawing.Point(865, 333);
            this.periodiqueCombo.Name = "periodiqueCombo";
            this.periodiqueCombo.Size = new System.Drawing.Size(210, 36);
            this.periodiqueCombo.TabIndex = 8;
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.Transparent;
            this.ajouter.BorderColor = System.Drawing.Color.Transparent;
            this.ajouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ajouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ajouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ajouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ajouter.FillColor = System.Drawing.Color.Transparent;
            this.ajouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ajouter.ForeColor = System.Drawing.Color.White;
            this.ajouter.Location = new System.Drawing.Point(598, 421);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(166, 48);
            this.ajouter.TabIndex = 9;
            this.ajouter.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2DateTimePicker2.BorderColor = System.Drawing.Color.Blue;
            this.guna2DateTimePicker2.BorderRadius = 20;
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(818, 241);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(261, 47);
            this.guna2DateTimePicker2.TabIndex = 10;
            this.guna2DateTimePicker2.Value = new System.DateTime(2022, 11, 22, 23, 6, 37, 621);
            this.guna2DateTimePicker2.ValueChanged += new System.EventHandler(this.guna2DateTimePicker2_ValueChanged);
            // 
            // EmpruntView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BiblioProject.Properties.Resources.WhatsApp_Image_2022_11_22_at_14_23_26;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1137, 583);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.periodiqueCombo);
            this.Controls.Add(this.cdCombo);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.ClientCombo);
            this.Controls.Add(this.livreCombo);
            this.Name = "EmpruntView";
            this.Text = "EmpruntView";
            this.Load += new System.EventHandler(this.EmpruntView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox livreCombo;
        private Guna.UI2.WinForms.Guna2ComboBox ClientCombo;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2ComboBox cdCombo;
        private Guna.UI2.WinForms.Guna2ComboBox periodiqueCombo;
        private Guna.UI2.WinForms.Guna2Button ajouter;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
    }
}