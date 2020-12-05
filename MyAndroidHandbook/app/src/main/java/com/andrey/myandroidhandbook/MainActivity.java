package com.andrey.myandroidhandbook;

import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.v4.view.GravityCompat;
import android.view.Menu;
import android.support.design.widget.NavigationView;

import androidx.navigation.NavController;
import androidx.navigation.Navigation;
import androidx.navigation.ui.AppBarConfiguration;
import androidx.navigation.ui.NavigationUI;

import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.Arrays;

public class MainActivity extends AppCompatActivity implements NavigationView.OnNavigationItemSelectedListener {

    private AppBarConfiguration mAppBarConfiguration;
    private ListView list ;
    private String[] array;
    private ArrayAdapter<String> adapter;
    private Toolbar toolbar;
    private int category_index;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        list = findViewById(R.id.listViewId);
        array = getResources().getStringArray(R.array.layout_arrays);
        adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, new ArrayList<String>(Arrays.asList(array)));
        list.setAdapter(adapter);

        toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        toolbar.setTitle(R.string.menu_layouts);
        DrawerLayout drawer = findViewById(R.id.drawer_layout);
        NavigationView navigationView = findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);
        // Passing each menu ID as a set of Ids because each
        // menu should be considered as top level destinations.
        mAppBarConfiguration = new AppBarConfiguration.Builder(
                R.id.id_layouts, R.id.id_views, R.id.id_codes, R.id.id_tips, R.id.id_theory)
                .setDrawerLayout(drawer)
                .build();

        NavController navController = Navigation.findNavController(this, R.id.nav_host_fragment);
        NavigationUI.setupActionBarWithNavController(this, navController, mAppBarConfiguration);
    // создаем слушателя на нажатие каждого из элементов списка
        list.setOnItemClickListener(
                new AdapterView.OnItemClickListener() {
                    @Override
                    public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                        Intent intent = new Intent(MainActivity.this, Text_Content_Activity.class);
                        intent.putExtra("category", category_index);
                        intent.putExtra("position", position);
                        startActivity(intent);
                    }
                }
        );
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onSupportNavigateUp() {
        NavController navController = Navigation.findNavController(this, R.id.nav_host_fragment);
        return NavigationUI.navigateUp(navController, mAppBarConfiguration)
                || super.onSupportNavigateUp();
    }

    @Override
    public boolean onNavigationItemSelected(@NonNull MenuItem menuItem) {

        int id = menuItem.getItemId();
        if(id==R.id.id_layouts){
            array = getResources().getStringArray(R.array.layout_arrays);
            adapter.clear();
            adapter.addAll(array);
            adapter.notifyDataSetChanged();
            toolbar.setTitle(R.string.menu_layouts);
            category_index = 0;
        }
        if(id==R.id.id_views){
            array = getResources().getStringArray(R.array.views_arrays);
            adapter.clear();
            adapter.addAll(array);
            adapter.notifyDataSetChanged();
            toolbar.setTitle(R.string.menu_views);
            category_index = 1;
        }
        if(id==R.id.id_codes){
            array = getResources().getStringArray(R.array.codes_arrays);
            adapter.clear();
            adapter.addAll(array);
            adapter.notifyDataSetChanged();
            toolbar.setTitle(R.string.menu_codes);
            category_index = 2;
        }
        if(id==R.id.id_tips){
            array = getResources().getStringArray(R.array.tips_arrays);
            adapter.clear();
            adapter.addAll(array);
            adapter.notifyDataSetChanged();
            toolbar.setTitle(R.string.menu_tips);
            category_index = 3;
        }
        if(id==R.id.id_theory){
            array = getResources().getStringArray(R.array.theory_arrays);
            adapter.clear();
            adapter.addAll(array);
            adapter.notifyDataSetChanged();
            toolbar.setTitle(R.string.menu_theory);
            category_index = 4;
        }

        DrawerLayout drawer = findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);
        return true;
    }
}