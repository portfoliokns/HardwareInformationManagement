@ModelType IEnumerable(Of HardwareInformationManagement.dt_hard)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.hard)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.comment)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.dt_position.position)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.dt_user.user)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.hard)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.comment)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.dt_position.position)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.dt_user.user)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
