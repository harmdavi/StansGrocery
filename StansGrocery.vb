
'David Harmon
'RCET0265
'Fall 2020
'Stans Gerocery
'https://github.com/harmdavi/StansGrocery.git

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
        'the vbLF stands for "Visual Basic Line Feed. This will split the text baised off of each line of information.
        temp = Split(My.Resources.Grocery, vbLf)
        'This for loop is here to load the data comming into the program into a usable array named food organized so that 
        'The contents are sorted like this: food$(item, location, category)
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
        Next
        Console.WriteLine(My.Resources.Grocery)
    End Sub
    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This loads the data into the load array sub and also check the Aisle radio button so that it is the default selection 
        'for the groub box.
        LoadDataArray()
        FilterByAisleRadio.Checked = True
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        'This sets a easy exit button. However I aknowledge that there might be times that you would not like the user to close out
        'of the program so easily. It might be better to hide exit options like having to type in "zzz" into the search bar (which
        'this code also does)
        Me.Close()
    End Sub
    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        If SearchBox.Text = "zzz" Then
            Me.Close()
        End If
    End Sub
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchToolStripMenuItem.Click
        Dim nothingArray() As String
        Dim searchResultNumber As Integer
        ListBoxDisplay.Items.Clear()
        'this searches through the entire array and pulls out anything that matches the search criteria. 
        For i = LBound(food) To UBound(food) - 1
            'food(i, 0),searchbox.text)>0
            If InStr(food(i, 0), SearchBox.Text) > 0 Or InStr(food(i, 2), SearchBox.Text) > 0 Or InStr(food(i, 1), SearchBox.Text) > 0 Then
                'this adds a number to the searchResultNumber variable. I was not able to get this funtion to work unless I simply
                'added a number to the variable everytime something was added to the listboxDisplay. This makes it so that a message
                'will form if there were no search results. 
                ListBoxDisplay.Items.Add(food(i, 0))
                If food(i, 0) <> "" Then
                    searchResultNumber = +1
                End If
            End If
        Next
        If searchResultNumber = 0 Then
            MsgBox($"Sorry no matches for {SearchBox.Text}")
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListBoxDisplay.Items.Clear()
        'This part of the code allows for you to look for items baised off of either the category or the Aisle
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
        'This sub does what the name implies and loads the combobox based off of what search critera have been selected on the 
        'combobox and radio button selections
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
        'This part of the code helps with loading the combo box with what information should be loaded into the listBoxDisplay
        If FilterByAisleRadio.Checked Then
            filter = 1
        Else
            filter = 2
        End If
        LoadComboBox()
    End Sub
    Private Sub ListBoxDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxDisplay.SelectedIndexChanged
        'This part of the code tells the user where to find the selected item in the listbox. It displays category and Aisle number
        For i = LBound(food) To UBound(food) - 1
            If ListBoxDisplay.SelectedItem Is food(i, 0) Then
                YouWillFind.Text = $"You Will Find {food(i, 0)} on Aisle {ListBoxDisplay.SelectedIndex} with the {food(i, 2)}"
            End If
        Next
    End Sub
    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        AboutForm.Size = Me.Size
        AboutForm.Show()
    End Sub
End Class