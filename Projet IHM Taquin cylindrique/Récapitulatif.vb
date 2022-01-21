Public Class Récapitulatif
    'Synchronisation des deux listbox lorqu'on clique sur un item.
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged,
        ListBox2.SelectedIndexChanged

        ListBox2.Items.Clear()
        ListBox2.Enabled = False

        Dim pos As Integer = sender.selectedIndex
        Me.ListBox1.SelectedIndex = pos
        For i As Integer = 0 To listeJoueurs(pos).listeTemps.Count - 1
            listeJoueurs(pos).listeTemps.Sort()
            Me.ListBox2.Items.Add(listeJoueurs(pos).meilleurTemps)
        Next
        Me.ComboBox_RESULTAT.Text = Me.ComboBox_RESULTAT.Items(pos)


    End Sub
    'Initialisation de la scrollbar
    Private Sub Récapitulatif_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.VScrollBar1.Value = 0
        Me.VScrollBar1.Maximum = 100
        Me.VScrollBar1.Minimum = 0

        Me.VScrollBar2.Value = 0
        Me.VScrollBar2.Maximum = 100
        Me.VScrollBar2.Minimum = 0
    End Sub
    'Bouton de retour à l'accueil qui reinitialise les listbox lors du click
    Private Sub BTN_ACCUEIL_Click(sender As Object, e As EventArgs) Handles BTN_ACCUEIL.Click
        Me.ListBox1.Items.Clear()
        Me.ListBox2.Items.Clear()
        Me.ListBox1.Sorted = False
        Me.ListBox2.Sorted = False
        Me.Hide()
        Accueil.Show()
    End Sub
    'Affiche une msgBox avec les statistiques du joueur selectionné
    Private Sub BTN_STATS_Click(sender As Object, e As EventArgs) Handles BTN_STATS.Click
        For Each joueur In Module1.listeJoueurs
            If joueur.nom = Me.ComboBox_RESULTAT.Text Then
                MsgBox("Statistiques de " & joueur.nom & ":" & vbNewLine & " Meilleur temps : " & joueur.meilleurTemps &
                       vbNewLine & " Nombre de parties jouees :" & joueur.nbPartiesJouees &
                      vbNewLine & " Temps total :" & joueur.TempsTotal, 0, "Quitter")
                Exit For
            End If

        Next

    End Sub
    'Tri des joueurs dans l'ordre alphabétiques
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_AaZ.Click
        Me.ListBox2.Items.Clear()
        Me.ListBox1.Sorted = True
        For Each nomJoueur As String In ListBox1.Items

            For Each joueur As Joueur In listeJoueurs
                If nomJoueur = joueur.nom Then
                    Me.ListBox2.Items.Add(joueur.meilleurTemps)
                End If
            Next
        Next

    End Sub
    'tri les meilleurs temps dans l'odre croissant
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTN_TRI_ASC.Click
        Me.ListBox1.Items.Clear()
        Me.ListBox2.Sorted = True

        For Each tmpJoueur As Integer In ListBox2.Items

            For Each joueur As Joueur In listeJoueurs
                If tmpJoueur = joueur.meilleurTemps Then
                    Me.ListBox1.Items.Add(joueur.nom)

                End If
            Next
        Next

    End Sub
    'Affiche les meilleurs temps de chaque joueur
    Private Sub BTN_MEILLEUR_TEMPS_Click(sender As Object, e As EventArgs) Handles BTN_MEILLEUR_TEMPS.Click
        Me.ListBox2.Items.Clear()
        For i As Integer = 0 To listeJoueurs.Count - 1
            For Each nomJoueur As String In Me.ListBox1.Items
                If nomJoueur = listeJoueurs(i).nom Then
                    Me.ListBox2.Items.Add(listeJoueurs(i).meilleurTemps)
                End If
            Next
        Next

    End Sub
End Class