<?php 
    function connect(

        $host = "localhost",
        $user = "root",
        $pass = "123456",
        $dbname = "travels"
        )
        {
        
        global $link;
        $link = mysqli_connect($host, $user, $pass);

        // $db_selected = mysqli_select_db($link, $dbname);     // полная запись, если исп-ся несколько таблиц 
        mysqli_select_db($link, $dbname);

        mysqli_set_charset($link, "set names 'utf8'");

        return true;
    }
?>