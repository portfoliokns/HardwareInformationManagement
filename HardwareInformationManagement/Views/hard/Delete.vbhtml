@ModelType HardwareInformationManagement.dt_hard
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
