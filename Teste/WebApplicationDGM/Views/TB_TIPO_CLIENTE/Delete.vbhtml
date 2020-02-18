@ModelType WebApplicationDGM.WebApplicationDGM.TB_TIPO_CLIENTE

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
