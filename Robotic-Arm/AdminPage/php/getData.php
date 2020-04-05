<?php
    
    $host = "localhost";
    $userName = "root";
    $pass = "";
    $dbName = "robottesting";
    $a = intval($_GET['a']);
    $array = array();
    $testNoArr = array();
    $cycleNoArr = array();
    $timeArr = array();


    $con = new mysqli($host, $userName, $pass, $dbName);

    if(!$con)
    {
        die("Failier to connect to database: " . $con->connect_error);
    }  

    //send sql select command to extract data from coloumn

    if($result = $con->query("SELECT * FROM endurancetesting"))
    {
        while($row = $result->fetch_array())
        {
            if($a == 0)
            {
                $testNoArr[] =  $row['testNo'];
                $cycleNoArr[] = $row['cycleNo'];
                $timeArr[] =  $row['time'];
            }
            if($a == 1)
            {
                $testNoArr[] =  $row['testNo'];
            }
                
            if($a == 2)
            {
                $cycleNoArr[] = $row['cycleNo'];
            }
                
            
            if($a == 3)
            {
                $timeArr[] =  $row['time'];
            }
                
        }
        
        $array['TestNo'] = $testNoArr;
        $array['CycleNo'] = $cycleNoArr;
        $array['Time'] = $timeArr;

        $result->free_result();
    }

    echo json_encode($array);

    $con->close();

?>