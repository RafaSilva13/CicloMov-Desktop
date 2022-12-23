<?php 

    include 'class/Cliente.class.php';

    $Cliente = new Clientes;

    $Cliente->add($_POST['emailCad'], $_POST['cpfCad'], $_POST['usuarioCad'], $_POST['senhaCad'],$_POST['nomeCad'], $_POST['telefoneCad']);

    header('location: index.php?cad');
    
?>