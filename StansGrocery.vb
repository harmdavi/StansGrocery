
'David Harmon
'RCET0265
'Fall 2020
'Stans Gerocery
'

Option Strict On
Option Explicit On
Option Compare Text


Public Class StansGrocery
    Dim food(256, 2) As String
    Sub LoadDataArray()
        Dim temp() As String
        Dim SecondArray() As String
        Dim ThirdArray() As String

        temp = Split(My.Resources.Grocery, vbLf)

        For i = LBound(temp) To UBound(temp) - 1
            SecondArray = Split(temp(i), Chr(34) & "," & Chr(34))
        Next
        'For i = 0 To 1

        'Next

    End Sub
    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterByAisleRadio.Checked = True
        LoadDataArray()
        ' temp = Split(My.Resources.Grocery, vbNewLine)
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        If SearchBox.Text = "zzz" Then
            Me.Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub
End Class
