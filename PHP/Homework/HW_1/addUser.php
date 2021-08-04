<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Регистрация пользователей</title>
</head>
<body>
    <h1>Страница регистрации пользователей</h1>
    
    <?php 
        if(!isset($_POST["submit"])) {
    ?>
    <form action="addUser.php" method="POST">
        <label for="login">Введите свой логин: </label><br/>
        <input type="text" name="login"><br/>
        <label for="password">Введите свой пароль: </label><br/>
        <input type="password" name="password"><br/>
        <label for="email">Введите свой электронный адрес: </label><br/>
        <input type="email" name="email"><br/>
        <label for="submit"></label>
        <input type="submit" name="submit">
        <label for="reset"></label>
        <input type="reset" name="reset">
    </form>
    <?php
        }
        elseif(isset($_POST["submit"])) 
        {
        
            // проверка (верификация) данных
            /////////////////////////////////////////////////////////////////////////////////////////////
            
            // убираем пробелы, защищаем от SQL уязвимостей
            
            $login = trim(htmlspecialchars($_POST["login"]));
            $password = trim(htmlspecialchars($_POST["password"]));
            $email = trim(htmlspecialchars($_POST["email"]));

            // проверям, что формы не пустые
            if($_POST["login"] == "" || $_POST["password"] == "" || $_POST["email"] == ""){
                echo "Вы ввели не все необходимые данные";
                return false;
            }
                
            // проверяем, что формы длиной больше 3 символов, меньше 30 символов
            if(strlen($_POST["login"]) < 3 || strlen($_POST["login"]) > 30 || strlen($_POST["password"]) < 3 || strlen($_POST["login"]) > 30){
                echo "Вы ввели меньше 8 или больше 30 знаков в логине / или пароле";
                return false;
            }

            // запись в файл
            /////////////////////////////////////////////////////////////////////////////////////////////
            $file = "D:\OpenServer\domains\menuUsers\users.txt";
            // global $file;
            
            if(!file_exists($file)){
                echo "Такого файла не существует\n";
                return false;
            }

            $f = fopen($file, "a+");
            $str = $_POST["login"] . ": " . md5($_POST["passwors"]) . ": " . $_POST["email"];
            echo $str;
            
            fputs($f, $str . "\n");
            fclose($f);
            
            // отрисовка сообщения об успешной регистрации
            ///////////////////////////////////////////////////////////////////////////////////////////// 
            // echo("<br/>");
            // echo("Вы  " . $_POST["login"] . "  успешно зарегистрированы!");
    ?>
            <br/>
            <br/>
            <a href="index.php">На главную страницу</a>    
    <?php   
            $_POST[] = NULL;
            return true;
            
            ////////////////////////////////////////////////////////////////////////////////////////////
        }
        else
        {
    ?>        
        <br/>
        <p>Вы не зарегистрированы!</p>
        <br/>
        <br/>
        <a href="index.php">На главную страницу</a>
    <?php
        }
    ?>
</body>
</html>