<?php

function verification($log, $pass, $eml){
    // проверка (верификация) данных
    // убираем пробелы, защищаем от SQL уязвимостей
    
    global $login;
    global $password;
    global $email;

    $login = trim(htmlspecialchars($log));
    $password = trim(htmlspecialchars($pass));
    $email = trim(htmlspecialchars($eml));

    // проверям, что формы не пустые

    if($login == "" || $password == "" || $email == ""){
        echo "Вы ввели не все необходимые данные";
        echo("<br/>" . "<br/>" . '<a href="index.php">На главную страницу</a>');
        return false;
    }
    // проверяем, что формы длиной больше 3 символов, меньше 30 символов

    if(strlen($login) < 3 || strlen($login) > 30 || strlen($password) < 3 || strlen($password) > 30){
        echo "Вы ввели меньше 3 или больше 30 знаков в логине / или пароле";
        echo("<br/>" . "<br/>" . '<a href="index.php">На главную страницу</a>');
        return false;
    }

    // проверка, что пользователь с таким логином уже не зарегистрирован

    global $pathToFile;
    $pathToFile = "D:\OpenServer\domains\menuUsers\users.txt";
    
    if(file_exists($pathToFile)){
        
        $buffer = fopen($pathToFile, "r");
        while($str = fgets($buffer, 128)){
            $nameFromForm = substr($str, 0, strpos($str, ':'));
            if($nameFromForm == $login){
                echo "Пользователь с логином " . $login . " уже зарегистрирован" . "<br/>";
                echo "Попробуйте ввести другой логин";
                echo("<br/>" . "<br/>" . '<a href="index.php">На главную страницу</a>');
                return false;
            }
        }
        echo $login . " - это уникальное имя " . "<br/>";
        return true;
    }
    else{
        echo "Такой файл не существует\nСоздайте файл users.txt";
        echo("<br/>" . "<br/>" . '<a href="index.php">На главную страницу</a>');
        return false;
    }
}
?>

<!-- //////////////////////////////////////////////////////////////////////////////////////////////////// -->

<?php
function register($log, $pass, $eml){
    
    $file = "D:\OpenServer\domains\menuUsers\users.txt";
    
    global $login;
    global $password;
    global $email;
    
    $login = $log;
    $password = $pass;
    $email = $eml;

    // запись в файл

    $f = fopen($file, "a+");
    $str = $login . ": " . md5($password) . ": " . $email;
    fputs($f, $str . "\n");
    fclose($f);    
        
    // отрисовка сообщения об успешной регистрации
            
    echo("<br/>");
    echo("Пользователь с логином " . $login . " успешно зарегистрирован!");
    echo("<br/>" . "<br/>" . '<a href="index.php">На главную страницу</a>');
    return true;    
}
?>

<!-- //////////////////////////////////////////////////////////////////////////////////////////////////// -->

<?php
function showUsers(){
    global $pathToFile;
    $pathToFile = "D:\OpenServer\domains\menuUsers\users.txt";
    
    if(file_exists($pathToFile)){
        
        $buffer = fopen($pathToFile, "r");
        while($str = fgets($buffer, 4096)){
            $nameFromStr = substr($str, 0, strpos($str, ":"));
            $cursorPosition = strlen($nameFromStr)+2;
                        
            $passwordFromStr = substr($str, $cursorPosition, 32);
            $cursorPosition += (strlen($passwordFromStr)+2);

            $emailFromStr = substr($str, $cursorPosition);
                        
            echo"<tr><td>" . $nameFromStr . "</td><td>" . $passwordFromStr . "</td><td>" . $emailFromStr . "</td></tr>";    
        }    
        fclose($buffer);
    }    
    return true;
}
?>

<!-- //////////////////////////////////////////////////////////////////////////////////////////////////// -->

<?php
function countOfUsers(){
    global $pathToFile;
    $pathToFile = "D:\OpenServer\domains\menuUsers\users.txt";
    global $count;
    $count = 0;

    if(file_exists($pathToFile)){
        $buffer = fopen($pathToFile, "r");
        
        while($str = fgets($buffer, 4096)){
            $count += 1;
        }    
    }  
    return $count;  
}
?>
