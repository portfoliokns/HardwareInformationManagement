@ModelType HardwareInformationManagement.dt_hard
@Code
    ViewData("Title") = "Details"
End Code

<h2>@ViewBag.japanese.detail</h2>

<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @ViewBag.japanese.hard_name
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.hard)
        </dd>

        <dt>
            @ViewBag.japanese.user_name
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.dt_user.user)
        </dd>

        <dt>
            @ViewBag.japanese.position_name
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.dt_position.position)
        </dd>

        <dt>
            @ViewBag.japanese.hard_comment
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.comment)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink(ViewBag.japanese.edit, "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink(ViewBag.japanese.back, "Index")
</p>
