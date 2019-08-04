<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWeatherForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblEventDetected = New System.Windows.Forms.Label()
        Me.timerWeatherStation = New System.Windows.Forms.Timer(Me.components)
        Me.buttonSummary = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "The following event was detected:"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(61, 110)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(155, 28)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start monitoring"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblEventDetected
        '
        Me.lblEventDetected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEventDetected.Location = New System.Drawing.Point(61, 60)
        Me.lblEventDetected.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventDetected.Name = "lblEventDetected"
        Me.lblEventDetected.Size = New System.Drawing.Size(371, 22)
        Me.lblEventDetected.TabIndex = 3
        '
        'timerWeatherStation
        '
        Me.timerWeatherStation.Interval = 2000
        '
        'buttonSummary
        '
        Me.buttonSummary.Location = New System.Drawing.Point(277, 110)
        Me.buttonSummary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonSummary.Name = "buttonSummary"
        Me.buttonSummary.Size = New System.Drawing.Size(155, 28)
        Me.buttonSummary.TabIndex = 6
        Me.buttonSummary.Text = "Show Summary"
        Me.buttonSummary.UseVisualStyleBackColor = True
        '
        'MainWeatherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 174)
        Me.Controls.Add(Me.buttonSummary)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblEventDetected)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MainWeatherForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LancesLab - WeatherStation Events"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblEventDetected As System.Windows.Forms.Label
    Friend WithEvents timerWeatherStation As System.Windows.Forms.Timer
    Friend WithEvents buttonSummary As System.Windows.Forms.Button

End Class
