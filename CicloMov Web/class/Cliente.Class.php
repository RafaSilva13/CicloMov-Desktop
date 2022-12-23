<?php
class Clientes
{
    var $CodClientes;
    var $EmailClientes;
    var $CPFClientes;
    var $TempoGeralClientes;
    var $Username;
    var $Senha;

    function add($Email, $CPF, $User, $Senha, $Nome, $Tell)
    {
        // Conexão com o banco de dados
        include 'conexao.php';

        if (!$conn) {
            die("Connection failed: " . mysqli_connect_error());
        }

        $sql = "INSERT INTO clientes (email_clientes, cpf_clientes, usuario_clientes, senha_clientes, nome_clientes, telefone_clientes)
            VALUES ('$Email', '$CPF', '$User', '$Senha', '$Nome', '$Tell')";

        if (mysqli_query($conn, $sql)) {
            echo "New record created successfully";
        } else {
            echo "Error: " . $sql . "<br>" . mysqli_error($conn);
        }

        mysqli_close($conn);
    }

}
