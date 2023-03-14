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
        Me.lblInternetSpeedTestSurvey = New System.Windows.Forms.Label()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblAverageInternetSpeed = New System.Windows.Forms.Label()
        Me.lblMbps = New System.Windows.Forms.Label()
        Me.lstSpeed = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblInternetSpeedTestSurvey
        '
        Me.lblInternetSpeedTestSurvey.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternetSpeedTestSurvey.Location = New System.Drawing.Point(400, 36)
        Me.lblInternetSpeedTestSurvey.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInternetSpeedTestSurvey.Name = "lblInternetSpeedTestSurvey"
        Me.lblInternetSpeedTestSurvey.Size = New System.Drawing.Size(469, 38)
        Me.lblInternetSpeedTestSurvey.TabIndex = 0
        Me.lblInternetSpeedTestSurvey.Text = "Internet Speed Test Survey"
        '
        'btnSpeed
        '
        Me.btnSpeed.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpeed.Location = New System.Drawing.Point(451, 142)
        Me.btnSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(279, 48)
        Me.btnSpeed.TabIndex = 1
        Me.btnSpeed.Text = "Enter Internet Speed"
        Me.btnSpeed.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(740, 595)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 32)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblAverageInternetSpeed
        '
        Me.lblAverageInternetSpeed.AutoSize = True
        Me.lblAverageInternetSpeed.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageInternetSpeed.Location = New System.Drawing.Point(591, 681)
        Me.lblAverageInternetSpeed.Name = "lblAverageInternetSpeed"
        Me.lblAverageInternetSpeed.Size = New System.Drawing.Size(269, 24)
        Me.lblAverageInternetSpeed.TabIndex = 3
        Me.lblAverageInternetSpeed.Text = "Average Internet Speed:"
        '
        'lblMbps
        '
        Me.lblMbps.AutoSize = True
        Me.lblMbps.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMbps.Location = New System.Drawing.Point(995, 679)
        Me.lblMbps.Name = "lblMbps"
        Me.lblMbps.Size = New System.Drawing.Size(80, 24)
        Me.lblMbps.TabIndex = 4
        Me.lblMbps.Text = "Label1"
        Me.lblMbps.Visible = False
        '
        'lstSpeed
        '
        Me.lstSpeed.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSpeed.FormattingEnabled = True
        Me.lstSpeed.ItemHeight = 43
        Me.lstSpeed.Location = New System.Drawing.Point(955, 82)
        Me.lstSpeed.Name = "lstSpeed"
        Me.lstSpeed.Size = New System.Drawing.Size(209, 305)
        Me.lstSpeed.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Internet_Speed_Test_Survey.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1176, 735)
        Me.Controls.Add(Me.lstSpeed)
        Me.Controls.Add(Me.lblMbps)
        Me.Controls.Add(Me.lblAverageInternetSpeed)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.lblInternetSpeedTestSurvey)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInternetSpeedTestSurvey As Label
    Friend WithEvents btnSpeed As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAverageInternetSpeed As Label
    Friend WithEvents lblMbps As Label
    Friend WithEvents lstSpeed As ListBox
End Class
