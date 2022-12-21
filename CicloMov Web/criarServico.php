<?php

    include 'conexao.php';

    $id = $_POST['id'];

    if(isset($_SESSION["login"])) {
        $user = $_SESSION['login'];
    }

    // Check connection
    if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
    }
    
    $sql = "INSERT INTO servicos (id_cliente, id_ponto, tempo_permanencia)
    VALUES ($user, $id, 0)";

    if (mysqli_query($conn, $sql)) {
    echo "New record created successfully";
    } else {
    echo "Error: " . $sql . "<br>" . mysqli_error($conn);
    }

    mysqli_close($conn);


?>