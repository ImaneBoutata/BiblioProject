using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioProject
{
    public partial class CdInterface : Form
    {
        public string  titre, auteur;
        public int id;

        private readonly ListeCdInterface _parent;/// <summary>
        ///  a ediiiterrrrrrr!!!!!!!!!!
        /// </summary>
       
        public CdInterface(ListeCdInterface parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void Clear()
        {
            titreBox.Text = auteurBox.Text =  String.Empty;
        }

        private void annulerBtncd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textForm_Click(object sender, EventArgs e)
        {

        }

        private void CdInterface_Load(object sender, EventArgs e)
        {

        }
        public void UpdateInfo()
        {
            textForm.Text = "Modifier un cd ";
            ajouterBtncd.Text = "Modifier";
            titreBox.Text = titre;
            auteurBox.Text = auteur;



        }
        private void ajouterBtncd_Click(object sender, EventArgs e)
        {
            if (titreBox.Text.Trim().Length < 3 )
            {
                MessageBox.Show("le titre est  > 3");
                return;
            }
            if (ajouterBtncd.Text == "Ajouter")
            {

                CD c = new CD(titreBox.Text.Trim(), auteurBox.Text.Trim());
                textForm.Text = "Ajouter un cd ";
                ajouterBtncd.Text = "Ajouter";
                titreBox.Text = titre;
                auteurBox.Text = auteur;
               
                CDdb.AddCD(c);
                Clear();

            }
            if (ajouterBtncd.Text == "Modifier")
            {

                CD c = new CD(titreBox.Text.Trim(), auteurBox.Text.Trim());
                CDdb.UpdateCD(c,id);
                Clear();

            }
            _parent.Display();
        }
    }
    }

