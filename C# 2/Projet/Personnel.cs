using System;

/// <summary>
/// Classe de base représentant le personnel du système.
/// Elle inclut des propriétés telles que le matricule, le mot de passe, la date d'embauche, la région de carrière et des informations spécifiques aux utilisateurs.
/// </summary>
public class Personnel
{
    // Propriétés privées
    private string matricule;
    private string mdp;
    private DateTime dateEmb;
    private string regCarriere;
    private int responsable;

    /// <summary>
    /// Constructeur pour la classe Personnel.
    /// </summary>
    /// <param name="unMatricule">Le matricule du personnel.</param>
    /// <param name="unMdp">Le mot de passe du personnel.</param>
    /// <param name="uneDateEmb">La date d'embauche du personnel.</param>
    /// <param name="uneRegcarr">La région de carrière du personnel.</param>
    /// <param name="unResponsable">Un indicateur pour déterminer si le personnel est responsable.</param>
    public Personnel(string unMatricule, string unMdp, DateTime uneDateEmb, string uneRegcarr, int unResponsable)
    {
        matricule = unMatricule;
        mdp = unMdp;
        dateEmb = uneDateEmb;
        regCarriere = uneRegcarr;
        responsable = unResponsable;
    }

    // Constructeur pour les utilisateurs
    public Personnel(string unMatricule, string unMdp, DateTime uneDateEmb, string uneRegcarr, int unResponsable, int unObjectif, int unePrime, string desAvantages, int unBudget, string unResponsableMatricule)
        : this(unMatricule, unMdp, uneDateEmb, uneRegcarr, unResponsable)
    {
        // Initialisation des propriétés spécifiques aux visiteurs
        Objectif = unObjectif;
        Prime = unePrime;
        Avantages = desAvantages;
        Budget = unBudget;
        ResponsableMatricule = unResponsableMatricule;
    }

    /// <summary>
    /// Obtient le matricule du personnel.
    /// </summary>
    /// <returns>Le matricule du personnel.</returns>
    public string GetMatricule()
    {
        return matricule;
    }

    /// <summary>
    /// Obtient le mot de passe du personnel.
    /// </summary>
    /// <returns>Le mot de passe du personnel.</returns>
    public string GetMdp()
    {
        return mdp;
    }

    /// <summary>
    /// Obtient la date d'embauche du personnel.
    /// </summary>
    /// <returns>La date d'embauche du personnel.</returns>
    public DateTime GetDateEmb()
    {
        return dateEmb;
    }

    /// <summary>
    /// Obtient la région de carrière du personnel.
    /// </summary>
    /// <returns>La région de carrière du personnel.</returns>
    public string GetRegCarriere()
    {
        return regCarriere;
    }

    /// <summary>
    /// Obtient un indicateur pour déterminer si le personnel est responsable.
    /// </summary>
    /// <returns>Un indicateur pour déterminer si le personnel est responsable.</returns>
    public int GetResponsable()
    {
        return responsable;
    }

    /// <summary>
    /// Modifie l'indicateur de responsabilité du personnel.
    /// </summary>
    /// <param name="unResponsable">Le nouvel indicateur de responsabilité.</param>
    public void SetResponsable(int unResponsable)
    {
        responsable = unResponsable;
    }

    // Propriétés spécifiques aux visiteurs
    private int Objectif;
    private int Prime;
    private string Avantages;
    private int Budget;
    private string ResponsableMatricule;

    /// <summary>
    /// Obtient l'objectif de l'utilisateur.
    /// </summary>
    /// <returns>L'objectif de l'utilisateur.</returns>
    public int GetObjectif()
    {
        return Objectif;
    }

    /// <summary>
    /// Modifie l'objectif de l'utilisateur.
    /// </summary>
    /// <param name="unObjectif">Le nouvel objectif de l'utilisateur.</param>
    public void SetObjectif(int unObjectif)
    {
        Objectif = unObjectif;
    }

    /// <summary>
    /// Obtient la prime de l'utilisateur.
    /// </summary>
    /// <returns>La prime de l'utilisateur.</returns>
    public int GetPrime()
    {
        return Prime;
    }

    /// <summary>
    /// Modifie la prime de l'utilisateur.
    /// </summary>
    /// <param name="unePrime">La nouvelle prime de l'utilisateur.</param>
    public void SetPrime(int unePrime)
    {
        Prime = unePrime;
    }

    /// <summary>
    /// Obtient les avantages de l'utilisateur.
    /// </summary>
    /// <returns>Les avantages de l'utilisateur.</returns>
    public string GetAvantages()
    {
        return Avantages;
    }

    /// <summary>
    /// Modifie les avantages de l'utilisateur.
    /// </summary>
    /// <param name="desAvantages">Les nouveaux avantages de l'utilisateur.</param>
    public void SetAvantages(string desAvantages)
    {
        Avantages = desAvantages;
    }

    /// <summary>
    /// Obtient le budget de l'utilisateur.
    /// </summary>
    /// <returns>Le budget de l'utilisateur.</returns>
    public int GetBudget()
    {
        return Budget;
    }

    /// <summary>
    /// Modifie le budget de l'utilisateur.
    /// </summary>
    /// <param name="unBudget">Le nouveau budget de l'utilisateur.</param>
    public void SetBudget(int unBudget)
    {
        Budget = unBudget;
    }

    /// <summary>
    /// Obtient le matricule du responsable de l'utilisateur.
    /// </summary>
    /// <returns>Le matricule du responsable de l'utilisateur.</returns>
    public string GetResponsableMatricule()
    {
        return ResponsableMatricule;
    }

    /// <summary>
    /// Modifie le matricule du responsable de l'utilisateur.
    /// </summary>
    /// <param name="unResponsableMatricule">Le nouveau matricule du responsable de l'utilisateur.</param>
    public void SetResponsableMatricule(string unResponsableMatricule)
    {
        ResponsableMatricule = unResponsableMatricule;
    }
}
