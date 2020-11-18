package com.andrey.myandroidhandbook.ui.views;

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

public class ViewsFragment extends Fragment {

    private ViewsViewModel viewsViewModel;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        viewsViewModel =
                new ViewModelProvider(this, new ViewModelProvider.NewInstanceFactory()).get(ViewsViewModel.class);
        View root = inflater.inflate(R.layout.fragment_views, container, false);
        final TextView textView = root.findViewById(R.id.text_views);
        viewsViewModel.getText().observe(getViewLifecycleOwner(), new Observer<String>() {
            @Override
            public void onChanged(@Nullable String s) {
                textView.setText(s);
            }
        });
        return root;
    }
}