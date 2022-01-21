<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BTN_JOUER = New System.Windows.Forms.Button()
        Me.BTN_QUITTER = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_RECAP = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BTN_AIDE = New System.Windows.Forms.Button()
        Me.DébutantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntermédiaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GodTierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NiveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_NIVEAU = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.Name = "ComboBox1"
        '
        'BTN_JOUER
        '
        Me.BTN_JOUER.BackColor = System.Drawing.Color.Orange
        Me.BTN_JOUER.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.BTN_JOUER, "BTN_JOUER")
        Me.BTN_JOUER.Name = "BTN_JOUER"
        Me.BTN_JOUER.UseVisualStyleBackColor = False
        '
        'BTN_QUITTER
        '
        Me.BTN_QUITTER.BackColor = System.Drawing.Color.Red
        Me.BTN_QUITTER.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.BTN_QUITTER, "BTN_QUITTER")
        Me.BTN_QUITTER.Name = "BTN_QUITTER"
        Me.BTN_QUITTER.UseVisualStyleBackColor = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'BTN_RECAP
        '
        Me.BTN_RECAP.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTN_RECAP.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.BTN_RECAP, "BTN_RECAP")
        Me.BTN_RECAP.Name = "BTN_RECAP"
        Me.BTN_RECAP.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'BTN_AIDE
        '
        Me.BTN_AIDE.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BTN_AIDE, "BTN_AIDE")
        Me.BTN_AIDE.Name = "BTN_AIDE"
        Me.BTN_AIDE.UseVisualStyleBackColor = False
        '
        'DébutantToolStripMenuItem
        '
        Me.DébutantToolStripMenuItem.Name = "DébutantToolStripMenuItem"
        resources.ApplyResources(Me.DébutantToolStripMenuItem, "DébutantToolStripMenuItem")
        '
        'IntermédiaireToolStripMenuItem
        '
        Me.IntermédiaireToolStripMenuItem.Name = "IntermédiaireToolStripMenuItem"
        resources.ApplyResources(Me.IntermédiaireToolStripMenuItem, "IntermédiaireToolStripMenuItem")
        '
        'ProToolStripMenuItem
        '
        Me.ProToolStripMenuItem.Name = "ProToolStripMenuItem"
        resources.ApplyResources(Me.ProToolStripMenuItem, "ProToolStripMenuItem")
        '
        'GodTierToolStripMenuItem
        '
        Me.GodTierToolStripMenuItem.Name = "GodTierToolStripMenuItem"
        resources.ApplyResources(Me.GodTierToolStripMenuItem, "GodTierToolStripMenuItem")
        '
        'NiveauToolStripMenuItem
        '
        Me.NiveauToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DébutantToolStripMenuItem, Me.IntermédiaireToolStripMenuItem, Me.ProToolStripMenuItem, Me.GodTierToolStripMenuItem})
        Me.NiveauToolStripMenuItem.Name = "NiveauToolStripMenuItem"
        resources.ApplyResources(Me.NiveauToolStripMenuItem, "NiveauToolStripMenuItem")
        '
        'BTN_NIVEAU
        '
        Me.BTN_NIVEAU.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BTN_NIVEAU, "BTN_NIVEAU")
        Me.BTN_NIVEAU.Name = "BTN_NIVEAU"
        Me.BTN_NIVEAU.UseVisualStyleBackColor = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Name = "Label3"
        '
        'Accueil
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_NIVEAU)
        Me.Controls.Add(Me.BTN_AIDE)
        Me.Controls.Add(Me.BTN_RECAP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_QUITTER)
        Me.Controls.Add(Me.BTN_JOUER)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Accueil"
        Me.ShowInTaskbar = False
        Me.TransparencyKey = System.Drawing.Color.Lime
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BTN_JOUER As Button
    Friend WithEvents BTN_QUITTER As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_RECAP As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BTN_AIDE As Button
    Friend WithEvents DébutantToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntermédiaireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GodTierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NiveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTN_NIVEAU As Button
    Friend WithEvents Label3 As Label
End Class
