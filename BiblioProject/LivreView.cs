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
    public partial class LivreView : Form
    {

        private readonly Home _parent;

        public LivreView(Home parent)
        {
            InitializeComponent();
            _parent = parent;

        }
        public void Clear()
        {
            auteurBox.Text = titreBox.Text = editeurBox.Text = String.Empty;
        }

        private void ajouterBtn_Click(object sender, EventArgs e)
        {
          
            if (ajouterBtn.Text == "Ajouter")
            {

                Livre c = new Livre(auteurBox.Text.Trim(), titreBox.Text.Trim(), editeurBox.Text.Trim());
                Livredb.AddLivre(c);
                Clear();
            }
            _parent.Display();
        }
    }
}
