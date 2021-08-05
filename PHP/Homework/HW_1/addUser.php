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
            include_once("functions.php");
            if(verification(($_POST["login"]), ($_POST["password"]), ($_POST["email"]))){
                register(($login), ($password), ($email));
            }
            
        }
        else
        {
            echo("<br/>" . "<p>Вы не зарегистрированы!</p>");
            echo("<br/>" . "<br/>" . '<a href="index.php">На главную страницу</a>');
        }
    ?>
</body>
</html>