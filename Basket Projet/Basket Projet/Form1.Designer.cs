namespace Basket_Projet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonConnexion = new Button();
            tabControlAll = new TabControl();
            tabJoueur = new TabPage();
            buttonJoueurPresence = new Button();
            tabCoach = new TabPage();
            groupListInscrit = new GroupBox();
            textDateListInscrit = new TextBox();
            buttonListInscrit = new Button();
            labelDateListInscrit = new Label();
            buttonCoachPresence = new Button();
            tabAdmin = new TabPage();
            tabAdminControl = new TabControl();
            tabAdminJoueur = new TabPage();
            buttonListJoueur = new Button();
            listJoueur = new ListBox();
            tab = new TabControl();
            tabAdminJoueurAdd = new TabPage();
            groupJoueurAdd = new GroupBox();
            textMailJoueurAdd = new TextBox();
            comboPosteJoueurAdd = new ComboBox();
            buttonJoueurAdd = new Button();
            textPrenomJoueurAdd = new TextBox();
            textNomJoueurAdd = new TextBox();
            labelPosteJoueurAdd = new Label();
            labelMailJoueurAdd = new Label();
            labelPrenomJoueurAdd = new Label();
            labelNomJoueurAdd = new Label();
            tabJoueurDelete = new TabPage();
            groupJoueurDelete = new GroupBox();
            buttonJoueurDelete = new Button();
            textPrenomJoueurDelete = new TextBox();
            textNomJoueurDelete = new TextBox();
            labelPrenomJoueurDelete = new Label();
            labelNomJoueurDelete = new Label();
            tabJoueurModif = new TabPage();
            groupJoueurModif = new GroupBox();
            comboPosteJoueurModif = new ComboBox();
            buttonJoueurModif = new Button();
            textPrenomJoueurModif = new TextBox();
            textNomJoueurModif = new TextBox();
            labelPosteJoueurModif = new Label();
            labelPrenomJoueurModif = new Label();
            labelNomJoueurModif = new Label();
            tabAdminCoach = new TabPage();
            buttonListCoach = new Button();
            listCoach = new ListBox();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            groupCoachAdd = new GroupBox();
            textMailCoachAdd = new TextBox();
            buttonCoachAdd = new Button();
            textPrenomCoachAdd = new TextBox();
            textNomCoachAdd = new TextBox();
            labelMailCoachAdd = new Label();
            labelPrenomCoachAdd = new Label();
            labelNomCoachAdd = new Label();
            tabPage2 = new TabPage();
            groupCoachDelete = new GroupBox();
            buttonCoachDelete = new Button();
            textPrenomCoachDelete = new TextBox();
            textNomCoachDelete = new TextBox();
            labelPrenomCoachDelete = new Label();
            labelNomCoachDelete = new Label();
            tabAdminSeance = new TabPage();
            tabControl1 = new TabControl();
            tabAdminSeanceAdd = new TabPage();
            groupAddSeance = new GroupBox();
            buttonAddSeance = new Button();
            dateTimeSeance = new DateTimePicker();
            labelDateSeance = new Label();
            tabAdminSeancesDelete = new TabPage();
            groupSeanceDelete = new GroupBox();
            textSeanceDelete = new TextBox();
            buttonSeanceDelete = new Button();
            labelDateSeanceDelete = new Label();
            listSeance = new ListBox();
            labelIDCon = new Label();
            labelMDP = new Label();
            textIdentifiantCon = new TextBox();
            textMDPCon = new TextBox();
            labelEtatCon = new Label();
            tabAgenda = new TabControl();
            tabSeance = new TabPage();
            buttonListSeances = new Button();
            labelNomCoachModif = new Label();
            labelPrenomCoachModif = new Label();
            textNomCoachModif = new TextBox();
            textPrenomCoachModif = new TextBox();
            buttonCoachModif = new Button();
            tabControlAll.SuspendLayout();
            tabJoueur.SuspendLayout();
            tabCoach.SuspendLayout();
            groupListInscrit.SuspendLayout();
            tabAdmin.SuspendLayout();
            tabAdminControl.SuspendLayout();
            tabAdminJoueur.SuspendLayout();
            tab.SuspendLayout();
            tabAdminJoueurAdd.SuspendLayout();
            groupJoueurAdd.SuspendLayout();
            tabJoueurDelete.SuspendLayout();
            groupJoueurDelete.SuspendLayout();
            tabJoueurModif.SuspendLayout();
            groupJoueurModif.SuspendLayout();
            tabAdminCoach.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            groupCoachAdd.SuspendLayout();
            tabPage2.SuspendLayout();
            groupCoachDelete.SuspendLayout();
            tabAdminSeance.SuspendLayout();
            tabControl1.SuspendLayout();
            tabAdminSeanceAdd.SuspendLayout();
            groupAddSeance.SuspendLayout();
            tabAdminSeancesDelete.SuspendLayout();
            groupSeanceDelete.SuspendLayout();
            tabAgenda.SuspendLayout();
            tabSeance.SuspendLayout();
            SuspendLayout();
            // 
            // buttonConnexion
            // 
            buttonConnexion.Location = new Point(125, 691);
            buttonConnexion.Name = "buttonConnexion";
            buttonConnexion.Size = new Size(133, 38);
            buttonConnexion.TabIndex = 0;
            buttonConnexion.Text = "Connexion";
            buttonConnexion.UseVisualStyleBackColor = true;
            buttonConnexion.Click += buttonConnexion_Click;
            // 
            // tabControlAll
            // 
            tabControlAll.Controls.Add(tabJoueur);
            tabControlAll.Controls.Add(tabCoach);
            tabControlAll.Controls.Add(tabAdmin);
            tabControlAll.Location = new Point(421, 12);
            tabControlAll.Name = "tabControlAll";
            tabControlAll.SelectedIndex = 0;
            tabControlAll.Size = new Size(932, 621);
            tabControlAll.TabIndex = 1;
            // 
            // tabJoueur
            // 
            tabJoueur.Controls.Add(buttonJoueurPresence);
            tabJoueur.Location = new Point(4, 29);
            tabJoueur.Name = "tabJoueur";
            tabJoueur.Padding = new Padding(3);
            tabJoueur.Size = new Size(924, 588);
            tabJoueur.TabIndex = 0;
            tabJoueur.Text = "Joueur";
            tabJoueur.UseVisualStyleBackColor = true;
            tabJoueur.Click += tabJoueur_Click;
            // 
            // buttonJoueurPresence
            // 
            buttonJoueurPresence.Location = new Point(27, 32);
            buttonJoueurPresence.Name = "buttonJoueurPresence";
            buttonJoueurPresence.Size = new Size(148, 69);
            buttonJoueurPresence.TabIndex = 1;
            buttonJoueurPresence.Text = "Présence Séance";
            buttonJoueurPresence.UseVisualStyleBackColor = true;
            buttonJoueurPresence.Click += buttonJoueurPresence_Click;
            // 
            // tabCoach
            // 
            tabCoach.Controls.Add(groupListInscrit);
            tabCoach.Controls.Add(buttonCoachPresence);
            tabCoach.Location = new Point(4, 29);
            tabCoach.Name = "tabCoach";
            tabCoach.Padding = new Padding(3);
            tabCoach.Size = new Size(924, 588);
            tabCoach.TabIndex = 1;
            tabCoach.Text = "Coach";
            tabCoach.UseVisualStyleBackColor = true;
            tabCoach.Click += tabPage2_Click;
            // 
            // groupListInscrit
            // 
            groupListInscrit.Controls.Add(textDateListInscrit);
            groupListInscrit.Controls.Add(buttonListInscrit);
            groupListInscrit.Controls.Add(labelDateListInscrit);
            groupListInscrit.Location = new Point(277, 35);
            groupListInscrit.Name = "groupListInscrit";
            groupListInscrit.Size = new Size(346, 464);
            groupListInscrit.TabIndex = 3;
            groupListInscrit.TabStop = false;
            groupListInscrit.Text = "Consulter les Inscrits";
            // 
            // textDateListInscrit
            // 
            textDateListInscrit.Location = new Point(111, 43);
            textDateListInscrit.Name = "textDateListInscrit";
            textDateListInscrit.Size = new Size(197, 27);
            textDateListInscrit.TabIndex = 3;
            textDateListInscrit.TextChanged += textDateListInscrit_TextChanged;
            // 
            // buttonListInscrit
            // 
            buttonListInscrit.Location = new Point(61, 126);
            buttonListInscrit.Name = "buttonListInscrit";
            buttonListInscrit.Size = new Size(229, 66);
            buttonListInscrit.TabIndex = 2;
            buttonListInscrit.Text = "Voir liste des Inscrits";
            buttonListInscrit.UseVisualStyleBackColor = true;
            buttonListInscrit.Click += buttonListInscrit_Click;
            // 
            // labelDateListInscrit
            // 
            labelDateListInscrit.AutoSize = true;
            labelDateListInscrit.Location = new Point(6, 46);
            labelDateListInscrit.Name = "labelDateListInscrit";
            labelDateListInscrit.Size = new Size(99, 20);
            labelDateListInscrit.TabIndex = 0;
            labelDateListInscrit.Text = "Date Séance :";
            // 
            // buttonCoachPresence
            // 
            buttonCoachPresence.Location = new Point(26, 35);
            buttonCoachPresence.Name = "buttonCoachPresence";
            buttonCoachPresence.Size = new Size(148, 69);
            buttonCoachPresence.TabIndex = 0;
            buttonCoachPresence.Text = "Présent";
            buttonCoachPresence.UseVisualStyleBackColor = true;
            buttonCoachPresence.Click += buttonCoachPresence_Click;
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(tabAdminControl);
            tabAdmin.Location = new Point(4, 29);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3);
            tabAdmin.Size = new Size(924, 588);
            tabAdmin.TabIndex = 2;
            tabAdmin.Text = "Administrateur";
            tabAdmin.UseVisualStyleBackColor = true;
            // 
            // tabAdminControl
            // 
            tabAdminControl.Controls.Add(tabAdminJoueur);
            tabAdminControl.Controls.Add(tabAdminCoach);
            tabAdminControl.Controls.Add(tabAdminSeance);
            tabAdminControl.Location = new Point(8, 6);
            tabAdminControl.Name = "tabAdminControl";
            tabAdminControl.SelectedIndex = 0;
            tabAdminControl.Size = new Size(893, 574);
            tabAdminControl.TabIndex = 0;
            // 
            // tabAdminJoueur
            // 
            tabAdminJoueur.Controls.Add(buttonListJoueur);
            tabAdminJoueur.Controls.Add(listJoueur);
            tabAdminJoueur.Controls.Add(tab);
            tabAdminJoueur.Location = new Point(4, 29);
            tabAdminJoueur.Name = "tabAdminJoueur";
            tabAdminJoueur.Padding = new Padding(3);
            tabAdminJoueur.Size = new Size(885, 541);
            tabAdminJoueur.TabIndex = 0;
            tabAdminJoueur.Text = "Gestion Joueur";
            tabAdminJoueur.UseVisualStyleBackColor = true;
            // 
            // buttonListJoueur
            // 
            buttonListJoueur.Location = new Point(585, 425);
            buttonListJoueur.Name = "buttonListJoueur";
            buttonListJoueur.Size = new Size(217, 85);
            buttonListJoueur.TabIndex = 9;
            buttonListJoueur.Text = "Liste des Joueurs";
            buttonListJoueur.UseVisualStyleBackColor = true;
            buttonListJoueur.Click += buttonListJoueur_Click;
            // 
            // listJoueur
            // 
            listJoueur.FormattingEnabled = true;
            listJoueur.ItemHeight = 20;
            listJoueur.Location = new Point(500, 35);
            listJoueur.Name = "listJoueur";
            listJoueur.Size = new Size(370, 384);
            listJoueur.TabIndex = 1;
            listJoueur.SelectedIndexChanged += listJoueur_SelectedIndexChanged;
            // 
            // tab
            // 
            tab.Controls.Add(tabAdminJoueurAdd);
            tab.Controls.Add(tabJoueurDelete);
            tab.Controls.Add(tabJoueurModif);
            tab.Location = new Point(6, 6);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(412, 535);
            tab.TabIndex = 0;
            tab.SelectedIndexChanged += tab_SelectedIndexChanged;
            // 
            // tabAdminJoueurAdd
            // 
            tabAdminJoueurAdd.Controls.Add(groupJoueurAdd);
            tabAdminJoueurAdd.Location = new Point(4, 29);
            tabAdminJoueurAdd.Name = "tabAdminJoueurAdd";
            tabAdminJoueurAdd.Padding = new Padding(3);
            tabAdminJoueurAdd.Size = new Size(404, 502);
            tabAdminJoueurAdd.TabIndex = 0;
            tabAdminJoueurAdd.Text = "Ajouter";
            tabAdminJoueurAdd.UseVisualStyleBackColor = true;
            // 
            // groupJoueurAdd
            // 
            groupJoueurAdd.Controls.Add(textMailJoueurAdd);
            groupJoueurAdd.Controls.Add(comboPosteJoueurAdd);
            groupJoueurAdd.Controls.Add(buttonJoueurAdd);
            groupJoueurAdd.Controls.Add(textPrenomJoueurAdd);
            groupJoueurAdd.Controls.Add(textNomJoueurAdd);
            groupJoueurAdd.Controls.Add(labelPosteJoueurAdd);
            groupJoueurAdd.Controls.Add(labelMailJoueurAdd);
            groupJoueurAdd.Controls.Add(labelPrenomJoueurAdd);
            groupJoueurAdd.Controls.Add(labelNomJoueurAdd);
            groupJoueurAdd.Location = new Point(0, 0);
            groupJoueurAdd.Name = "groupJoueurAdd";
            groupJoueurAdd.Size = new Size(398, 496);
            groupJoueurAdd.TabIndex = 0;
            groupJoueurAdd.TabStop = false;
            groupJoueurAdd.Text = "Ajouteur un Joueur";
            // 
            // textMailJoueurAdd
            // 
            textMailJoueurAdd.Location = new Point(210, 151);
            textMailJoueurAdd.Name = "textMailJoueurAdd";
            textMailJoueurAdd.Size = new Size(168, 27);
            textMailJoueurAdd.TabIndex = 11;
            // 
            // comboPosteJoueurAdd
            // 
            comboPosteJoueurAdd.FormattingEnabled = true;
            comboPosteJoueurAdd.Items.AddRange(new object[] { "-- Choississez un Poste --", "1 - Meneur de Jeu", "2 - Pivot", "3 - Aillier", "4 - Aillier Fort", "5 - Arrière" });
            comboPosteJoueurAdd.Location = new Point(210, 199);
            comboPosteJoueurAdd.Name = "comboPosteJoueurAdd";
            comboPosteJoueurAdd.Size = new Size(168, 28);
            comboPosteJoueurAdd.TabIndex = 10;
            // 
            // buttonJoueurAdd
            // 
            buttonJoueurAdd.Location = new Point(90, 278);
            buttonJoueurAdd.Name = "buttonJoueurAdd";
            buttonJoueurAdd.Size = new Size(217, 85);
            buttonJoueurAdd.TabIndex = 8;
            buttonJoueurAdd.Text = "Ajouter un Joueur";
            buttonJoueurAdd.UseVisualStyleBackColor = true;
            buttonJoueurAdd.Click += buttonJoueurAdd_Click;
            // 
            // textPrenomJoueurAdd
            // 
            textPrenomJoueurAdd.Location = new Point(210, 99);
            textPrenomJoueurAdd.Name = "textPrenomJoueurAdd";
            textPrenomJoueurAdd.Size = new Size(168, 27);
            textPrenomJoueurAdd.TabIndex = 5;
            textPrenomJoueurAdd.TextChanged += textBox4_TextChanged;
            // 
            // textNomJoueurAdd
            // 
            textNomJoueurAdd.Location = new Point(210, 46);
            textNomJoueurAdd.Name = "textNomJoueurAdd";
            textNomJoueurAdd.Size = new Size(168, 27);
            textNomJoueurAdd.TabIndex = 4;
            textNomJoueurAdd.TextChanged += textBox3_TextChanged;
            // 
            // labelPosteJoueurAdd
            // 
            labelPosteJoueurAdd.AutoSize = true;
            labelPosteJoueurAdd.Location = new Point(30, 207);
            labelPosteJoueurAdd.Name = "labelPosteJoueurAdd";
            labelPosteJoueurAdd.Size = new Size(51, 20);
            labelPosteJoueurAdd.TabIndex = 3;
            labelPosteJoueurAdd.Text = "Poste :";
            // 
            // labelMailJoueurAdd
            // 
            labelMailJoueurAdd.AutoSize = true;
            labelMailJoueurAdd.Location = new Point(30, 158);
            labelMailJoueurAdd.Name = "labelMailJoueurAdd";
            labelMailJoueurAdd.Size = new Size(101, 20);
            labelMailJoueurAdd.TabIndex = 2;
            labelMailJoueurAdd.Text = "Adresse Mail :";
            // 
            // labelPrenomJoueurAdd
            // 
            labelPrenomJoueurAdd.AutoSize = true;
            labelPrenomJoueurAdd.Location = new Point(30, 106);
            labelPrenomJoueurAdd.Name = "labelPrenomJoueurAdd";
            labelPrenomJoueurAdd.Size = new Size(67, 20);
            labelPrenomJoueurAdd.TabIndex = 1;
            labelPrenomJoueurAdd.Text = "Prénom :";
            labelPrenomJoueurAdd.Click += labelPrenomJoueurAdd_Click;
            // 
            // labelNomJoueurAdd
            // 
            labelNomJoueurAdd.AutoSize = true;
            labelNomJoueurAdd.Location = new Point(30, 49);
            labelNomJoueurAdd.Name = "labelNomJoueurAdd";
            labelNomJoueurAdd.Size = new Size(49, 20);
            labelNomJoueurAdd.TabIndex = 0;
            labelNomJoueurAdd.Text = "Nom :";
            labelNomJoueurAdd.Click += labelNomJoueurAdd_Click;
            // 
            // tabJoueurDelete
            // 
            tabJoueurDelete.Controls.Add(groupJoueurDelete);
            tabJoueurDelete.Location = new Point(4, 29);
            tabJoueurDelete.Name = "tabJoueurDelete";
            tabJoueurDelete.Padding = new Padding(3);
            tabJoueurDelete.Size = new Size(404, 502);
            tabJoueurDelete.TabIndex = 1;
            tabJoueurDelete.Text = "Supprimer";
            tabJoueurDelete.UseVisualStyleBackColor = true;
            // 
            // groupJoueurDelete
            // 
            groupJoueurDelete.Controls.Add(buttonJoueurDelete);
            groupJoueurDelete.Controls.Add(textPrenomJoueurDelete);
            groupJoueurDelete.Controls.Add(textNomJoueurDelete);
            groupJoueurDelete.Controls.Add(labelPrenomJoueurDelete);
            groupJoueurDelete.Controls.Add(labelNomJoueurDelete);
            groupJoueurDelete.Location = new Point(6, 6);
            groupJoueurDelete.Name = "groupJoueurDelete";
            groupJoueurDelete.Size = new Size(377, 478);
            groupJoueurDelete.TabIndex = 0;
            groupJoueurDelete.TabStop = false;
            groupJoueurDelete.Text = "Supprimer un Joueur";
            groupJoueurDelete.Enter += groupBox1_Enter_1;
            // 
            // buttonJoueurDelete
            // 
            buttonJoueurDelete.Location = new Point(84, 198);
            buttonJoueurDelete.Name = "buttonJoueurDelete";
            buttonJoueurDelete.Size = new Size(190, 83);
            buttonJoueurDelete.TabIndex = 10;
            buttonJoueurDelete.Text = "Supprimer un Joueur";
            buttonJoueurDelete.UseVisualStyleBackColor = true;
            buttonJoueurDelete.Click += buttonJoueurDelete_Click;
            // 
            // textPrenomJoueurDelete
            // 
            textPrenomJoueurDelete.Location = new Point(198, 101);
            textPrenomJoueurDelete.Name = "textPrenomJoueurDelete";
            textPrenomJoueurDelete.Size = new Size(168, 27);
            textPrenomJoueurDelete.TabIndex = 9;
            // 
            // textNomJoueurDelete
            // 
            textNomJoueurDelete.Location = new Point(198, 48);
            textNomJoueurDelete.Name = "textNomJoueurDelete";
            textNomJoueurDelete.Size = new Size(168, 27);
            textNomJoueurDelete.TabIndex = 8;
            // 
            // labelPrenomJoueurDelete
            // 
            labelPrenomJoueurDelete.AutoSize = true;
            labelPrenomJoueurDelete.Location = new Point(18, 108);
            labelPrenomJoueurDelete.Name = "labelPrenomJoueurDelete";
            labelPrenomJoueurDelete.Size = new Size(67, 20);
            labelPrenomJoueurDelete.TabIndex = 7;
            labelPrenomJoueurDelete.Text = "Prénom :";
            // 
            // labelNomJoueurDelete
            // 
            labelNomJoueurDelete.AutoSize = true;
            labelNomJoueurDelete.Location = new Point(18, 51);
            labelNomJoueurDelete.Name = "labelNomJoueurDelete";
            labelNomJoueurDelete.Size = new Size(49, 20);
            labelNomJoueurDelete.TabIndex = 6;
            labelNomJoueurDelete.Text = "Nom :";
            // 
            // tabJoueurModif
            // 
            tabJoueurModif.Controls.Add(groupJoueurModif);
            tabJoueurModif.Location = new Point(4, 29);
            tabJoueurModif.Name = "tabJoueurModif";
            tabJoueurModif.Padding = new Padding(3);
            tabJoueurModif.Size = new Size(404, 502);
            tabJoueurModif.TabIndex = 2;
            tabJoueurModif.Text = "Modifier";
            tabJoueurModif.UseVisualStyleBackColor = true;
            // 
            // groupJoueurModif
            // 
            groupJoueurModif.Controls.Add(comboPosteJoueurModif);
            groupJoueurModif.Controls.Add(buttonJoueurModif);
            groupJoueurModif.Controls.Add(textPrenomJoueurModif);
            groupJoueurModif.Controls.Add(textNomJoueurModif);
            groupJoueurModif.Controls.Add(labelPosteJoueurModif);
            groupJoueurModif.Controls.Add(labelPrenomJoueurModif);
            groupJoueurModif.Controls.Add(labelNomJoueurModif);
            groupJoueurModif.Location = new Point(14, 14);
            groupJoueurModif.Name = "groupJoueurModif";
            groupJoueurModif.Size = new Size(375, 470);
            groupJoueurModif.TabIndex = 0;
            groupJoueurModif.TabStop = false;
            groupJoueurModif.Text = "Modifier un Joueur";
            // 
            // comboPosteJoueurModif
            // 
            comboPosteJoueurModif.FormattingEnabled = true;
            comboPosteJoueurModif.Items.AddRange(new object[] { "-- Choisissez un Poste --", "1 - Meneur de Jeu", "2 - Pivot", "3 - Aillier", "4 - Aillier Fort", "5 - Arrière" });
            comboPosteJoueurModif.Location = new Point(201, 158);
            comboPosteJoueurModif.Name = "comboPosteJoueurModif";
            comboPosteJoueurModif.Size = new Size(168, 28);
            comboPosteJoueurModif.TabIndex = 15;
            // 
            // buttonJoueurModif
            // 
            buttonJoueurModif.Location = new Point(84, 233);
            buttonJoueurModif.Name = "buttonJoueurModif";
            buttonJoueurModif.Size = new Size(192, 65);
            buttonJoueurModif.TabIndex = 14;
            buttonJoueurModif.Text = "Modifier un Joueur";
            buttonJoueurModif.UseVisualStyleBackColor = true;
            buttonJoueurModif.Click += buttonJoueurModif_Click_1;
            // 
            // textPrenomJoueurModif
            // 
            textPrenomJoueurModif.Location = new Point(201, 88);
            textPrenomJoueurModif.Name = "textPrenomJoueurModif";
            textPrenomJoueurModif.Size = new Size(168, 27);
            textPrenomJoueurModif.TabIndex = 12;
            // 
            // textNomJoueurModif
            // 
            textNomJoueurModif.Location = new Point(201, 35);
            textNomJoueurModif.Name = "textNomJoueurModif";
            textNomJoueurModif.Size = new Size(168, 27);
            textNomJoueurModif.TabIndex = 11;
            // 
            // labelPosteJoueurModif
            // 
            labelPosteJoueurModif.AutoSize = true;
            labelPosteJoueurModif.Location = new Point(21, 161);
            labelPosteJoueurModif.Name = "labelPosteJoueurModif";
            labelPosteJoueurModif.Size = new Size(124, 20);
            labelPosteJoueurModif.TabIndex = 10;
            labelPosteJoueurModif.Text = "Poste à Modifier :";
            // 
            // labelPrenomJoueurModif
            // 
            labelPrenomJoueurModif.AutoSize = true;
            labelPrenomJoueurModif.Location = new Point(21, 95);
            labelPrenomJoueurModif.Name = "labelPrenomJoueurModif";
            labelPrenomJoueurModif.Size = new Size(67, 20);
            labelPrenomJoueurModif.TabIndex = 9;
            labelPrenomJoueurModif.Text = "Prénom :";
            // 
            // labelNomJoueurModif
            // 
            labelNomJoueurModif.AutoSize = true;
            labelNomJoueurModif.Location = new Point(21, 38);
            labelNomJoueurModif.Name = "labelNomJoueurModif";
            labelNomJoueurModif.Size = new Size(49, 20);
            labelNomJoueurModif.TabIndex = 8;
            labelNomJoueurModif.Text = "Nom :";
            // 
            // tabAdminCoach
            // 
            tabAdminCoach.Controls.Add(buttonListCoach);
            tabAdminCoach.Controls.Add(listCoach);
            tabAdminCoach.Controls.Add(tabControl2);
            tabAdminCoach.Location = new Point(4, 29);
            tabAdminCoach.Name = "tabAdminCoach";
            tabAdminCoach.Padding = new Padding(3);
            tabAdminCoach.Size = new Size(885, 541);
            tabAdminCoach.TabIndex = 1;
            tabAdminCoach.Text = "Gestion Coach";
            tabAdminCoach.UseVisualStyleBackColor = true;
            // 
            // buttonListCoach
            // 
            buttonListCoach.Location = new Point(571, 445);
            buttonListCoach.Name = "buttonListCoach";
            buttonListCoach.Size = new Size(217, 85);
            buttonListCoach.TabIndex = 10;
            buttonListCoach.Text = "Liste des Coach";
            buttonListCoach.UseVisualStyleBackColor = true;
            buttonListCoach.Click += buttonListCoach_Click;
            // 
            // listCoach
            // 
            listCoach.FormattingEnabled = true;
            listCoach.ItemHeight = 20;
            listCoach.Location = new Point(486, 35);
            listCoach.Name = "listCoach";
            listCoach.Size = new Size(370, 404);
            listCoach.TabIndex = 2;
            listCoach.SelectedIndexChanged += listCoach_SelectedIndexChanged;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Location = new Point(6, 6);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(412, 535);
            tabControl2.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupCoachAdd);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(404, 502);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ajouter";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupCoachAdd
            // 
            groupCoachAdd.Controls.Add(textMailCoachAdd);
            groupCoachAdd.Controls.Add(buttonCoachAdd);
            groupCoachAdd.Controls.Add(textPrenomCoachAdd);
            groupCoachAdd.Controls.Add(textNomCoachAdd);
            groupCoachAdd.Controls.Add(labelMailCoachAdd);
            groupCoachAdd.Controls.Add(labelPrenomCoachAdd);
            groupCoachAdd.Controls.Add(labelNomCoachAdd);
            groupCoachAdd.Location = new Point(0, 0);
            groupCoachAdd.Name = "groupCoachAdd";
            groupCoachAdd.Size = new Size(398, 496);
            groupCoachAdd.TabIndex = 0;
            groupCoachAdd.TabStop = false;
            groupCoachAdd.Text = "Ajouteur un Coach";
            // 
            // textMailCoachAdd
            // 
            textMailCoachAdd.Location = new Point(210, 151);
            textMailCoachAdd.Name = "textMailCoachAdd";
            textMailCoachAdd.Size = new Size(168, 27);
            textMailCoachAdd.TabIndex = 9;
            // 
            // buttonCoachAdd
            // 
            buttonCoachAdd.Location = new Point(90, 278);
            buttonCoachAdd.Name = "buttonCoachAdd";
            buttonCoachAdd.Size = new Size(217, 85);
            buttonCoachAdd.TabIndex = 8;
            buttonCoachAdd.Text = "Ajouter un Coach";
            buttonCoachAdd.UseVisualStyleBackColor = true;
            buttonCoachAdd.Click += buttonCoachAdd_Click;
            // 
            // textPrenomCoachAdd
            // 
            textPrenomCoachAdd.Location = new Point(210, 99);
            textPrenomCoachAdd.Name = "textPrenomCoachAdd";
            textPrenomCoachAdd.Size = new Size(168, 27);
            textPrenomCoachAdd.TabIndex = 5;
            // 
            // textNomCoachAdd
            // 
            textNomCoachAdd.Location = new Point(210, 46);
            textNomCoachAdd.Name = "textNomCoachAdd";
            textNomCoachAdd.Size = new Size(168, 27);
            textNomCoachAdd.TabIndex = 4;
            // 
            // labelMailCoachAdd
            // 
            labelMailCoachAdd.AutoSize = true;
            labelMailCoachAdd.Location = new Point(30, 158);
            labelMailCoachAdd.Name = "labelMailCoachAdd";
            labelMailCoachAdd.Size = new Size(45, 20);
            labelMailCoachAdd.TabIndex = 2;
            labelMailCoachAdd.Text = "Mail :";
            // 
            // labelPrenomCoachAdd
            // 
            labelPrenomCoachAdd.AutoSize = true;
            labelPrenomCoachAdd.Location = new Point(30, 106);
            labelPrenomCoachAdd.Name = "labelPrenomCoachAdd";
            labelPrenomCoachAdd.Size = new Size(67, 20);
            labelPrenomCoachAdd.TabIndex = 1;
            labelPrenomCoachAdd.Text = "Prénom :";
            // 
            // labelNomCoachAdd
            // 
            labelNomCoachAdd.AutoSize = true;
            labelNomCoachAdd.Location = new Point(30, 49);
            labelNomCoachAdd.Name = "labelNomCoachAdd";
            labelNomCoachAdd.Size = new Size(49, 20);
            labelNomCoachAdd.TabIndex = 0;
            labelNomCoachAdd.Text = "Nom :";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupCoachDelete);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(404, 502);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Supprimer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupCoachDelete
            // 
            groupCoachDelete.Controls.Add(buttonCoachDelete);
            groupCoachDelete.Controls.Add(textPrenomCoachDelete);
            groupCoachDelete.Controls.Add(textNomCoachDelete);
            groupCoachDelete.Controls.Add(labelPrenomCoachDelete);
            groupCoachDelete.Controls.Add(labelNomCoachDelete);
            groupCoachDelete.Location = new Point(6, 6);
            groupCoachDelete.Name = "groupCoachDelete";
            groupCoachDelete.Size = new Size(377, 478);
            groupCoachDelete.TabIndex = 0;
            groupCoachDelete.TabStop = false;
            groupCoachDelete.Text = "Supprimer un Coach";
            // 
            // buttonCoachDelete
            // 
            buttonCoachDelete.Location = new Point(84, 198);
            buttonCoachDelete.Name = "buttonCoachDelete";
            buttonCoachDelete.Size = new Size(190, 83);
            buttonCoachDelete.TabIndex = 10;
            buttonCoachDelete.Text = "Supprimer un Coach";
            buttonCoachDelete.UseVisualStyleBackColor = true;
            buttonCoachDelete.Click += buttonCoachDelete_Click;
            // 
            // textPrenomCoachDelete
            // 
            textPrenomCoachDelete.Location = new Point(198, 101);
            textPrenomCoachDelete.Name = "textPrenomCoachDelete";
            textPrenomCoachDelete.Size = new Size(168, 27);
            textPrenomCoachDelete.TabIndex = 9;
            // 
            // textNomCoachDelete
            // 
            textNomCoachDelete.Location = new Point(198, 48);
            textNomCoachDelete.Name = "textNomCoachDelete";
            textNomCoachDelete.Size = new Size(168, 27);
            textNomCoachDelete.TabIndex = 8;
            // 
            // labelPrenomCoachDelete
            // 
            labelPrenomCoachDelete.AutoSize = true;
            labelPrenomCoachDelete.Location = new Point(18, 108);
            labelPrenomCoachDelete.Name = "labelPrenomCoachDelete";
            labelPrenomCoachDelete.Size = new Size(67, 20);
            labelPrenomCoachDelete.TabIndex = 7;
            labelPrenomCoachDelete.Text = "Prénom :";
            // 
            // labelNomCoachDelete
            // 
            labelNomCoachDelete.AutoSize = true;
            labelNomCoachDelete.Location = new Point(18, 51);
            labelNomCoachDelete.Name = "labelNomCoachDelete";
            labelNomCoachDelete.Size = new Size(49, 20);
            labelNomCoachDelete.TabIndex = 6;
            labelNomCoachDelete.Text = "Nom :";
            // 
            // tabAdminSeance
            // 
            tabAdminSeance.BackColor = Color.White;
            tabAdminSeance.Controls.Add(tabControl1);
            tabAdminSeance.Location = new Point(4, 29);
            tabAdminSeance.Name = "tabAdminSeance";
            tabAdminSeance.Padding = new Padding(3);
            tabAdminSeance.Size = new Size(885, 541);
            tabAdminSeance.TabIndex = 2;
            tabAdminSeance.Text = "Gestion Séances";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAdminSeanceAdd);
            tabControl1.Controls.Add(tabAdminSeancesDelete);
            tabControl1.Location = new Point(6, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(426, 525);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabAdminSeanceAdd
            // 
            tabAdminSeanceAdd.Controls.Add(groupAddSeance);
            tabAdminSeanceAdd.Location = new Point(4, 29);
            tabAdminSeanceAdd.Name = "tabAdminSeanceAdd";
            tabAdminSeanceAdd.Padding = new Padding(3);
            tabAdminSeanceAdd.Size = new Size(418, 492);
            tabAdminSeanceAdd.TabIndex = 0;
            tabAdminSeanceAdd.Text = "Ajouter";
            tabAdminSeanceAdd.UseVisualStyleBackColor = true;
            // 
            // groupAddSeance
            // 
            groupAddSeance.Controls.Add(buttonAddSeance);
            groupAddSeance.Controls.Add(dateTimeSeance);
            groupAddSeance.Controls.Add(labelDateSeance);
            groupAddSeance.Location = new Point(37, 6);
            groupAddSeance.Name = "groupAddSeance";
            groupAddSeance.Size = new Size(346, 464);
            groupAddSeance.TabIndex = 1;
            groupAddSeance.TabStop = false;
            groupAddSeance.Text = "Ajouter une Séance";
            groupAddSeance.Enter += groupBox1_Enter;
            // 
            // buttonAddSeance
            // 
            buttonAddSeance.Location = new Point(61, 126);
            buttonAddSeance.Name = "buttonAddSeance";
            buttonAddSeance.Size = new Size(229, 66);
            buttonAddSeance.TabIndex = 2;
            buttonAddSeance.Text = "Ajouter la séance";
            buttonAddSeance.UseVisualStyleBackColor = true;
            buttonAddSeance.Click += button1_Click_1;
            // 
            // dateTimeSeance
            // 
            dateTimeSeance.Location = new Point(111, 41);
            dateTimeSeance.Name = "dateTimeSeance";
            dateTimeSeance.Size = new Size(221, 27);
            dateTimeSeance.TabIndex = 1;
            dateTimeSeance.ValueChanged += dateTimeSeance_ValueChanged;
            // 
            // labelDateSeance
            // 
            labelDateSeance.AutoSize = true;
            labelDateSeance.Location = new Point(6, 46);
            labelDateSeance.Name = "labelDateSeance";
            labelDateSeance.Size = new Size(99, 20);
            labelDateSeance.TabIndex = 0;
            labelDateSeance.Text = "Date Séance :";
            // 
            // tabAdminSeancesDelete
            // 
            tabAdminSeancesDelete.Controls.Add(groupSeanceDelete);
            tabAdminSeancesDelete.Location = new Point(4, 29);
            tabAdminSeancesDelete.Name = "tabAdminSeancesDelete";
            tabAdminSeancesDelete.Padding = new Padding(3);
            tabAdminSeancesDelete.Size = new Size(418, 492);
            tabAdminSeancesDelete.TabIndex = 1;
            tabAdminSeancesDelete.Text = "Supprimer";
            tabAdminSeancesDelete.UseVisualStyleBackColor = true;
            // 
            // groupSeanceDelete
            // 
            groupSeanceDelete.Controls.Add(textSeanceDelete);
            groupSeanceDelete.Controls.Add(buttonSeanceDelete);
            groupSeanceDelete.Controls.Add(labelDateSeanceDelete);
            groupSeanceDelete.Location = new Point(36, 14);
            groupSeanceDelete.Name = "groupSeanceDelete";
            groupSeanceDelete.Size = new Size(346, 464);
            groupSeanceDelete.TabIndex = 2;
            groupSeanceDelete.TabStop = false;
            groupSeanceDelete.Text = "Supprimer une Séance";
            // 
            // textSeanceDelete
            // 
            textSeanceDelete.Location = new Point(111, 43);
            textSeanceDelete.Name = "textSeanceDelete";
            textSeanceDelete.Size = new Size(197, 27);
            textSeanceDelete.TabIndex = 3;
            // 
            // buttonSeanceDelete
            // 
            buttonSeanceDelete.Location = new Point(61, 126);
            buttonSeanceDelete.Name = "buttonSeanceDelete";
            buttonSeanceDelete.Size = new Size(229, 66);
            buttonSeanceDelete.TabIndex = 2;
            buttonSeanceDelete.Text = "Supprimer la séance";
            buttonSeanceDelete.UseVisualStyleBackColor = true;
            buttonSeanceDelete.Click += buttonSeanceDelete_Click;
            // 
            // labelDateSeanceDelete
            // 
            labelDateSeanceDelete.AutoSize = true;
            labelDateSeanceDelete.Location = new Point(6, 46);
            labelDateSeanceDelete.Name = "labelDateSeanceDelete";
            labelDateSeanceDelete.Size = new Size(99, 20);
            labelDateSeanceDelete.TabIndex = 0;
            labelDateSeanceDelete.Text = "Date Séance :";
            // 
            // listSeance
            // 
            listSeance.FormattingEnabled = true;
            listSeance.ItemHeight = 20;
            listSeance.Location = new Point(3, 0);
            listSeance.Name = "listSeance";
            listSeance.Size = new Size(350, 424);
            listSeance.TabIndex = 1;
            listSeance.SelectedIndexChanged += listSeance_SelectedIndexChanged;
            // 
            // labelIDCon
            // 
            labelIDCon.AutoSize = true;
            labelIDCon.Location = new Point(12, 597);
            labelIDCon.Name = "labelIDCon";
            labelIDCon.Size = new Size(84, 20);
            labelIDCon.TabIndex = 2;
            labelIDCon.Text = "Identifiant :";
            // 
            // labelMDP
            // 
            labelMDP.AutoSize = true;
            labelMDP.Location = new Point(12, 639);
            labelMDP.Name = "labelMDP";
            labelMDP.Size = new Size(107, 20);
            labelMDP.TabIndex = 3;
            labelMDP.Text = "Mot de Passe : ";
            // 
            // textIdentifiantCon
            // 
            textIdentifiantCon.Location = new Point(125, 590);
            textIdentifiantCon.Name = "textIdentifiantCon";
            textIdentifiantCon.Size = new Size(194, 27);
            textIdentifiantCon.TabIndex = 1;
            textIdentifiantCon.TextChanged += textIdentifiantCon_TextChanged;
            // 
            // textMDPCon
            // 
            textMDPCon.Location = new Point(125, 639);
            textMDPCon.Name = "textMDPCon";
            textMDPCon.Size = new Size(194, 27);
            textMDPCon.TabIndex = 4;
            textMDPCon.TextChanged += textBox2_TextChanged;
            // 
            // labelEtatCon
            // 
            labelEtatCon.AutoSize = true;
            labelEtatCon.Location = new Point(279, 700);
            labelEtatCon.Name = "labelEtatCon";
            labelEtatCon.Size = new Size(138, 20);
            labelEtatCon.TabIndex = 1;
            labelEtatCon.Text = "labelEtatConnexion";
            labelEtatCon.Click += label2_Click;
            // 
            // tabAgenda
            // 
            tabAgenda.Controls.Add(tabSeance);
            tabAgenda.Location = new Point(12, 2);
            tabAgenda.Name = "tabAgenda";
            tabAgenda.SelectedIndex = 0;
            tabAgenda.Size = new Size(367, 565);
            tabAgenda.TabIndex = 0;
            tabAgenda.SelectedIndexChanged += tabAgenda_SelectedIndexChanged;
            // 
            // tabSeance
            // 
            tabSeance.Controls.Add(buttonListSeances);
            tabSeance.Controls.Add(listSeance);
            tabSeance.Location = new Point(4, 29);
            tabSeance.Name = "tabSeance";
            tabSeance.Padding = new Padding(3);
            tabSeance.Size = new Size(359, 532);
            tabSeance.TabIndex = 0;
            tabSeance.Text = "Séances";
            tabSeance.UseVisualStyleBackColor = true;
            // 
            // buttonListSeances
            // 
            buttonListSeances.Location = new Point(65, 441);
            buttonListSeances.Name = "buttonListSeances";
            buttonListSeances.Size = new Size(217, 85);
            buttonListSeances.TabIndex = 9;
            buttonListSeances.Text = "Listes des Séances";
            buttonListSeances.UseVisualStyleBackColor = true;
            buttonListSeances.Click += buttonListSeances_Click;
            // 
            // labelNomCoachModif
            // 
            labelNomCoachModif.AutoSize = true;
            labelNomCoachModif.Location = new Point(21, 38);
            labelNomCoachModif.Name = "labelNomCoachModif";
            labelNomCoachModif.Size = new Size(49, 20);
            labelNomCoachModif.TabIndex = 8;
            // 
            // labelPrenomCoachModif
            // 
            labelPrenomCoachModif.AutoSize = true;
            labelPrenomCoachModif.Location = new Point(21, 95);
            labelPrenomCoachModif.Name = "labelPrenomCoachModif";
            labelPrenomCoachModif.Size = new Size(67, 20);
            labelPrenomCoachModif.TabIndex = 9;
            // 
            // textNomCoachModif
            // 
            textNomCoachModif.Location = new Point(201, 35);
            textNomCoachModif.Name = "textNomCoachModif";
            textNomCoachModif.Size = new Size(168, 27);
            textNomCoachModif.TabIndex = 11;
            // 
            // textPrenomCoachModif
            // 
            textPrenomCoachModif.Location = new Point(201, 88);
            textPrenomCoachModif.Name = "textPrenomCoachModif";
            textPrenomCoachModif.Size = new Size(168, 27);
            textPrenomCoachModif.TabIndex = 12;
            // 
            // buttonCoachModif
            // 
            buttonCoachModif.Location = new Point(84, 233);
            buttonCoachModif.Name = "buttonCoachModif";
            buttonCoachModif.Size = new Size(192, 65);
            buttonCoachModif.TabIndex = 14;
            buttonCoachModif.Text = "Modifier un Joueur";
            buttonCoachModif.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 741);
            Controls.Add(tabAgenda);
            Controls.Add(labelEtatCon);
            Controls.Add(textMDPCon);
            Controls.Add(textIdentifiantCon);
            Controls.Add(labelMDP);
            Controls.Add(labelIDCon);
            Controls.Add(tabControlAll);
            Controls.Add(buttonConnexion);
            Name = "Form1";
            Text = "Basket Gestionnaire";
            Load += Form1_Load;
            tabControlAll.ResumeLayout(false);
            tabJoueur.ResumeLayout(false);
            tabCoach.ResumeLayout(false);
            groupListInscrit.ResumeLayout(false);
            groupListInscrit.PerformLayout();
            tabAdmin.ResumeLayout(false);
            tabAdminControl.ResumeLayout(false);
            tabAdminJoueur.ResumeLayout(false);
            tab.ResumeLayout(false);
            tabAdminJoueurAdd.ResumeLayout(false);
            groupJoueurAdd.ResumeLayout(false);
            groupJoueurAdd.PerformLayout();
            tabJoueurDelete.ResumeLayout(false);
            groupJoueurDelete.ResumeLayout(false);
            groupJoueurDelete.PerformLayout();
            tabJoueurModif.ResumeLayout(false);
            groupJoueurModif.ResumeLayout(false);
            groupJoueurModif.PerformLayout();
            tabAdminCoach.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupCoachAdd.ResumeLayout(false);
            groupCoachAdd.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupCoachDelete.ResumeLayout(false);
            groupCoachDelete.PerformLayout();
            tabAdminSeance.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabAdminSeanceAdd.ResumeLayout(false);
            groupAddSeance.ResumeLayout(false);
            groupAddSeance.PerformLayout();
            tabAdminSeancesDelete.ResumeLayout(false);
            groupSeanceDelete.ResumeLayout(false);
            groupSeanceDelete.PerformLayout();
            tabAgenda.ResumeLayout(false);
            tabSeance.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonConnexion;
        private TabControl tabControlAll;
        private TabPage tabJoueur;
        private TabPage tabCoach;
        private TabPage tabAdmin;
        private TabControl tabAdminControl;
        private TabPage tabAdminJoueur;
        private TabPage tabAdminCoach;
        private TabPage tabAdminSeance;
        private TabControl tabControl1;
        private TabPage tabAdminSeanceAdd;
        private TabPage tabAdminSeancesDelete;
        private GroupBox groupAddSeance;
        private Label labelDateSeance;
        private Button buttonAddSeance;
        private DateTimePicker dateTimeSeance;
        private GroupBox groupSeanceDelete;
        private Button buttonSeanceDelete;
        private Label labelDateSeanceDelete;
        private ListBox listSeance;
        private Label labelIDCon;
        private Label labelMDP;
        private TextBox textIdentifiantCon;
        private TextBox textMDPCon;
        private Label labelEtatCon;
        private TextBox textSeanceDelete;
        private ListBox listJoueur;
        private TabControl tab;
        private TabPage tabAdminJoueurAdd;
        private GroupBox groupJoueurAdd;
        private DateTimePicker dateNaissJoueurAdd;
        private Button buttonJoueurAdd;
        private TextBox textPrenomJoueurAdd;
        private TextBox textNomJoueurAdd;
        private Label labelPosteJoueurAdd;
        private Label labelMailJoueurAdd;
        private Label labelPrenomJoueurAdd;
        private Label labelNomJoueurAdd;
        private TabPage tabJoueurDelete;
        private GroupBox groupJoueurDelete;
        private TabPage tabJoueurModif;
        private Button buttonJoueurDelete;
        private TextBox textPrenomJoueurDelete;
        private TextBox textNomJoueurDelete;
        private Label labelPrenomJoueurDelete;
        private Label labelNomJoueurDelete;
        private GroupBox groupJoueurModif;
        private TextBox textPrenomJoueurModif;
        private TextBox textNomJoueurModif;
        private Label labelPosteJoueurModif;
        private Label labelPrenomJoueurModif;
        private Label labelNomJoueurModif;
        private Button buttonJoueurModif;
        private ComboBox comboPosteJoueurAdd;
        private ComboBox comboPosteJoueurModif;
        private ListBox listCoach;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private GroupBox groupCoachAdd;
        private Button buttonCoachAdd;
        private TextBox textPrenomCoachAdd;
        private TextBox textNomCoachAdd;
        private Label labelPrenomCoachAdd;
        private Label labelNomCoachAdd;
        private TabPage tabPage2;
        private GroupBox groupCoachDelete;
        private Button buttonCoachDelete;
        private TextBox textPrenomCoachDelete;
        private TextBox textNomCoachDelete;
        private Label labelPrenomCoachDelete;
        private Label labelNomCoachDelete;
        private TabControl tabAgenda;
        private TabPage tabSeance;
        private Button buttonCoachPresence;
        private Button buttonJoueurPresence;
        private TextBox textMailJoueurAdd;
        private Button buttonListJoueur;
        private TextBox textMailCoachAdd;
        private Label labelMailCoachAdd;
        private Label labelNomCoachModif;
        private Label labelPrenomCoachModif;
        private TextBox textNomCoachModif;
        private TextBox textPrenomCoachModif;
        private Button buttonCoachModif;
        private Button buttonListCoach;
        private Button buttonListSeances;
        private GroupBox groupListInscrit;
        private TextBox textDateListInscrit;
        private Button buttonListInscrit;
        private Label labelDateListInscrit;
    }
}