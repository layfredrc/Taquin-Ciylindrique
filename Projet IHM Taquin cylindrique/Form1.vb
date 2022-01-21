Public Class Accueil
    'Initialisation de la combobox et limite sur la longueur du nom à entrer
    'Bouton jouer desactivé au chargement
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BTN_JOUER.Enabled = False
        Me.BTN_RECAP.Enabled = True
        Me.BTN_QUITTER.Enabled = True
        Me.BTN_NIVEAU.Enabled = True
        Me.BTN_AIDE.Enabled = True
        Me.ComboBox1.Text = ""
        Me.ComboBox1.MaxLength = 15
    End Sub
    'Quitte le programme si l'utilisateur repond "oui" à la msgbox
    Private Sub BTN_QUITTER_Click(sender As Object, e As EventArgs) Handles BTN_QUITTER.Click
        If MsgBox("Souhaitez-vous vraiment quitter ce magnifique programme ? Le videur à l'air sympathique pourtant..", 36, "Quitter") = MsgBoxResult.Yes Then
            End
        End If
    End Sub
    'vérifie si l'utilisateur entre des caractères alphabetiques
    'si ce ne sont pas des lettres la combobox ne les affiches pas
    'si la longueur du texte est différent de 0 alors le bouton jouer est activé
    'si la longueur du texte est égale à la longueur maximale que peut contenur la cbbox alors on fait entendre le son d'erreur BEEP
    Private Sub ComboBOX1_Keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

        If Me.ComboBox1.Text.Length > 0 Then
            Me.BTN_JOUER.Enabled = True
            If IsNothing(Me.ComboBox1.Text) Then
                Me.BTN_JOUER.Enabled = False
            End If
        End If

        If Me.ComboBox1.Text.Length = Me.ComboBox1.MaxLength Then
            Beep()
        End If

    End Sub
    'En cliquant sur ce bouton, on verifie si le joueur existe deja via la combobox
    'si le joueur n'a pas deja ete cree alors on intancie un nouveau joueur qu'on ajoutera 
    'a la liste de joueur et a la combobox
    'ensuite on initialise le formulaire taquin en fonction du niveau selectionne (ou pas)
    'puis enfin on va melanger les cases du taquin
    Private Sub BTN_JOUER_Click(sender As Object, e As EventArgs) Handles BTN_JOUER.Click
        If ComboBox1.Items.Contains(ComboBox1.Text) = False Then
            ComboBox1.Items.Add(ComboBox1.Text)
            Dim j As Joueur
            j.nom = ComboBox1.Text
            j.meilleurTemps = 9999999
            j.nbPartiesJouees = 0
            j.TempsTotal = 99999999
            j.listeTemps = New List(Of Integer)()

            Module1.listeJoueurs.Add(j)
            Récapitulatif.ComboBox_RESULTAT.Items.Add(j.nom)
        End If

        Taquin.LBL_NOM.Text = ComboBox1.Text
        Taquin.ProgressBar1.Value = 0

        If Taquin.LBL_TEMPS.Text <> "\" Then
            Taquin.ProgressBar1.Maximum = CInt(Taquin.LBL_TEMPS.Text)
            Taquin.Timer1.Enabled = True
            Taquin.Timer1.Start()
        Else
            Taquin.ProgressBar1.Enabled = False
            Taquin.ProgressBar1.Visible = False
            Taquin.Timer1.Enabled = False
            Taquin.Timer1.Stop()

        End If

        Me.Hide()
        Taquin.Show()
        melangeBouttons()

        If Taquin.LBL_NOM.Text = "Toto" Then
            My.Computer.Audio.Play(My.Resources.zizi, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Play(My.Resources.avengers, AudioPlayMode.BackgroundLoop)
        End If

    End Sub
    'Lorsqu'on quitte le champ de texte de la combobox on va normaliser le texte ecrit en
    'mettant en majuscule le premier caractere
    Private Sub ComboBox1_LostFocus(sender As Object, e As EventArgs) Handles ComboBox1.LostFocus
        ComboBox1.Text = StrConv(ComboBox1.Text, VbStrConv.ProperCase)
    End Sub
    'Lorsqu'on choisit un item de la combobox alors elle s'ecrit dans le champ de texte
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Taquin.LBL_NOM.Text = ComboBox1.Text
    End Sub
    'Affichage du formulaire recapitulatif qui affiche le nom des joueurs inscrits ainsi que 
    'leur meilleur temps si ils en ont un.
    Private Sub BTN_RECAP_Click(sender As Object, e As EventArgs) Handles BTN_RECAP.Click
        Me.Hide()
        Récapitulatif.Show()
        Récapitulatif.ListBox2.Items.Clear()
        Récapitulatif.ListBox1.Items.Clear()
        Récapitulatif.ListBox2.Enabled = False
        For i As Integer = 0 To listeJoueurs.Count - 1
            Récapitulatif.ListBox1.Items.Add(listeJoueurs(i).nom)

        Next
        For i As Integer = 0 To listeJoueurs(0).listeTemps.Count - 1
            listeJoueurs(0).listeTemps.Sort()
            Récapitulatif.ListBox2.Items.Add(listeJoueurs(0).meilleurTemps)
        Next
    End Sub
    'Ouvre le formulaire aide
    Private Sub BTN_AIDE_Click(sender As Object, e As EventArgs) Handles BTN_AIDE.Click
        Me.Hide()
        Aide.Show()
    End Sub
    'Ouvre le formulaire niveau
    Private Sub BTN_NIVEAU_Click(sender As Object, e As EventArgs) Handles BTN_NIVEAU.Click
        Me.Hide()
        Niveau.Show()
    End Sub


End Class
