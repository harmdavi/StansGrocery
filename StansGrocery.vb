
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
        'the vbLF stands for "Visual Basic Line Feed. This will split the text baised off of each line of information. 
        For i = LBound(temp) To UBound(temp) - 1
            'The LBound and UBound gets the maximum length of columns and rows from the array. 
            SecondArray = Split(temp(i), Chr(34) & "," & Chr(34))
            'this loads the second array with the infomation in the temp array moves it baised on the quotation mark and comma delimiters
            ThirdArray = Split(SecondArray(0), "$$ITM")
            Console.Write(ThirdArray(1))
            'This splits the second array in its 0 spot and writes whatever item is next to the $$ITM delimiter in the third array
            Me.food$(i, 0) = ThirdArray(1)
            ' then takes that Item and loads it into the 0 demention of the food array
            ThirdArray = Split(SecondArray(1), "##LOC")
            Console.Write(ThirdArray(1))
            Me.food$(i, 1) = ThirdArray(1)
            'This takes the value after the ##LOC delimiter and loads it into the third array to be loaded into the food array.
            ThirdArray = Split(SecondArray(2), "%%CAT")
            ThirdArray = Split(ThirdArray(1), Chr(34))
            'The code on the line above takes out one more unessisary quotation mark found in the txt file so the food array can be loaded with only the correct information
            Console.WriteLine(ThirdArray(0))
            Me.food$(i, 2) = ThirdArray(0)


            'For i = 0 To 1

        Next

        Console.WriteLine(My.Resources.Grocery)

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

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ListBoxDisplay.Items.Clear()
        For i = LBound(food) To UBound(food) - 1
            'food(i, 0),searchbox.text)>0
            If InStr(food(i, 0), SearchBox.Text) > 0 Or InStr(food(i, 2), SearchBox.Text) > 0 Or InStr(food(i, 1), SearchBox.Text) > 0 Then
                'Console.WriteLine(food(i, 0))
                'Console.WriteLine(ListBox)
                ListBoxDisplay.Items.Add(food(i, 0))
            End If

        Next
    End Sub
End Class
