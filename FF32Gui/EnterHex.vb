Option Explicit On
'' Option Strict On
Imports System.Drawing.Text
Imports System.Text
Imports System.IO
Imports System
Imports Microsoft.VisualBasic
Imports System.Timers
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Globalization
Imports System.ComponentModel


Public Class EnterHex

    Dim hcount As Integer = 0
    Dim TotBytes As Integer = 0

    Private Sub EnterHex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hcount = 0
        TotBytes = 0
        HexBox.Text = "-"
        HexBox.SelectionLength = 0
        HexBox.SelectionStart = HexBox.Text.Length
        HexBox.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If saveWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim objWriter As New System.IO.StreamWriter(saveWork.FileName)
            HexBox.Text = HexBox.Text.Replace("-", "")
            Try
                objWriter.Write(HexBox.Text)
                objWriter.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Close()
        End If
    End Sub

    Private Function HexToByteArray(ByVal hexString As [String]) As Byte()
        Dim length As Integer = hexString.Length
        Dim upperBound As Integer = length \ 2
        If length Mod 2 = 0 Then
            upperBound -= 1
        Else
            hexString = "0" & hexString
        End If
        Dim bytes(upperBound) As Byte
        For i As Integer = 0 To upperBound
            bytes(i) = Convert.ToByte(hexString.Substring(i * 2, 2), 16)
        Next
        Return bytes
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If saveWork.ShowDialog = Windows.Forms.DialogResult.OK Then
            HexBox.Text = HexBox.Text.Replace("-", "")
            Dim fs As New FileStream(saveWork.FileName, FileMode.Create, FileAccess.ReadWrite)
            Dim bw As New BinaryWriter(fs)
            Try
                bw.Write(HexToByteArray(HexBox.Text))
                bw.Close()
                fs.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                bw.Close()
                fs.Close()
            End Try
            Close()
        End If
    End Sub

    Private Sub HexBox_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles HexBox.KeyPress

        e.Handled = True
        If InStr("0123456789abcdefABCDEF", e.KeyChar) <> 0 Then
            hcount += 1
            If hcount = 2 Then
                HexBox.Text &= e.KeyChar & "-"
                hcount = 0
                TotBytes += 1
            Else
                HexBox.Text &= e.KeyChar
            End If
            HexBox.SelectionLength = 0
            HexBox.SelectionStart = HexBox.Text.Length
            Labelbytes.Text = TotBytes & " bytes"
        Else
            If Asc(e.KeyChar) = 8 And HexBox.Text.Length > 1 Then
                If hcount = 0 Then
                    hcount = 3
                    TotBytes -= 1
                End If
                If HexBox.Text.Count > hcount Then
                    HexBox.Text = HexBox.Text.Remove(HexBox.Text.Count - hcount)
                    HexBox.SelectionLength = 0
                    HexBox.SelectionStart = HexBox.Text.Length
                    hcount = 0
                    Labelbytes.Text = TotBytes & " bytes"
                End If
            End If
        End If
    End Sub

    Private Sub HexBox_KeyDown(sender As Object, e As KeyEventArgs) Handles HexBox.KeyDown

        If e.KeyCode = Keys.Enter Then e.Handled = True
        If e.KeyCode = Keys.Delete Then e.Handled = True
        If e.KeyCode = Keys.Left Then e.Handled = True

    End Sub

    Private Sub HexBox_TextChanged(sender As Object, e As EventArgs) Handles HexBox.TextChanged

    End Sub
End Class