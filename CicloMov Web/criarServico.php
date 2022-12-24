<?php

include 'conexao.php';
session_start();

$id = $_POST['idPonto'];
$tempo = $_POST['time'] . ':00';

// $_SESSION["tempo"] = $tempo;
// date_default_timezone_set('America/Sao_Paulo');
// $hora = date('H:i:s');
// $v = explode(':', $_SESSION['tempo']);
// $_SESSION['tempo_restante'] = date('H:i:s', strtotime("{$hora} + {$v[0]} hours {$v[1]} minutes {$v[2]} seconds"));

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

mysqli_close($conn);
