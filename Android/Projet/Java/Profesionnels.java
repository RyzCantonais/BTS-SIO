package com.example.gremdic;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

public class Profesionnels extends AppCompatActivity {

    EditText ville;
    EditText cp;
    TextView resultat;
    BD db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_profesionnels);

        ville = findViewById(R.id.tbVillePro);
        cp = findViewById(R.id.tbCpPro);
        resultat = findViewById(R.id.labelResultatPro);
        db = new BD(this);
    }

    public void visualiserPro(View view){
        StringBuilder liste = new StringBuilder();
        if(ville.length() > 0 && cp.length() > 0)
            Toast.makeText(this, "Veuillez saisir une seule information", Toast.LENGTH_LONG).show();
        if(ville.length() > 0) {
            try {
                Cursor data = db.getProByVille(ville.getText().toString());
                while (data.moveToNext()){
                    String nom = data.getString(0);
                    String prenom = data.getString(1);
                    liste.append(nom).append(" : ").append(prenom).append("\n");
                }
                resultat.setText(liste.toString());
            } catch (Exception e){
                e.printStackTrace();
            }
        } else {
            try {
                Cursor data = db.getProByCp(cp.getText().toString());
                while (data.moveToNext()){
                    String nom = data.getString(0);
                    String prenom = data.getString(1);
                    liste.append(nom).append(" : ").append(prenom).append("\n");
                }
                resultat.setText(liste.toString());
            } catch (Exception e){
                e.printStackTrace();
            };
        }
    }

    public void retourPro(View view){
        Intent btnRetourPro = new Intent(this, Accueuil.class);
        startActivity(btnRetourPro);
    }

    public void disconnectPro(View view){
        Intent btnDisconnectPro = new Intent(this, Connexion.class);
        startActivity(btnDisconnectPro);
    }
}
