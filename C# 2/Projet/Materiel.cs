using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboGSB
{
    /// <summary>
    /// Classe représentant du matériel informatique.
    /// Elle inclut des propriétés telles que l'ID du matériel, le processeur, la mémoire, le disque, les logiciels installés, la date d'achat, la garantie et le fournisseur.
    /// </summary>
    public class Materiel
    {
        int idMateriel;
        string processeur;
        int memoire;
        string disque;
        string logicielInstalles;
        DateTime datedAchat;
        bool garantie = false;
        string fournisseur;

        /// <summary>
        /// Constructeur pour la classe Materiel avec ID spécifié.
        /// </summary>
        /// <param name="idMateriel">L'ID du matériel.</param>
        /// <param name="processeur">Le processeur du matériel.</param>
        /// <param name="memoire">La mémoire du matériel.</param>
        /// <param name="disque">Le disque du matériel.</param>
        /// <param name="logicielInstalles">Les logiciels installés sur le matériel.</param>
        /// <param name="datedAchat">La date d'achat du matériel.</param>
        /// <param name="garantie">Indique si le matériel est sous garantie.</param>
        /// <param name="fournisseur">Le fournisseur du matériel.</param>
        public Materiel(int idMateriel, string processeur, int memoire, string disque, string logicielInstalles, DateTime datedAchat, bool garantie, string fournisseur)
        {
            this.idMateriel = idMateriel;
            this.processeur = processeur;
            this.memoire = memoire;
            this.disque = disque;
            this.logicielInstalles = logicielInstalles;
            this.datedAchat = datedAchat;
            this.garantie = garantie;
            this.fournisseur = fournisseur;
        }

        /// <summary>
        /// Constructeur pour la classe Materiel sans ID spécifié.
        /// </summary>
        /// <param name="processeur">Le processeur du matériel.</param>
        /// <param name="memoire">La mémoire du matériel.</param>
        /// <param name="disque">Le disque du matériel.</param>
        /// <param name="logicielInstalles">Les logiciels installés sur le matériel.</param>
        /// <param name="datedAchat">La date d'achat du matériel.</param>
        /// <param name="garantie">Indique si le matériel est sous garantie.</param>
        /// <param name="fournisseur">Le fournisseur du matériel.</param>
        public Materiel(string processeur, int memoire, string disque, string logicielInstalles, DateTime datedAchat, bool garantie, string fournisseur)
        {
            this.processeur = processeur;
            this.memoire = memoire;
            this.disque = disque;
            this.logicielInstalles = logicielInstalles;
            this.datedAchat = datedAchat;
            this.garantie = garantie;
            this.fournisseur = fournisseur;
        }

        /// <summary>
        /// Obtient l'ID du matériel.
        /// </summary>
        /// <returns>L'ID du matériel.</returns>
        public int getIdMateriel()
        {
            return idMateriel;
        }

        /// <summary>
        /// Obtient le processeur du matériel.
        /// </summary>
        /// <returns>Le processeur du matériel.</returns>
        public string getProcesseur()
        {
            return processeur;
        }

        /// <summary>
        /// Obtient la mémoire du matériel.
        /// </summary>
        /// <returns>La mémoire du matériel.</returns>
        public int getMemoire()
        {
            return memoire;
        }

        /// <summary>
        /// Obtient le disque du matériel.
        /// </summary>
        /// <returns>Le disque du matériel.</returns>
        public string getDisque()
        {
            return disque;
        }

        /// <summary>
        /// Obtient les logiciels installés sur le matériel.
        /// </summary>
        /// <returns>Les logiciels installés sur le matériel.</returns>
        public string getLogicielInstalles()
        {
            return logicielInstalles;
        }

        /// <summary>
        /// Obtient la date d'achat du matériel.
        /// </summary>
        /// <returns>La date d'achat du matériel.</returns>
        public DateTime getDatedAchat()
        {
            return datedAchat;
        }

        /// <summary>
        /// Indique si le matériel est sous garantie.
        /// </summary>
        /// <returns>True si le matériel est sous garantie, sinon False.</returns>
        public bool getGarantie()
        {
            return garantie;
        }

        /// <summary>
        /// Obtient le fournisseur du matériel.
        /// </summary>
        /// <returns>Le fournisseur du matériel.</returns>
        public string getFournisseur()
        {
            return fournisseur;
        }

        /// <summary>
        /// Modifie l'ID du matériel.
        /// </summary>
        /// <param name="idMateriel">Le nouvel ID du matériel.</param>
        public void setIdMateriel(int idMateriel)
        {
            this.idMateriel = idMateriel;
        }

        /// <summary>
        /// Modifie le processeur du matériel.
        /// </summary>
        /// <param name="processeur">Le nouveau processeur du matériel.</param>
        public void setProcesseur(string processeur)
        {
            this.processeur = processeur;
        }

        /// <summary>
        /// Modifie la mémoire du matériel.
        /// </summary>
        /// <param name="memoire">La nouvelle mémoire du matériel.</param>
        public void setMemoire(int memoire)
        {
            this.memoire = memoire;
        }

        /// <summary>
        /// Modifie le disque du matériel.
        /// </summary>
        /// <param name="disque">Le nouveau disque du matériel.</param>
        public void setDisque(string disque)
        {
            this.disque = disque;
        }

        /// <summary>
        /// Modifie les logiciels installés sur le matériel.
        /// </summary>
        /// <param name="logicielInstalles">Les nouveaux logiciels installés sur le matériel.</param>
        public void setLogicielInstalles(string logicielInstalles)
        {
            this.logicielInstalles = logicielInstalles;
        }

        /// <summary>
        /// Modifie la date d'achat du matériel.
        /// </summary>
        /// <param name="datedAchat">La nouvelle date d'achat du matériel.</param>
        public void setDatedAchat(DateTime datedAchat)
        {
            this.datedAchat = datedAchat;
        }

        /// <summary>
        /// Modifie l'état de garantie du matériel.
        /// </summary>
        /// <param name="garantie">Indique si le matériel est sous garantie.</param>
        public void setGarantie(bool garantie)
        {
            this.garantie = garantie;
        }

        /// <summary>
        /// Modifie le fournisseur du matériel.
        /// </summary>
        /// <param name="fournisseur">Le nouveau fournisseur du matériel.</param>
        public void setFournisseur(string fournisseur)
        {
            this.fournisseur = fournisseur;
        }
    }
}