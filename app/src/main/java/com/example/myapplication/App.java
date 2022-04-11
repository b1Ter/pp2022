package com.example.myapplication;

import android.app.Application;
import androidx.room.Room;

public class App extends Application {
    public static App instance;
    private com.example.myapplication.AppDatabase database;

    @Override
    public void onCreate() {
        super.onCreate();
        instance = this;
        database = Room.databaseBuilder(this, com.example.myapplication.AppDatabase.class, "database").build();
    }
    public static App getInstance() {
        return instance;
    }
    public com.example.myapplication.AppDatabase getDatabase() {
        return database;
    }
}
