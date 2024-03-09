package com.example.gremdic;

import android.content.Context;
import androidx.test.ext.junit.runners.AndroidJUnit4;
import androidx.test.platform.app.InstrumentationRegistry;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;
import static org.junit.Assert.*;

@RunWith(AndroidJUnit4.class)
public class BDTest {

    private Context appContext;
    private BD database;

    @Before
    public void setup() {
        appContext = InstrumentationRegistry.getInstrumentation().getTargetContext();
        database = new BD(appContext);
    }

    @Test
    public void testInsertDataPRO() {
        // Insertion d'un professionnel
        String nom = "Doe";
        String prenom = "John";
        String type = "Médecin";
        String adresse = "123 Rue Test";
        String mail = "john@example.com";
        String tel = "123456789";
        String mdp = "motdepasse";
        //int cp = "31270";

        //database.insertDataPRO(nom, prenom, type, adresse, cp,mail, tel, mdp);

        // Vérification si les données ont été insérées correctement
        // Vous pouvez utiliser une méthode de récupération pour vérifier les données insérées
        // et comparer avec les valeurs attendues.
        // Par exemple, vérifiez si les données insérées sont présentes dans la base de données.
        // Assurez-vous d'avoir une méthode de récupération dans la classe BD pour tester cela.
        // Vous pouvez également vérifier le nombre de lignes affectées dans la base de données.

        // Implémentez ici vos vérifications/assertions pour tester l'insertion de professionnel
    }

    @Test
    public void testInsertDataRdv() {
        // Insertion d'un rendez-vous
        String laDate = "2023-12-31";
        int heure = 10;
        int id_pro = 1;

        //database.insertDataRdv(laDate, heure, id_pro);

        // Vérification si les données ont été insérées correctement
        // Vous pouvez utiliser une méthode de récupération pour vérifier les données insérées
        // et comparer avec les valeurs attendues.
        // Par exemple, vérifiez si les données insérées sont présentes dans la base de données.
        // Assurez-vous d'avoir une méthode de récupération dans la classe BD pour tester cela.
        // Vous pouvez également vérifier le nombre de lignes affectées dans la base de données.

        // Implémentez ici vos vérifications/assertions pour tester l'insertion de rendez-vous
    }
}
