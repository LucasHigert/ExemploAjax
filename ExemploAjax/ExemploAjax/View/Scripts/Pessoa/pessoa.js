$(function () {
    $("#pessoa-tabela").DataTable({
        ajax: "http://localhost:53862/Pessoa/obtertodos",
        serverSide: true,
        columns: [
            { "data": "Id" },
            { "data": "Nome" },
            { "data": "CPF" },
            {
                render: function (data, type, row) {
                    return "<button class='btn btn-primary botao-editar'>Editar</button>\
                    <button class='btn btn-danger botao-apagar'>Apagar\</button>";
                }
            }


        ]

    });
});