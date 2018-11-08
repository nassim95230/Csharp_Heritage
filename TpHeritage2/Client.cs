using System;
using System.Collections.Generic;
using System.Text;

namespace TpHeritage2
{
    class Client
    {
        protected string nom;
        protected string prenom;
        protected int numero;

        public Client(string nom, string prenom, int numero)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.numero = numero;
        }
    }
}
