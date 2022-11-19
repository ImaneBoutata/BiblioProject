using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioProject
{
     class Emprunt
    {
        DateTime dateEmprunt;
        DateTime dateRetour;
        Client client;
        Ouvrage ouvrage;

        public Emprunt(DateTime dateEmprunt, DateTime dateRetour, Client client, Ouvrage ouvrage)
        {
            this.dateEmprunt = dateEmprunt;
            this.dateRetour = dateRetour;
            this.client = client;
            this.ouvrage = ouvrage;
        }

        public DateTime DateEmprunt { get => dateEmprunt; set => dateEmprunt = value; }
        public DateTime DateRetour { get => dateRetour; set => dateRetour = value; }
        internal Client Client { get => client; set => client = value; }
        internal Ouvrage Ouvrage { get => ouvrage; set => ouvrage = value; }
    }
}
