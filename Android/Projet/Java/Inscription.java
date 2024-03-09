package com.example.gremdic;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class Inscription extends AppCompatActivity {

    BD db;

    EditText nom;
    EditText prenom;
    EditText type;
    EditText adresse;
    EditText mail;
    EditText tel;
    EditText mdp;
    EditText cp;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_inscription);

        db = new BD(this);

        nom = findViewById(R.id.tbNom);
        prenom = findViewById(R.id.tbPrenom);
        type = findViewById(R.id.tbType);
        adresse = findViewById(R.id.tbAdresse);
        mail = findViewById(R.id.tbMail);
        tel = findViewById(R.id.tbTel);
        mdp = findViewById(R.id.tbMdp);
        cp = findViewById(R.id.tbCp);
    }

    public void confirmationAccount(View view) {
        if(nom.getText().toString().isEmpty() || prenom.getText().toString().isEmpty() || type.getText().toString().isEmpty() || adresse.getText().toString().isEmpty() || cp.getText().toString().isEmpty() || mail.getText().toString().isEmpty() || tel.getText().toString().isEmpty() || mdp.getText().toString().isEmpty()) {
            Toast.makeText(this, "Veuillez remplir tous les champs", Toast.LENGTH_LONG).show();
            return;
        }

        try {
            //int leCp = Integer.parseInt(cp.getText().toString());
            db.insertDataPRO(nom.getText().toString(), prenom.getText().toString(), type.getText().toString(), adresse.getText().toString(), cp.getText().toString(), mail.getText().toString(), tel.getText().toString(), mdp.getText().toString());
            Intent btnConfirmationInscription = new Intent(this, Accueuil.class);
            startActivity(btnConfirmationInscription);
        } catch(Exception e){
            Toast.makeText(this, "Erreur lors de l'inscription : " + e.getMessage(), Toast.LENGTH_LONG).show();
            e.printStackTrace(); // Ajout d'un log pour voir l'erreur complète dans la console
        }
    }


    public void retourInscription(View view){
        Intent btnRetourInscription = new Intent(this, Connexion.class);
        startActivity(btnRetourInscription);
    }
}
