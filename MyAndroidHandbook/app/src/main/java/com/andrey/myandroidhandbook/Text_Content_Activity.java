package com.andrey.myandroidhandbook;

import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.DrawableRes;
import android.support.annotation.Nullable;
import android.support.v7.app.AppCompatActivity;
import android.widget.ImageView;
import android.widget.TextView;

public class Text_Content_Activity extends AppCompatActivity {

    private int category = 0;
    private int position = 0;
    private int [] array_layouts = {R.string.text_view_layout1, R.string.text_view_layout2, R.string.text_view_layout3, R.string.text_view_layout4, R.string.text_view_layout5, R.string.text_view_layout6};
    private int [] array_views = {R.string.text_view_view1, R.string.text_view_view2, R.string.text_view_view3, R.string.text_view_view4, R.string.text_view_view5, R.string.text_view_view1};
    private int [] array_codes = {R.string.text_view_codes1, R.string.text_view_codes2, R.string.text_view_codes3, R.string.text_view_codes4, R.string.text_view_codes5, R.string.text_view_codes6};
    private int [] array_tips = {R.string.text_view_tips1, R.string.text_view_tips2, R.string.text_view_tips3, R.string.text_view_tips4, R.string.text_view_tips5, R.string.text_view_tips6};
    private int [] array_theory = {R.string.text_view_theory1, R.string.text_view_theory2, R.string.text_view_theory3, R.string.text_view_theory4, R.string.text_view_theory5, R.string.text_view_theory6};
    private TextView text_content;
    private int[] image_content = {R.drawable.android_layouts_1, R.drawable.android_views_1, R.drawable.android_codes_1, R.drawable.android_tips_1, R.drawable.android_theory_1};


    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.text_content);
        text_content = findViewById(R.id.text_view_content);
        reciveIntent();
    }

    private void reciveIntent(){
        Intent intentMy = getIntent();
        if(intentMy!=null){
            category = intentMy.getIntExtra("category", 0);
            position = intentMy.getIntExtra("position", 0);
        }
        switch (category){
            case 0:
                // image_content.setImageResource("@drawable/android_layouts_1");
                text_content.setText(array_layouts [position]);
                break;
            case 1:
               // image_content.setImageResource("@drawable/android_views_1");
                text_content.setText(array_views [position]);
                break;
            case 2:
                //image_content.setImageResource("@drawable/android_codes_1");
                text_content.setText(array_codes [position]);
                break;
            case 3:
                //image_content.setImageResource("@drawable/android_tips_1");
                text_content.setText(array_tips [position]);
                break;
            case 4:
                //image_content.setImageResource("@drawable/android_theory_1");
                text_content.setText(array_theory [position]);
                break;
        }
    }
}
