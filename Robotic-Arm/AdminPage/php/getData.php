<?php

    $host = "localhost";
    $userName = "root";
    $pass = "";
    $dbName = "RobotTesting";

    $con = mysqli_connect($host, $userName, $pass, $dbName);

    if(!$con)
    {
        die('Could not connect: '. mysqli_error($con));
    }
    else
        echo "Connected!";



?>