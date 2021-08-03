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
        elseif(isset($_POST["submit"]) and $_POST["login"] != "" and $_POST["password"] != "" and $_POST["email"] != ""){
            echo("<br/>");
            echo("Вы  " . $_POST["login"] . "  успешно зарегистрированы!");
    ?>
        <br/>
        <br/>
        <a href="index.php">На главную страницу</a>    
    <?php    
        $_POST[] = NULL;
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