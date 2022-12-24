<?php

include 'conexao.php';
session_start();

$id = $_POST['idPonto'];
$tempo = $_POST['time'] . ':00';


$user = $_SESSION['login'];

// Check connection
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

$sql = "INSERT INTO servicos (id_clientes, id_ponto, tempo_permanencia) VALUES ('$user', '$id', '$tempo')";


if (mysqli_query($conn, $sql)) {
    echo "New record created successfully";
} else {
    echo "Error: " . $sql . "<br>" . mysqli_error($conn);
}

$sql = "UPDATE clientes SET tempo_geral_clientes='$tempo' WHERE cod_clientes = '$cod'";
if (mysqli_query($conn, $sql)) {
    echo "New record created successfully";
} else {
    echo "Error: " . $sql . "<br>" . mysqli_error($conn);
}

mysqli_close($conn);
