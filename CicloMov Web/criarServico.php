<?php

    include 'conexao.php';

    $id = $_POST['id'];
    $tempo=$_POST['time'].':00';

    if(isset($_SESSION["login"])) {
        $user = $_SESSION['login'];
    }

    // Check connection
    if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
    }
    
    $sql = "INSERT INTO servicos (id_cliente, id_ponto, tempo_permanencia)
    VALUES ($user, $id, $tempo)";

    if (mysqli_query($conn, $sql)) {
    echo "New record created successfully";
    } else {
    echo "Error: " . $sql . "<br>" . mysqli_error($conn);
    }

    mysqli_close($conn);
    // header('Location: pontos.php');



?>