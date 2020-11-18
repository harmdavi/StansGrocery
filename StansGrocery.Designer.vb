<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StansGrocery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.FilterByCategory = New System.Windows.Forms.RadioButton()
        Me.FilterByAisleRadio = New System.Windows.Forms.RadioButton()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreYouSureYouNeedHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PleaseAcceptLicenceAgreementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcceptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(12, 76)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(642, 31)
        Me.SearchBox.TabIndex = 0
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(700, 70)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(247, 43)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(700, 133)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(238, 33)
        Me.ComboBox1.TabIndex = 2
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 25
        Me.ListBox.Location = New System.Drawing.Point(12, 136)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(642, 379)
        Me.ListBox.TabIndex = 3
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.FilterByCategory)
        Me.GroupBox.Controls.Add(Me.FilterByAisleRadio)
        Me.GroupBox.Location = New System.Drawing.Point(700, 200)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(238, 315)
        Me.GroupBox.TabIndex = 4
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Filter"
        '
        'FilterByCategory
        '
        Me.FilterByCategory.AutoSize = True
        Me.FilterByCategory.Location = New System.Drawing.Point(16, 191)
        Me.FilterByCategory.Name = "FilterByCategory"
        Me.FilterByCategory.Size = New System.Drawing.Size(215, 29)
        Me.FilterByCategory.TabIndex = 1
        Me.FilterByCategory.TabStop = True
        Me.FilterByCategory.Text = "Filter By Category"
        Me.FilterByCategory.UseVisualStyleBackColor = True
        '
        'FilterByAisleRadio
        '
        Me.FilterByAisleRadio.AutoSize = True
        Me.FilterByAisleRadio.Location = New System.Drawing.Point(16, 81)
        Me.FilterByAisleRadio.Name = "FilterByAisleRadio"
        Me.FilterByAisleRadio.Size = New System.Drawing.Size(175, 29)
        Me.FilterByAisleRadio.TabIndex = 0
        Me.FilterByAisleRadio.TabStop = True
        Me.FilterByAisleRadio.Text = "Filter By Aisle"
        Me.FilterByAisleRadio.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(775, 535)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(116, 44)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1031, 40)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(98, 38)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(220, 44)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(220, 44)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(85, 36)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem2})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(359, 44)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'HelpToolStripMenuItem2
        '
        Me.HelpToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem3})
        Me.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2"
        Me.HelpToolStripMenuItem2.Size = New System.Drawing.Size(359, 44)
        Me.HelpToolStripMenuItem2.Text = "Help"
        '
        'HelpToolStripMenuItem3
        '
        Me.HelpToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AreYouSureYouNeedHelpToolStripMenuItem})
        Me.HelpToolStripMenuItem3.Name = "HelpToolStripMenuItem3"
        Me.HelpToolStripMenuItem3.Size = New System.Drawing.Size(359, 44)
        Me.HelpToolStripMenuItem3.Text = "Help"
        '
        'AreYouSureYouNeedHelpToolStripMenuItem
        '
        Me.AreYouSureYouNeedHelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YesToolStripMenuItem})
        Me.AreYouSureYouNeedHelpToolStripMenuItem.Name = "AreYouSureYouNeedHelpToolStripMenuItem"
        Me.AreYouSureYouNeedHelpToolStripMenuItem.Size = New System.Drawing.Size(463, 44)
        Me.AreYouSureYouNeedHelpToolStripMenuItem.Text = "Are you Sure you need Help?"
        '
        'YesToolStripMenuItem
        '
        Me.YesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PleaseAcceptLicenceAgreementToolStripMenuItem, Me.AcceptToolStripMenuItem})
        Me.YesToolStripMenuItem.Name = "YesToolStripMenuItem"
        Me.YesToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.YesToolStripMenuItem.Text = "Yes."
        '
        'PleaseAcceptLicenceAgreementToolStripMenuItem
        '
        Me.PleaseAcceptLicenceAgreementToolStripMenuItem.Name = "PleaseAcceptLicenceAgreementToolStripMenuItem"
        Me.PleaseAcceptLicenceAgreementToolStripMenuItem.Size = New System.Drawing.Size(508, 44)
        Me.PleaseAcceptLicenceAgreementToolStripMenuItem.Text = "Please accept Licence agreement "
        '
        'AcceptToolStripMenuItem
        '
        Me.AcceptToolStripMenuItem.Name = "AcceptToolStripMenuItem"
        Me.AcceptToolStripMenuItem.Size = New System.Drawing.Size(508, 44)
        Me.AcceptToolStripMenuItem.Text = "Accept"
        '
        'StansGrocery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 591)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StansGrocery"
        Me.Text = "Stans Grocery"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox As ListBox
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents FilterByCategory As RadioButton
    Friend WithEvents FilterByAisleRadio As RadioButton
    Friend WithEvents ExitButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents AreYouSureYouNeedHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PleaseAcceptLicenceAgreementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcceptToolStripMenuItem As ToolStripMenuItem
End Class
