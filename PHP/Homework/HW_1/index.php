<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Пользователи</title>
    <?php 
        echo "<link rel='stylesheet' href='style.css'>";   
    ?>
</head>
<body>
    <div class="container-page">
        
        <h1>Выберите действие, нажав на кнопку меню</h1>    
            <div class="info-users">
                <p>
                На сайте зарегистрировано: 
                <span>
                    <?php include_once("functions.php");
                            $count = countOfUsers();
                            echo($count);?>
                    </span> пользователей
                </p>
            </div>
            <div class="addUser">
                <button class="btn">
                    <?php 
                        echo'<a href="addUser.php">Add new user</a>';
                    ?>
                </button>
            </div>
            <div class="showUsers">
                <button class="btn">
                    <?php
                        echo'<a href="showUsers.php">Show all users</a>';
                    ?>
                </button>
            </div>
            
    </div>
</body>
</html>