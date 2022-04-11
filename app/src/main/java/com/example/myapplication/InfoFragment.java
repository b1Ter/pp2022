package com.example.myapplication;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.Nullable;
import androidx.databinding.DataBindingUtil;
import androidx.fragment.app.Fragment;

import com.example.myapplication.databinding.FragmentInfoBinding;

public class InfoFragment extends Fragment {

    public Employee employee;
    AppDatabase bd;

    @Override
    public void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        employee = savedInstanceState.getParcelable(Employee.class.getSimpleName());
        bd = savedInstanceState.getParcelable(AppDatabase.class.getSimpleName());
    }

    @Nullable
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             @Nullable Bundle savedInstanceState) {
        setEmployee();
        return inflater.inflate(R.layout.fragment_info, container, false);
    }

    public void setEmployee() {
        FragmentInfoBinding binding = DataBindingUtil.setContentView(requireActivity(), R.layout.fragment_info);
        binding.setEmployee(employee);
    }
    public void onClickSave(View view) {
        bd.employeeDao().update(employee);
    }
    public void onClickRemove(View view) {
        bd.employeeDao().delete(employee);
    }
}
