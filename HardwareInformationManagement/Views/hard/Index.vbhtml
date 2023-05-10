@ModelType IEnumerable(Of HardwareInformationManagement.dt_hard)
@Code
    ViewData("Title") = "Index"
End Code

<h2>@ViewBag.japanese.hard_index</h2>

<p>
    @Html.ActionLink(ViewBag.japanese.new_create, "Create")
</p>
<table class="table">
    <tr>
        <th>
            @ViewBag.japanese.hard_name
        </th>
        <th>
            @ViewBag.japanese.position_name
        </th>
        <th>
            @ViewBag.japanese.user_name
        </th>
        <th>
            @ViewBag.japanese.hard_comment
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.hard)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.dt_position.position)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.dt_user.user)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.comment)
            </td>
            <td>
                @Html.ActionLink(ViewBag.japanese.edit, "Edit", New With {.id = item.Id}) |
                @Html.ActionLink(ViewBag.japanese.detail, "Details", New With {.id = item.Id}) |
                @Html.ActionLink(ViewBag.japanese.delete, "Delete", New With {.id = item.Id})
            </td>
        </tr>
    Next

</table>
