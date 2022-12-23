<?php

include 'conexao.php';

session_start();

$usuario = $_POST['usuario'];
$senha = $_POST['senha'];


if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

$sql = "SELECT cod_clientes, tempo_geral_clientes, usuario_clientes, senha_clientes FROM clientes WHERE usuario_clientes = '$usuario' and senha_clientes = '$senha'";
$result = mysqli_query($conn, $sql);


if (mysqli_num_rows($result) > 0) {
    while ($row = mysqli_fetch_assoc($result)) {
        $_SESSION["login"] = $row['cod_clientes'];
        $_SESSION["logado"]="sim";
        if($row['tempo_geral_clientes']!=""){

            $_SESSION["tempo"] = $row['tempo_geral_clientes'];
            date_default_timezone_set('America/Sao_Paulo');
            $hora = date('H:i:s');
            $v = explode(':', $_SESSION['tempo']);
            $_SESSION['tempo_restante'] = date('H:i:s', strtotime("{$hora} + {$v[0]} hours {$v[1]} minutes {$v[2]} seconds"));
        }
    }
    header('location: pontos.php');
} else {
    $_SESSION["erro"] = 1;
    header('location: login.php');
}

mysqli_close($conn);
