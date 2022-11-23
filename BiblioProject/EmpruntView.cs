using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BiblioProject
{
    public partial class EmpruntView : Form
    {
        private readonly EmpruntListe _parent;
        public string id, dateEmprunt, dateRetour, cinClient,titreLivre,titreCd,nomPeriodique;


        public EmpruntView(EmpruntListe parent)
        {
            InitializeComponent();
            _parent = parent;

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        
        private void EmpruntView_Load(object sender, EventArgs e)
        {
            ClientCombo.Text = "CIN Client";

            Empruntdb.DisplayComboBoxClient("SELECT CIN FROM CLIENT", livreCombo);
            Empruntdb.DisplayComboBoxLivre("SELECT TITRE FROM LIVRE", ClientCombo);
            Empruntdb.DisplayComboBoxCD("SELECT TITRE FROM CD", cdCombo);
            Empruntdb.DisplayComboBoxPeriodique("SELECT NOM FROM PERIODIQUE", periodiqueCombo);



        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            ClientCombo.Text=livreCombo.Text=cdCombo.Text=periodiqueCombo.Text=String.Empty;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           

            // if (guna2Button1.Text == "Ajouter")
            //{

            

            Emprunt emp = new Emprunt(guna2DateTimePicker1.Value.ToString("yyyy/MM/dd"), guna2DateTimePicker2.Value.ToString("yyyy/MM/dd"), ClientCombo.Text, livreCombo.Text, cdCombo.Text, periodiqueCombo.Text);
             Empruntdb.AddEmprunt(emp);
           // Clear();
             }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ClientCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClientCombo_TextChanged(object sender, EventArgs e)
        {
           
                //ClientCombo.Text = "CIN Client";
            
        }
        //_parent.Display();

    }
}
