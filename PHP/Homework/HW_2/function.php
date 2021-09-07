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

        echo 'успешно записали имя страны в БД';
    }
?>