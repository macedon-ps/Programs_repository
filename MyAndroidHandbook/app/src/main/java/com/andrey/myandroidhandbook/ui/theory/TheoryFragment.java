package com.andrey.myandroidhandbook.ui.theory;

import android.arch.lifecycle.Observer;
import android.arch.lifecycle.ViewModelProvider;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.andrey.myandroidhandbook.R;

public class TheoryFragment extends Fragment {

    private TheoryViewModel theoryViewModel;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        theoryViewModel =
                new ViewModelProvider(this, new ViewModelProvider.NewInstanceFactory()).get(TheoryViewModel.class);
        View root = inflater.inflate(R.layout.fragment_theory, container, false);
        final TextView textView = root.findViewById(R.id.text_theory);
        theoryViewModel.getText().observe(getViewLifecycleOwner(), new Observer<String>() {
            @Override
            public void onChanged(@Nullable String s) {
                textView.setText(s);
            }
        });
        return root;
    }
}