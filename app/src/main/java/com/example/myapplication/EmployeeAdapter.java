package com.example.myapplication;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import java.util.List;

public class EmployeeAdapter extends ArrayAdapter<Employee> {
    private LayoutInflater inflater;
    private int layout;
    private List<Employee> employees;

    public EmployeeAdapter(Context context, int resource, List<Employee> states) {
        super(context, resource, states);
        this.employees = states;
        this.layout = resource;
        this.inflater = LayoutInflater.from(context);
    }
    public View getView(int position, View convertView, ViewGroup parent) {

        View view=inflater.inflate(this.layout, parent, false);

        TextView idView = view.findViewById(R.id.id_view);
        TextView nameView = view.findViewById(R.id.name_view);

        Employee emp = employees.get(position);

        nameView.setText(emp.getName());
        idView.setText(emp.getID());

        return view;
    }
}
