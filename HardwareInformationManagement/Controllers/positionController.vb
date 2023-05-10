﻿Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports HardwareInformationManagement

Namespace Controllers
    Public Class positionController
        Inherits System.Web.Mvc.Controller

        Private db As New db_SystemEntities

        ' GET: position
        Function Index() As ActionResult
            Return View(db.dt_position.ToList())
        End Function

        ' GET: position/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dt_position As dt_position = db.dt_position.Find(id)
            If IsNothing(dt_position) Then
                Return HttpNotFound()
            End If
            Return View(dt_position)
        End Function

        ' GET: position/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: position/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,position")> ByVal dt_position As dt_position) As ActionResult
            If ModelState.IsValid Then
                db.dt_position.Add(dt_position)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(dt_position)
        End Function

        ' GET: position/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dt_position As dt_position = db.dt_position.Find(id)
            If IsNothing(dt_position) Then
                Return HttpNotFound()
            End If
            Return View(dt_position)
        End Function

        ' POST: position/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,position")> ByVal dt_position As dt_position) As ActionResult
            If ModelState.IsValid Then
                db.Entry(dt_position).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(dt_position)
        End Function

        ' GET: position/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim dt_position As dt_position = db.dt_position.Find(id)
            If IsNothing(dt_position) Then
                Return HttpNotFound()
            End If
            Return View(dt_position)
        End Function

        ' POST: position/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim dt_position As dt_position = db.dt_position.Find(id)
            db.dt_position.Remove(dt_position)
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
