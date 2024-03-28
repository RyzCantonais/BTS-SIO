using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboGSB
{
    public class Chercheurs : Personnel
    {
        private string nom;
        private string prenom;
        private string speCherche;
        private DateTime dateThese;

        public Chercheurs(string unMatricule, string unMdp, DateTime uneDateEmb, string uneRegcarr, string nom, string prenom, string speCherche, DateTime dateThese)
            : base(unMatricule, unMdp, uneDateEmb, uneRegcarr, 0)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.speCherche = speCherche;
            this.dateThese = dateThese;
        }

        public string GetNom()
        {
            return nom;
        }

        public string GetPrenom()
        {
            return prenom;
        }

        public string GetSpeCherche()
        {
            return speCherche;
        }

        public DateTime GetDateThese()
        {
            return dateThese;
        }

        public void SetNom(string nom)
        {
            this.nom = nom;
        }

        public void SetPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public void SetSpeCherche(string speCherche)
        {
            this.speCherche = speCherche;
        }

        public void SetDateThese(DateTime dateThese)
        {
            this.dateThese = dateThese;
        }
    }
}
