
Imports MaterialSkin

Public Class frmMain
    Private decItem1, decItem2, decTotal, decSavings As Decimal

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        'Initialize SkinManager
        '
        Dim skinManager As MaterialSkinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
        skinManager.Theme = MaterialSkinManager.Themes.LIGHT
        skinManager.ColorScheme = New ColorScheme(Primary.Blue900, Primary.Blue700, Primary.LightBlue900, Accent.LightBlue200, TextShade.WHITE)
        'Format Inputs and Outputs
        FormatInputs()
        FormatOutputs()
    End Sub

    Private Sub validate_Keys(sender As Object, e As KeyPressEventArgs) Handles txtItem1.KeyPress, txtItem2.KeyPress
        Dim t As TextBox = sender
        If Not (Char.IsDigit(e.KeyChar)) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            'to be rejected
            e.Handled = True
        Else
            'to be accepted
            e.Handled = If(e.KeyChar = "." AndAlso t.Text.Contains("."), True, False)
        End If
    End Sub

    Private Sub textBox_TextChanged(sender As Object, e As EventArgs) Handles txtItem1.TextChanged, txtItem2.TextChanged
        decTotal = 0
        FormatOutputs()
    End Sub

    Private Sub textBox_Focus(sender As Object, e As EventArgs) Handles txtTotal.Enter, txtTotal.Click, txtItem2.Enter, txtItem2.Click, txtItem1.Enter, txtItem1.Click
        Dim t As TextBox = sender
        t.SelectAll()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'get inputs
        GetInputs()
        'computations
        decTotal = decItem1 + decItem2
        decSavings = If(decItem1 < decItem2, decItem1 * 0.5, decItem2 * 0.5)
        decTotal -= decSavings
        'display
        MsgBox("Customer saved: " & decSavings.ToString("N2"))
        FormatOutputs()
    End Sub

    Private Sub textBox_LoseFocus(sender As Object, e As EventArgs) Handles txtItem2.Leave, txtItem1.Leave
        GetInputs()
        FormatInputs()
    End Sub

    Private Sub MaterialContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub GetInputs()
        Decimal.TryParse(txtItem1.Text, decItem1)
        Decimal.TryParse(txtItem2.Text, decItem2)
    End Sub

    Private Sub FormatInputs()
        txtItem1.Text = decItem1.ToString("N2")
        txtItem2.Text = decItem2.ToString("N2")
    End Sub

    Private Sub FormatOutputs()
        txtTotal.Text = decTotal.ToString("N2")
    End Sub
End Class
