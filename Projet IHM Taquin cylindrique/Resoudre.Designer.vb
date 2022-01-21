<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resoudre
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonGo = New System.Windows.Forms.Button()
        Me.TextBoxTexteSaisi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelWaiting = New System.Windows.Forms.Label()
        Me.TextBoxTexteRepondu = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(436, 314)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 36)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "end"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(445, 241)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(727, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Texte Repondu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Texte Saisi"
        '
        'ButtonGo
        '
        Me.ButtonGo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGo.Location = New System.Drawing.Point(436, 261)
        Me.ButtonGo.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonGo.Name = "ButtonGo"
        Me.ButtonGo.Size = New System.Drawing.Size(101, 36)
        Me.ButtonGo.TabIndex = 19
        Me.ButtonGo.Text = "Go"
        Me.ButtonGo.UseVisualStyleBackColor = True
        '
        'TextBoxTexteSaisi
        '
        Me.TextBoxTexteSaisi.Location = New System.Drawing.Point(43, 30)
        Me.TextBoxTexteSaisi.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxTexteSaisi.Multiline = True
        Me.TextBoxTexteSaisi.Name = "TextBoxTexteSaisi"
        Me.TextBoxTexteSaisi.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBoxTexteSaisi.Size = New System.Drawing.Size(347, 485)
        Me.TextBoxTexteSaisi.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(465, 201)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 25
        '
        'LabelWaiting
        '
        Me.LabelWaiting.AutoSize = True
        Me.LabelWaiting.Location = New System.Drawing.Point(492, 201)
        Me.LabelWaiting.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelWaiting.Name = "LabelWaiting"
        Me.LabelWaiting.Size = New System.Drawing.Size(0, 17)
        Me.LabelWaiting.TabIndex = 26
        '
        'TextBoxTexteRepondu
        '
        Me.TextBoxTexteRepondu.Location = New System.Drawing.Point(588, 30)
        Me.TextBoxTexteRepondu.Name = "TextBoxTexteRepondu"
        Me.TextBoxTexteRepondu.Size = New System.Drawing.Size(363, 485)
        Me.TextBoxTexteRepondu.TabIndex = 27
        Me.TextBoxTexteRepondu.Text = ""
        '
        'Resoudre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 545)
        Me.Controls.Add(Me.TextBoxTexteRepondu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelWaiting)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonGo)
        Me.Controls.Add(Me.TextBoxTexteSaisi)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Resoudre"
        Me.Text = "Resoudre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonGo As Button
    Friend WithEvents TextBoxTexteSaisi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelWaiting As Label
    Friend WithEvents TextBoxTexteRepondu As RichTextBox
End Class
