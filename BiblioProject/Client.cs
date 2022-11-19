using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioProject
{
     class Client
    {
        String nom;
        String prenom;
        String CIN;

        public Client(string nom, string prenom, string cin)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.CIN = cin;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Cin { get => CIN; set => CIN = value; }
    }
}
