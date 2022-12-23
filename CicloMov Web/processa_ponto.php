<?php

    session_start();
    include('class/Cliente.Class.php');
    include 'conexao.php';

    $cod = $_SESSION['login'];
    $tempo=$_POST['time'].':00';
    $sql = "UPDATE clientes SET tempo_geral_clientes='$tempo' WHERE cod_clientes = '$cod'";

    if (mysqli_query($conn, $sql)) {
        echo "Record updated successfully";
    } else {
        echo "Error updating record: " . mysqli_error($conn);
    }

    mysqli_close($conn);
    header('Location: pontos.php');
    


?>