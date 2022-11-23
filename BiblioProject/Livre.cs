using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioProject
{
     class Livre : Ouvrage
    {
        String auteur;
        String titre;
        String editeur;

        public Livre(  String auteur, String titre, String editeur) 
        {
            this.auteur = auteur;
            this.titre = titre;
            this.editeur = editeur;
        }

        public string Auteur { get => auteur; set => auteur = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Editeur { get => editeur; set => editeur = value; }
    }
}
