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
        String cin;

        public Client(string nom, string prenom, string cin)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.cin = cin;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Cin { get => cin; set => cin = value; }
    }
}
