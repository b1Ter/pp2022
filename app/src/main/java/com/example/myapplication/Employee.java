package com.example.myapplication;


import androidx.room.Entity;
import androidx.room.PrimaryKey;
import androidx.annotation.Nullable;

import java.sql.Date;


@Entity
public class Employee {
    @PrimaryKey int id;
    public String Name;
    public String Position;
    public Float Salary;
    public Boolean IsFired = false;
    public Date ReceiptDate;

    Employee(String Name, String Position, Float Salary, @Nullable Boolean IsFired, Date ReceiptDate) {
        com.example.myapplication.AppDatabase db = App.getInstance().getDatabase();
        EmployeeDao employeeDao = db.employeeDao();
        if (employeeDao.getLast() != null)
            this.id = ((Employee)employeeDao.getLast()).id + 1;
        this.Name = Name;
        this.Position = Position;
        this.Salary = Salary;
        this.IsFired = IsFired;
        this.ReceiptDate = ReceiptDate;
    }

    //получение данных
    public int getID() {
        return id;
    }
    public String getName() {
        return Name;
    }
    public String getPosition() {
        return Position;
    }
    public Float getSalary() {
        return Salary;
    }
    public Boolean getIsFired() {
        return IsFired;
    }
    public Date getReceiptDate() {
        return ReceiptDate;
    }
    //изменение данных
    public void setName(String newName) {
        this.Name = newName;
    }
    public void setSalary(Float newSalary) {
        this.Salary = newSalary;
    }
    public void setPosition(String newPosition) {
        this.Position = newPosition;
    }
    public void setIsFired(Boolean newIsFired) {
        this.IsFired = newIsFired;
    }
    public void setReceiptDate(Date newReceipt) {
        this.ReceiptDate = newReceipt;
    }
}
