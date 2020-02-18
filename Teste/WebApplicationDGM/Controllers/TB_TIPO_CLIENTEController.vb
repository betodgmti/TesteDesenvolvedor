Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebApplicationDGM.WebApplicationDGM

Namespace Controllers
    Public Class TB_TIPO_CLIENTEController
        Inherits System.Web.Mvc.Controller

        Private db As New Database1Entities

        ' GET: TB_TIPO_CLIENTE
        Function Index() As ActionResult
            Return View(db.TB_TIPO_CLIENTE.ToList())
        End Function

        ' GET: TB_TIPO_CLIENTE/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tB_TIPO_CLIENTE As TB_TIPO_CLIENTE = db.TB_TIPO_CLIENTE.Find(id)
            If IsNothing(tB_TIPO_CLIENTE) Then
                Return HttpNotFound()
            End If
            Return View(tB_TIPO_CLIENTE)
        End Function

        ' GET: TB_TIPO_CLIENTE/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: TB_TIPO_CLIENTE/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="COD_TIPO_CLIENTE,DSC_TIPO_CLIENTE,DT_EXCLUIDO")> ByVal tB_TIPO_CLIENTE As TB_TIPO_CLIENTE) As ActionResult
            If ModelState.IsValid Then
                db.TB_TIPO_CLIENTE.Add(tB_TIPO_CLIENTE)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tB_TIPO_CLIENTE)
        End Function

        ' GET: TB_TIPO_CLIENTE/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tB_TIPO_CLIENTE As TB_TIPO_CLIENTE = db.TB_TIPO_CLIENTE.Find(id)
            If IsNothing(tB_TIPO_CLIENTE) Then
                Return HttpNotFound()
            End If
            Return View(tB_TIPO_CLIENTE)
        End Function

        ' POST: TB_TIPO_CLIENTE/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="COD_TIPO_CLIENTE,DSC_TIPO_CLIENTE,DT_EXCLUIDO")> ByVal tB_TIPO_CLIENTE As TB_TIPO_CLIENTE) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tB_TIPO_CLIENTE).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tB_TIPO_CLIENTE)
        End Function

        ' GET: TB_TIPO_CLIENTE/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tB_TIPO_CLIENTE As TB_TIPO_CLIENTE = db.TB_TIPO_CLIENTE.Find(id)
            If IsNothing(tB_TIPO_CLIENTE) Then
                Return HttpNotFound()
            End If
            Return View(tB_TIPO_CLIENTE)
        End Function

        ' POST: TB_TIPO_CLIENTE/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tB_TIPO_CLIENTE As TB_TIPO_CLIENTE = db.TB_TIPO_CLIENTE.Find(id)
            db.TB_TIPO_CLIENTE.Remove(tB_TIPO_CLIENTE)
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
