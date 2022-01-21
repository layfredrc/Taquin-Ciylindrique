<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Aide
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PRG_BAR = New System.Windows.Forms.ToolStripProgressBar()
        Me.LBL_STATUT = New System.Windows.Forms.ToolStripTextBox()
        Me.BTN_REFR = New System.Windows.Forms.Button()
        Me.BTN_SUIV = New System.Windows.Forms.Button()
        Me.BTN_PREC = New System.Windows.Forms.Button()
        Me.BTN_ENVOYER = New System.Windows.Forms.Button()
        Me.TXT_BOXSEARCH = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PRG_BAR, Me.LBL_STATUT})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 423)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(661, 27)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PRG_BAR
        '
        Me.PRG_BAR.Name = "PRG_BAR"
        Me.PRG_BAR.Size = New System.Drawing.Size(100, 24)
        '
        'LBL_STATUT
        '
        Me.LBL_STATUT.Name = "LBL_STATUT"
        Me.LBL_STATUT.Size = New System.Drawing.Size(100, 27)
        '
        'BTN_REFR
        '
        Me.BTN_REFR.Location = New System.Drawing.Point(575, 3)
        Me.BTN_REFR.Name = "BTN_REFR"
        Me.BTN_REFR.Size = New System.Drawing.Size(85, 23)
        Me.BTN_REFR.TabIndex = 13
        Me.BTN_REFR.Text = "Rafraichir"
        Me.BTN_REFR.UseVisualStyleBackColor = True
        '
        'BTN_SUIV
        '
        Me.BTN_SUIV.Location = New System.Drawing.Point(209, 3)
        Me.BTN_SUIV.Name = "BTN_SUIV"
        Me.BTN_SUIV.Size = New System.Drawing.Size(78, 23)
        Me.BTN_SUIV.TabIndex = 12
        Me.BTN_SUIV.Text = "Suivant"
        Me.BTN_SUIV.UseVisualStyleBackColor = True
        '
        'BTN_PREC
        '
        Me.BTN_PREC.Location = New System.Drawing.Point(95, 3)
        Me.BTN_PREC.Name = "BTN_PREC"
        Me.BTN_PREC.Size = New System.Drawing.Size(89, 23)
        Me.BTN_PREC.TabIndex = 11
        Me.BTN_PREC.Text = "Précédent"
        Me.BTN_PREC.UseVisualStyleBackColor = True
        '
        'BTN_ENVOYER
        '
        Me.BTN_ENVOYER.Location = New System.Drawing.Point(575, 41)
        Me.BTN_ENVOYER.Name = "BTN_ENVOYER"
        Me.BTN_ENVOYER.Size = New System.Drawing.Size(75, 23)
        Me.BTN_ENVOYER.TabIndex = 10
        Me.BTN_ENVOYER.Text = "Envoyer"
        Me.BTN_ENVOYER.UseVisualStyleBackColor = True
        '
        'TXT_BOXSEARCH
        '
        Me.TXT_BOXSEARCH.Location = New System.Drawing.Point(95, 42)
        Me.TXT_BOXSEARCH.Name = "TXT_BOXSEARCH"
        Me.TXT_BOXSEARCH.Size = New System.Drawing.Size(454, 22)
        Me.TXT_BOXSEARCH.TabIndex = 9
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(661, 450)
        Me.WebBrowser1.TabIndex = 8
        Me.WebBrowser1.Url = New System.Uri("http://Pornhub.com", System.UriKind.Absolute)
        '
        'Timer1
        '
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(778, 38)
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.MenuStrip1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.BTN_PREC)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.BTN_ENVOYER)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.BTN_REFR)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TXT_BOXSEARCH)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.BTN_SUIV)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(661, 70)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(661, 95)
        Me.ToolStripContainer1.TabIndex = 16
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowDrop = True
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(70, 28)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'Aide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 450)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "Aide"
        Me.Text = "Aide"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents PRG_BAR As ToolStripProgressBar
    Friend WithEvents LBL_STATUT As ToolStripTextBox
    Friend WithEvents BTN_REFR As Button
    Friend WithEvents BTN_SUIV As Button
    Friend WithEvents BTN_PREC As Button
    Friend WithEvents BTN_ENVOYER As Button
    Friend WithEvents TXT_BOXSEARCH As TextBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
