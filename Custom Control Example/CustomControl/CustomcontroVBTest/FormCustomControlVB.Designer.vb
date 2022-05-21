<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomControlVB
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
        Me.UserControlCustomControl1 = New CustomControl.UserControlCustomControl()
        Me.SuspendLayout()
        '
        'UserControlCustomControl1
        '
        Me.UserControlCustomControl1.Location = New System.Drawing.Point(54, 20)
        Me.UserControlCustomControl1.Name = "UserControlCustomControl1"
        Me.UserControlCustomControl1.Size = New System.Drawing.Size(492, 259)
        Me.UserControlCustomControl1.TabIndex = 0
        '
        'FormCustomControlVB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 291)
        Me.Controls.Add(Me.UserControlCustomControl1)
        Me.Name = "FormCustomControlVB"
        Me.Text = "Custom Control VB Test"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControlCustomControl1 As CustomControl.UserControlCustomControl
End Class
