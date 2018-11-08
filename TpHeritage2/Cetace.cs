using System;
using System.Collections.Generic;
using System.Text;

namespace TpHeritage2
{
    class Cetace:Mammifere
    {
        protected int DureeApnee;
        protected int ProfondeurPlongee;

        public Cetace(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, int DureeApnee, int ProfondeurPlongee)
            :base(nom, LieuHabitation, monCrie, jeSuisDomestique)
        {
            this.DureeApnee = DureeApnee;
            this.ProfondeurPlongee = ProfondeurPlongee;
        }
    }
}
