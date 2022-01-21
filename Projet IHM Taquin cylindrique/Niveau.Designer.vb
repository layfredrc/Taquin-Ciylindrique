<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Niveau
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Niveau))
        Me.BTN_NOOB = New System.Windows.Forms.Button()
        Me.BTN_ESPORT = New System.Windows.Forms.Button()
        Me.BTN_GOD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_STANDARD = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_NOOB
        '
        Me.BTN_NOOB.BackColor = System.Drawing.Color.PaleGreen
        Me.BTN_NOOB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_NOOB.Font = New System.Drawing.Font("OCR A Extended", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NOOB.Location = New System.Drawing.Point(43, 128)
        Me.BTN_NOOB.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_NOOB.Name = "BTN_NOOB"
        Me.BTN_NOOB.Size = New System.Drawing.Size(356, 52)
        Me.BTN_NOOB.TabIndex = 5
        Me.BTN_NOOB.Text = "NOOB"
        Me.BTN_NOOB.UseVisualStyleBackColor = False
        '
        'BTN_ESPORT
        '
        Me.BTN_ESPORT.BackColor = System.Drawing.Color.RoyalBlue
        Me.BTN_ESPORT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ESPORT.Font = New System.Drawing.Font("OCR A Extended", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ESPORT.Location = New System.Drawing.Point(43, 295)
        Me.BTN_ESPORT.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_ESPORT.Name = "BTN_ESPORT"
        Me.BTN_ESPORT.Size = New System.Drawing.Size(356, 58)
        Me.BTN_ESPORT.TabIndex = 6
        Me.BTN_ESPORT.Text = "E-SPORT PRO GAMER"
        Me.BTN_ESPORT.UseVisualStyleBackColor = False
        '
        'BTN_GOD
        '
        Me.BTN_GOD.BackColor = System.Drawing.Color.Red
        Me.BTN_GOD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_GOD.Font = New System.Drawing.Font("OCR A Extended", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GOD.Location = New System.Drawing.Point(43, 381)
        Me.BTN_GOD.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_GOD.Name = "BTN_GOD"
        Me.BTN_GOD.Size = New System.Drawing.Size(356, 55)
        Me.BTN_GOD.TabIndex = 7
        Me.BTN_GOD.Text = "GOD TIER"
        Me.BTN_GOD.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(60, 41)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(325, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'BTN_STANDARD
        '
        Me.BTN_STANDARD.BackColor = System.Drawing.SystemColors.ControlText
        Me.BTN_STANDARD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_STANDARD.Font = New System.Drawing.Font("OCR A Extended", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_STANDARD.ForeColor = System.Drawing.SystemColors.Control
        Me.BTN_STANDARD.Location = New System.Drawing.Point(43, 212)
        Me.BTN_STANDARD.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_STANDARD.Name = "BTN_STANDARD"
        Me.BTN_STANDARD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BTN_STANDARD.Size = New System.Drawing.Size(356, 53)
        Me.BTN_STANDARD.TabIndex = 9
        Me.BTN_STANDARD.Text = "STANDARD"
        Me.BTN_STANDARD.UseVisualStyleBackColor = False
        '
        'Niveau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 479)
        Me.Controls.Add(Me.BTN_STANDARD)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTN_GOD)
        Me.Controls.Add(Me.BTN_ESPORT)
        Me.Controls.Add(Me.BTN_NOOB)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Niveau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Niveau"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_NOOB As Button
    Friend WithEvents BTN_ESPORT As Button
    Friend WithEvents BTN_GOD As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_STANDARD As Button
End Class
