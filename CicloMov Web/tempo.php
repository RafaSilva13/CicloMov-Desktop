<?php

include 'conexao.php';

session_start();

if (isset($_SESSION['login'])) {

    $usuario = $_SESSION['login'];


    if (!$conn) {
        die("Connection failed: " . mysqli_connect_error());
    }

    $sql = "SELECT tempo_permanencia FROM servicos WHERE id_clientes = '$usuario' ";
    $result = mysqli_query($conn, $sql);


    if (mysqli_num_rows($result) > 0) {
        while ($row = mysqli_fetch_assoc($result)) {
            if ($row['tempo_permanencia'] != "") {

                $_SESSION["tempo"] = $row['tempo_permanencia'];
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
}
