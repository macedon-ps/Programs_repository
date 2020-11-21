package com.andrey.myandroidhandbook.ui.layouts;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.arch.lifecycle.Observer;
import android.arch.lifecycle.ViewModelProvider;

import com.andrey.myandroidhandbook.R;

public class LayoutsFragment extends Fragment {

    private LayoutsViewModel layoutsViewModel;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        layoutsViewModel =
                new ViewModelProvider(this, new ViewModelProvider.NewInstanceFactory()).get(LayoutsViewModel.class);
        View root = inflater.inflate(R.layout.fragment_layouts, container, false);
        final TextView textView = root.findViewById(R.id.text_layouts);
//        layoutsViewModel.getText().observe(getViewLifecycleOwner(), new Observer<String>() {
//            @Override
//            public void onChanged(@Nullable String s) {
//                textView.setText(s);
//            }
//        });
        return root;
    }
}