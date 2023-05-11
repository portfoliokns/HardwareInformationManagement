Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports HardwareInformationManagement

Namespace Controllers
    Public Class userController
        Inherits System.Web.Mvc.Controller

        Private db As New db_SystemEntities
        Private japanese As New My.Resources.Japanese

        ' GET: user
        Function Index() As ActionResult
            ViewBag.japanese = japanese
            Return View(db.dt_user.ToList())
        End Function

        ' GET: user/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dt_user As dt_user = db.dt_user.Find(id)
            If IsNothing(dt_user) Then
                Return HttpNotFound()
            End If
            ViewBag.japanese = japanese
            Return View(dt_user)
        End Function

        ' GET: user/Create
        Function Create() As ActionResult
            ViewBag.japanese = japanese
            Return View()
        End Function

        ' POST: user/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,user")> ByVal dt_user As dt_user) As ActionResult
            If ModelState.IsValid Then
                Dim maxId = If(db.dt_user.Any(), db.dt_user.Max(Function(d) d.Id), 0)
                dt_user.Id = maxId + 1
                db.dt_user.Add(dt_user)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(dt_user)
        End Function

        ' GET: user/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dt_user As dt_user = db.dt_user.Find(id)
            If IsNothing(dt_user) Then
                Return HttpNotFound()
            End If
            ViewBag.japanese = japanese
            Return View(dt_user)
        End Function

        ' POST: user/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,user")> ByVal dt_user As dt_user) As ActionResult
            If ModelState.IsValid Then
                db.Entry(dt_user).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(dt_user)
        End Function

        ' GET: user/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dt_user As dt_user = db.dt_user.Find(id)
            If IsNothing(dt_user) Then
                Return HttpNotFound()
            End If
            ViewBag.japanese = japanese
            Return View(dt_user)
        End Function

        ' POST: user/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim dt_user As dt_user = db.dt_user.Find(id)
            db.dt_user.Remove(dt_user)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
