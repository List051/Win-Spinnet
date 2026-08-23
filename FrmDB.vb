
'=================================
' *** WinItalPascal ***
' Autore        : Iaora
' File          : FrmDB
' Cartella      : WinTest
' Soluzione     : WinTest --> Form con cambio DataBase
' Creato il     : 20/08/2026
' Modificato il : 
' YouTube       : iaoraGo
' NuGet         : ItalPascal
' GitHub        : List051
'=================================
Imports System.Data.SqlClient
Imports WinItalPascal


Public Class FrmDB
    ' wincod
    Private Sub FrmDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmTitolo.CTitolo(Me, "Gestione DB con WinItalPascal")
        IPMessageBox.Show("Form con cambio DataBase")


        ' winpopup
    End Sub




    Private Sub TxtCerca_TextChanged(sender As Object, e As EventArgs) Handles TxtCerca.TextChanged

    End Sub

    Private Sub BtnConn_Click(sender As Object, e As EventArgs) Handles BtnConn.Click

    End Sub

    Private Sub Btn1_Salva_Click(sender As Object, e As EventArgs) Handles Btn1_Salva.Click

    End Sub

    Private Sub Btn2_Salva_Click(sender As Object, e As EventArgs) Handles Btn2_Salva.Click

    End Sub

    Private Sub BtnCirc_Click(sender As Object, e As EventArgs) Handles BtnCirc.Click

    End Sub


    Private Sub PrimoDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PrimoDataGrid.CellContentClick

    End Sub

    Private Sub SecondoDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SecondoDataGrid.CellContentClick

    End Sub

    Private Sub ToggleBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ToggleBtn.CheckedChanged

    End Sub
End Class