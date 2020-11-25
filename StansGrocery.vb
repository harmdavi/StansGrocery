
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
    Dim filter As Integer
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
            Me.food$(i, 1) = ThirdArray(1).PadLeft(2) 'the pad left fixes the sorting of the aisle numeric values
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
        LoadDataArray()
        FilterByAisleRadio.Checked = True
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
        Dim nothingArray() As String
        Dim searchResultNumber As Integer
        ListBoxDisplay.Items.Clear()
        For i = LBound(food) To UBound(food) - 1
            'food(i, 0),searchbox.text)>0
            If InStr(food(i, 0), SearchBox.Text) > 0 Or InStr(food(i, 2), SearchBox.Text) > 0 Or InStr(food(i, 1), SearchBox.Text) > 0 Then

                ListBoxDisplay.Items.Add(food(i, 0))
                If food(i, 0) <> "" Then
                    searchResultNumber = +1
                End If
            End If
        Next
        If searchResultNumber = 0 Then
            MsgBox($"Sorry no matches for {SearchBox.Text}")
        End If
        'If ListBoxDisplay.Equals(Nothing) Then
        '    MsgBox($"Sorry no matches for {SearchBox}")
        'End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        ListBoxDisplay.Items.Clear()

        For i = LBound(food) To UBound(food) - 1
            If ComboBox1.SelectedItem.ToString = food(i, filter) Then
                ListBoxDisplay.Items.Add(food(i, 0))
            End If
        Next
        If ComboBox1.SelectedItem.Equals("  Show All") Then
            For i = LBound(food) To UBound(food) - 1
                ListBoxDisplay.Items.Add(food(i, 0))
            Next
        End If
    End Sub
    Private Sub LoadComboBox()
        ComboBox1.Items.Clear()

        For i = LBound(food) To UBound(food) - 1
            If Not ComboBox1.Items.Contains(food(i, filter)) And food(i, filter) <> "" And food(i, filter) <> "  " Then
                ComboBox1.Items.Add(food(i, filter))
            End If
        Next
        ComboBox1.Sorted = True
        ComboBox1.Items.Insert(0, "  Show All")
        ComboBox1.SelectedIndex = 0
        If ComboBox1.SelectedItem.Equals("  Show All") Then
            For i = LBound(food) To UBound(food) - 1
                ListBoxDisplay.Items.Add(food(i, 0))
            Next

        End If

    End Sub

    Private Sub FilterByAisleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadio.CheckedChanged, FilterByCategory.CheckedChanged
        If FilterByAisleRadio.Checked Then
            filter = 1
        Else
            filter = 2
        End If
        LoadComboBox()

    End Sub

    Private Sub ListBoxDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxDisplay.SelectedIndexChanged
        For i = LBound(food) To UBound(food) - 1
            If ListBoxDisplay.SelectedItem Is food(i, 0) Then
                YouWillFind.Text = $"You Will Find {food(i, 0)} on Aisle {ListBoxDisplay.SelectedIndex} with the {food(i, 2)}"
            End If
        Next
    End Sub

    Private Sub LicenceAgreementToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        AboutForm.Size = Me.Size
        AboutForm.Show()
    End Sub

End Class