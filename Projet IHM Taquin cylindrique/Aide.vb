Public Class Aide
    'Initialisation des outils
    'initialisation de la page web d'accueil
    Private Sub Aide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WebBrowser1.Navigate("https://fr.wikipedia.org/wiki/Taquin")
        Me.BTN_PREC.Enabled = False
        Me.BTN_REFR.Enabled = True
        Me.BTN_SUIV.Enabled = False
        Me.BTN_ENVOYER.Enabled = True

    End Sub

    'Lorsque le chargement est fini
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        'Affiche le nouveau statut, désactive le bouton « Stop »
        Me.LBL_STATUT.Text = WebBrowser1.StatusText

        'On récupère l'adresse de la page et on l'affiche
        Me.TXT_BOXSEARCH.Text = Me.WebBrowser1.Url.ToString
    End Sub

    'Lorsque le chargement commence
    Private Sub WebBrowser1_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        If Me.WebBrowser1.CanGoBack Then
            Me.BTN_PREC.Enabled = True
        Else
            Me.BTN_PREC.Enabled = False
        End If

        If Me.WebBrowser1.CanGoForward Then
            Me.BTN_SUIV.Enabled = True
        Else
            Me.BTN_SUIV.Enabled = False
        End If

    End Sub

    'À chaque changement d'état, on met à jour les boutons
    Sub WebBrowser1_CanGoForwardChanged(ByVal sender As Object, ByVal e As EventArgs) Handles WebBrowser1.CanGoForwardChanged
        If Me.WebBrowser1.CanGoForward Then
            Me.BTN_SUIV.Enabled = True
        Else
            Me.BTN_SUIV.Enabled = False
        End If
    End Sub

    'À chaque changement d'état, on met à jour les boutons
    Sub WebBrowser1_CanGoBackChanged(ByVal sender As Object, ByVal e As EventArgs) Handles WebBrowser1.CanGoBackChanged
        If Me.WebBrowser1.CanGoBack Then
            Me.BTN_PREC.Enabled = True
        Else
            Me.BTN_PREC.Enabled = False
        End If
    End Sub

    'Au changement de statut de la page
    Sub WebBrowser1_StatutTextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles WebBrowser1.StatusTextChanged
        'On met le statut à jour
        Me.LBL_STATUT.Text = WebBrowser1.StatusText
    End Sub

    'Au changement de progression de la page
    Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        Me.PRG_BAR.Maximum = e.MaximumProgress
        Me.PRG_BAR.Value = e.CurrentProgress
    End Sub
    'Tant que l'on ne tape rien sur la barre de recherche le bouton envoyer est desactivé
    'sinon lorque l'on click, le timer et le bouton rafraichir sont activé
    Private Sub BTN_ENVOYER_Click(sender As Object, e As EventArgs) Handles BTN_ENVOYER.Click
        Me.Timer1.Enabled = True
        Me.BTN_REFR.Enabled = True


        While Me.TXT_BOXSEARCH.TextLength.Equals(0)
            Me.BTN_ENVOYER.Enabled = False

        End While
        Me.WebBrowser1.Navigate(TXT_BOXSEARCH.Text)

    End Sub
    'Si on a deja navigue sur des pages alors on pourra retourner a la page web precedente
    Private Sub BTN_PREC_Click(sender As Object, e As EventArgs) Handles BTN_PREC.Click
        Me.BTN_SUIV.Enabled = True
        Me.Timer1.Enabled = True
        Me.BTN_REFR.Enabled = True
        Me.BTN_ENVOYER.Enabled = True

        If Me.WebBrowser1.CanGoBack() Then
            Me.WebBrowser1.GoBack()

        End If

    End Sub
    'Si on peut aller a une page web suivante alors on ira dans cette page au moment du click
    Private Sub BTN_SUIV_Click(sender As Object, e As EventArgs) Handles BTN_SUIV.Click
        Me.BTN_PREC.Enabled = True
        Me.Timer1.Enabled = True
        Me.BTN_SUIV.Enabled = False
        Me.BTN_ENVOYER.Enabled = True
        Me.Timer1.Interval = 5
        If Me.WebBrowser1.CanGoForward() Then
            Me.WebBrowser1.GoForward()
        End If
    End Sub
    'raffraichit la page web
    Private Sub BTN_REFR_Click(sender As Object, e As EventArgs) Handles BTN_REFR.Click
        Me.BTN_SUIV.Enabled = False
        Me.BTN_REFR.Enabled = True
        Me.BTN_PREC.Enabled = True
        Me.BTN_ENVOYER.Enabled = True
        Me.Timer1.Enabled = True

        Me.WebBrowser1.Refresh()

    End Sub
    'retrour au formulaire 'accueil'
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        If MsgBox("Revenir à l'accueil ?", 36, "Quitter") = MsgBoxResult.Yes Then
            Me.Hide()
            Accueil.Show()
        End If
    End Sub
    'affiche l'etat de la recherche web
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PRG_BAR.Value = 100 Then
            Me.Timer1.Enabled = False
            Me.LBL_STATUT.Text = "Prêt"
        Else
            Me.PRG_BAR.Value = Me.PRG_BAR.Value + 10
            Me.LBL_STATUT.Text = "Chargement.."
        End If
    End Sub
End Class