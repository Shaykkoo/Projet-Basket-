using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket_Projet
{
    public class Seances
    {
        //variables des séances
        private int idSeance;
        private DateTime dateSeance;

        //constructeur  
        public Seances(int idSeance, DateTime dateSeance)
        {
            this.idSeance = idSeance;
            this.dateSeance = dateSeance;
        }

        public int getIdSeance()
        {
            return idSeance;
        }

        public DateTime getDateSeance()
        {
            return dateSeance;
        }

        public override bool Equals(object obj)
        {
            Seances s;
            if (obj is Seances)
            {
                s = (Seances)obj;
                if (this.idSeance.Equals(s.idSeance))
                { return true; }

            }
            return false;
        }

        public override string ToString()
        {
            return "" + dateSeance.ToString("yyyy-MM-dd");
        }
    }
}
