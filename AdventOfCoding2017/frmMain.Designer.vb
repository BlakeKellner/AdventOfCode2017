<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GOButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblResultsLabel = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.cmdCopyToClipboard = New System.Windows.Forms.Button()
        Me.chkTabDelimited = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'GOButton
        '
        Me.GOButton.Location = New System.Drawing.Point(12, 384)
        Me.GOButton.Name = "GOButton"
        Me.GOButton.Size = New System.Drawing.Size(75, 23)
        Me.GOButton.TabIndex = 0
        Me.GOButton.Text = "GO"
        Me.GOButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 36)
        Me.TextBox1.MaxLength = 999999
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(769, 333)
        Me.TextBox1.TabIndex = 1
        '
        'lblResultsLabel
        '
        Me.lblResultsLabel.AutoSize = True
        Me.lblResultsLabel.Location = New System.Drawing.Point(12, 424)
        Me.lblResultsLabel.Name = "lblResultsLabel"
        Me.lblResultsLabel.Size = New System.Drawing.Size(45, 13)
        Me.lblResultsLabel.TabIndex = 2
        Me.lblResultsLabel.Text = "Results:"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(72, 424)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(34, 13)
        Me.lblResults.TabIndex = 3
        Me.lblResults.Text = "#N/A"
        '
        'cmdCopyToClipboard
        '
        Me.cmdCopyToClipboard.Location = New System.Drawing.Point(75, 441)
        Me.cmdCopyToClipboard.Name = "cmdCopyToClipboard"
        Me.cmdCopyToClipboard.Size = New System.Drawing.Size(104, 23)
        Me.cmdCopyToClipboard.TabIndex = 4
        Me.cmdCopyToClipboard.Text = "Copy to Clipboard"
        Me.cmdCopyToClipboard.UseVisualStyleBackColor = True
        '
        'chkTabDelimited
        '
        Me.chkTabDelimited.AutoSize = True
        Me.chkTabDelimited.Location = New System.Drawing.Point(15, 13)
        Me.chkTabDelimited.Name = "chkTabDelimited"
        Me.chkTabDelimited.Size = New System.Drawing.Size(91, 17)
        Me.chkTabDelimited.TabIndex = 5
        Me.chkTabDelimited.Text = "Tab Delimited"
        Me.chkTabDelimited.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 543)
        Me.Controls.Add(Me.chkTabDelimited)
        Me.Controls.Add(Me.cmdCopyToClipboard)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblResultsLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GOButton)
        Me.Name = "frmMain"
        Me.Text = "Advent of Coding 2017"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GOButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblResultsLabel As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents cmdCopyToClipboard As Button
    Friend WithEvents chkTabDelimited As CheckBox
End Class
