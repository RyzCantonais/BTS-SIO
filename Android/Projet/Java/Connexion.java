package com.example.gremdic;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class Connexion extends AppCompatActivity {

    BD db;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_connexion);

        db = new BD(this);
    }

    public void login(View view){
    //Méthode connexion +pop up si nécessaire
        Intent btnConfirmationAccount = new Intent(this, Accueuil.class);
        startActivity(btnConfirmationAccount);

        db.viderTableProfessionnel();
        db.viderTableRDV();
    }

    public void createAccount(View view){
        Intent btnCreateAccount = new Intent(this, Inscription.class);
        startActivity(btnCreateAccount);
    }
}
