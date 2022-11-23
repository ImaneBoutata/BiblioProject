using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioProject
{
     class Emprunt
    {
        String dateEmprunt;
        String dateRetour;
        String cinClient;
        String titreLivre;
        String titreCd;
        String nomPeriodique;

        public Emprunt(String dateEmprunt, String dateRetour, String cinClient, String titreLivre, String titreCd, String nomPeriodique)
        {
            this.dateEmprunt = dateEmprunt;
            this.dateRetour = dateRetour;
            this.cinClient=cinClient;
            this.titreLivre=titreLivre;
            this.titreCd=titreCd;
            this.nomPeriodique = nomPeriodique;
            
        }

        public String DateEmprunt { get => dateEmprunt; set => dateEmprunt = value; }
        public String DateRetour { get => dateRetour; set => dateRetour = value; }
        public string CinClient { get => cinClient; set => cinClient = value; }
        public string TitreLivre { get => titreLivre; set => titreLivre = value; }
        public string TitreCd { get => titreCd; set => titreCd = value; }
        public string NomPeriodique { get => nomPeriodique; set => nomPeriodique = value; }
    }
}
