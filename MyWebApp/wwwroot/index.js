$(document).ready(function () {
    var $meuButton = $("#meu-button");
    var $itens = $(".itens li");

    $meuButton.on("click", ExibirMensagem);
    function ExibirMensagem() {
        alert("Teste Evento");
    }

    $itens.on("click", function () {
        alert($(this).text());
    });

    var $login = $("#login");
    var $popupForm = $(".popup-form");

    $login.on("click", function () {
        $popupForm.toggle();
    });


});


