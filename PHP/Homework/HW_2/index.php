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
    <div class="main-container">
        <nav class="navbar navbar-expand-lg navbar-dark bg-success">
            <div class="container-fluid">
                <a class="navbar-brand" href="index.php?page=1">Страны мира</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse parent" id="navbarSupportedContent">
                    <?php
                    if (isset($_GET["page"])) {
                        global $page;
                        $page = $_GET["page"];
                    }
                    ?>
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0 ">
                        <li class="nav-item">
                            <a <?php
                                if ($page == 2) echo 'class="nav-link active"';
                                else echo 'class="nav-link"';
                                ?> href="index.php?page=2">Поиск стран</a>
                        </li>
                        <li class="nav-item">
                            <a <?php
                                if ($page == 3) echo 'class="nav-link active"';
                                else echo 'class="nav-link"';
                                ?> href="index.php?page=3">Добавление стран</a>
                        </li>
                        <li class="nav-item ms-auto me-0 baby">
                            <a <?php
                                if ($page == 4) echo 'class="nav-link active"';
                                else echo 'class="nav-link"';
                                ?> href="index.php?page=4">Список стран в БД</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>

        <h1 class="text-center mt-3 mb-3">Страны мира</h1>

        <div class="code-block mx-3 mt-5">
            <?php
            global $page;
            if (isset($_GET["page"])) {
                $page = $_GET["page"];
                if ($page == 1) {
                    echo '<div class="mt-3 mb-3">Электронный справочник по странам мира</div>';
                    echo '<img class="col-12 col-sm-12 col-md-8 col-lg-6" src="images/countriesMap.jpg" alt="Карта стран мира">';
                }
                if ($page == 2) {
                    echo '<div class="mt-3 mb-3">Введите название страны, которое вы хотите найти в Энциклопедии стран мира (в текстовом файле):</div>';
                    echo '<br/>';
                    include_once("searchCountries.php");

                        echo '<br/>';
                        echo '<br/>';
                        if(isset($_POST['search-button'])){
                            searchCountries($_POST['search-country']);
                        }
                }
                if ($page == 3) {
                    echo '<div class="mt-3 mb-3">Введите название страны, которое вы хотите добавить к своему Списку стран мира (в БД MySQL):</div>';
                    echo '<br/>';
                    include_once("addCountries.php");
                        
                        echo '<br/>';
                        echo '<br/>';
                        if(isset($_POST['add-button'])){
                            writeNewCountry($_POST["add-country"]);
                        }
                }
                if ($page == 4) {
                    echo '<div class="mt-3 mb-3">Ваш Список стран мира (из БД MySQL):</div>';
                    include_once("listCountries.php");    
                }
            }
            ?>
        </div>

        <footer mx-2>
            <p>Step Academy &copy;</p>
        </footer>
    </div>
    <?php
    echo '<script src="JS\bootstrap.min.js"></script>'
    ?>
</body>

</html>