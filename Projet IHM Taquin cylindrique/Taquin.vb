Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Taquin
    'Initialisation des outils
    Private Sub Taquin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = True
        Me.LBL_CHRONO.Visible = False
        Me.LBL_NOM.Text = Accueil.ComboBox1.GetItemText(Accueil.ComboBox1.Text)
        Me.ProgressBar1.Value = 0
        Me.LBL_CHRONO.Text = "0"
    End Sub
    'lorsque le joueur abandonne, une msgbox s'affiche pour confirmer si il veut vraiment abandonner
    'si il repond "oui" alors on arrete le timern on lui augmente son nb de partie jouees de 1
    'on reinitialise les outils en fonction du niveau et on remelange le taquin
    Private Sub BTN_ABANDON_Click(sender As Object, e As EventArgs) Handles BTN_ABANDON.Click
        If MsgBox("Souhaitez-vous vraiment fuir !?", 36, "Quitter") = MsgBoxResult.Yes Then
            Accueil.BTN_RECAP.Enabled = True
            Me.Timer1.Stop()
            NbClick = 0
            For Each joueur In listeJoueurs
                If joueur.nom = Accueil.ComboBox1.Text Then
                    joueur.nbPartiesJouees = joueur.nbPartiesJouees + 1
                End If
            Next
            Me.Close()
            Lose.Show()
            Me.LBL_NBCLICKS.Text = "0"
            If Me.LBL_TEMPS.Text <> "\" Then
                Me.LBL_TEMPS.Text = CStr(Me.ProgressBar1.Maximum)
            End If

        End If
    End Sub
    'Chaque seconde on enleve 1 au label temps et on ajoute 1 au lbl chrono (invisible) et a la progressbar
    'si le lbl temps descend jusqu'a 0 alors le joueur a perdu donc une msgbow apparaitra 
    'puis le formulaire "lose" s'affichera
    'On augmentera le nb de partie jouees du joueur de 1 et on actualisera son temps total.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Me.Timer1.Enabled = True Then
            Me.Timer1.Interval = 1000
            Me.Timer1.Start()
            If CInt(Me.LBL_TEMPS.Text) = 0 Then
                Me.Timer1.Stop()
                MsgBox("Le temps est écoulé vous avez perdu !")
                Me.Hide()
                Lose.Show()
                Me.LBL_TEMPS.Text = CStr(Me.ProgressBar1.Maximum)
                Me.LBL_CHRONO.Text = "0"
                Me.ProgressBar1.Value = 0

                Dim TmpJoueur As Joueur
                TmpJoueur.listeTemps = New List(Of Integer)()
                For i As Integer = 0 To Module1.listeJoueurs.Count - 1
                    If Module1.listeJoueurs(i).nom = Accueil.ComboBox1.Text Then
                        TmpJoueur.nom = Module1.listeJoueurs(i).nom
                        TmpJoueur.TempsTotal = TmpJoueur.TempsTotal + CInt(Me.LBL_TEMPS.Text)
                        TmpJoueur.nbPartiesJouees = Module1.listeJoueurs(i).nbPartiesJouees + 1
                        Module1.listeJoueurs(i) = TmpJoueur
                    End If
                Next

            Else
                Me.LBL_TEMPS.Text = CStr(Me.LBL_TEMPS.Text - 1)
                Me.LBL_CHRONO.Text = CStr(Me.LBL_CHRONO.Text + 1)
                Me.ProgressBar1.Value = Me.ProgressBar1.Value + 1
            End If
        End If
    End Sub
    'Ouvre le formulaire "Resoudre"
    'Copie le taquin dans la textbox de saisie
    Private Sub BTN_EXE_Click(sender As Object, e As EventArgs) Handles BTN_EXE.Click

        Resoudre.TextBoxTexteSaisi.Text = ("4 4" + vbNewLine + Me.BTN_1.Text + " " + Me.BTN_2.Text + " " + Me.BTN_3.Text + " " + Me.BTN_4.Text + vbNewLine + Me.BTN_5.Text + " " + Me.BTN_6.Text + " " + Me.BTN_7.Text + " " + Me.BTN_8.Text + vbNewLine + Me.BTN_9.Text + " " + Me.BTN_10.Text + " " + Me.BTN_11.Text + " " + Me.BTN_12.Text + vbNewLine + Me.BTN_13.Text + " " + Me.BTN_14.Text + " " + Me.BTN_15.Text + " " + Me.BTN_16.Text)

        Resoudre.Show()

    End Sub
    Public NbClick As Integer = 0
    'Deplacement des boutons
    Private Sub boutton1_Clicked(sender As Object, e As EventArgs) Handles BTN_1.Click
        EchangeBouttons(BTN_1, BTN_2)
        EchangeBouttons(BTN_1, BTN_5)
        EchangeBouttons(BTN_1, BTN_4) 'cylindrique'

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton2_Clicked(sender As Object, e As EventArgs) Handles BTN_2.Click
        EchangeBouttons(BTN_2, BTN_1)
        EchangeBouttons(BTN_2, BTN_6)
        EchangeBouttons(BTN_2, BTN_3)

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton3_Clicked(sender As Object, e As EventArgs) Handles BTN_3.Click
        EchangeBouttons(BTN_3, BTN_2)
        EchangeBouttons(BTN_3, BTN_7)
        EchangeBouttons(BTN_3, BTN_4)

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton4_Clicked(sender As Object, e As EventArgs) Handles BTN_4.Click
        EchangeBouttons(BTN_4, BTN_3)
        EchangeBouttons(BTN_4, BTN_8)
        EchangeBouttons(BTN_4, BTN_1) 'cylindrique'

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton5_Clicked(sender As Object, e As EventArgs) Handles BTN_5.Click
        EchangeBouttons(BTN_5, BTN_1)
        EchangeBouttons(BTN_5, BTN_6)
        EchangeBouttons(BTN_5, BTN_9)
        EchangeBouttons(BTN_5, BTN_8) 'cylindrique'

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton6_Clicked(sender As Object, e As EventArgs) Handles BTN_6.Click
        EchangeBouttons(BTN_6, BTN_2)
        EchangeBouttons(BTN_6, BTN_5)
        EchangeBouttons(BTN_6, BTN_7)
        EchangeBouttons(BTN_6, BTN_10)

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton7_Clicked(sender As Object, e As EventArgs) Handles BTN_7.Click
        EchangeBouttons(BTN_7, BTN_3)
        EchangeBouttons(BTN_7, BTN_6)
        EchangeBouttons(BTN_7, BTN_8)
        EchangeBouttons(BTN_7, BTN_11)

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton8_Clicked(sender As Object, e As EventArgs) Handles BTN_8.Click
        EchangeBouttons(BTN_8, BTN_4)
        EchangeBouttons(BTN_8, BTN_7)
        EchangeBouttons(BTN_8, BTN_12)
        EchangeBouttons(BTN_8, BTN_5) 'cylindrique'

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton9_Clicked(sender As Object, e As EventArgs) Handles BTN_9.Click
        EchangeBouttons(BTN_9, BTN_5)
        EchangeBouttons(BTN_9, BTN_10)
        EchangeBouttons(BTN_9, BTN_12) 'cylindrique'
        EchangeBouttons(BTN_9, BTN_13)

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton10_Clicked(sender As Object, e As EventArgs) Handles BTN_10.Click
        EchangeBouttons(BTN_10, BTN_6)
        EchangeBouttons(BTN_10, BTN_9)
        EchangeBouttons(BTN_10, BTN_11)
        EchangeBouttons(BTN_10, BTN_14)

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton11_Clicked(sender As Object, e As EventArgs) Handles BTN_11.Click
        EchangeBouttons(BTN_11, BTN_7)
        EchangeBouttons(BTN_11, BTN_10)
        EchangeBouttons(BTN_11, BTN_12)
        EchangeBouttons(BTN_11, BTN_15)

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton12_Clicked(sender As Object, e As EventArgs) Handles BTN_12.Click
        EchangeBouttons(BTN_12, BTN_8)
        EchangeBouttons(BTN_12, BTN_9) 'cylindrique'
        EchangeBouttons(BTN_12, BTN_11)
        EchangeBouttons(BTN_12, BTN_16)

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton13_Clicked(sender As Object, e As EventArgs) Handles BTN_13.Click
        EchangeBouttons(BTN_13, BTN_9)
        EchangeBouttons(BTN_13, BTN_16) 'cylindrique
        EchangeBouttons(BTN_13, BTN_14)

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton14_Clicked(sender As Object, e As EventArgs) Handles BTN_14.Click
        EchangeBouttons(BTN_14, BTN_10)
        EchangeBouttons(BTN_14, BTN_13)
        EchangeBouttons(BTN_14, BTN_15)

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton15_Clicked(sender As Object, e As EventArgs) Handles BTN_15.Click
        EchangeBouttons(BTN_15, BTN_11)
        EchangeBouttons(BTN_15, BTN_14)
        EchangeBouttons(BTN_15, BTN_16)

        PartiGagné()
    End Sub
    'Deplacement des boutons
    Private Sub boutton16_Clicked(sender As Object, e As EventArgs) Handles BTN_16.Click
        EchangeBouttons(BTN_16, BTN_12)
        EchangeBouttons(BTN_16, BTN_15)
        EchangeBouttons(BTN_16, BTN_13) 'cylindrique'

        PartiGagné()
    End Sub
End Class