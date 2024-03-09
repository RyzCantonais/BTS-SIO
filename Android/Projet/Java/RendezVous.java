package com.example.gremdic;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.CalendarView;
import android.widget.EditText;
import android.widget.Toast;

public class RendezVous extends AppCompatActivity {

    BD db;
    String curDate;
    CalendarView date;
    EditText heure;
    EditText motif;
    EditText idPro;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_rendez_vous);

        db = new BD(this);
        date = findViewById(R.id.calendarView);
        heure = findViewById(R.id.tbHeure);
        motif = findViewById(R.id.tbMotif);
        idPro = findViewById(R.id.tbIdPro);


        date.setOnDateChangeListener(new CalendarView.OnDateChangeListener() {
            @Override
            public void onSelectedDayChange(CalendarView calendarView, int year, int month, int dayofMonth) {
                curDate = String.valueOf(dayofMonth) + "/" + String.valueOf(month) + "/" + String.valueOf(year);
            }
        });
    }

    public void enregistrerRDV(View view){
        try {
            int lheure = Integer.parseInt(heure.getText().toString());
            int lidPro = Integer.parseInt(idPro.getText().toString());
            db.insertDataRdv(curDate, lheure, motif.getText().toString(), lidPro);

            Toast.makeText(this, "Le rdv a bien été pris", Toast.LENGTH_LONG).show();
        } catch (NumberFormatException e) {
            Toast.makeText(this, "Veuillez entrer des valeurs valides pour l'heure et l'ID professionnel", Toast.LENGTH_LONG).show();
        }
    }


    public void retourRDV(View view){
        Intent btnRetourRDV = new Intent(this, Accueuil.class);
        startActivity(btnRetourRDV);
    }

    public void disconnectRDV(View view){
        Intent btnDisconnectRDV = new Intent(this, Connexion.class);
        startActivity(btnDisconnectRDV);
    }
}
