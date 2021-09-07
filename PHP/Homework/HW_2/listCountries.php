<?php

    include_once("function.php");
    connect();

    $err = mysqli_connect_error($result);
    if ($err) {
        echo 'Ошибка подключения к базе данных. Код ошибки:' . $err . '<br>';
        exit();
    }

    $selectAllCountries = 'select * from countries';
    $result = mysqli_query($link, $selectAllCountries);

    $err = mysqli_connect_error($result);
    if ($err) {
        echo 'Ошибка SQL запроса. Код ошибки:' . $err . '<br>';
        exit();
    }
    echo '<div class="height-scroll"';
    echo '<form class="col-12 col-sm-12 col-md-6 col-lg-6 overflow-y-scroll">';
    echo '<table class="table table-striped">';
    echo '<tr>';
    echo '<td class="col-2 col-sm-2 col-md-2 col-lg-2">№ п/п</td>';
    echo '<td class="col-10 col-sm-10 col-md-10 col-lg-10">Страны:</td>';
    echo '</tr>';

    $number = 1;
    while ($row = mysqli_fetch_array($result, MYSQLI_NUM)) {
        echo '<tr>';
        echo '<td class="col-2 col-sm-2 col-md-2 col-lg-2">' . $number++ . '</td>' . '<td class="col-10 col-sm-10 col-md-10 col-lg-10">' . $row[1] . '</td>';
        echo '</tr>';
    }

    echo '</table>';
    echo '</form>';
    echo '</div>';
?>
    