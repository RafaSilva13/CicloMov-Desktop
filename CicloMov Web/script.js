function GetId(id) {
    console.log(id);
}

function AbrirModal(numero) {
    $("#confirmacao").modal('show');

    $("#btnConfirmar").click(function() {
        $.post("criarServico.php", { id: numero }, function() {
            $("#confirmacao").modal('hide');
            setInterval($_SESSION["tempo"]++, 1000);
        });
    });

}