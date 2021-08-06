<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Все пользователи сервиса</title>
</head>
<body>
    <h1>Страница всех пользователей</h1>
    <table border="1">
        <caption>Зарегистрированные пользователи: </caption>
        <tr><td>Логины пользователей</td><td>Хешированные пароли пользователей</td><td>Электронные адреса пользователей</td></tr>

    <?php
        include_once("functions.php");
        showUsers();
    ?>

    </table>
    <br/>
    <br/>
    <a href="index.php">На главную страницу</a>

</body>
</html>