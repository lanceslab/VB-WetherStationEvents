<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.labelNormal = New System.Windows.Forms.Label()
        Me.labelRaining = New System.Windows.Forms.Label()
        Me.labelSnowing = New System.Windows.Forms.Label()
        Me.labelLightning = New System.Windows.Forms.Label()
        Me.labelTornado = New System.Windows.Forms.Label()
        Me.textBoxNormal = New System.Windows.Forms.TextBox()
        Me.textBoxRaining = New System.Windows.Forms.TextBox()
        Me.textBoxTornado = New System.Windows.Forms.TextBox()
        Me.textBoxLightning = New System.Windows.Forms.TextBox()
        Me.textBoxSnowing = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'labelNormal
        '
        Me.labelNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNormal.Location = New System.Drawing.Point(65, 22)
        Me.labelNormal.Name = "labelNormal"
        Me.labelNormal.Size = New System.Drawing.Size(80, 23)
        Me.labelNormal.TabIndex = 0
        Me.labelNormal.Text = "Normal:"
        '
        'labelRaining
        '
        Me.labelRaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRaining.Location = New System.Drawing.Point(65, 64)
        Me.labelRaining.Name = "labelRaining"
        Me.labelRaining.Size = New System.Drawing.Size(80, 23)
        Me.labelRaining.TabIndex = 1
        Me.labelRaining.Text = "Raining:"
        '
        'labelSnowing
        '
        Me.labelSnowing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSnowing.Location = New System.Drawing.Point(65, 113)
        Me.labelSnowing.Name = "labelSnowing"
        Me.labelSnowing.Size = New System.Drawing.Size(80, 23)
        Me.labelSnowing.TabIndex = 2
        Me.labelSnowing.Text = "Snowing:"
        '
        'labelLightning
        '
        Me.labelLightning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLightning.Location = New System.Drawing.Point(65, 155)
        Me.labelLightning.Name = "labelLightning"
        Me.labelLightning.Size = New System.Drawing.Size(80, 23)
        Me.labelLightning.TabIndex = 3
        Me.labelLightning.Text = "Lightning:"
        '
        'labelTornado
        '
        Me.labelTornado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTornado.Location = New System.Drawing.Point(65, 202)
        Me.labelTornado.Name = "labelTornado"
        Me.labelTornado.Size = New System.Drawing.Size(80, 23)
        Me.labelTornado.TabIndex = 4
        Me.labelTornado.Text = "Tornado:"
        '
        'textBoxNormal
        '
        Me.textBoxNormal.Location = New System.Drawing.Point(164, 21)
        Me.textBoxNormal.Name = "textBoxNormal"
        Me.textBoxNormal.ReadOnly = True
        Me.textBoxNormal.Size = New System.Drawing.Size(73, 20)
        Me.textBoxNormal.TabIndex = 5
        Me.textBoxNormal.TabStop = False
        '
        'textBoxRaining
        '
        Me.textBoxRaining.Location = New System.Drawing.Point(164, 63)
        Me.textBoxRaining.Name = "textBoxRaining"
        Me.textBoxRaining.ReadOnly = True
        Me.textBoxRaining.Size = New System.Drawing.Size(73, 20)
        Me.textBoxRaining.TabIndex = 6
        Me.textBoxRaining.TabStop = False
        '
        'textBoxTornado
        '
        Me.textBoxTornado.Location = New System.Drawing.Point(164, 201)
        Me.textBoxTornado.Name = "textBoxTornado"
        Me.textBoxTornado.ReadOnly = True
        Me.textBoxTornado.Size = New System.Drawing.Size(73, 20)
        Me.textBoxTornado.TabIndex = 7
        Me.textBoxTornado.TabStop = False
        '
        'textBoxLightning
        '
        Me.textBoxLightning.Location = New System.Drawing.Point(164, 154)
        Me.textBoxLightning.Name = "textBoxLightning"
        Me.textBoxLightning.ReadOnly = True
        Me.textBoxLightning.Size = New System.Drawing.Size(73, 20)
        Me.textBoxLightning.TabIndex = 8
        Me.textBoxLightning.TabStop = False
        '
        'textBoxSnowing
        '
        Me.textBoxSnowing.Location = New System.Drawing.Point(164, 113)
        Me.textBoxSnowing.Name = "textBoxSnowing"
        Me.textBoxSnowing.ReadOnly = True
        Me.textBoxSnowing.Size = New System.Drawing.Size(73, 20)
        Me.textBoxSnowing.TabIndex = 9
        Me.textBoxSnowing.TabStop = False
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 245)
        Me.Controls.Add(Me.textBoxSnowing)
        Me.Controls.Add(Me.textBoxLightning)
        Me.Controls.Add(Me.textBoxTornado)
        Me.Controls.Add(Me.textBoxRaining)
        Me.Controls.Add(Me.textBoxNormal)
        Me.Controls.Add(Me.labelTornado)
        Me.Controls.Add(Me.labelLightning)
        Me.Controls.Add(Me.labelSnowing)
        Me.Controls.Add(Me.labelRaining)
        Me.Controls.Add(Me.labelNormal)
        Me.Name = "SummaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary of Weather Readings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelNormal As System.Windows.Forms.Label
    Friend WithEvents labelRaining As System.Windows.Forms.Label
    Friend WithEvents labelSnowing As System.Windows.Forms.Label
    Friend WithEvents labelLightning As System.Windows.Forms.Label
    Friend WithEvents labelTornado As System.Windows.Forms.Label
    Friend WithEvents textBoxNormal As System.Windows.Forms.TextBox
    Friend WithEvents textBoxRaining As System.Windows.Forms.TextBox
    Friend WithEvents textBoxTornado As System.Windows.Forms.TextBox
    Friend WithEvents textBoxLightning As System.Windows.Forms.TextBox
    Friend WithEvents textBoxSnowing As System.Windows.Forms.TextBox
End Class
