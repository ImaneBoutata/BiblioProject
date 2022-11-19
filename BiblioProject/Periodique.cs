using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioProject
{
     class Periodique : Ouvrage
    {
        String nom;
        String numero;
        String periodicite;

        public Periodique( int cote, String nom, String numero, String periodicite) : base(cote)
        {
            this.nom = nom;
            this.numero= numero;
            this.periodicite = periodicite;
            
        }

        public string Nom { get => nom; set => nom = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Periodicite { get => periodicite; set => periodicite = value; }
    }
}
