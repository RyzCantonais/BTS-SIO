using System;

namespace laboGSB
{
    /// <summary>
    /// Classe représentant un utilisateur du système, héritée de la classe Personnel.
    /// Elle inclut des propriétés spécifiques telles que l'objectif, la prime, les avantages et le budget de l'utilisateur.
    /// </summary>
    public class Utilisateur : Personnel
    {
        // Propriétés privées spécifiques à la classe Utilisateur
        private int objectif;
        private int prime;
        private string avantage;
        private int budget;

        /// <summary>
        /// Constructeur pour la classe Utilisateur.
        /// </summary>
        /// <param name="unMatricule">Le matricule de l'utilisateur.</param>
        /// <param name="unMdp">Le mot de passe de l'utilisateur.</param>
        /// <param name="uneDateEmb">La date d'embauche de l'utilisateur.</param>
        /// <param name="uneRegcarr">La région de carrière de l'utilisateur.</param>
        /// <param name="unObjectif">L'objectif de l'utilisateur.</param>
        /// <param name="unePrime">La prime de l'utilisateur.</param>
        /// <param name="unAvantage">Les avantages de l'utilisateur.</param>
        /// <param name="unBudget">Le budget de l'utilisateur.</param>
        public Utilisateur(string unMatricule, string unMdp, DateTime uneDateEmb, string uneRegcarr, int unObjectif, int unePrime, string unAvantage, int unBudget)
            : base(unMatricule, unMdp, uneDateEmb, uneRegcarr, 0)
        {
            objectif = unObjectif;
            prime = unePrime;
            avantage = unAvantage;
            budget = unBudget;
        }

        /// <summary>
        /// Obtient l'objectif de l'utilisateur.
        /// </summary>
        /// <returns>L'objectif de l'utilisateur.</returns>
        public int GetObjectif()
        {
            return objectif;
        }

        /// <summary>
        /// Obtient la prime de l'utilisateur.
        /// </summary>
        /// <returns>La prime de l'utilisateur.</returns>
        public int GetPrime()
        {
            return prime;
        }

        /// <summary>
        /// Obtient les avantages de l'utilisateur.
        /// </summary>
        /// <returns>Les avantages de l'utilisateur.</returns>
        public string GetAvantage()
        {
            return avantage;
        }

        /// <summary>
        /// Obtient le budget de l'utilisateur.
        /// </summary>
        /// <returns>Le budget de l'utilisateur.</returns>
        public int GetBudget()
        {
            return budget;
        }

        /// <summary>
        /// Modifie l'objectif de l'utilisateur.
        /// </summary>
        /// <param name="unObjectif">Le nouvel objectif de l'utilisateur.</param>
        public void SetObjectif(int unObjectif)
        {
            objectif = unObjectif;
        }

        /// <summary>
        /// Modifie la prime de l'utilisateur.
        /// </summary>
        /// <param name="unePrime">La nouvelle prime de l'utilisateur.</param>
        public void SetPrime(int unePrime)
        {
            prime = unePrime;
        }

        /// <summary>
        /// Modifie les avantages de l'utilisateur.
        /// </summary>
        /// <param name="unAvantage">Les nouveaux avantages de l'utilisateur.</param>
        public void SetAvantage(string unAvantage)
        {
            avantage = unAvantage;
        }

        /// <summary>
        /// Modifie le budget de l'utilisateur.
        /// </summary>
        /// <param name="unBudget">Le nouveau budget de l'utilisateur.</param>
        public void SetBudget(int unBudget)
        {
            budget = unBudget;
        }
    }
}