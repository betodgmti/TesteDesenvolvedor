@ModelType WebApplicationDGM.WebApplicationDGM.TB_CLIENTE

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Delete</title>
</head>
<body>
    <h3>Are you sure you want to delete this?</h3>
    <div>
        <h4>TB_CLIENTE</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.NOM_USUAL)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.NOM_USUAL)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.NOM_COMPLETO)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.NOM_COMPLETO)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.NRO_CPF)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.NRO_CPF)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.DT_EXCLUIDO)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.DT_EXCLUIDO)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.TB_TIPO_CLIENTE.DSC_TIPO_CLIENTE)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.TB_TIPO_CLIENTE.DSC_TIPO_CLIENTE)
            </dd>
    
        </dl>
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()
    
            @<div class="form-actions no-color">
                <input type="submit" value="Delete" class="btn btn-default" /> |
                @Html.ActionLink("Back to List", "Index")
            </div>
        End Using
    </div>
</body>
</html>
