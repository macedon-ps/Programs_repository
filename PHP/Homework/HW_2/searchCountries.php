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

    echo '<form action="searchCountries.php" method="post">';
    echo '<table class="table table-striped">';
    echo '<tr>';
    echo '<td>№ п/п</td>';
    echo '<td>Страны:</td>';
    echo '</tr>';

    while ($row = mysqli_fetch_array($result, MYSQLI_NUM)) {
        echo '<tr>';
        echo '<td>' . $row[0] . '</td>' . '<td>' . $row[1] . '</td>';
        echo '</tr>';
    }

    echo '</table>';
    echo '</form>';

    echo '<form class="d-flex">';
    // echo '<input type="submit" name="search" value="Поиск">';
    echo '<input class="form-control me-2" type="search" name="search-country" placeholder="Найти страну" aria-label="Search">';
    echo '<button class="btn btn-success" type="submit" name="search-button">Поиск</button>';
    echo '</form>';
?>
    