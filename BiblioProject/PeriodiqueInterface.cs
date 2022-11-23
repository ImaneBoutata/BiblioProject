using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BiblioProject
{
    public partial class PeriodiqueInterface : Form
    {

        private readonly ListePeriodiqueInterface _parent;
        public int id;
        public string  nom, numero, periodicite;
        public PeriodiqueInterface(ListePeriodiqueInterface parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void textForm_Click(object sender, EventArgs e)
        {

        }

        private void annulerBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PeriodiqueInterface_Load(object sender, EventArgs e)
        {

        }
        public void UpdateInfo()
        {
            textForm.Text = "Modifier une periodique ";
            ajouterBtn.Text = "Modifier";
            nomBox.Text = nom;
            perBox.Text = periodicite;
            numBox.Text = numero;


        }
        public void Clear()
        {
            nomBox.Text = numBox.Text = perBox.Text = String.Empty;
        }
        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            if (nomBox.Text.Trim().Length < 3)
            {
                MessageBox.Show("le nom de periodique est  > 3");
                return;
            }
            if (ajouterBtn.Text == "Ajouter")
            {

                Periodique per = new Periodique(nomBox.Text.Trim(), numBox.Text.Trim(), perBox.Text.Trim());
                textForm.Text = "Ajouter une periodique ";
                ajouterBtn.Text = "Ajouter";
                nomBox.Text = nom;
                numBox.Text = numero;
                perBox.Text = periodicite;
                Periodiquedb.AddPeriodicite(per);
                Clear();

            }
            if (ajouterBtn.Text == "Modifier")
            {

                Periodique per = new Periodique(nomBox.Text.Trim(), numBox.Text.Trim(), perBox.Text.Trim());
                Periodiquedb.UpdatePeriodicite(per,id);
                Clear();

            }
            _parent.Display();
        }

        private void prenomBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
