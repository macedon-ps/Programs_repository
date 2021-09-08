<?php 
    function connect(
        
        $host = 'localhost', 
        $user = 'root', 
        $pass = '123456', 
        $dbname = 'travels'
        )
        {
        global $link;
        $link = mysqli_connect($host, $user, $pass) or die ('connection error');
        
        mysqli_select_db($link, $dbname) or die ('DB open error');
        
        mysqli_set_charset($link, "set names 'utf8'");
        return true;     
        
    }
?>
<?php 
    function writeNewCountry($nameCountry){

        // подключение к базе данных
        connect();
        // проверка подключения к БД
        $err = mysqli_connect_error();
        if ($err) {
            echo 'Ошибка подключения к базе данных. Код ошибки:' . $err . '<br>';
            exit();
        }
        
        // проверка на пробелы и спецсимволы
        $addCountry = trim(htmlspecialchars($nameCountry)); 
        // запрос на поиск стран с заданным названием
        $selectThisCountry = 'select * from countries where country = "' . $addCountry . '"';
        
        global $link;
        $result = mysqli_query($link, $selectThisCountry);
        
        // проверка на ошибки выполнения запроса
        $err = mysqli_connect_error();
        if ($err) {
            echo 'Ошибка SQL запроса. Код ошибки:' . $err . '<br>';
            exit();
        }
        
        // проверка на то, существует ли такое название страны в БД
        $row = mysqli_fetch_array($result, MYSQLI_NUM);
        if($row != null){
            echo'Страна с таким названием уже создана в базе данных. Попробуйте еще!';
            exit();
        }
        else echo'Это уникальное название страны!';
       
        $insertThisCountry = 'insert into countries (country) values ("' . $addCountry . '")';
        $result = mysqli_query($link, $insertThisCountry);
        
        // проверка на ошибки выполнения запроса
        $err = mysqli_connect_error($result);
        if ($err) {
            echo 'Ошибка SQL запроса. Код ошибки:' . $err . '<br>';
            exit();
        }
        
        echo ' Успешно записали имя страны в БД';
        return true;
    }
?>
<?php
function searchCountries($nameCountry){
    
    
    // проверка на пробелы и спецсимволы
    $searchCountry = trim(htmlspecialchars($nameCountry)); 
    // echo '$searchCountry = ' . $searchCountry;

    global $pathToFile;
    $pathToFile = "D:\OpenServer\domains\countriesList\countries.txt";        
    
    if(file_exists($pathToFile)){
        
        $buffer = fopen($pathToFile, "r");
        $i = 1; 

        while($str = fgets($buffer, 100)){
            $nameFromStr = trim(substr($str, 0));
            
            if($nameFromStr == $searchCountry){

                echo 'Такая страна существует в Энциклопедии стран мира';
                echo '<br/>';

                echo '<div class="country-name"';
                echo '<form class="col-12 col-sm-12 col-md-6 col-lg-6 d-flex">';
                echo '<table class="table table-striped">';
                echo '<tr>';
                echo '<td class="col-2 col-sm-2 col-md-2 col-lg-2">№ п/п</td>';
                echo '<td class="col-10 col-sm-10 col-md-10 col-lg-10">Название страны:</td>';
                echo '</tr>';
                echo '<tr>';
                echo '<td class="col-2 col-sm-2 col-md-2 col-lg-2">' . $i . '  ' . '</td><td class="col-10 col-sm-10 col-md-10 col-lg-10">' . $nameFromStr . '</td>';
                echo '</tr>';
                echo '<br/>';  
                echo '</table>';
                echo '</form>';
                echo '</div>';
            }
            $i++;  
        }    
        fclose($buffer);
    }  
    
    return true;
}
?>