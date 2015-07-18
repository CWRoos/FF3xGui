<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterHex
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.saveWork = New System.Windows.Forms.SaveFileDialog()
        Me.HexBox = New System.Windows.Forms.TextBox()
        Me.Labelbytes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save As BIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(411, 343)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(145, 343)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Save AS HEX"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'saveWork
        '
        Me.saveWork.Filter = "Bin files|*.bin;*.hex|All fFiles|*.*"
        Me.saveWork.Title = "Save Work"
        '
        'HexBox
        '
        Me.HexBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.HexBox.Location = New System.Drawing.Point(12, 12)
        Me.HexBox.Multiline = True
        Me.HexBox.Name = "HexBox"
        Me.HexBox.Size = New System.Drawing.Size(483, 325)
        Me.HexBox.TabIndex = 0
        '
        'Labelbytes
        '
        Me.Labelbytes.AutoSize = True
        Me.Labelbytes.Location = New System.Drawing.Point(294, 350)
        Me.Labelbytes.Name = "Labelbytes"
        Me.Labelbytes.Size = New System.Drawing.Size(42, 13)
        Me.Labelbytes.TabIndex = 4
        Me.Labelbytes.Text = "0 Bytes"
        '
        'EnterHex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 378)
        Me.Controls.Add(Me.Labelbytes)
        Me.Controls.Add(Me.HexBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(515, 405)
        Me.MinimumSize = New System.Drawing.Size(515, 405)
        Me.Name = "EnterHex"
        Me.ShowIcon = False
        Me.Text = "Enter Hex Bytes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents saveWork As System.Windows.Forms.SaveFileDialog
    Friend WithEvents HexBox As System.Windows.Forms.TextBox
    Friend WithEvents Labelbytes As System.Windows.Forms.Label
End Class
