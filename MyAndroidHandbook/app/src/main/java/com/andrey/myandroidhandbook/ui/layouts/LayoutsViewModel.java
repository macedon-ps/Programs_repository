package com.andrey.myandroidhandbook.ui.layouts;

import android.arch.lifecycle.LiveData;
import android.arch.lifecycle.MutableLiveData;
import android.arch.lifecycle.ViewModel;

public class LayoutsViewModel extends ViewModel {

    private MutableLiveData<String> mText;

    public LayoutsViewModel() {
        mText = new MutableLiveData<>();
        mText.setValue("LAYOUTS");
    }

    public LiveData<String> getText() {
        return mText;
    }
}