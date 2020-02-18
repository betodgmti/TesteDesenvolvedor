@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>DGM Test Web</h1>
    <p class="lead">DGM Teste para Desenvolvedor .NET</p>
    <p><a href="https://github.com/Absollute/TesteDesenvolvedor" class="btn btn-primary btn-lg">Leia mais... &raquo;</a></p>
</div>

<div class="row">
    <div class="col-md-4">
        <h2>Welcome to DGM Test Web!</h2>
        <p>
            Esta é uma avaliação básica de código.
        </p>
        <h2>Objetivo</h2>
        <p>
            O objetivo é conhecer um pouco do seu conhecimento/prática C#.
        </p>
    </div>  
    <div class="col-md-4">
        <h2>Requisitos</h2>
        <p>Os clientes podem ser do tipo Interno e Externo.</p>
        <p>Uma lista com todos os clientes cadastrados, deverá ser exibida e quando selecionado o item da lista, deverá abrir a tela de edição.</p>

    </div>
    <div class="col-md-4">
        <h2>Clientes</h2>
        <p>
            @Html.ActionLink("Lista de Clientes", "Index", "TB_CLIENTE")
            </p>
        <p>
            @Html.ActionLink("Lista do Tipo de Clientes", "Index", "TB_TIPO_CLIENTE")
        </p>
    </div>
</div>
