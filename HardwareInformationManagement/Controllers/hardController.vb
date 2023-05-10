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
    Public Class hardController
        Inherits System.Web.Mvc.Controller

        Private db As New db_SystemEntities

        ' GET: hard
        Function Index() As ActionResult
            Dim dt_hard = db.dt_hard.Include(Function(d) d.dt_position).Include(Function(d) d.dt_user)
            Return View(dt_hard.ToList())
        End Function

        ' GET: hard/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dt_hard As dt_hard = db.dt_hard.Find(id)
            If IsNothing(dt_hard) Then
                Return HttpNotFound()
            End If
            Return View(dt_hard)
        End Function

        ' GET: hard/Create
        Function Create() As ActionResult
            ViewBag.position_id = New SelectList(db.dt_position, "Id", "position")
            ViewBag.user_id = New SelectList(db.dt_user, "Id", "user")
            Return View()
        End Function

        ' POST: hard/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,hard,user_id,position_id,comment")> ByVal dt_hard As dt_hard) As ActionResult
            If ModelState.IsValid Then
                db.dt_hard.Add(dt_hard)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.position_id = New SelectList(db.dt_position, "Id", "position", dt_hard.position_id)
            ViewBag.user_id = New SelectList(db.dt_user, "Id", "user", dt_hard.user_id)
            Return View(dt_hard)
        End Function

        ' GET: hard/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dt_hard As dt_hard = db.dt_hard.Find(id)
            If IsNothing(dt_hard) Then
                Return HttpNotFound()
            End If
            ViewBag.position_id = New SelectList(db.dt_position, "Id", "position", dt_hard.position_id)
            ViewBag.user_id = New SelectList(db.dt_user, "Id", "user", dt_hard.user_id)
            Return View(dt_hard)
        End Function

        ' POST: hard/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,hard,user_id,position_id,comment")> ByVal dt_hard As dt_hard) As ActionResult
            If ModelState.IsValid Then
                db.Entry(dt_hard).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.position_id = New SelectList(db.dt_position, "Id", "position", dt_hard.position_id)
            ViewBag.user_id = New SelectList(db.dt_user, "Id", "user", dt_hard.user_id)
            Return View(dt_hard)
        End Function

        ' GET: hard/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dt_hard As dt_hard = db.dt_hard.Find(id)
            If IsNothing(dt_hard) Then
                Return HttpNotFound()
            End If
            Return View(dt_hard)
        End Function

        ' POST: hard/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim dt_hard As dt_hard = db.dt_hard.Find(id)
            db.dt_hard.Remove(dt_hard)
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
