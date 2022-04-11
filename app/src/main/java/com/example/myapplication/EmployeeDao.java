package com.example.myapplication;


import androidx.room.Dao;
import androidx.room.Delete;
import androidx.room.Insert;
import androidx.room.Query;
import androidx.room.Update;

import java.util.List;

@Dao
public interface EmployeeDao {

    @Insert
    void insertAll(Employee... employees);
    @Delete
    void delete(Employee employee);
    @Update
    void update(Employee employee);

    @Query("Select * from employee")
    List<Employee> getAll();
    @Query("SELECT * FROM employee WHERE id = :id")
    Employee getById(int id);
    @Query("SELECT * FROM employee order by id desc limit 1")
    Employee getLast();
    @Query("Select * from employee where IsFired like :isFired")
    List<Employee> getFired(Boolean isFired);
}
