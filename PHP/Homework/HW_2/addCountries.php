<?php
    
    if(isset($_POST["add-button"])){
        $_SESSION["addNameCountry"] = $_POST["add-country"];
    }

    echo '<div class="add-countries bg-light col-10 col-sm-10 col-md-8 col-lg-6">';
    echo '<form action="index.php?page=3" method="post" class="d-flex">';
    
    echo '<input class="form-control me-2" name="add-country" value="' . $_SESSION["addNameCountry"] . '" type="search" required placeholder="Добавить страну" aria-label="Search">'; 
            
    echo '<input type="submit" class="btn btn-success" name="add-button"></input>';
    echo '</form>';
    echo '</div>';
    
?>   