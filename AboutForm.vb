Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Text = $"David Harmon{vbNewLine}RCET0265 {vbNewLine}Fall 2020 {vbNewLine}Stan's Gerocery {vbNewLine}https://github.com/harmdavi/StansGrocery.git"
        'Label1.Size = Me.Size
        'Label1.Location = Me.Width
        'Label1.Location.X.Equals(Me.Size.Width / 2)
    End Sub
End Class