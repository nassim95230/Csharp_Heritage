using System;
using System.Collections.Generic;
using System.Text;

namespace TpHeritage2
{
    class Felin:Mammifere
    {
        protected int nombrePattes;

        public Felin(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, int nombrePattes)
            :base(nom, LieuHabitation, monCrie, jeSuisDomestique)
        {
            this.nombrePattes = nombrePattes;
        }
    }
}
