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
    public partial class LivreInterface : Form
    {
        private readonly ListeLivreInterface _parent;
        public string  titre, auteur, editeur;
        public int id;
        public LivreInterface(ListeLivreInterface parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            textForm.Text = "Modifier un livre ";
            ajouterBtn.Text = "Modifier";
            titreBox.Text = titre;
            auteurBox.Text = auteur;



        }

        private void annulerBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LivreInterface_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            titreBox.Text = auteurBox.Text =ediBox.Text= String.Empty;
        }
        private void ajouterBtncd_Click(object sender, EventArgs e)
        {
            if (titreBox.Text.Trim().Length < 3)
            {
                MessageBox.Show("le titre de livre est  > 3");
                return;
            }
            if (ajouterBtn.Text == "Ajouter")
            {

                Livre l = new Livre(titreBox.Text.Trim(), auteurBox.Text.Trim(), ediBox.Text.Trim());
                textForm.Text = "Ajouter un livre ";
                ajouterBtn.Text = "Ajouter";
                titreBox.Text = titre;
                auteurBox.Text = auteur;
                ediBox.Text = editeur;
                Livredb.AddLivre(l);
                Clear();

            }
            if (ajouterBtn.Text == "Modifier")
            {


                Livre l = new Livre(titreBox.Text.Trim(), auteurBox.Text.Trim(), ediBox.Text.Trim());
                Livredb.UpdateLivre(l, id);
                Clear();

            }
            _parent.Display();
        }
    }
    }

