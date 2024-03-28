using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboGSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Définir les onglets comme inaccessibles par défaut
            tabPageTechnicien.Enabled = false;
            tabPageResponsable.Enabled = false;
            tabPageUtilisateur.Enabled = false;
        }


        /// <summary>
        /// Événement déclenché lorsqu'un utilisateur tente de se connecter.
        /// </summary>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string resultatConnexion = BD.VerifConn(tbIdConnexion.Text, tbMDPConnexion.Text);

            // Activer les onglets appropriés en fonction du résultat de la connexion
            // Leçon sur les switch : https://www.w3schools.com/cs/cs_switch.php
            switch (resultatConnexion)
            {
                case "Technicien":
                    tabPageTechnicien.Enabled = true; // Activer l'onglet "Technicien"
                    tabControl1.SelectedTab = tabPageTechnicien; // Sélectionner l'onglet "Technicien"
                    break;
                case "Responsable":
                    tabPageResponsable.Enabled = true; // Activer l'onglet "Responsable"
                    tabControl1.SelectedTab = tabPageResponsable; // Sélectionner l'onglet "Responsable"
                    break;
                case "Utilisateur":
                    tabPageUtilisateur.Enabled = true; // Activer l'onglet "Utilisateur"
                    tabControl1.SelectedTab = tabPageUtilisateur; // Sélectionner l'onglet "Utilisateur"
                    break;
                case "Erreur de connexion":
                    MessageBox.Show("Erreur de connexion. Veuillez réessayer.");
                    break;
                default:
                    MessageBox.Show("Profil non reconnu.");
                    break;
            }
        }

        /// <summary>
        /// Événement déclenché lorsqu'un technicien ajoute un incident.
        /// </summary>
        private void btnValiderIncident_Click(object sender, EventArgs e)
        {
            Incident incident = new Incident(tbDéclaIncident.Text, "", textBoxMatriculePerso.Text, dateTimePickerDateDecla.Value, Convert.ToInt16(textBoxIdMateriel.Text), textBoxMatriculeTech.Text, Convert.ToInt16(tbEtatInci.Text));
            BD.AjoutIncident(incident);
            MessageBox.Show("Executer");
        }

        /// <summary>
        /// Événement déclenché lorsqu'un technicien ajoute un matériel.
        /// </summary>
        private void btnConfirmerMatériel_Click(object sender, EventArgs e)
        {
            bool garantie = rbGarantieTrue.Checked;
            Materiel nouveauMateriel = new Materiel(cbProcesseur.Text, Convert.ToInt16(nudMemoire.Value), cbDisque.Text, tbLogiciel.Text, Convert.ToDateTime(dateTimePicker1.Value), garantie, tbFournisseur.Text);
            BD.AjoutMateriel(nouveauMateriel);
            ActualiserMateriel();
        }

        /// <summary>
        /// Fonction pour actualiser les ComboBox de matériel.
        /// </summary>
        public void ActualiserMateriel()
        {
            // Effacez d'abord tous les éléments de la ComboBox
            cbConsultMatériel.Items.Clear();
            cbSuppMater.Items.Clear();

            foreach (int id in BD.GetIdMateriel())
            {
                cbConsultMatériel.Items.Add(id);
                cbSuppMater.Items.Add(id);
            }
        }

        /// <summary>
        /// Fonction pour actualiser les ComboBox des techniciens.
        /// </summary>
        public void ActualiserTechnicien()
        {
            cbSuppTech.Items.Clear();
            foreach(string matricule in BD.GetMatriculeTechnicien())
            {
                cbSuppTech.Items.Add(matricule);
            }
        }

        /// <summary>
        /// Fonction pour actualiser les ComboBox des utilisateurs.
        /// </summary>
        public void ActualiserUtilisateur()
        {
            cbSuppU.Items.Clear();
            foreach (string matricule in BD.GetMatriculeUtilisateur())
            {
                cbSuppU.Items.Add(matricule);
            }
        }

        /// <summary>
        /// Événement déclenché lors de l'enregistrement d'un utilisateur.
        /// </summary>
        private void btnEnregU_Click(object sender, EventArgs e)
        {
            Personnel utilisateur = new Personnel(tbMatriculeU.Text, tbNomU.Text, dateTimePicker2.Value, tbRegion.Text, 0, Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), tbAvan.Text, Convert.ToInt16(numericUpDown3.Value), "SMA027");
            Utilisateur unUtilisateur = new Utilisateur(tbMatriculeU.Text, tbNomU.Text, dateTimePicker2.Value, tbRegion.Text, Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value), tbAvan.Text, Convert.ToInt16(numericUpDown3.Value));

            BD.AjoutPersonnel(utilisateur);
            BD.AjoutUtilisateur(unUtilisateur);
            ActualiserUtilisateur();
        }

        /// <summary>
        /// Événement de chargement de la fenêtre principale.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserMateriel();
            ActualiserTechnicien();
            ActualiserUtilisateur();

            List<Incident> incidents = BD.affichIncident();

            cbConsInci.Items.Clear();

            foreach (Incident unIncident in incidents)
            {
                cbConsInci.Items.Add(unIncident.getId());
            }
        }

        /// <summary>
        /// Événement déclenché lors de la consultation d'un matériel.
        /// </summary>
        private void btnConsutlter_Click(object sender, EventArgs e)
        {
            lbConsulterMatériel.Items.Clear();
            lbConsulterMatériel.Items.Add(BD.GetUnMateriel(Convert.ToInt16(cbConsultMatériel.SelectedItem)));
        }

        /// <summary>
        /// Événement déclenché lors de la suppression d'un matériel.
        /// </summary>
        private void btnSuprMtr_Click(object sender, EventArgs e)
        {
            BD.SuppMateriel(Convert.ToInt16(cbSuppMater.SelectedItem));
            ActualiserMateriel();
        }

        /// <summary>
        /// Événement déclenché lors de l'enregistrement d'un technicien.
        /// </summary>
        private void btnEnregTech_Click(object sender, EventArgs e)
        {
            Personnel personnel = new Personnel(tbMatriculeTech.Text, tbMDPTech.Text, dateTimePicker3.Value, tbRegCarr.Text, 0);
            Technicien technicien = new Technicien(tbMatriculeTech.Text, tbNiv.Text, tbMDPTech.Text, dateTimePicker3.Value, tbRegCarr.Text, dateTimePicker3.Value, tbFormTech.Text, tbCompTech.Text);
            BD.AjoutPersonnel(personnel);
            BD.AjoutTechnicien(technicien);
            ActualiserTechnicien();
        }

        /// <summary>
        /// Événement déclenché lors de l'affichage des incidents.
        /// </summary>
        private void btnAfficherIncident_Click(object sender, EventArgs e)
        {
            // Effacez le contenu de la ListBox avant d'ajouter de nouveaux éléments
            lbUtilisateur.Items.Clear();

            List<Incident> incidents = BD.affichIncident();

            foreach (Incident incident in incidents)
            {
                lbUtilisateur.Items.Add(incident.getId() + " " + incident.getProbleme());
            }
        }

        /// <summary>
        /// Événement déclenché lors de la consultation d'un incident.
        /// </summary>
        private void btnConsulIncident_Click(object sender, EventArgs e)
        {
            lbConsInci.Items.Clear();

            int rang = cbConsInci.SelectedIndex;
            List<Incident> incidents = BD.affichIncident();

            lbConsInci.Items.Add(incidents[rang].getId() + " " + incidents[rang].getProbleme());
        }

        private void btnEnregIncident_Click(object sender, EventArgs e)
        {
            int rang = cbConsInci.SelectedIndex;
            List<Incident> incidents = BD.affichIncident();

            if (incidents[rang].getEtat() == 1)
            {
                incidents[rang].setEtat(2);
            }
            if (incidents[rang].getEtat() == 0)
            {
                incidents[rang].setEtat(1);
            }

            BD.majEtatIncident(incidents[rang].getId(), incidents[rang].getEtat());
        }

        /// <summary>
        /// Événement déclenché lors de la suppression d'un technicien.
        /// </summary>
        private void btnSuppTech_Click(object sender, EventArgs e)
        {
            BD.supprTechnicien(cbSuppTech.Text);
            ActualiserTechnicien();
        }

        /// <summary>
        /// Événement déclenché lors de la suppression d'un utilisateur.
        /// </summary>
        private void btnSuppU_Click(object sender, EventArgs e)
        {
            BD.supprUtilisateur(cbSuppU.Text);
            ActualiserUtilisateur();
        }

        /// <summary>
        /// Modifier un utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEnregChercheur_Click(object sender, EventArgs e)
        {
            Chercheurs chercheur = new Chercheurs(textBoxMatriculeChercheur.Text, textBoxMdpChercheur.Text, dateTimePickerDateEmbauchChercheur.Value, textBoxRegCarrChercheur.Text, textBoxNomChercheur.Text, textBoxPrenomChercheur.Text, textBoxSpecialiterChercheur.Text, dateTimePickerTheseChercheur.Value);
            BD.AjoutChercheur(chercheur);
            ///ActualiserChercheur(); // Méthode pour actualiser l'affichage des chercheurs
        }

        private void buttonAfficherChercheur_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Efface les éléments précédents de la ListBox

            List<string> chercheurs = BD.GetChercheurs();

            foreach (string chercheur in chercheurs)
            {
                listBox1.Items.Add(chercheur); // Ajoute le nom et prénom du chercheur à la ListBox
                listBox1.Items.Add(""); // Ajoute un élément vide pour le saut de ligne
            }
        }
    }
}
