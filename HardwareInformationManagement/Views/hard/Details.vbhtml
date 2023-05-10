@ModelType HardwareInformationManagement.dt_hard
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>dt_hard</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.hard)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.hard)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.comment)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.comment)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.dt_position.position)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.dt_position.position)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.dt_user.user)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.dt_user.user)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
