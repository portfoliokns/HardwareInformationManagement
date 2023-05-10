@ModelType HardwareInformationManagement.dt_position
@Code
    ViewData("Title") = "Details"
End Code

<h2>@ViewBag.japanese.detail</h2>

<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @ViewBag.japanese.position_name
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.position)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink(ViewBag.japanese.edit, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(ViewBag.japanese.back, "Index")
</p>
