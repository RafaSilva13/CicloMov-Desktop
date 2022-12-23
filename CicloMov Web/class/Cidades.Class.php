<?php
    class Clientes{
        var $CodCidade;
        var $IdEstado;
        var $DecricaoCidade;

        function add($Estado, $Descricao){
            // Conexão com o banco de dados
            include 'connection.php';

            if (!$conn) {
                die("Connection failed: " . mysqli_connect_error());
            }
            
            $sql = "INSERT INTO cidades (id_estado, descricao_cidade)
            VALUES (null, $Estado, $Descricao)";
            
            if (mysqli_query($conn, $sql)) {
                echo "New record created successfully";
              } else {
                echo "Error: " . $sql . "<br>" . mysqli_error($conn);
              }
            
            mysqli_close($conn);
        }

    }
?>