using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Basket_Projet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Seances s = new Seances(0, DateTime.Parse(dateTimeSeance.Text));
            if (BasketORM.AddSeance(s))
            {
                MessageBox.Show("Séance ajoutée");

            }
            else
            {
                MessageBox.Show("La séance n'a pas été ajouté");
            }
            listSeance.Items.Clear();
            listSeance.Items.AddRange(BasketORM.GetVoirSeances().ToArray());
        }

        private void buttonSeanceDelete_Click(object sender, EventArgs e)
        {
            Seances s = new Seances(0, Convert.ToDateTime(textSeanceDelete.Text));
            if (BasketORM.DelSeance(s))
            {
                MessageBox.Show("Séance supprimée");
            }
            else
            {
                MessageBox.Show("La séance n'a pas été supprimé");
            }
            listSeance.Items.Clear();
            listSeance.Items.AddRange(BasketORM.GetVoirSeances().ToArray());
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNomJoueurAdd_Click(object sender, EventArgs e)
        {

        }

        private void labelPrenomJoueurAdd_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }



        private void listSeance_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seances s = (Seances)listSeance.SelectedItem;
            textSeanceDelete.Text = s.getDateSeance().ToString("yyyy-MM-dd");
            textDateListInscrit.Text = s.getDateSeance().ToString("yyyy-MM-dd");
        }

        private void tabAgenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabFicheAdd_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasketORM.Connexion();

            tabControlAll.TabPages.Remove(tabAdmin);
            tabControlAll.TabPages.Remove(tabJoueur);
            tabControlAll.TabPages.Remove(tabCoach);

            listSeance.Items.Clear();
            listSeance.Items.AddRange(BasketORM.GetVoirSeances().ToArray());





        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            string statut = BasketORM.Login(textIdentifiantCon.Text, textMDPCon.Text);
            Session.SetStatutUser(statut);

            if (statut == "1")
            {
                MessageBox.Show("Bonjour admin.");
                labelEtatCon.Text = "Connexion réussie";
                tabControlAll.TabPages.Add(tabAdmin);
                tabControlAll.TabPages.Remove(tabJoueur);
                tabControlAll.TabPages.Remove(tabCoach);


            }
            else if (statut == "2")
            {
                MessageBox.Show("Bonjour Coach.");
                labelEtatCon.Text = "Connexion réussie";
                tabControlAll.TabPages.Add(tabCoach);
                tabControlAll.TabPages.Remove(tabJoueur);
                tabControlAll.TabPages.Remove(tabAdmin);
            }
            else if (statut == "3")
            {
                MessageBox.Show("Bonjour Joueur.");
                labelEtatCon.Text = "Connexion réussie";
                tabControlAll.TabPages.Add(tabJoueur);
                tabControlAll.TabPages.Remove(tabCoach);
                tabControlAll.TabPages.Remove(tabAdmin);
            }
            else
            {
                MessageBox.Show("Identifiant ou Mot de Passe incorrect.");
                labelEtatCon.Text = "Connexion échouée";
            }






            /*bool etatC = Connection.Connexion();
            if (etatC)
            {

                Login login = new Login(textIdentifiantCon.Text, textMDPCon.Text);
                if (login.CheckLogin())
                {
                    labelEtatCon.Text = "Connexion réussie";
                }
                else
                {
                    labelEtatCon.Text = "Connexion échouée";
                }
            }*/
        }

        private void textIdentifiantCon_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonJoueurAdd_Click(object sender, EventArgs e)
        {
            Joueur j = new Joueur(textNomJoueurAdd.Text, textPrenomJoueurAdd.Text, textMailJoueurAdd.Text, comboPosteJoueurAdd.SelectedIndex);
            if (BasketORM.AddJoueur(j))
            {
                MessageBox.Show("Compte crée");

            }
            else
            {
                MessageBox.Show("Le compte n'a pas ete crée");
            }
            listJoueur.Items.Clear();
            listJoueur.Items.AddRange(BasketORM.GetVoirJoueur().ToArray());


        }

        private void listJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Joueur j = (Joueur)listJoueur.SelectedItem;
            textNomJoueurDelete.Text = j.GetNomJoueur();
            textPrenomJoueurDelete.Text = j.GetPrenomJoueur();
            textNomJoueurModif.Text = j.GetNomJoueur();
            textPrenomJoueurModif.Text = j.GetPrenomJoueur();
        }

        private void buttonListJoueur_Click(object sender, EventArgs e)
        {
            listJoueur.Items.Clear();
            listJoueur.Items.AddRange(BasketORM.GetVoirJoueur().ToArray());
        }

        private void buttonJoueurDelete_Click(object sender, EventArgs e)
        {
            if (BasketORM.DelJoueur(textNomJoueurDelete.Text, textPrenomJoueurDelete.Text))
            {
                MessageBox.Show("Compte supprimé");

            }
            else
            {
                MessageBox.Show("Le compte n'a pas ete supprimé");
            }
            listJoueur.Items.Clear();
            listJoueur.Items.AddRange(BasketORM.GetVoirJoueur().ToArray());
        }

        private void buttonJoueurModif_Click_1(object sender, EventArgs e)
        {
            if (BasketORM.ModifJoueur(textNomJoueurModif.Text, textPrenomJoueurModif.Text, comboPosteJoueurModif.SelectedIndex))
            {
                MessageBox.Show("Poste Modifié");

            }
            else
            {
                MessageBox.Show("Le Poste n'a pas ete modifié");
            }
            listJoueur.Items.Clear();
            listJoueur.Items.AddRange(BasketORM.GetVoirJoueur().ToArray());
        }

        private void listCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coach c = (Coach)listCoach.SelectedItem;
            textNomCoachDelete.Text = c.GetNomCoach();
            textPrenomCoachDelete.Text = c.GetPrenomCoach();

        }

        private void buttonListCoach_Click(object sender, EventArgs e)
        {
            listCoach.Items.Clear();
            listCoach.Items.AddRange(BasketORM.GetVoirCoach().ToArray());
        }

        private void buttonCoachAdd_Click(object sender, EventArgs e)
        {
            Coach c = new Coach(textNomCoachAdd.Text, textPrenomCoachAdd.Text, textMailCoachAdd.Text);
            if (BasketORM.AddCoach(c))
            {
                MessageBox.Show("Coach crée");

            }
            else
            {
                MessageBox.Show("Le compte n'a pas ete crée");
            }
            listCoach.Items.Clear();
            listCoach.Items.AddRange(BasketORM.GetVoirCoach().ToArray());
        }

        private void buttonCoachDelete_Click(object sender, EventArgs e)
        {
            Coach c = new Coach(textNomCoachAdd.Text, textPrenomCoachAdd.Text, textMailCoachAdd.Text);
            if (BasketORM.DelCoach(c))
            {
                MessageBox.Show("Compte Supprimer");

            }
            else
            {
                MessageBox.Show("Le compte n'a pas été supprimé");
            }
            listCoach.Items.Clear();
            listCoach.Items.AddRange(BasketORM.GetVoirCoach().ToArray());
        }

        private void buttonListSeances_Click(object sender, EventArgs e)
        {
            listSeance.Items.Clear();
            listSeance.Items.AddRange(BasketORM.GetVoirSeances().ToArray());
        }

        private void dateTimeSeance_ValueChanged(object sender, EventArgs e)
        {
            dateTimeSeance.Format = DateTimePickerFormat.Custom;
            dateTimeSeance.CustomFormat = "yyyy-MM-dd";
        }

        private void buttonJoueurPresence_Click(object sender, EventArgs e)
        {
            if (BasketORM.PresenceJoueur(listSeance.SelectedItem.ToString()))
            {
                MessageBox.Show("Présent");

            }
            else
            {
                MessageBox.Show("Vous n'avez pas pu être inscrit");
            }
        }

        private void buttonCoachPresence_Click(object sender, EventArgs e)
        {
            if (BasketORM.PresenceCoach(listSeance.SelectedItem.ToString()))
            {
                MessageBox.Show("Présent");

            }
            else
            {
                MessageBox.Show("Vous n'avez pas pu être inscrit");
            }

        }

        private void tabJoueur_Click(object sender, EventArgs e)
        {

        }

        private void textDateListInscrit_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonListInscrit_Click(object sender, EventArgs e)
        {
            string phrase = BasketORM.GetInscrits(textDateListInscrit.Text);
            

            MessageBox.Show(phrase);
        }
    }
}