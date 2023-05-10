@ModelType IEnumerable(Of HardwareInformationManagement.dt_user)
@Code
ViewData("Title") = "Index"
End Code

<h2>@ViewBag.japanese.user_index</h2>

<p>
    @Html.ActionLink(ViewBag.japanese.new_create, "Create")
</p>
<table class="table">
    <tr>
        <th>
            @ViewBag.japanese.user_name
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user)
        </td>
        <td>
            @Html.ActionLink(ViewBag.japanese.edit, "Edit", New With {.id = item.Id}) |
            @Html.ActionLink(ViewBag.japanese.detail, "Details", New With {.id = item.Id}) |
            @Html.ActionLink(ViewBag.japanese.delete, "Delete", New With {.id = item.Id})
        </td>
    </tr>
Next

</table>
