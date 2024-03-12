using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Basket_Projet
{
    public static class BasketORM
    {

        static int idUser = 0;
        static string nomUser = null;
        static string prenomUser = null;
        static int idStatut = 0;
        static string mailUser = null;
        static int telUser = 0;
        static string username = null;
        static string password = null;

        private static MySqlConnection conn = null;


        public static bool Connexion()
        {
            string cs = @"server=localhost;userid=root;password=;database=basket3";
            conn = new MySqlConnection(cs);
            conn.Open();
            return (conn.State == ConnectionState.Open);

        }
        public static bool Deconnexion()
        {
            conn.Close();
            return (conn.State == ConnectionState.Closed);
        }



        public static string Login(string username2, string pass)
        {

            MySqlCommand cmd = conn.CreateCommand();
            string req = "SELECT * FROM user WHERE username ='" + username2 + "' AND password ='" + pass + "'";
            cmd.CommandText = req;
            MySqlDataReader reader = cmd.ExecuteReader();
            string reponse = null;

            if (reader.Read())
            {
                

                idUser = reader.GetInt32("idUser");
                Session.SetIdUser(idUser);
                nomUser = reader["nomUser"].ToString();
                prenomUser = reader["prenomUser"].ToString();
                idStatut = reader.GetInt32("idStatut");
                username = reader["username"].ToString();
                password = reader["password"].ToString();

                if (idStatut == 1)
                {
                    reponse = "1";
                }
                else if (idStatut == 2)
                {
                    reponse = "2";
                }
                else
                {
                    reponse = "3";
                }
            }

            reader.Close();
            return reponse;
        }

        public static List<Joueur> GetVoirJoueur()
        {
            List<Joueur> listDesJoueur = new List<Joueur>();
            MySqlDataReader reader = null;
            MySqlCommand cmd = conn.CreateCommand();
            String reqafficheJoueur = "SELECT * FROM user WHERE idStatut = '3'";
            cmd.CommandText = reqafficheJoueur;
            reader = cmd.ExecuteReader();
            Joueur j = null;
            while (reader.Read())
            {
                j = new Joueur(reader.GetString("nomUser"), reader.GetString("prenomUser"), reader.GetString("mailUser"), reader.GetInt32("idPoste"));
                listDesJoueur.Add(j);
            }
            reader.Close();
            return listDesJoueur;

        }


        public static bool AddJoueur(Joueur j)
        {

            MySqlCommand cmd = conn.CreateCommand();
            String req = "INSERT INTO user (nomUser,prenomUser,mailUser,idStatut,idPoste) VALUES('" + j.GetNomJoueur() + "','" + j.GetPrenomJoueur() + "','" + j.GetMailJoueur() + "','3','" + j.GetIdPoste() + "')";
            cmd.CommandText = req;
            int insert = cmd.ExecuteNonQuery();
            return (insert == 1);

        }

        public static bool DelJoueur(string nomJoueur, string prenomJoueur)
        {

            MySqlCommand cmd = conn.CreateCommand();
            String req = "DELETE FROM user WHERE nomUser = '"+nomJoueur+"' AND prenomUser = '"+prenomJoueur+"'";
            cmd.CommandText = req;
            int insert = cmd.ExecuteNonQuery();
            return (insert == 1);

        }

        public static bool ModifJoueur(string nomJoueur, string prenomJoueur, int idPoste)
        {

            MySqlCommand cmd = conn.CreateCommand();
            String req = "UPDATE user SET idPoste = '" + idPoste + "' WHERE nomUser = '" + nomJoueur + "' AND prenomUser = '" + prenomJoueur +"' ";
            cmd.CommandText = req;
            int insert = cmd.ExecuteNonQuery();
            return (insert == 1);

        }




        public static List<Coach> GetVoirCoach()
        {
            List<Coach> listDesCoach = new List<Coach>();
            MySqlDataReader reader = null;
            MySqlCommand cmd = conn.CreateCommand();
            String reqafficheCoach = "SELECT * FROM user WHERE idStatut = '2'";
            cmd.CommandText = reqafficheCoach;
            reader = cmd.ExecuteReader();
            Coach c = null;
            while (reader.Read())
            {
                c = new Coach(reader.GetString("nomUser"), reader.GetString("prenomUser"), reader.GetString("mailUser"));
                listDesCoach.Add(c);
            }
            reader.Close();
            return listDesCoach;

        }


        public static bool AddCoach(Coach c)
        {

            MySqlCommand cmd = conn.CreateCommand();
            String req = "INSERT INTO user (nomUser,prenomUser,mailUser,idStatut,idPoste) VALUES('" + c.GetNomCoach() + "','" + c.GetPrenomCoach() + "','" + c.GetMailCoach() + "','2','6')";
            cmd.CommandText = req;
            int insert = cmd.ExecuteNonQuery();
            return (insert == 1);

        }

        public static bool DelCoach(Coach c)
        {

            MySqlCommand cmd = conn.CreateCommand();
            String req = "DELETE FROM user WHERE nomUser = '" + c.GetNomCoach() + "' AND prenomUser = '" + c.GetPrenomCoach() + "'";
            cmd.CommandText = req;
            int insert = cmd.ExecuteNonQuery();
            return (insert == 1);

        }





        public static List<Seances> GetVoirSeances()
        {
            List<Seances> listDesSeances = new List<Seances>();
            MySqlDataReader reader = null;
            MySqlCommand cmd = conn.CreateCommand();
            String reqafficheSeances = "SELECT * FROM seance";
            cmd.CommandText = reqafficheSeances;
            reader = cmd.ExecuteReader();
            Seances s = null;
            while (reader.Read())
            {
                s = new Seances(reader.GetInt32("idSeance"), reader.GetDateTime("dateSeance"));
                listDesSeances.Add(s);
            }
            reader.Close();
            return listDesSeances;

        }

        public static bool AddSeance(Seances s)
        {

            MySqlCommand cmd = conn.CreateCommand();
            String req = "INSERT INTO Seance (dateSeance) VALUES('" + s.getDateSeance().ToString("yyyy-MM-dd") + "')";
            cmd.CommandText = req;
            int insert = cmd.ExecuteNonQuery();
            return (insert == 1);

        }

        public static bool DelSeance(Seances s)
        {

            MySqlCommand cmd = conn.CreateCommand();
            String req = "DELETE FROM Seance WHERE dateSeance = '" + s.getDateSeance().ToString("yyyy-MM-dd") + "'";
            cmd.CommandText = req;
            int insert = cmd.ExecuteNonQuery();
            return (insert == 1);

        }


        public static bool PresenceJoueur(string dateSeance)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String req = "SELECT idSeance FROM seance WHERE dateSeance = '" + dateSeance + "'";
            cmd.CommandText = req;
            MySqlDataReader reader = cmd.ExecuteReader();

            int idSeance = 0;
            
            if(reader.Read())
            {
                
                idSeance = reader.GetInt32("idSeance");
            }

            reader.Close();

            MySqlCommand cmd2 = conn.CreateCommand();
            String req2 = "INSERT INTO participe (idSeance, idUser) VALUES('" + idSeance + "', '" + idUser + "')";
            cmd2.CommandText = req2;
            int insert2 = cmd2.ExecuteNonQuery();
            return (insert2 == 1);

        }


        public static bool PresenceCoach(string dateSeance)
        {

            MySqlCommand cmd = conn.CreateCommand();
            String req = "SELECT idSeance FROM seance WHERE dateSeance = '" + dateSeance + "'";
            cmd.CommandText = req;
            MySqlDataReader reader = cmd.ExecuteReader();

            int idSeance = 0;

            if (reader.Read())
            {

                idSeance = reader.GetInt32("idSeance");
            }

            reader.Close();

            MySqlCommand cmd2 = conn.CreateCommand();
            String req2 = "INSERT INTO participe (idSeance, idUser) VALUES('" + idSeance + "', '" + idUser + "')";
            cmd2.CommandText = req2;
            int insert2 = cmd2.ExecuteNonQuery();
            return (insert2 == 1);

        }

        public static string GetInscrits(string dateSeance)
        {

            MySqlCommand cmd = conn.CreateCommand();
            String req = "SELECT user.idStatut, user.nomUser, user.prenomUser FROM user " +
                "INNER JOIN participe ON user.idUser = participe.idUser " +
                "INNER JOIN seance ON participe.idSeance = seance.idSeance " +
                "WHERE seance.dateSeance = '" + dateSeance + "'" +
                "ORDER BY `user`.`idStatut` ASC";
            cmd.CommandText = req;
            MySqlDataReader reader = cmd.ExecuteReader();

            var idStatut = new List<int>();
            var nomUser = new List<string>();
            var prenomUser = new List<string>();
            int i = 0;
            while (reader.Read())
            {
                idStatut.Add(reader.GetInt32("idStatut"));
                nomUser.Add(reader.GetString("nomUser"));
                prenomUser.Add(reader.GetString("prenomUser"));
                i++;
            }

            reader.Close();
            int j = 0;
            string resultat = "";
    
            while (j < i)
            {
                if (idStatut[j] == 2)
                {
                    resultat += "Coach \n" + nomUser[j] + " " + prenomUser[j] + "\n\n";
                }
                else if (idStatut[j] == 3)
                {
                    resultat += "Joueur \n" + nomUser[j] + " " + prenomUser[j] + "\n\n";
                }
                else
                {
                    resultat += "Erreur\n";
                }
                j++;
            }
            return resultat;
        }
    }
}


