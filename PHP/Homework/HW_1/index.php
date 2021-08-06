<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Пользователи</title>
</head>
<body>
    <nav>
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
            <button>
                <?php 
                    echo'<a href="addUser.php">Add new user</a>';
                ?>
            </button>
        </div>
        <div class="showUsers">
        <button>
                <?php
                    echo'<a href="showUsers.php">Show all users</a>';
                ?>
            </button>
        </div>
    </nav>
</body>
</html>