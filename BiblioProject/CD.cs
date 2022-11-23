using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioProject
{
     class CD : Ouvrage
    {
        String titre;
        String auteur;

        public CD(String titre, String auteur) 
        {
            this.titre = titre;
            this.auteur = auteur;
        }

        public string Titre { get => titre; set => titre = value; }
        public string Auteur { get => auteur; set => auteur = value; }
    }
}
