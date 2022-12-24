

function GetId(id) {
    console.log(id);
}

function AbrirModal(numero) {
    $("#confirmacao").modal('show');
    
    $("#btnConfirmar").click(function () {
        $.post("criarServico.php", { idPonto: numero, time: $('#time').val() }, function () {
            $("#confirmacao").modal('hide');
            
        });
    });

}




