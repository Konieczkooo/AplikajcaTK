﻿Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'robienie screena formy
        Dim bmp As New Bitmap(Me.Width, Me.Height)

        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

        Clipboard.SetImage(bmp) 'copy picture onto clipboard
    End Sub
End Class