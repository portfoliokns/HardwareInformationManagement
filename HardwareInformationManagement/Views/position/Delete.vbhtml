@ModelType HardwareInformationManagement.dt_position
@Code
    ViewData("Title") = "Delete"
End Code

<h2>@ViewBag.japanese.delete</h2>

<h3>@ViewBag.japanese.delete_message</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value=@ViewBag.japanese.delete_complete class="btn btn-default" /> |
             @Html.ActionLink(ViewBag.japanese.back, "Index")
        </div>
    End Using
</div>
