package com.example.gremdic;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class Accueuil extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_acceuil);
    }

    public void prendreRDV(View view){
        Intent btnPrendreRDV = new Intent(this, RendezVous.class);
        startActivity(btnPrendreRDV);
    }

    public void afficherPlanning(View view){
        Intent btnAfficherPlanning = new Intent(this, Planning.class);
        startActivity(btnAfficherPlanning);
    }

    public void afficherPro(View view){
        Intent btnAfficherPro = new Intent(this, Profesionnels.class);
        startActivity(btnAfficherPro);
    }

    public void disconnectAccueuil(View view){
        Intent btnDisconnectAccueuil = new Intent(this, Connexion.class);
        startActivity(btnDisconnectAccueuil);
    }
}
