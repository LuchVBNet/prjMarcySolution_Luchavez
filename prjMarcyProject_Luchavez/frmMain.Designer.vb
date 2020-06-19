
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblItem1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblItem2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnCalculate = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblTotal = New MaterialSkin.Controls.MaterialLabel()
        Me.txtItem1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtItem2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtTotal = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnExit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'lblItem1
        '
        Me.lblItem1.AutoSize = True
        Me.lblItem1.Depth = 0
        Me.lblItem1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblItem1.Location = New System.Drawing.Point(46, 164)
        Me.lblItem1.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblItem1.Name = "lblItem1"
        Me.lblItem1.Size = New System.Drawing.Size(51, 19)
        Me.lblItem1.TabIndex = 4
        Me.lblItem1.Text = "Item 1"
        '
        'lblItem2
        '
        Me.lblItem2.AutoSize = True
        Me.lblItem2.Depth = 0
        Me.lblItem2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblItem2.Location = New System.Drawing.Point(46, 192)
        Me.lblItem2.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblItem2.Name = "lblItem2"
        Me.lblItem2.Size = New System.Drawing.Size(51, 19)
        Me.lblItem2.TabIndex = 5
        Me.lblItem2.Text = "Item 2"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(126, 92)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(176, 19)
        Me.MaterialLabel3.TabIndex = 7
        Me.MaterialLabel3.Text = "Buy One Get One Half Off"
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCalculate.Depth = 0
        Me.btnCalculate.Icon = Nothing
        Me.btnCalculate.Location = New System.Drawing.Point(214, 231)
        Me.btnCalculate.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Primary = True
        Me.btnCalculate.Size = New System.Drawing.Size(97, 36)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Depth = 0
        Me.lblTotal.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(46, 285)
        Me.lblTotal.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 19)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total"
        '
        'txtItem1
        '
        Me.txtItem1.Depth = 0
        Me.txtItem1.Hint = ""
        Me.txtItem1.Location = New System.Drawing.Point(113, 163)
        Me.txtItem1.MaxLength = 32767
        Me.txtItem1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtItem1.Name = "txtItem1"
        Me.txtItem1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItem1.SelectedText = ""
        Me.txtItem1.SelectionLength = 0
        Me.txtItem1.SelectionStart = 0
        Me.txtItem1.Size = New System.Drawing.Size(255, 23)
        Me.txtItem1.TabIndex = 0
        Me.txtItem1.TabStop = False
        Me.txtItem1.UseSystemPasswordChar = False
        '
        'txtItem2
        '
        Me.txtItem2.Depth = 0
        Me.txtItem2.Hint = ""
        Me.txtItem2.Location = New System.Drawing.Point(113, 191)
        Me.txtItem2.MaxLength = 32767
        Me.txtItem2.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtItem2.Name = "txtItem2"
        Me.txtItem2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItem2.SelectedText = ""
        Me.txtItem2.SelectionLength = 0
        Me.txtItem2.SelectionStart = 0
        Me.txtItem2.Size = New System.Drawing.Size(255, 23)
        Me.txtItem2.TabIndex = 1
        Me.txtItem2.TabStop = False
        Me.txtItem2.UseSystemPasswordChar = False
        '
        'txtTotal
        '
        Me.txtTotal.Depth = 0
        Me.txtTotal.Hint = ""
        Me.txtTotal.Location = New System.Drawing.Point(113, 284)
        Me.txtTotal.MaxLength = 32767
        Me.txtTotal.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.SelectionLength = 0
        Me.txtTotal.SelectionStart = 0
        Me.txtTotal.Size = New System.Drawing.Size(255, 23)
        Me.txtTotal.TabIndex = 3
        Me.txtTotal.TabStop = False
        Me.txtTotal.UseSystemPasswordChar = False
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExit.Depth = 0
        Me.btnExit.Icon = Nothing
        Me.btnExit.Location = New System.Drawing.Point(318, 231)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Primary = False
        Me.btnExit.Size = New System.Drawing.Size(50, 36)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(414, 338)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtItem2)
        Me.Controls.Add(Me.txtItem1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.lblItem2)
        Me.Controls.Add(Me.lblItem1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(414, 338)
        Me.MinimumSize = New System.Drawing.Size(414, 338)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcy’s Department Store"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblItem1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblItem2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnCalculate As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblTotal As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtItem1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtItem2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtTotal As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnExit As MaterialSkin.Controls.MaterialFlatButton
End Class
