<?php
    session_start();
    $messageLogin = "Login effettuato con successo";
    $messageError = "Credenziali sbagliate";
    $filename = "registra.csv";
    $handler = fopen($filename, "r");
    $mail = $_POST["mail"];
    $password = $_POST["password"];
    while($riga = fgetcsv($handler, $length = 0 , $delimiter = ";"))
    {
        if ($riga[2] == $mail and $riga[3] == md5($password))
        {
            if ($_POST["loggato"] == true)
            {
                setcookie("cookies",$mail,time() + 3600);
            }
        }
    }