using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioProject
{
     class Ouvrage
    {

       
        int cote;

        public Ouvrage( int cote)
        {
         
            this.cote = cote;

        }

     
        public int Cote { get => cote; set => cote = value; }
    }
}
