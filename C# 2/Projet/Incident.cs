using System;

namespace laboGSB
{
    /// <summary>
    /// Classe représentant un incident dans un système de gestion de services. Elle contient des informations telles que l'ID, le problème, le matériel associé, le travail réalisé, les dates de déclaration, de prise en charge, de fin, et des informations de personnel technique.
    /// </summary>
    public class Incident
    {

        private int id;
        private string probleme;
        private string materiel;
        private string travailRealise;
        private DateTime dateDeclaration;
        private DateTime datePriseEnCharge;
        private DateTime dateFin;
        private string matriculePerso;
        private int idMateriel;
        private string matriculeTech;
        private int etat;

        /// <summary>
        /// Constructeur pour créer un incident avec des informations nécessaires.
        /// </summary>
        public Incident(string unProbleme, string materiel, string matriculePerso, DateTime uneDateDeclaration, int idMateriel, string matriculeTech, int etat)
        {
            this.probleme = unProbleme;
            this.materiel = materiel;
            this.matriculePerso = matriculePerso;
            this.dateDeclaration = uneDateDeclaration;
            this.idMateriel = idMateriel;
            this.matriculeTech = matriculeTech;
            this.etat = etat;
        }

        /// <summary>
        /// Constructeur pour créer un incident avec des informations de travail.
        /// </summary>
        public Incident(string unProbleme, string unTravailRealise, DateTime uneDateDeclaration, DateTime uneDatePriseEnCharge, DateTime uneDateFin)
        {
            probleme = unProbleme;
            travailRealise = unTravailRealise;
            dateDeclaration = uneDateDeclaration;
            datePriseEnCharge = uneDatePriseEnCharge;
            dateFin = uneDateFin;
        }

        /// <summary>
        /// Constructeur pour créer un incident avec un ID et un problème.
        /// </summary>
        public Incident(int unIdIncident, string unProbleme)
        {
            this.id = unIdIncident;
            this.probleme = unProbleme;
        }

        /// <summary>
        /// Constructeur pour créer un incident avec des informations complètes.
        /// </summary>
        public Incident(int unId_Incident, string unProbleme, string unTravailRealise, DateTime uneDateDeclaration, DateTime uneDatePriseEnCharge, DateTime uneDateFin, string unMatriculePerso, int unId_Materiel, string unMatriculeTech)
        {
            this.id = unId_Incident;
            this.probleme = unProbleme;
            this.travailRealise = unTravailRealise;
            this.dateDeclaration = uneDateDeclaration;
            this.datePriseEnCharge = uneDatePriseEnCharge;
            this.dateFin = uneDateFin;
            this.matriculePerso = unMatriculePerso;
            this.idMateriel = unId_Materiel;
            this.matriculeTech = unMatriculeTech;
        }

        /// <summary>
        /// Obtient l'ID de l'incident.
        /// </summary>
        /// <returns>L'ID de l'incident.</returns>
        public int getId()
        {
            return id;
        }

        /// <summary>
        /// Modifie l'ID de l'incident.
        /// </summary>
        /// <param name="unId">Le nouvel ID de l'incident.</param>
        public void setId(int unId)
        {
            id = unId;
        }

        /// <summary>
        /// Obtient le problème de l'incident.
        /// </summary>
        /// <returns>Le problème de l'incident.</returns>
        public string getProbleme()
        {
            return probleme;
        }

        /// <summary>
        /// Modifie le problème de l'incident.
        /// </summary>
        /// <param name="unProbleme">Le nouveau problème de l'incident.</param>
        public void setProbleme(string unProbleme)
        {
            probleme = unProbleme;
        }

        /// <summary>
        /// Obtient le matériel associé à l'incident.
        /// </summary>
        /// <returns>Le matériel associé à l'incident.</returns>
        public string getMateriel()
        {
            return materiel;
        }

        /// <summary>
        /// Modifie le matériel associé à l'incident.
        /// </summary>
        /// <param name="unMateriel">Le nouveau matériel associé à l'incident.</param>
        public void setMateriel(string unMateriel)
        {
            materiel = unMateriel;
        }

        /// <summary>
        /// Obtient le travail réalisé associé à l'incident.
        /// </summary>
        /// <returns>Le travail réalisé associé à l'incident.</returns>
        public string getTravailRealise()
        {
            return travailRealise;
        }

        /// <summary>
        /// Modifie le travail réalisé associé à l'incident.
        /// </summary>
        /// <param name="unTravailRealise">Le nouveau travail réalisé associé à l'incident.</param>
        public void setTravailRealise(string unTravailRealise)
        {
            travailRealise = unTravailRealise;
        }

        /// <summary>
        /// Obtient la date de déclaration associé à l'incident.
        /// </summary>
        /// <returns>La date de déclaration associé à l'incident.</returns>
        public DateTime getDateDeclaration()
        {
            return dateDeclaration;
        }

        /// <summary>
        /// Modifie la date de déclaration associé à l'incident.
        /// </summary>
        /// <param name="uneDateDeclaration">La date de déclaration associé à l'incident.</param>
        public void setDateDeclaration(DateTime uneDateDeclaration)
        {
            dateDeclaration = uneDateDeclaration;
        }

        /// <summary>
        /// Obtient la date de prise en charge associé à l'incident.
        /// </summary>
        /// <returns>La date de prise en charge associé à l'incident.</returns>
        public DateTime getDatePriseEnCharge()
        {
            return datePriseEnCharge;
        }

        /// <summary>
        /// Modifie la date de prise en charge associé à l'incident.
        /// </summary>
        /// <param name="uneDatePriseEnCharge">La date de prise en charge associé à l'incident.</param>
        public void setDatePriseEnCharge(DateTime uneDatePriseEnCharge)
        {
            datePriseEnCharge = uneDatePriseEnCharge;
        }

        /// <summary>
        /// Obtient la date de fin associé à l'incident.
        /// </summary>
        /// <returns>La date de fin associé à l'incident.</returns>
        public DateTime getDateFin()
        {
            return dateFin;
        }

        /// <summary>
        /// Modifie la date de fin associé à l'incident.
        /// </summary>
        /// <param name="uneDateFin">La date de fin associé à l'incident.</param>
        public void setDateFin(DateTime uneDateFin)
        {
            dateFin = uneDateFin;
        }

        /// <summary>
        /// Obtient le matricule d'un personnel associé à l'incident.
        /// </summary>
        /// <returns>Le matricule d'un personnel associé à l'incident.</returns>
        public string getMatriculePerso()
        {
            return matriculePerso;
        }

        /// <summary>
        /// Modifie le matricule d'un personnel à l'incident.
        /// </summary>
        /// <param name="unMatriculePerso">Le nouveau matricule d'un personnel associé à l'incident.</param>
        public void setMatriculePerso(string unMatriculePerso)
        {
            matriculePerso = unMatriculePerso;
        }

        /// <summary>
        /// Obtient l'id d'un matériel associé à l'incident.
        /// </summary>
        /// <returns>L'id d'un matériel associé à l'incident.</returns>
        public int getIdMateriel()
        {
            return idMateriel;
        }

        /// <summary>
        /// Modifie l'id d'un matériel associé à l'incident.
        /// </summary>
        /// <param name="unIdMateriel">Le nouvel id du matériel associé à l'incident.</param>
        public void setIdMateriel(int unIdMateriel)
        {
            idMateriel = unIdMateriel;
        }

        /// <summary>
        /// Obtient le matricule d'un technicien associé à l'incident.
        /// </summary>
        /// <returns>Le matricule d'un technicien associé à l'incident.</returns>
        public string getMatriculeTech()
        {
            return matriculeTech;
        }

        /// <summary>
        /// Modifie le matricule du technicien associé à l'incident.
        /// </summary>
        /// <param name="unMatriculeTech">Le nouveau matricule du technicien associé à l'incident.</param>
        public void setMatriculeTech(string unMatriculeTech)
        {
            matriculeTech = unMatriculeTech;
        }

        public static implicit operator Incident(Technicien v)
        {
            throw new NotImplementedException();
        }

        public void setEtat(int unEtat)
        {
            etat = unEtat;
        }

        public int getEtat()
        {
            return etat;
        }
    }
}
