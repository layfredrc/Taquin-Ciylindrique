Public Class Lose
    'Lors du chargement du fomulaire on passera un fichier audio en boucle
    Private Sub Lose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.ahah, AudioPlayMode.BackgroundLoop)
    End Sub
    'Retour vers l'accueil et arrêt du fichier audio    
    Private Sub BTN_RETOUR_Click(sender As Object, e As EventArgs) Handles BTN_RETOUR.Click
        Me.Close()
        Accueil.Show()
        My.Computer.Audio.Stop()
        Taquin.NbClick = 0
    End Sub

End Class