<?php
    include_once("function.php");
    connect();
    // проверка на ошибки подключения к БД
        
    echo '<div class="add-countries bg-light col-10 col-sm-10 col-md-8 col-lg-6">';
    echo '<form action="addCountries.php" method="post" class="d-flex">';
    echo '<input class="form-control me-2" name="add-country" type="search" required placeholder="Добавить страну" aria-label="Search">'; 
    echo '<input type="submit" class="btn btn-success" name="add-button">Добавить</input>';
    echo '</form>';
    echo '</div>';
    
    if(isset($_POST['add-button'])){
        
        writeNewCountry($_POST["add-country"]);
        // echo'Вы нажали на $_POST["add-button"] = ' . $_POST['add-button'];
        // echo'Название страны - ' . $_POST["add-country"];
    }
?>   