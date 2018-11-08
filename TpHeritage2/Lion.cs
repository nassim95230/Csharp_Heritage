using System;
using System.Collections.Generic;
using System.Text;

namespace TpHeritage2
{
    class Lion:Felin
    {
        public Lion(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, int nombrePattes)
            :base(nom, LieuHabitation, monCrie, jeSuisDomestique, nombrePattes)
        {

        }

        public void Affichage()
        {
            string affichage;
            affichage = "Son nom est" + nom + "son lieu d'habitation" + LieuHabitation + "son cri" + monCrie + "ses nombres de pattes sont" + nombrePattes;
        }
    }
}
