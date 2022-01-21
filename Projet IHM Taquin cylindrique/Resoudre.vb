Public Class Resoudre

    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click
        TextBoxTexteRepondu.Text = ""
        ecrit_fichier()
        appelle_Sprint5()
        TextBoxTexteRepondu.Text = lit_fichier()
        TextBoxTexteRepondu.EnableAutoDragDrop = True
        TextBoxTexteRepondu.Enabled = True

    End Sub
    Sub ecrit_fichier()
        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("TexteSaisi.txt", False, utf8WithoutBom)
        file.WriteLine("4 4" + vbNewLine + Taquin.BTN_1.Text + " " + Taquin.BTN_2.Text + " " + Taquin.BTN_3.Text + " " + Taquin.BTN_4.Text + vbNewLine + Taquin.BTN_5.Text + " " + Taquin.BTN_6.Text + " " + Taquin.BTN_7.Text + " " + Taquin.BTN_8.Text + vbNewLine + Taquin.BTN_9.Text + " " + Taquin.BTN_10.Text + " " + Taquin.BTN_11.Text + " " + Taquin.BTN_12.Text + vbNewLine + Taquin.BTN_13.Text + " " + Taquin.BTN_14.Text + " " + Taquin.BTN_15.Text + " " + Taquin.BTN_16.Text)
        file.Close()

    End Sub

    Function lit_fichier() As String
        Return My.Computer.FileSystem.ReadAllText("TexteRepondu.txt")
    End Function

    Sub appelle_Sprint5()
        'echo.exe < TexteSaisi.txt > TexteRepondu.txt

        Dim commande As String =
            "Taquin.exe < TexteSaisi.txt > TexteRepondu.txt"

        Dim p As New Process
        Dim psi As New ProcessStartInfo(
            "cmd.exe",
            "/c " & commande
        )
        p.StartInfo = psi
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        LabelWaiting.Text = ChrW(8987)


        p.Start()
        p.WaitForExit()
        LabelWaiting.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        ' Taquin.BTN_1.Text = "1"
        ' Taquin.BTN_2.Text = "2"
        ' Taquin.BTN_3.Text = "3"
        ' Taquin.BTN_4.Text = "4"
        ' Taquin.BTN_5.Text = "5"
        ' Taquin.BTN_6.Text = "6"
        ' Taquin.BTN_7.Text = "7"
        ' Taquin.BTN_8.Text = "8"
        ' Taquin.BTN_9.Text = "9"
        ' Taquin.BTN_10.Text = "10"
        ' Taquin.BTN_11.Text = "11"
        ' Taquin.BTN_12.Text = "12"
        ' Taquin.BTN_13.Text = "13"
        ' Taquin.BTN_14.Text = "14"
        ' Taquin.BTN_15.Text = "15"
        ' Taquin.BTN_16.Text = "#"

        Taquin.Show()
        PartiGagné()
    End Sub

    Private Sub Resoudre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBoxTexteRepondu.Enabled = False

    End Sub
End Class
