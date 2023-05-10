@ModelType HardwareInformationManagement.dt_user
@Code
    ViewData("Title") = "Edit"
End Code

<h2>@ViewBag.japanese.edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        @Html.HiddenFor(Function(model) model.Id)

     <div class="form-group">
         @ViewBag.japanese.user_name
         <div class="col-md-10">
             @Html.EditorFor(Function(model) model.user, New With {.htmlAttributes = New With {.class = "form-control"}})
             @Html.ValidationMessageFor(Function(model) model.user, "", New With {.class = "text-danger"})
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
