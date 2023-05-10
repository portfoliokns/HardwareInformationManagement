@ModelType HardwareInformationManagement.dt_position
@Code
    ViewData("Title") = "Create"
End Code

<h2>@ViewBag.japanese.new_create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>新しい設置場所を登録してください</h4>
        <hr />
        <div class="form-group">
            @Html.LabelFor(Function(model) model.Id, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Id, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Id, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @ViewBag.japanese.position_name
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.position, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.position, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value=@ViewBag.japanese.save class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink(ViewBag.japanese.back, "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
