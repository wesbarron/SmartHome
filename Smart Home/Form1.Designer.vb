<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmartHome
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
        Me.lblMain = New System.Windows.Forms.Label()
        Me.comBoxMonth = New System.Windows.Forms.ComboBox()
        Me.lblMonthlySavings = New System.Windows.Forms.Label()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.picBoxMain = New System.Windows.Forms.PictureBox()
        Me.lblMonthlyAverage = New System.Windows.Forms.Label()
        Me.lblSignificant = New System.Windows.Forms.Label()
        CType(Me.picBoxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Oswald", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(490, 51)
        Me.lblMain.Margin = New System.Windows.Forms.Padding(3)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(268, 126)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "Smart Home " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'comBoxMonth
        '
        Me.comBoxMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comBoxMonth.FormattingEnabled = True
        Me.comBoxMonth.Location = New System.Drawing.Point(533, 205)
        Me.comBoxMonth.Name = "comBoxMonth"
        Me.comBoxMonth.Size = New System.Drawing.Size(168, 39)
        Me.comBoxMonth.TabIndex = 1
        '
        'lblMonthlySavings
        '
        Me.lblMonthlySavings.AutoSize = True
        Me.lblMonthlySavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlySavings.Location = New System.Drawing.Point(148, 353)
        Me.lblMonthlySavings.Name = "lblMonthlySavings"
        Me.lblMonthlySavings.Size = New System.Drawing.Size(362, 29)
        Me.lblMonthlySavings.TabIndex = 2
        Me.lblMonthlySavings.Text = "The electric savings for X is X"
        '
        'btnStats
        '
        Me.btnStats.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStats.ForeColor = System.Drawing.Color.White
        Me.btnStats.Location = New System.Drawing.Point(253, 410)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(295, 51)
        Me.btnStats.TabIndex = 5
        Me.btnStats.Text = "Display Statistics"
        Me.btnStats.UseVisualStyleBackColor = False
        '
        'picBoxMain
        '
        Me.picBoxMain.Image = Global.Smart_Home.My.Resources.Resources.smarthome
        Me.picBoxMain.Location = New System.Drawing.Point(-1, -1)
        Me.picBoxMain.Name = "picBoxMain"
        Me.picBoxMain.Size = New System.Drawing.Size(439, 318)
        Me.picBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxMain.TabIndex = 6
        Me.picBoxMain.TabStop = False
        '
        'lblMonthlyAverage
        '
        Me.lblMonthlyAverage.AutoSize = True
        Me.lblMonthlyAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyAverage.Location = New System.Drawing.Point(164, 485)
        Me.lblMonthlyAverage.Name = "lblMonthlyAverage"
        Me.lblMonthlyAverage.Size = New System.Drawing.Size(384, 29)
        Me.lblMonthlyAverage.TabIndex = 7
        Me.lblMonthlyAverage.Text = "The average monthly savings: X"
        '
        'lblSignificant
        '
        Me.lblSignificant.AutoSize = True
        Me.lblSignificant.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignificant.Location = New System.Drawing.Point(100, 539)
        Me.lblSignificant.Name = "lblSignificant"
        Me.lblSignificant.Size = New System.Drawing.Size(504, 29)
        Me.lblSignificant.TabIndex = 8
        Me.lblSignificant.Text = "X had the most significant monthly savings"
        '
        'frmSmartHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 594)
        Me.Controls.Add(Me.lblSignificant)
        Me.Controls.Add(Me.lblMonthlyAverage)
        Me.Controls.Add(Me.picBoxMain)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.lblMonthlySavings)
        Me.Controls.Add(Me.comBoxMonth)
        Me.Controls.Add(Me.lblMain)
        Me.Name = "frmSmartHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart Home Application"
        CType(Me.picBoxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMain As Label
    Friend WithEvents comBoxMonth As ComboBox
    Friend WithEvents lblMonthlySavings As Label
    Friend WithEvents btnStats As Button
    Friend WithEvents picBoxMain As PictureBox
    Friend WithEvents lblMonthlyAverage As Label
    Friend WithEvents lblSignificant As Label
End Class
