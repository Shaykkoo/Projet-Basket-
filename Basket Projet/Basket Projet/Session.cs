using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket_Projet
{
    public static class Session
    {
        private static string statutUser;
        private static int idUser;

        public static string GetStatutUser()
        {
            return statutUser;
        }

        public static void SetStatutUser(string statut)
        {
            statutUser = statut;
        }

        public static int GetIdUser()
        {
            return idUser;
        }

        public static void SetIdUser(int id)
        {
            idUser = id;
        }
    }
}
