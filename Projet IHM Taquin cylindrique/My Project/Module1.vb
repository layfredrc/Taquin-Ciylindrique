Module Module1
    Public listeJoueurs As New List(Of Joueur)

    Public Structure Joueur
        Dim nom As String
        Dim meilleurTemps As Integer
        Dim nbPartiesJouees As Integer
        Dim TempsTotal As Integer
        Dim listeTemps As List(Of Integer)
    End Structure
    'Methode pour effectuer le deplacement
    '..
    Sub EchangeBouttons(ByRef Button1 As Button, ByRef Button2 As Button)
        If Button2.Text = "#" Then
            Taquin.NbClick = Taquin.NbClick + 1
            Taquin.LBL_NBCLICKS.Text = Val(Taquin.NbClick)

            Button2.Text = Button1.Text
            Button1.Text = "#"
            ' Taquin.BTN_16.Visible = False

        End If

        If Button1.Text = "#" Then
            Button1.Visible = False
            Button2.Visible = True
        ElseIf Button2.Text = "#" Then
            Button2.Visible = False
            Button1.Visible = True
        End If
        Taquin.BTN_ABANDON.Focus()
    End Sub
    'Si les boutons sont dans l'odre alors on va arreter le timer et afficher le formulaire "Win"
    'puis on va parcourir la liste des joueurs et actualiser ses attributs
    'si le joueur n'a jouer qu'une seule partie alors son meilleur temps et aussi egal a son temps total
    'si le joueur ameliore sa performace alors on actualise son meilleur temps
    'une msgbox notifiera le joueur pour lui dire qu'il a gagné

    Sub PartiGagné()
        If Taquin.BTN_1.Text = "1" And Taquin.BTN_2.Text = "2" And Taquin.BTN_3.Text = "3" And Taquin.BTN_4.Text = "4" And Taquin.BTN_5.Text = "5" And Taquin.BTN_6.Text = "6" And Taquin.BTN_7.Text = "7" And Taquin.BTN_8.Text = "8" And Taquin.BTN_9.Text = "9" And Taquin.BTN_10.Text = "10" And Taquin.BTN_11.Text = "11" And Taquin.BTN_12.Text = "12" And Taquin.BTN_13.Text = "13" And Taquin.BTN_14.Text = "14" And Taquin.BTN_15.Text = "15" And Taquin.BTN_16.Text = "" Then
            Taquin.Timer1.Stop()
            Win.Show()

            Dim TmpJoueur As Joueur
            TmpJoueur.listeTemps = New List(Of Integer)()

            For i As Integer = 0 To Module1.listeJoueurs.Count - 1

                If Module1.listeJoueurs(i).nom = Accueil.ComboBox1.Text Then
                    If Module1.listeJoueurs(i).nbPartiesJouees = 0 Then

                        TmpJoueur.nom = Module1.listeJoueurs(i).nom
                        TmpJoueur.meilleurTemps = CInt(Taquin.LBL_CHRONO.Text)
                        TmpJoueur.TempsTotal = TmpJoueur.meilleurTemps
                        TmpJoueur.nbPartiesJouees = Module1.listeJoueurs(i).nbPartiesJouees + 1
                        TmpJoueur.listeTemps.Add(CInt(Taquin.LBL_CHRONO.Text))
                        Module1.listeJoueurs(i) = TmpJoueur
                        MsgBox("vous avez gagnés votre " & TmpJoueur.nbPartiesJouees & "eme partie")
                    Else



                        If Module1.listeJoueurs(i).meilleurTemps <> 99999999 Then
                            listeJoueurs(i).listeTemps.Add(CInt(Taquin.LBL_CHRONO.Text))
                            listeJoueurs(i).listeTemps.Sort()

                            If listeJoueurs(i).meilleurTemps < CInt(Taquin.LBL_CHRONO.Text) Then
                                TmpJoueur.meilleurTemps = CInt(Taquin.LBL_CHRONO.Text)
                            End If
                            TmpJoueur.nom = Module1.listeJoueurs(i).nom
                            TmpJoueur.TempsTotal = listeJoueurs(i).TempsTotal + CInt(Taquin.LBL_CHRONO.Text)
                            TmpJoueur.nbPartiesJouees = Module1.listeJoueurs(i).nbPartiesJouees + 1
                            TmpJoueur.listeTemps.Add(CInt(Taquin.LBL_CHRONO.Text))
                            Module1.listeJoueurs(i) = TmpJoueur
                        End If
                        MsgBox("vous avez gagnés votre " & TmpJoueur.nbPartiesJouees & "eme partie")
                    End If
                End If
            Next
            Taquin.LBL_TEMPS.Text = CStr(Taquin.ProgressBar1.Maximum)
            Taquin.LBL_CHRONO.Text = "0"
            Taquin.ProgressBar1.Value = 0
            Taquin.Hide()

        End If

    End Sub
    'fonction permettant de générer des numéros aléatoires allant de 1 à 15 qui seront redistribués aléatoirement dans les textes des bouttons
    Sub melangeBouttons()
        Dim tabBTN(16), i, j, rand As Integer
        Dim bool As Boolean = False
        i = 1
        tabBTN(j) = 1

        Do While i <= 16

            rand = (15 * Rnd()) + 1

            For j = 1 To i
                If (tabBTN(j) = rand) Then
                    bool = True
                    Exit For
                End If
            Next

            If bool = True Then
                bool = False
            Else
                tabBTN(i) = rand
                i = i + 1
            End If
        Loop

        'on distribue pour chaque texte de bouttons du taquin, une unique valeure aléatoire se trouvant dans le Tableau tabBTN

        Taquin.BTN_1.Text = tabBTN(1)
        Taquin.BTN_2.Text = tabBTN(2)
        Taquin.BTN_3.Text = tabBTN(3)
        Taquin.BTN_4.Text = tabBTN(4)
        Taquin.BTN_5.Text = tabBTN(5)
        Taquin.BTN_6.Text = tabBTN(6)
        Taquin.BTN_7.Text = tabBTN(7)
        Taquin.BTN_8.Text = tabBTN(8)
        Taquin.BTN_9.Text = tabBTN(9)
        Taquin.BTN_10.Text = tabBTN(10)
        Taquin.BTN_11.Text = tabBTN(11)
        Taquin.BTN_12.Text = tabBTN(12)
        Taquin.BTN_13.Text = tabBTN(13)
        Taquin.BTN_14.Text = tabBTN(14)
        Taquin.BTN_15.Text = tabBTN(15)
        Taquin.BTN_16.Text = tabBTN(16)


        'Pour tous les controles dans le formulaire Taquin, si le controle est un boutton et que le boutton à pour Text le n°16, 
        'alors il deviens invisble et on lui donne comme text "#" pour pouvoir effectuer les mouvements

        For Each Con As Control In Taquin.Controls
            If Con.GetType Is GetType(Button) And Con.Text = "16" Then
                Con.Visible = False
                Con.Text = "#"
            End If
        Next
        If Taquin.BTN_16.Text = "16" Then
            Taquin.BTN_16.Visible = False
            Taquin.BTN_16.Text = "#"
        End If
        If Taquin.BTN_13.Text = "16" Then
            Taquin.BTN_13.Visible = False
            Taquin.BTN_13.Text = "#"
        End If
        If Taquin.BTN_12.Text = "16" Then
            Taquin.BTN_12.Visible = False
            Taquin.BTN_12.Text = "#"
        End If
    End Sub
    Sub resetBoutons()
        Taquin.BTN_1.Text = ""
        Taquin.BTN_2.Text = ""
        Taquin.BTN_3.Text = ""
        Taquin.BTN_4.Text = ""
        Taquin.BTN_5.Text = ""
        Taquin.BTN_6.Text = ""
        Taquin.BTN_7.Text = ""
        Taquin.BTN_8.Text = ""
        Taquin.BTN_9.Text = ""
        Taquin.BTN_10.Text = ""
        Taquin.BTN_11.Text = ""
        Taquin.BTN_12.Text = ""
        Taquin.BTN_13.Text = ""
        Taquin.BTN_14.Text = ""
        Taquin.BTN_15.Text = ""
        Taquin.BTN_16.Text = ""
    End Sub

    Sub Main()
        Application.Run(Accueil)
    End Sub
End Module
