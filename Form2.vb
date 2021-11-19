Imports System.Diagnostics
Imports System.Data
Imports System.Data.OleDb

Public Class Form2
    Dim contar As Integer
    Dim sexo As String
    Dim ContadorFem As Integer
    Dim ContadorMasc As Integer
    Dim edad As Integer
    Dim UltS As Integer
    Dim TSueldo As Integer
    Dim categoria As String
    Dim Administrativo As Integer
    Dim Ayudante As Integer
    Dim Cadete As Integer


    Private Sub BtnConexionf2_Click(sender As Object, e As EventArgs) Handles BtnConexionf2.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=C:\Users\Martin\source\repos\visual\datos.mdb;")
        con.Open()

        Try
            MsgBox("conexion correcta")
        Catch ex As Exception
            MsgBox("conexion incorrecta")
        End Try

        Dim leo = "select * FROM Tabla1 where Nleg > 0"
        Dim adaptador = New OleDb.OleDbDataAdapter(leo, con)
        Dim registro = New DataSet
        adaptador.Fill(registro, "Tabla1")
        Dim lista = registro.Tables("Tabla1").Rows.Count

        contar = 0





        Do While contar < lista
            sexo = registro.Tables("Tabla1").Rows(contar).Item("Sexo")
            UltS = registro.Tables("Tabla1").Rows(contar).Item("UltSueldo")
            categoria = registro.Tables("Tabla1").Rows(contar).Item("Categoria")
            edad = registro.Tables("Tabla1").Rows(contar).Item("Edad")


            If sexo = "Femenino" Then
                ContadorFem = ContadorFem + 1
            Else
                ContadorMasc = ContadorMasc + 1
            End If

            If categoria = "Cadete" And edad > 23 Then
                cadete = cadete + 1
            End If

            If categoria = "Ayudante" And edad > 40 Then
                Ayudante = Ayudante + 1
            End If
            If categoria = "Administrativo" Then
                Administrativo = Administrativo + 1

            End If
            TSueldo = UltS + TSueldo
            contar = contar + 1
        Loop
        LblTotalEmpleados.Text = contar
        LblTotalFem.Text = ContadorFem
        LblTotalMasc.Text = ContadorMasc
        LblTotalSueldo.Text = TSueldo
        LblTotalCadetes.Text = Cadete
        LblTotalAyudantes.Text = Ayudante
        LblTotalAdmin.Text = Administrativo
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Form1.Show()
        Dim form2 As Form2 = Me
        form2.Close()

    End Sub

End Class