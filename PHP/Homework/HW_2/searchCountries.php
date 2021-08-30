<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Поиск стран мира</title>
    <?php echo '<link rel="stylesheet" href="CSS\bootstrap.min.css">' ?>
    <?php echo '<link rel="stylesheet" href="CSS\style.css">' ?>
</head>

<body>
    <div class="search-countries-container mx-2">
        <nav class="navbar navbar-expand-lg navbar-dark bg-success">
            <div class="container-fluid">
                <a class="navbar-brand" href="index.php">Страны мира</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="index.php">Home</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="searchCountries.php">Поиск стран</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="addCountries.php">Добавление стран</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    
        <div class="search-countries bg-light">
            <h1 class="text-center">Справочник по странам мира</h1>
            <h2 class="text-center">Найти страну</h2>
    
            <form>
                <label for="search">Найти страну: </label>
                <input type="search" name="search" id="search">
            </form>
            <form class="d-flex">
                    <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
                    <button class="btn btn-outline-light" type="submit">Search</button>
            </form>
        </div>
    </div>
    
    <?php
        echo '<script src="JS\bootstrap.min.js"></script>'
    ?>
</body>

</html>