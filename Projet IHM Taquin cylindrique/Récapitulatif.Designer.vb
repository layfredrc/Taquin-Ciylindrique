<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Récapitulatif
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Récapitulatif))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.BTN_ACCUEIL = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_STATS = New System.Windows.Forms.Button()
        Me.ComboBox_RESULTAT = New System.Windows.Forms.ComboBox()
        Me.BTN_AaZ = New System.Windows.Forms.Button()
        Me.BTN_TRI_ASC = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_MEILLEUR_TEMPS = New System.Windows.Forms.Button()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.AccueilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccueilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(81, 229)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(213, 244)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(515, 229)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(239, 244)
        Me.ListBox2.TabIndex = 1
        '
        'BTN_ACCUEIL
        '
        Me.BTN_ACCUEIL.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ACCUEIL.Location = New System.Drawing.Point(351, 250)
        Me.BTN_ACCUEIL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_ACCUEIL.Name = "BTN_ACCUEIL"
        Me.BTN_ACCUEIL.Size = New System.Drawing.Size(111, 36)
        Me.BTN_ACCUEIL.TabIndex = 2
        Me.BTN_ACCUEIL.Text = "Accueil"
        Me.BTN_ACCUEIL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 42)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "J O U E U R S"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(540, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 39)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "R E C O R D S"
        '
        'BTN_STATS
        '
        Me.BTN_STATS.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_STATS.Location = New System.Drawing.Point(324, 315)
        Me.BTN_STATS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_STATS.Name = "BTN_STATS"
        Me.BTN_STATS.Size = New System.Drawing.Size(159, 36)
        Me.BTN_STATS.TabIndex = 7
        Me.BTN_STATS.Text = "Statistiques"
        Me.BTN_STATS.UseVisualStyleBackColor = True
        '
        'ComboBox_RESULTAT
        '
        Me.ComboBox_RESULTAT.FormattingEnabled = True
        Me.ComboBox_RESULTAT.Location = New System.Drawing.Point(339, 489)
        Me.ComboBox_RESULTAT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox_RESULTAT.Name = "ComboBox_RESULTAT"
        Me.ComboBox_RESULTAT.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox_RESULTAT.TabIndex = 8
        '
        'BTN_AaZ
        '
        Me.BTN_AaZ.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_AaZ.Location = New System.Drawing.Point(125, 495)
        Me.BTN_AaZ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_AaZ.Name = "BTN_AaZ"
        Me.BTN_AaZ.Size = New System.Drawing.Size(83, 33)
        Me.BTN_AaZ.TabIndex = 11
        Me.BTN_AaZ.Text = "A à Z"
        Me.BTN_AaZ.UseVisualStyleBackColor = True
        '
        'BTN_TRI_ASC
        '
        Me.BTN_TRI_ASC.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_TRI_ASC.Location = New System.Drawing.Point(547, 489)
        Me.BTN_TRI_ASC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_TRI_ASC.Name = "BTN_TRI_ASC"
        Me.BTN_TRI_ASC.Size = New System.Drawing.Size(175, 39)
        Me.BTN_TRI_ASC.TabIndex = 12
        Me.BTN_TRI_ASC.Text = "Trier"
        Me.BTN_TRI_ASC.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(125, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(568, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BTN_MEILLEUR_TEMPS
        '
        Me.BTN_MEILLEUR_TEMPS.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MEILLEUR_TEMPS.Location = New System.Drawing.Point(324, 383)
        Me.BTN_MEILLEUR_TEMPS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_MEILLEUR_TEMPS.Name = "BTN_MEILLEUR_TEMPS"
        Me.BTN_MEILLEUR_TEMPS.Size = New System.Drawing.Size(159, 64)
        Me.BTN_MEILLEUR_TEMPS.TabIndex = 14
        Me.BTN_MEILLEUR_TEMPS.Text = "Meilleur Temps"
        Me.BTN_MEILLEUR_TEMPS.UseVisualStyleBackColor = True
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Location = New System.Drawing.Point(733, 229)
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(21, 244)
        Me.VScrollBar2.TabIndex = 10
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(273, 229)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(21, 244)
        Me.VScrollBar1.TabIndex = 9
        '
        'AccueilBindingSource
        '
        Me.AccueilBindingSource.DataSource = GetType(Projet_IHM_Taquin_cylindrique.Accueil)
        '
        'Récapitulatif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 592)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTN_MEILLEUR_TEMPS)
        Me.Controls.Add(Me.BTN_TRI_ASC)
        Me.Controls.Add(Me.BTN_AaZ)
        Me.Controls.Add(Me.VScrollBar2)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.ComboBox_RESULTAT)
        Me.Controls.Add(Me.BTN_STATS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_ACCUEIL)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Récapitulatif"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Récapitulatif"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccueilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents AccueilBindingSource As BindingSource
    Friend WithEvents BTN_ACCUEIL As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_STATS As Button
    Friend WithEvents ComboBox_RESULTAT As ComboBox
    Friend WithEvents BTN_AaZ As Button
    Friend WithEvents BTN_TRI_ASC As Button
    Friend WithEvents BTN_MEILLEUR_TEMPS As Button
    Friend WithEvents VScrollBar2 As VScrollBar
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
