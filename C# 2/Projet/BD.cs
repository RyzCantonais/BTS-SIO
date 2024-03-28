using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace laboGSB
{
    public class BD
    {
        // Connexion à la base de données MySQL
        static string connStr = "Server=127.0.0.1;Database=labogsb;Uid=root;Password=;SSLMode=none;";
        static MySqlConnection conn = new MySqlConnection(connStr);

        /// <summary>
        /// Vérifie la connexion en comparant les identifiants fournis avec la base de données.
        /// Renvoie le rôle de l'utilisateur ou une erreur de connexion.
        /// </summary>
        public static string VerifConn(string id, string mdp)
        {
            string matricule = id;
            string motDePasse = mdp;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string sql = "SELECT COUNT(*) FROM personnel WHERE Matricule = @Matricule AND Mot_de_passe = @Mot_de_passe";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Matricule", matricule);
            cmd.Parameters.AddWithValue("@Mot_de_passe", motDePasse);
            int nb = Convert.ToInt32(cmd.ExecuteScalar());

            if (nb > 0)
            {

                string sql1 = "SELECT COUNT(*) FROM techniciens WHERE Matricule = @Matricule";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@Matricule", matricule);
                int nb1 = Convert.ToInt32(cmd1.ExecuteScalar());

                if (nb1 > 0)
                {
                    conn.Close();
                    return "Technicien";
                }


                string sql2 = "SELECT COUNT(*) FROM personnel WHERE Matricule = @Matricule AND Responsable = 1";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@Matricule", matricule);
                int nb2 = Convert.ToInt32(cmd2.ExecuteScalar());

                if (nb2 > 0)
                {
                    conn.Close();
                    return "Responsable";
                }
                conn.Close();
                return "Utilisateur";
            }
            else
            {
                conn.Close();
                return "Erreur de connexion";
            }
        }

        /// <summary>
        /// Ajoute un technicien à la base de données.
        /// </summary>
        public static void AjoutTechnicien(Technicien unTechnicien)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO techniciens (Matricule, Intervention, Formation, Competences) VALUES (@Matricule, @Intervention, @Formation, @Competences)";
            cmd.Parameters.AddWithValue("@Matricule", unTechnicien.GetMatricule());
            cmd.Parameters.AddWithValue("@Intervention", unTechnicien.GetIntervention());
            cmd.Parameters.AddWithValue("@Formation", unTechnicien.GetFormation());
            cmd.Parameters.AddWithValue("@Competences", unTechnicien.GetCompetence());
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Supprime un technicien de la base de données.
        /// </summary>
        public static void supprTechnicien(string id)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlCommand cmd4 = conn.CreateCommand();
            cmd4.CommandText = "DELETE FROM techniciens WHERE Matricule = @index";
            cmd4.Parameters.AddWithValue("@index", id);
            cmd4.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Ajoute un membre du personnel à la base de données.
        /// </summary>
        public static void AjoutPersonnel(Personnel unPersonnel)
        {
            conn.Open();
            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "INSERT INTO personnel (Matricule, Mot_de_passe, Date_d_embauche, Region_carriere) VALUES (@Matricule, @Mot_de_passe, @Date_d_embauche, @Region_carriere)";
            cmd1.Parameters.AddWithValue("@Matricule", unPersonnel.GetMatricule());
            cmd1.Parameters.AddWithValue("@Mot_de_passe", unPersonnel.GetMdp());
            cmd1.Parameters.AddWithValue("@Date_d_embauche", unPersonnel.GetDateEmb());
            cmd1.Parameters.AddWithValue("@Region_carriere", unPersonnel.GetRegCarriere());
            cmd1.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Ajoute un membre des chercheus à la base de données.
        /// </summary>
        public static void AjoutChercheur(Chercheurs unChercheur)
        {
            conn.Open();
            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "INSERT INTO chercheur (matricule , nom, prenom, specialiter, anneeThese) VALUES (@Matricule, @Nom, @Prenom, @Specialiter, @AnneeThese)";
            cmd1.Parameters.AddWithValue("@Matricule", unChercheur.GetMatricule());
            cmd1.Parameters.AddWithValue("@Nom", unChercheur.GetNom());
            cmd1.Parameters.AddWithValue("@Prenom", unChercheur.GetPrenom());
            cmd1.Parameters.AddWithValue("@Specialiter", unChercheur.GetSpeCherche());
            cmd1.Parameters.AddWithValue("@AnneeThese", unChercheur.GetDateThese());
            cmd1.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Récupérer nom et prénom des chercheurs pour l'affichage
        /// </summary>
        public static List<string> GetChercheurs()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            List<string> NomPrenom = new List<string>();
            MySqlCommand GetAllChercheurs = conn.CreateCommand();
            GetAllChercheurs.CommandText = "SELECT nom, prenom FROM chercheur;";
            MySqlDataReader datareader = GetAllChercheurs.ExecuteReader();
            while (datareader.Read())
            {
                NomPrenom.Add((string)datareader["nom"]);
                NomPrenom.Add((string)datareader["prenom"]);
            }
            conn.Close();
            return NomPrenom;
        }

        /// <summary>
        /// Ajoute un utilisateur à la base de données.
        /// </summary>
        public static void AjoutUtilisateur(Utilisateur unUtilisateur)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO utilisateurs (Matricule, Objectif, Prime, Avantages, Responsable) VALUES (@Matricule, @Objectif, @Prime, @Avantages, @Responsable)";
            cmd.Parameters.AddWithValue("@Matricule", unUtilisateur.GetMatricule());
            cmd.Parameters.AddWithValue("@Objectif", unUtilisateur.GetObjectif());
            cmd.Parameters.AddWithValue("@Prime", unUtilisateur.GetPrime());
            cmd.Parameters.AddWithValue("@Avantages", unUtilisateur.GetAvantage());
            cmd.Parameters.AddWithValue("@Responsable", unUtilisateur.GetResponsable());
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Modifie un utilisateur à la base de données.
        /// </summary>
        /// <param name="unUtilisateur"></param>
        public static void ModifierUtilisateur(Utilisateur unUtilisateur)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE utilisateurs SET Objectif = @Objectif, Prime = @Prime, Avantages = @Avantages, Responsable = @Responsable WHERE Matricule = @Matricule";
            cmd.Parameters.AddWithValue("@Matricule", unUtilisateur.GetMatricule());
            cmd.Parameters.AddWithValue("@Objectif", unUtilisateur.GetObjectif());
            cmd.Parameters.AddWithValue("@Prime", unUtilisateur.GetPrime());
            cmd.Parameters.AddWithValue("@Avantages", unUtilisateur.GetAvantage());
            cmd.Parameters.AddWithValue("@Responsable", unUtilisateur.GetResponsable());
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Supprime un utilisateur de la base de données.
        /// </summary>
        public static void supprUtilisateur(string id)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlCommand cmd4 = conn.CreateCommand();
            cmd4.CommandText = "DELETE FROM utilisateurs WHERE Matricule = @index";
            cmd4.Parameters.AddWithValue("@index", id);
            cmd4.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Ajoute un incident à la base de données.
        /// </summary>
        public static void AjoutIncident(Incident unIncident)
        {
            conn.Open();
            MySqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = "INSERT INTO incident (Probleme, Travail_realise, Date_declaration, Matricule_Perso, Id_Materiel, Matricule_Tech, Etat) VALUES (@Probleme, @Travail_realise, @Date_declaration, @Matricule_perso, @Id_Materiel, @Matricule_Tech, @Etat)";
            cmd2.Parameters.AddWithValue("@Probleme", unIncident.getProbleme());
            cmd2.Parameters.AddWithValue("@Travail_realise", unIncident.getTravailRealise());
            cmd2.Parameters.AddWithValue("@Date_declaration", unIncident.getDateDeclaration());
            cmd2.Parameters.AddWithValue("@Matricule_perso", unIncident.getMatriculePerso());
            cmd2.Parameters.AddWithValue("@Id_Materiel", unIncident.getIdMateriel());
            cmd2.Parameters.AddWithValue("@Matricule_Tech", unIncident.getMatriculeTech());
            cmd2.Parameters.AddWithValue("@Etat", unIncident.getEtat());
            cmd2.ExecuteNonQuery();
            conn.Close();
        } 

        /// <summary>
        /// Ajoute un matériel à la base de données.
        /// </summary>
        public static void AjoutMateriel(Materiel unMateriel)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            MySqlCommand cmd3 = conn.CreateCommand();
            cmd3.CommandText = "INSERT INTO materiel (Processeur, Memoire, Disque, Logiciels_installes, Date_d_achat, Garantie, Fournisseur) VALUES (@Processeur, @Memoire, @Disque, @Logiciels_installes, @Date_d_achat, @Garantie, @Fournisseur)";
            cmd3.Parameters.AddWithValue("@Processeur", unMateriel.getProcesseur());
            cmd3.Parameters.AddWithValue("@Memoire", unMateriel.getMemoire());
            cmd3.Parameters.AddWithValue("@Disque", unMateriel.getDisque());
            cmd3.Parameters.AddWithValue("@Logiciels_installes", unMateriel.getLogicielInstalles());
            cmd3.Parameters.AddWithValue("@Date_d_achat", unMateriel.getDatedAchat());
            cmd3.Parameters.AddWithValue("@Garantie", unMateriel.getGarantie());
            cmd3.Parameters.AddWithValue("@Fournisseur", unMateriel.getFournisseur());
            cmd3.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Récupère la liste des identifiants de matériel depuis la base de données.
        /// </summary>
        public static List<int> GetIdMateriel()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            List<int> IdMateriels = new List<int>();
            MySqlCommand GetAllMateriel = conn.CreateCommand();
            GetAllMateriel.CommandText = "SELECT Id_Materiel FROM Materiel;";
            MySqlDataReader datareader = GetAllMateriel.ExecuteReader();
            while (datareader.Read())
            {
                IdMateriels.Add((int)datareader["Id_Materiel"]);
            }
            conn.Close();
            return IdMateriels;
        }

        /// <summary>
        /// Récupère les détails d'un matériel en fonction de son identifiant depuis la base de données.
        /// </summary>
        public static string GetUnMateriel(int id)
        {
            string details = "";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlCommand GetUnMateriel = conn.CreateCommand();
            GetUnMateriel.CommandText = "SELECT * FROM Materiel WHERE Id_Materiel = @index;";
            GetUnMateriel.Parameters.AddWithValue("@index", id);
            MySqlDataReader datareader = GetUnMateriel.ExecuteReader();
            datareader.Read();
            details = datareader["Id_Materiel"] + " " + datareader["Processeur"] + " " + datareader["Memoire"] + " " + datareader["Disque"] + " " + datareader["Logiciels_installes"] + " " + datareader["Date_d_achat"] + " " + datareader["Garantie"] + " " + datareader["Fournisseur"];
            conn.Close();
            return details;
        }



        /// <summary>
        /// Supprime un matériel de la base de données en fonction de son identifiant.
        /// </summary>
        public static void SuppMateriel(int id)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlCommand cmd4 = conn.CreateCommand();
            cmd4.CommandText = "DELETE FROM materiel WHERE Id_Materiel = @index";
            cmd4.Parameters.AddWithValue("@index", id);
            cmd4.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Récupère la liste des matricules de techniciens depuis la base de données.
        /// </summary>
        public static List<string> GetMatriculeTechnicien()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            List<string> MatriculeT = new List<string>();
            MySqlCommand GetAllMatricule = conn.CreateCommand();
            GetAllMatricule.CommandText = "SELECT Matricule FROM techniciens;";
            MySqlDataReader datareader = GetAllMatricule.ExecuteReader();
            while (datareader.Read())
            {
                MatriculeT.Add((string)datareader["Matricule"]);
            }
            conn.Close();
            return MatriculeT;
        }

        /// <summary>
        /// Récupère la liste des matricules d'utilisateurs depuis la base de données.
        /// </summary>
        public static List<string> GetMatriculeUtilisateur()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            List<string> MatriculeU = new List<string>();
            MySqlCommand GetAllMatricule = conn.CreateCommand();
            GetAllMatricule.CommandText = "SELECT Matricule FROM visiteurs;";
            MySqlDataReader datareader = GetAllMatricule.ExecuteReader();
            while (datareader.Read())
            {
                MatriculeU.Add((string)datareader["Matricule"]);
            }
            conn.Close();
            return MatriculeU;
        }

        /// <summary>
        /// Récupère la liste des incidents depuis la base de données.
        /// </summary>
        public static List<Incident> affichIncident()
        {
            List<Incident> lesIncidents = new List<Incident>();
            conn.Open();
            MySqlCommand cmd5 = conn.CreateCommand();
            cmd5.CommandText = "SELECT * FROM incident";
            MySqlDataReader reader = cmd5.ExecuteReader();

            while (reader.Read())
            {
                Incident unIncident = new Incident((int)reader["Id_Incident"], (string)reader["Probleme"]); //(string)reader["Travail_realise"], (System.DateTime)reader["Date_declaration"], (System.DateTime)reader["Date_prise_en_charge"], (System.DateTime)reader["Date_de_fin"], (string)reader["Matricule_Perso"], (int)reader["Id_Materiel"], (string)reader["Matricule_Tech"]);
                lesIncidents.Add(unIncident);
            }
            conn.Close();
            return lesIncidents;
        }

        public static void majEtatIncident(int unId, int unEtat)
        {
            conn.Open();
            MySqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = "UPDATE incident set Etat = @Etat WHERE Id_Incident=@id";
            cmd2.Parameters.AddWithValue("@Etat", unEtat);
            cmd2.Parameters.AddWithValue("@Id", unId);
            cmd2.ExecuteNonQuery();
            conn.Close();
        }
    }
}
