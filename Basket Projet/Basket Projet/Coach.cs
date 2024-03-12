using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket_Projet
{
    public class Coach
    {
        private string nomCoach;
        private string prenomCoach;
        private string mailCoach;

        //contructeur
        public Coach(string nomCoach, string prenomCoach, string mailCoach)
        {
            this.nomCoach = nomCoach;
            this.prenomCoach = prenomCoach;
            this.mailCoach = mailCoach;
        }

        //getter
        public string GetNomCoach()
        {
            return nomCoach;
        }
        public string GetPrenomCoach()
        {
            return prenomCoach;
        }
        public string GetMailCoach()
        {
            return mailCoach;
        }

        public override string ToString()
        {
            return nomCoach + " | " + prenomCoach + " | " + mailCoach;
        }
    }
}
