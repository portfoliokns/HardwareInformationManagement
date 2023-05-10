@ModelType IEnumerable(Of HardwareInformationManagement.dt_position)
@Code
ViewData("Title") = "Index"
End Code

<h2>@ViewBag.japanese.position_index</h2>

<p>
    @Html.ActionLink(ViewBag.japanese.new_create, "Create")
</p>
<table class="table">
    <tr>
        <th>
            @ViewBag.japanese.hard_name
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.position)
        </td>
        <td>
            @Html.ActionLink(ViewBag.japanese.edit, "Edit", New With {.id = item.Id}) |
            @Html.ActionLink(ViewBag.japanese.detail, "Details", New With {.id = item.Id}) |
            @Html.ActionLink(ViewBag.japanese.delete, "Delete", New With {.id = item.Id})
        </td>
    </tr>
Next

</table>
