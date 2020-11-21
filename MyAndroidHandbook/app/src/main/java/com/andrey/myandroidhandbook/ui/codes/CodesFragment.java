package com.andrey.myandroidhandbook.ui.codes;

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

public class CodesFragment extends Fragment {

    private CodesViewModel codesViewModel;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        codesViewModel =
                new ViewModelProvider(this, new ViewModelProvider.NewInstanceFactory()).get(CodesViewModel.class);
        View root = inflater.inflate(R.layout.fragment_codes, container, false);
        final TextView textView = root.findViewById(R.id.text_codes);
//        codesViewModel.getText().observe(getViewLifecycleOwner(), new Observer<String>() {
//            @Override
//            public void onChanged(@Nullable String s) {
//                textView.setText(s);
//            }
//        });
        return root;
    }
}