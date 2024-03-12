using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket_Projet
{
    public class Joueur
    {
        private int idJoueur;
        private string nomJoueur;
        private string prenomJoueur;
        private string mailJoueur;
        private int idPoste;

        //constructeur
        public Joueur(string nomJoueur, string prenomJoueur, string mailJoueur, int idPoste)
        {
            this.nomJoueur = nomJoueur;
            this.prenomJoueur = prenomJoueur;
            this.mailJoueur = mailJoueur;
            this.idPoste = idPoste;
        }

        //getter 
        public int GetIdJoueur()
        {
            return idJoueur;
        }
        public string GetNomJoueur()
        {
            return nomJoueur;
        }
        public string GetPrenomJoueur()
        {
            return prenomJoueur;
        }
        public string GetMailJoueur()
        {
            return mailJoueur;
        }
        public int GetIdPoste()
        {
            return idPoste;
        }

        //public override bool equals
        /* public override bool Equals(object obj)
        {
            Joueur j;
            if (obj is Joueur)
            {
                j = (Joueur)obj;
                if (this.idJoueur.Equals(j.idJoueur))
                {
                    return true;
                }
            }
            return false;
        }*/

            public override string ToString()
        {
            return nomJoueur + " | " + prenomJoueur + " | " + mailJoueur + " | " + idPoste;
        }
    }

}

