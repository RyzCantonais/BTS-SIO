using System;

namespace laboGSB
{
    public class Technicien : Personnel
    {
        /// <summary>
        /// Classe représentant un technicien, héritée de la classe Personnel.
        /// Elle inclut des propriétés spécifiques telles que la date d'entrée en fonction, la formation, les compétences et les interventions du technicien.
        /// </summary>
        private DateTime date;
        private string formation;
        private string competence;
        private string intervention;

        /// <summary>
        /// Constructeur pour la classe Technicien, utilisant le constructeur de la classe de base Personnel.
        /// </summary>
        /// <param name="unMatricule">Le matricule du technicien.</param>
        /// <param name="uneIntervention">Le type d'intervention du technicien.</param>
        /// <param name="unMdp">Le mot de passe du technicien.</param>
        /// <param name="uneDateEmb">La date d'embauche du technicien.</param>
        /// <param name="uneRegcarr">La région de carrière du technicien.</param>
        /// <param name="uneDate">La date d'entrée en fonction du technicien.</param>
        /// <param name="uneFormation">La formation du technicien.</param>
        /// <param name="uneCompetence">Les compétences du technicien.</param>
        public Technicien(string unMatricule, string uneIntervention, string unMdp, DateTime uneDateEmb, string uneRegcarr, DateTime uneDate, string uneFormation, string uneCompetence)
            : base(unMatricule, unMdp, uneDateEmb, uneRegcarr, 0)
        {
            date = uneDate;
            formation = uneFormation;
            competence = uneCompetence;
            intervention = uneIntervention;
        }

        /// <summary>
        /// Obtient le type d'intervention du technicien.
        /// </summary>
        /// <returns>Le type d'intervention du technicien.</returns>
        public string GetIntervention()
        {
            return intervention;
        }

        /// <summary>
        /// Obtient la date d'entrée en fonction du technicien.
        /// </summary>
        /// <returns>La date d'entrée en fonction du technicien.</returns>
        public DateTime GetDate()
        {
            return date;
        }

        /// <summary>
        /// Obtient la formation du technicien.
        /// </summary>
        /// <returns>La formation du technicien.</returns>
        public string GetFormation()
        {
            return formation;
        }

        /// <summary>
        /// Obtient les compétences du technicien.
        /// </summary>
        /// <returns>Les compétences du technicien.</returns>
        public string GetCompetence()
        {
            return competence;
        }

        /// <summary>
        /// Modifie la date d'entrée en fonction du technicien.
        /// </summary>
        /// <param name="uneDate">La nouvelle date d'entrée en fonction du technicien.</param>
        public void SetDate(DateTime uneDate)
        {
            date = uneDate;
        }

        /// <summary>
        /// Modifie la formation du technicien.
        /// </summary>
        /// <param name="uneFormation">La nouvelle formation du technicien.</param>
        public void SetFormation(string uneFormation)
        {
            formation = uneFormation;
        }

        /// <summary>
        /// Modifie les compétences du technicien.
        /// </summary>
        /// <param name="uneCompetence">Les nouvelles compétences du technicien.</param>
        public void SetCompetence(string uneCompetence)
        {
            competence = uneCompetence;
        }
    }
}