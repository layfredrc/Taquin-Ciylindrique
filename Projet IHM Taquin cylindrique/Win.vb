Public Class Win
    'notifie le joueur de sa victoire avec une msgbox
    Private Sub BTN_WIN_Click(sender As Object, e As EventArgs) Handles BTN_WIN.Click
        MsgBox("Tu as gagné la partie. Bravo jeune champion, tu l'a fait en " &
               Taquin.LBL_NBCLICKS.Text & " clicks")
        Accueil.Show()

        Me.Close()
        Taquin.LBL_NBCLICKS.Text = "0"
        Taquin.Close()
        My.Computer.Audio.Stop()
    End Sub
    'Fichier audio joueur en boucle
    Private Sub Win_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.imaboss, AudioPlayMode.BackgroundLoop)
    End Sub
End Class