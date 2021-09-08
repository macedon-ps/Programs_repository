<?php 
    
    if(isset($_POST["search-button"])){
        $_SESSION["searchNameCountry"] = $_POST["search-country"];
    }
    
    echo '<div class="search-countries bg-light col-10 col-sm-10 col-md-8 col-lg-6">';
    echo '<form action="index.php?page=2" method="post" class="d-flex">';
    echo '<input class="form-control me-2" type="search" name="search-country" value="' . $_SESSION["searchNameCountry"] . '" required placeholder="Найти страну" aria-label="Search">'; 
    echo '<button class="btn btn-success" type="submit" name="search-button">Найти</button>';
    echo '</form>';
    echo '</div>';

?>