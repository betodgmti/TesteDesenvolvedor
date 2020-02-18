@ModelType WebApplicationDGM.WebApplicationDGM.TB_TIPO_CLIENTE

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>
    <div>
        <h4>TB_TIPO_CLIENTE</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.DSC_TIPO_CLIENTE)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.DSC_TIPO_CLIENTE)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.DT_EXCLUIDO)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.DT_EXCLUIDO)
            </dd>
    
        </dl>
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With { .id = Model.COD_TIPO_CLIENTE }) |
        @Html.ActionLink("Back to List", "Index")
    </p>
</body>
</html>
