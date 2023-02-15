Option Explicit On
Option Strict On
Option Infer Off
' Name:         Multiplication Project
' Purpose:      Displays a multiplication table that shows the multiplicand, multiplier, and product.
' Programmer:   Kaysar Adde on 2/15

Imports System.Threading

Public Class frmMain

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' Displays a multiplication table.
        Dim multiply As Double
        Dim user As Double
        Dim finalanswer As Double

        Double.TryParse(txtNumber.Text, user)

        Do While multiply < 9
            multiply += 1
            finalanswer = user * multiply
            lblTable.Text = lblTable.Text &
                user.ToString("N0") &
                multiply.ToString(" x ") &
                multiply.ToString("N0") &
                multiply.ToString(" = ") &
                finalanswer.ToString("N0") & ControlChars.NewLine
        Loop
        finalanswer = multiply





    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' Displays a multiplication table.


    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' Allow only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lblTable.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
