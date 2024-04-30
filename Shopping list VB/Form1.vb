Imports Microsoft.Office.Interop.Word
Imports OfficeOpenXml
Imports Shopping_list_VB.Shopping_list
Imports System.Diagnostics
Imports System.IO

Public Class Form1
    Private number As Integer

    Public Sub New()
        InitializeComponent()
        number = 0
    End Sub

    Private Sub Form1(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim buys As String = txtcompras.Text
        number += 1
        Dim compra As New slist(number, buys)
        listcompras.Items.Add(compra.ToString())
    End Sub

    Private Sub listView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listcompras.SelectedIndexChanged
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        Try
            Dim carpetaDestino As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim rutaArchivo As String = Path.Combine(carpetaDestino, "Shopping list.txt")

            Using writer As New StreamWriter(rutaArchivo)
                For Each item As ListViewItem In listcompras.Items
                    writer.WriteLine(item.Text)
                    For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                        writer.WriteLine(subItem.Text)
                    Next
                Next
            End Using

            MessageBox.Show("Data saved correctly in: " & rutaArchivo, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class


