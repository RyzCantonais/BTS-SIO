CREATE TABLE Personnel(
   Matricule VARCHAR(50),
   Mot_de_passe VARCHAR(50),
   Date_d_embauche DATE,
   Région_carrière VARCHAR(50),
   PRIMARY KEY(Matricule)
);

CREATE TABLE Visiteurs(
   Matricule VARCHAR(50),
   Objectif INT,
   Prime INT,
   Avantages VARCHAR(50),
   Budget INT,
   PRIMARY KEY(Matricule),
   FOREIGN KEY(Matricule) REFERENCES Personnel(Matricule)
);

CREATE TABLE Techniciens(
   Matricule VARCHAR(50),
   Intervention DATE,
   Formation VARCHAR(50),
   Compétences VARCHAR(50),
   PRIMARY KEY(Matricule),
   FOREIGN KEY(Matricule) REFERENCES Personnel(Matricule)
);

CREATE TABLE Matériel(
   Id_Matériel COUNTER,
   Processeur VARCHAR(50),
   Mémoire INT,
   Disque VARCHAR(50),
   Logiciels_installés VARCHAR(50),
   Date_d_achat DATE,
   Garantie VARCHAR(50),
   Fournisseur VARCHAR(50),
   PRIMARY KEY(Id_Matériel)
);

CREATE TABLE Incident(
   Id_Incident COUNTER,
   Problème VARCHAR(50),
   Travail_réalisé VARCHAR(50),
   Date_déclaration DATE,
   Date_prise_en_charge DATE,
   Date_de_fin DATE,
   Matricule VARCHAR(50) NOT NULL,
   Id_Matériel INT NOT NULL,
   Matricule_1 VARCHAR(50) NOT NULL,
   PRIMARY KEY(Id_Incident),
   FOREIGN KEY(Matricule) REFERENCES Techniciens(Matricule),
   FOREIGN KEY(Id_Matériel) REFERENCES Matériel(Id_Matériel),
   FOREIGN KEY(Matricule_1) REFERENCES Personnel(Matricule)
);
