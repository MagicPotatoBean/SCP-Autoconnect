<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Autopaste = New System.ComponentModel.BackgroundWorker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Autopaste
        '
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.Location = New System.Drawing.Point(0, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(120, 46)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(136, 85)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(136, 85)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Autojoin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Autopaste As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button2 As Button
End Class
