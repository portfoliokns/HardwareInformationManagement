@ModelType HardwareInformationManagement.dt_hard
@Code
    ViewData("Title") = "Delete"
End Code

<h2>@ViewBag.japanese.delete</h2>

<div>
    <h4>@ViewBag.japanese.delete_message</h4>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value=@ViewBag.japanese.delete_complete class="btn btn-default" /> |
            @Html.ActionLink(ViewBag.japanese.back, "Index")
        </div>
    End Using
</div>
