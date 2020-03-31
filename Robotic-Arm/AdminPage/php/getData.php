<?php
    require 'path/'
    $host = "localhost";
    $userName = "root";
    $pass = "";
    $dbName = "robottesting";

    $con = mysqli_connect($host, $userName, $pass, $dbName);

    if(!$con)
        die('Could not connect: '. mysqli_error($con));
    else
        echo("<script> console.log('Conected'); </script>");

    mysqli_select_db($con, "endurancetesting");

    mysqli_close($con);

?>