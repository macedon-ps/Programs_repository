<?php 
    session_start();
    include_once("function.php");
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Список стран</title>
    <?php echo '<link rel="stylesheet" href="CSS\bootstrap.min.css">' ?>
    <?php echo '<link rel="stylesheet" href="CSS\style.css">' ?>
</head>

<body>
    <div class="main-container mx-2">
        <nav class="navbar navbar-expand-lg navbar-dark bg-success">
            <div class="container-fluid">
                <a class="navbar-brand" href="index.php?page=1">Страны мира</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <?php 
                        if(isset($_GET["page"])){
                            global $page;
                            $page = $_GET["page"];
                        }
                    ?>
                    
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <a 
                            <?php 
                                if($page == 1) echo'class="nav-link active"';
                                else echo'class="nav-link"';
                            ?> 
                            href="index.php?page=1">Home</a>
                        </li>
                        <li class="nav-item">
                            <a 
                            <?php 
                                if($page == 2) echo'class="nav-link active"';
                                else echo'class="nav-link"';
                            ?>   
                            href="index.php?page=2">Поиск стран</a>
                        </li>
                        <li class="nav-item">
                            <a 
                            <?php 
                                if($page == 3) echo'class="nav-link active"';
                                else echo'class="nav-link"';
                            ?> 
                            href="index.php?page=3">Добавление стран</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        
        <h1 class="text-center mt-3 mb-3">Справочник по странам мира</h1>
        
        <div>
            <?php
            global $page;
            if(isset($_GET["page"])){
                $page = $_GET["page"];
                if($page == 1){
                    include_once("index.php");
                    echo"Грузим блок Home";
                }
                if($page == 2){
                    include_once("searchCountries.php");
                    echo"Грузим блок Search";
                }
                if($page == 3){
                    include_once("addCountries.php");
                    echo"Грузим блок Add";
                }
            }
            ?>
            <div class="row">
                <footer>Step Academy &copy;</footer>
            </div>
        
        </div>
    </div>
    <?php
    echo '<script src="JS\bootstrap.min.js"></script>'
    ?>
</body>

</html>