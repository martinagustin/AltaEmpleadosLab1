Imports System.Diagnostics
Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Dim rowcount As Integer

    Public Sub CargarGrid()
        Dim da As New OleDb.OleDbDataAdapter("Select * from tabla1", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DtGrid.DataSource = ds.Tables(0)
        Else
            DtGrid.DataSource = Nothing
        End If
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtNleg.Text = "" Or TxtApellido.Text = "" Or TxtNombre.Text = "" Or TxtDni.Text = "" Or TxtDireccion.Text = "" Or TxtLocalidad.Text = "" Or TxtCelular.Text = "" Or CmbSexo.Text = "" Or TxtEdad.Text = "" Or CmbCategoria.Text = "" Or TxtUltSueldo.Text = "" Then
            MsgBox("No se pueden guardar registros con campos vacios")
        Else
            Dim sql As String = "Insert Into Tabla1 (Nleg,Apellido,Nombre,NDoc,Direccion,Localidad,NCelular,Sexo,Edad,Categoria,UltSueldo) VALUES  ('" & TxtNleg.Text & "','" & TxtApellido.Text & "','" & TxtNombre.Text & "','" & TxtDni.Text & "','" & TxtDireccion.Text & "','" & TxtLocalidad.Text & "','" & TxtCelular.Text & "','" & Me.CmbSexo.Text & "','" & TxtEdad.Text & "','" & Me.CmbCategoria.Text & "','" & TxtUltSueldo.Text & "')"
            operaciones(DtGrid, sql)
        End If



    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        CargarGrid()

    End Sub

    Private Sub BtnConexion_Click(sender As Object, e As EventArgs) Handles BtnConexion.Click
        AbrirConexion()
        Try
            Conexion.Open()
            MsgBox("Conexión realizada de manera exitosa", MsgBoxStyle.Information, "2021")
            Conexion.Close()
        Catch ex As Exception
            MsgBox("No se logro realizar la conexión debido: " & ex.Message, MsgBoxStyle.Critical, "2021")
        End Try
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub CmbSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbSexo.KeyPress
        e.Handled = True
    End Sub
    Private Sub CmbCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbCategoria.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDni.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub TxtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCelular.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub TxtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
End Class
