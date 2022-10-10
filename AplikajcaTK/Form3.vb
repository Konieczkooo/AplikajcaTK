Imports MaterialSkin

Public Class Form3
    Private Sub MaterialLabel2_Click(sender As Object, e As EventArgs) Handles MaterialLabel2.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'robienie screena formy
        Dim bmp As New Bitmap(Me.Width, Me.Height)

        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

        Clipboard.SetImage(bmp) 'copy picture onto clipboard
    End Sub
End Class