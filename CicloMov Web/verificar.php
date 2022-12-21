<?php

    include 'conexao.php';

    session_start();
    
    $usuario = $_POST['usuario'];
    $senha = $_POST['senha'];
    

    if (!$conn) {
        die("Connection failed: " . mysqli_connect_error());
    }
    
    $sql = "SELECT cod_clientes, usuario_clientes, senha_clientes FROM clientes WHERE usuario_clientes = '$usuario' and senha_clientes = '$senha'";
    $result = mysqli_query($conn, $sql);
    
    
    if (mysqli_num_rows($result) > 0) {
        while($row = mysqli_fetch_assoc($result)) {
            echo $row['cod_clientes'];;
            $_SESSION["login"] = $row['cod_clientes'];
        }
        header('location: pontos.php');
    } 
    else {
        $_SESSION["erro"] = 1;
        header('location: login.php');
    }
    
    mysqli_close($conn);

?>