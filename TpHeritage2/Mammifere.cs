using System;
using System.Collections.Generic;
using System.Text;

namespace TpHeritage2
{
    class Mammifere
    {
        protected string nom;
        protected string LieuHabitation;
        protected string monCrie;
        protected bool jeSuisDomestique;

        public Mammifere(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique)
        {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
        }

        public bool JeSuisDangereux()
        {
            if (jeSuisDomestique == true)
            {
                return false;
            }
            return true;
        }
    }
}
