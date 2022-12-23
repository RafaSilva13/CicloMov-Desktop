<?php 
    session_start();
    unset($_SESSION['login']);
    unset($_SESSION['tempo']);
    unset($_SESSION['tempo_restante']);
    unset($_SESSION['logado']);
    session_destroy();
    header('Location: login.php');
?>