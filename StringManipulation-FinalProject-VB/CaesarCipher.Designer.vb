<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaesarCipher
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
        Me.C2 = New System.Windows.Forms.CheckBox()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'C2
        '
        Me.C2.AutoSize = True
        Me.C2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2.ForeColor = System.Drawing.Color.DarkRed
        Me.C2.Location = New System.Drawing.Point(230, 35)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(86, 23)
        Me.C2.TabIndex = 1
        Me.C2.Text = "Decipher"
        Me.C2.UseVisualStyleBackColor = True
        '
        'T2
        '
        Me.T2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T2.Location = New System.Drawing.Point(110, 149)
        Me.T2.Multiline = True
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(206, 23)
        Me.T2.TabIndex = 4
        '
        'T1
        '
        Me.T1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T1.Location = New System.Drawing.Point(110, 104)
        Me.T1.Multiline = True
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(206, 23)
        Me.T1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Plain Text"
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Checked = True
        Me.C1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.C1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1.ForeColor = System.Drawing.Color.DarkRed
        Me.C1.Location = New System.Drawing.Point(110, 35)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(84, 23)
        Me.C1.TabIndex = 0
        Me.C1.Text = "Encipher"
        Me.C1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cipher"
        '
        'CaesarCipher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(339, 200)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C1)
        Me.Name = "CaesarCipher"
        Me.Text = "Caesar Cipher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C2 As System.Windows.Forms.CheckBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
