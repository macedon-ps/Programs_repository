<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Регистрация пользователей</title>
    <?php 
        echo "<link rel='stylesheet' href='style.css'>";   
    ?>
</head>
<body>
    <div class="container-page">
        <h1>Страница регистрации пользователей</h1>
        
        <?php 
            if(!isset($_POST["submit"])) {
        ?>
        <form action="addUser.php" method="POST">
            <label for="login" class="input-item">Введите свой логин: </label><br/>
            <input type="text" name="login" class="input-item"><br/>
            <label for="password" class="input-item">Введите свой пароль: </label><br/>
            <input type="password" name="password" class="input-item"><br/>
            <label for="email" class="input-item">Введите свой электронный адрес: </label><br/>
            <input type="email" name="email" class="input-item"><br/>
            <label for="submit"></label>
            <input type="submit" name="submit"">
            <label for="reset" class="input-item"></label>
            <input type="reset" name="reset">
        </form>
        <br/>
        <br/>
        <a href="index.php">На главную страницу</a>
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
    </div>
</body>
</html>