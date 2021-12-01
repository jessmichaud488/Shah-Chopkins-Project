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
        Me.lblTwelve = New System.Windows.Forms.Label()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblTotals = New System.Windows.Forms.Label()
        Me.lblQtyBox = New System.Windows.Forms.Label()
        Me.lblTotalBox = New System.Windows.Forms.Label()
        Me.txtTwelveBox = New System.Windows.Forms.TextBox()
        Me.txtFiveBox = New System.Windows.Forms.TextBox()
        Me.txtTwoBox = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.txtShippingBox = New System.Windows.Forms.TextBox()
        Me.lblTwelveTotalBox = New System.Windows.Forms.Label()
        Me.lblFiveTotalBox = New System.Windows.Forms.Label()
        Me.lblTwoTotalBox = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTwelve
        '
        Me.lblTwelve.AutoSize = True
        Me.lblTwelve.Location = New System.Drawing.Point(124, 66)
        Me.lblTwelve.Name = "lblTwelve"
        Me.lblTwelve.Size = New System.Drawing.Size(49, 13)
        Me.lblTwelve.TabIndex = 6
        Me.lblTwelve.Text = "&12 pack:"
        '
        'lblFive
        '
        Me.lblFive.AutoSize = True
        Me.lblFive.Location = New System.Drawing.Point(125, 106)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(43, 13)
        Me.lblFive.TabIndex = 8
        Me.lblFive.Text = "&5 pack:"
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Location = New System.Drawing.Point(124, 146)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(44, 13)
        Me.lblTwo.TabIndex = 10
        Me.lblTwo.Text = "&2 Pack:"
        '
        'lblTotals
        '
        Me.lblTotals.AutoSize = True
        Me.lblTotals.Location = New System.Drawing.Point(124, 226)
        Me.lblTotals.Name = "lblTotals"
        Me.lblTotals.Size = New System.Drawing.Size(39, 13)
        Me.lblTotals.TabIndex = 13
        Me.lblTotals.Text = "Totals:"
        '
        'lblQtyBox
        '
        Me.lblQtyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQtyBox.Location = New System.Drawing.Point(180, 219)
        Me.lblQtyBox.Name = "lblQtyBox"
        Me.lblQtyBox.Size = New System.Drawing.Size(64, 20)
        Me.lblQtyBox.TabIndex = 14
        '
        'lblTotalBox
        '
        Me.lblTotalBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalBox.Location = New System.Drawing.Point(259, 217)
        Me.lblTotalBox.Name = "lblTotalBox"
        Me.lblTotalBox.Size = New System.Drawing.Size(100, 22)
        Me.lblTotalBox.TabIndex = 15
        '
        'txtTwelveBox
        '
        Me.txtTwelveBox.Location = New System.Drawing.Point(180, 59)
        Me.txtTwelveBox.Name = "txtTwelveBox"
        Me.txtTwelveBox.Size = New System.Drawing.Size(64, 20)
        Me.txtTwelveBox.TabIndex = 0
        '
        'txtFiveBox
        '
        Me.txtFiveBox.Location = New System.Drawing.Point(180, 99)
        Me.txtFiveBox.Name = "txtFiveBox"
        Me.txtFiveBox.Size = New System.Drawing.Size(64, 20)
        Me.txtFiveBox.TabIndex = 1
        '
        'txtTwoBox
        '
        Me.txtTwoBox.Location = New System.Drawing.Point(180, 139)
        Me.txtTwoBox.Name = "txtTwoBox"
        Me.txtTwoBox.Size = New System.Drawing.Size(64, 20)
        Me.txtTwoBox.TabIndex = 2
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(124, 264)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(280, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(180, 186)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(51, 13)
        Me.lblShipping.TabIndex = 12
        Me.lblShipping.Text = "&Shipping:"
        '
        'txtShippingBox
        '
        Me.txtShippingBox.Location = New System.Drawing.Point(259, 179)
        Me.txtShippingBox.Name = "txtShippingBox"
        Me.txtShippingBox.Size = New System.Drawing.Size(100, 20)
        Me.txtShippingBox.TabIndex = 3
        '
        'lblTwelveTotalBox
        '
        Me.lblTwelveTotalBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblTwelveTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTwelveTotalBox.Location = New System.Drawing.Point(259, 59)
        Me.lblTwelveTotalBox.Name = "lblTwelveTotalBox"
        Me.lblTwelveTotalBox.Size = New System.Drawing.Size(100, 23)
        Me.lblTwelveTotalBox.TabIndex = 7
        '
        'lblFiveTotalBox
        '
        Me.lblFiveTotalBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblFiveTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFiveTotalBox.Location = New System.Drawing.Point(259, 96)
        Me.lblFiveTotalBox.Name = "lblFiveTotalBox"
        Me.lblFiveTotalBox.Size = New System.Drawing.Size(100, 23)
        Me.lblFiveTotalBox.TabIndex = 9
        '
        'lblTwoTotalBox
        '
        Me.lblTwoTotalBox.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblTwoTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTwoTotalBox.Location = New System.Drawing.Point(259, 136)
        Me.lblTwoTotalBox.Name = "lblTwoTotalBox"
        Me.lblTwoTotalBox.Size = New System.Drawing.Size(100, 23)
        Me.lblTwoTotalBox.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTwoTotalBox)
        Me.Controls.Add(Me.lblFiveTotalBox)
        Me.Controls.Add(Me.lblTwelveTotalBox)
        Me.Controls.Add(Me.txtShippingBox)
        Me.Controls.Add(Me.lblShipping)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtTwoBox)
        Me.Controls.Add(Me.txtFiveBox)
        Me.Controls.Add(Me.txtTwelveBox)
        Me.Controls.Add(Me.lblTotalBox)
        Me.Controls.Add(Me.lblQtyBox)
        Me.Controls.Add(Me.lblTotals)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblFive)
        Me.Controls.Add(Me.lblTwelve)
        Me.Name = "Form1"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTwelve As Label
    Friend WithEvents lblFive As Label
    Friend WithEvents lblTwo As Label
    Friend WithEvents lblTotals As Label
    Friend WithEvents lblQtyBox As Label
    Friend WithEvents lblTotalBox As Label
    Friend WithEvents txtTwelveBox As TextBox
    Friend WithEvents txtFiveBox As TextBox
    Friend WithEvents txtTwoBox As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblShipping As Label
    Friend WithEvents txtShippingBox As TextBox
    Friend WithEvents lblTwelveTotalBox As Label
    Friend WithEvents lblFiveTotalBox As Label
    Friend WithEvents lblTwoTotalBox As Label
End Class
