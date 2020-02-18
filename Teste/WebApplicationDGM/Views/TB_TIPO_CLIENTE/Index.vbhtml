@ModelType IEnumerable(Of WebApplicationDGM.WebApplicationDGM.TB_TIPO_CLIENTE)

@Code
	Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.DSC_TIPO_CLIENTE)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.DT_EXCLUIDO)
            </th>
            <th></th>
        </tr>
    
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.DSC_TIPO_CLIENTE)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.DT_EXCLUIDO)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.COD_TIPO_CLIENTE }) |
                @Html.ActionLink("Details", "Details", New With {.id = item.COD_TIPO_CLIENTE }) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.COD_TIPO_CLIENTE })
            </td>
        </tr>
    Next
    
    </table>
</body>
</html>
