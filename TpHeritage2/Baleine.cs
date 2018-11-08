using System;
using System.Collections.Generic;
using System.Text;

namespace TpHeritage2
{
    class Baleine:Cetace
    {
        public Baleine(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, int DureeApnee, int ProfondeurPlongee)
            : base(nom, LieuHabitation, monCrie, jeSuisDomestique, DureeApnee, ProfondeurPlongee)
        {

        }

        public void Afficher()
        {
            string affichage;
            affichage = "Son nom est" + nom + "son lieu d'habitation" + LieuHabitation + "son cri" + monCrie + "sa duree d'apnee" + DureeApnee + "sa profondeur de plongée" + ProfondeurPlongee;
        }
    }
}
