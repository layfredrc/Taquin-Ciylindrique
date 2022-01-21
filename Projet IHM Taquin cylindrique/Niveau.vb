Public Class Niveau
    'change le texte du label temps et affiche le formulaire d'accueil
    Private Sub BTN_ESPORT_Click(sender As Object, e As EventArgs) Handles BTN_ESPORT.Click
        Me.Hide()
        Accueil.Show()
        Taquin.LBL_TEMPS.Text = "300"
    End Sub
    'change le texte du label temps et affiche le formulaire d'accueil
    Private Sub BTN_NOOB_Click(sender As Object, e As EventArgs) Handles BTN_NOOB.Click
        Me.Hide()
        Accueil.Show()
        Taquin.LBL_TEMPS.Text = "\"
    End Sub
    'change le texte du label temps et affiche le formulaire d'accueil
    Private Sub BTN_GOD_Click(sender As Object, e As EventArgs) Handles BTN_GOD.Click
        Me.Hide()
        Accueil.Show()
        Taquin.LBL_TEMPS.Text = "60"
    End Sub
    'change le texte du label temps et affiche le formulaire d'accueil
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_STANDARD.Click
        Me.Hide()
        Accueil.Show()
        Taquin.LBL_TEMPS.Text = "500"
    End Sub
End Class