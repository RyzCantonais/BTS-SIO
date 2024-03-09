package com.example.gremdic;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.widget.CalendarView;
import android.widget.TextView;
import android.widget.Toast;

public class Planning extends AppCompatActivity {

    BD db;
    CalendarView calendar;
    String curDate;
    TextView resultat;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_planning);

        calendar = findViewById(R.id.calendarView2);
        resultat = findViewById(R.id.labelResultat);
        db = new BD(this);

        calendar.setOnDateChangeListener(new CalendarView.OnDateChangeListener() {
            @Override
            public void onSelectedDayChange(@NonNull CalendarView calendarView, int year, int month, int dayofMonth) {
                curDate = year + "/" + month + "/" + dayofMonth;
                StringBuilder liste = new StringBuilder(); // Utilisation d'un StringBuilder pour concaténer les rendez-vous
                try {
                    Cursor data = db.getInfoByDate(curDate);
                    while (data.moveToNext()){
                        String motif = data.getString(0);
                        String heure = data.getString(1);
                        liste.append(motif).append(" : ").append(heure).append("\n"); // Ajout de chaque rendez-vous dans le StringBuilder
                    }
                    resultat.setText(liste.toString()); // Affichage de tous les rendez-vous dans le TextView
                    //Toast.makeText(Planning.this, "Rendez-vous pour la date sélectionnée :\n" + liste.toString(), Toast.LENGTH_LONG).show();
                } catch (Exception e){
                    e.printStackTrace();
                }
            }
        });
    }


    public void retourPlanning(View view){
        Intent btnRetourPlanning = new Intent(this, Accueuil.class);
        startActivity(btnRetourPlanning);
    }

    public void disconnectPlanning(View view){
        Intent btnDisconnectPlanning = new Intent(this, Connexion.class);
        startActivity(btnDisconnectPlanning);
    }
}
