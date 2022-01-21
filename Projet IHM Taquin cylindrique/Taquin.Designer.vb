<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Taquin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Taquin))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_NOM = New System.Windows.Forms.Label()
        Me.BTN_ABANDON = New System.Windows.Forms.Button()
        Me.LBL_TEMPS = New System.Windows.Forms.Label()
        Me.BTN_16 = New System.Windows.Forms.Button()
        Me.BTN_15 = New System.Windows.Forms.Button()
        Me.BTN_14 = New System.Windows.Forms.Button()
        Me.BTN_12 = New System.Windows.Forms.Button()
        Me.BTN_11 = New System.Windows.Forms.Button()
        Me.BTN_10 = New System.Windows.Forms.Button()
        Me.BTN_9 = New System.Windows.Forms.Button()
        Me.BTN_8 = New System.Windows.Forms.Button()
        Me.BTN_7 = New System.Windows.Forms.Button()
        Me.BTN_6 = New System.Windows.Forms.Button()
        Me.BTN_5 = New System.Windows.Forms.Button()
        Me.BTN_4 = New System.Windows.Forms.Button()
        Me.BTN_3 = New System.Windows.Forms.Button()
        Me.BTN_2 = New System.Windows.Forms.Button()
        Me.BTN_1 = New System.Windows.Forms.Button()
        Me.LBL_CHRONO = New System.Windows.Forms.Label()
        Me.lblNbClicks = New System.Windows.Forms.Label()
        Me.LBL_NBCLICKS = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BTN_EXE = New System.Windows.Forms.Button()
        Me.BTN_13 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'LBL_NOM
        '
        Me.LBL_NOM.AutoSize = True
        Me.LBL_NOM.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NOM.Location = New System.Drawing.Point(583, 68)
        Me.LBL_NOM.Name = "LBL_NOM"
        Me.LBL_NOM.Size = New System.Drawing.Size(46, 23)
        Me.LBL_NOM.TabIndex = 0
        Me.LBL_NOM.Text = "NOM"
        '
        'BTN_ABANDON
        '
        Me.BTN_ABANDON.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ABANDON.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTN_ABANDON.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ABANDON.Location = New System.Drawing.Point(545, 421)
        Me.BTN_ABANDON.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BTN_ABANDON.Name = "BTN_ABANDON"
        Me.BTN_ABANDON.Size = New System.Drawing.Size(161, 41)
        Me.BTN_ABANDON.TabIndex = 17
        Me.BTN_ABANDON.Text = "ABANDONNER"
        Me.BTN_ABANDON.UseVisualStyleBackColor = True
        '
        'LBL_TEMPS
        '
        Me.LBL_TEMPS.AutoSize = True
        Me.LBL_TEMPS.Font = New System.Drawing.Font("OCR A Extended", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TEMPS.Location = New System.Drawing.Point(743, 68)
        Me.LBL_TEMPS.Name = "LBL_TEMPS"
        Me.LBL_TEMPS.Size = New System.Drawing.Size(54, 25)
        Me.LBL_TEMPS.TabIndex = 18
        Me.LBL_TEMPS.Text = "500"
        '
        'BTN_16
        '
        Me.BTN_16.BackColor = System.Drawing.Color.Orange
        Me.BTN_16.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_16.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_16.FlatAppearance.BorderSize = 4
        Me.BTN_16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_16.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_16.ForeColor = System.Drawing.Color.Black
        Me.BTN_16.Location = New System.Drawing.Point(328, 262)
        Me.BTN_16.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_16.Name = "BTN_16"
        Me.BTN_16.Size = New System.Drawing.Size(96, 76)
        Me.BTN_16.TabIndex = 50
        Me.BTN_16.UseVisualStyleBackColor = False
        '
        'BTN_15
        '
        Me.BTN_15.BackColor = System.Drawing.Color.Orange
        Me.BTN_15.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_15.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_15.FlatAppearance.BorderSize = 4
        Me.BTN_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_15.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_15.ForeColor = System.Drawing.Color.Black
        Me.BTN_15.Location = New System.Drawing.Point(287, 329)
        Me.BTN_15.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_15.Name = "BTN_15"
        Me.BTN_15.Size = New System.Drawing.Size(96, 76)
        Me.BTN_15.TabIndex = 49
        Me.BTN_15.Text = "15"
        Me.BTN_15.UseVisualStyleBackColor = False
        '
        'BTN_14
        '
        Me.BTN_14.BackColor = System.Drawing.Color.Orange
        Me.BTN_14.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_14.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_14.FlatAppearance.BorderSize = 4
        Me.BTN_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_14.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_14.ForeColor = System.Drawing.Color.Black
        Me.BTN_14.Location = New System.Drawing.Point(183, 329)
        Me.BTN_14.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_14.Name = "BTN_14"
        Me.BTN_14.Size = New System.Drawing.Size(96, 76)
        Me.BTN_14.TabIndex = 48
        Me.BTN_14.Text = "14"
        Me.BTN_14.UseVisualStyleBackColor = False
        '
        'BTN_12
        '
        Me.BTN_12.BackColor = System.Drawing.Color.Orange
        Me.BTN_12.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_12.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_12.FlatAppearance.BorderSize = 4
        Me.BTN_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_12.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_12.ForeColor = System.Drawing.Color.Black
        Me.BTN_12.Location = New System.Drawing.Point(328, 178)
        Me.BTN_12.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_12.Name = "BTN_12"
        Me.BTN_12.Size = New System.Drawing.Size(96, 76)
        Me.BTN_12.TabIndex = 46
        Me.BTN_12.Text = "12"
        Me.BTN_12.UseVisualStyleBackColor = False
        '
        'BTN_11
        '
        Me.BTN_11.BackColor = System.Drawing.Color.Orange
        Me.BTN_11.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_11.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_11.FlatAppearance.BorderSize = 4
        Me.BTN_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_11.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_11.ForeColor = System.Drawing.Color.Black
        Me.BTN_11.Location = New System.Drawing.Point(287, 245)
        Me.BTN_11.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_11.Name = "BTN_11"
        Me.BTN_11.Size = New System.Drawing.Size(96, 76)
        Me.BTN_11.TabIndex = 45
        Me.BTN_11.Text = "11"
        Me.BTN_11.UseVisualStyleBackColor = False
        '
        'BTN_10
        '
        Me.BTN_10.BackColor = System.Drawing.Color.Orange
        Me.BTN_10.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_10.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_10.FlatAppearance.BorderSize = 4
        Me.BTN_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_10.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_10.ForeColor = System.Drawing.Color.Black
        Me.BTN_10.Location = New System.Drawing.Point(183, 245)
        Me.BTN_10.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_10.Name = "BTN_10"
        Me.BTN_10.Size = New System.Drawing.Size(96, 76)
        Me.BTN_10.TabIndex = 44
        Me.BTN_10.Text = "10"
        Me.BTN_10.UseVisualStyleBackColor = False
        '
        'BTN_9
        '
        Me.BTN_9.BackColor = System.Drawing.Color.Orange
        Me.BTN_9.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_9.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_9.FlatAppearance.BorderSize = 4
        Me.BTN_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_9.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_9.ForeColor = System.Drawing.Color.Black
        Me.BTN_9.Location = New System.Drawing.Point(79, 245)
        Me.BTN_9.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_9.Name = "BTN_9"
        Me.BTN_9.Size = New System.Drawing.Size(96, 76)
        Me.BTN_9.TabIndex = 43
        Me.BTN_9.Text = "9"
        Me.BTN_9.UseVisualStyleBackColor = False
        '
        'BTN_8
        '
        Me.BTN_8.BackColor = System.Drawing.Color.Orange
        Me.BTN_8.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_8.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_8.FlatAppearance.BorderSize = 4
        Me.BTN_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_8.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_8.ForeColor = System.Drawing.Color.Black
        Me.BTN_8.Location = New System.Drawing.Point(391, 162)
        Me.BTN_8.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_8.Name = "BTN_8"
        Me.BTN_8.Size = New System.Drawing.Size(96, 76)
        Me.BTN_8.TabIndex = 42
        Me.BTN_8.Text = "8"
        Me.BTN_8.UseVisualStyleBackColor = False
        '
        'BTN_7
        '
        Me.BTN_7.BackColor = System.Drawing.Color.Orange
        Me.BTN_7.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_7.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_7.FlatAppearance.BorderSize = 4
        Me.BTN_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_7.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_7.ForeColor = System.Drawing.Color.Black
        Me.BTN_7.Location = New System.Drawing.Point(287, 162)
        Me.BTN_7.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_7.Name = "BTN_7"
        Me.BTN_7.Size = New System.Drawing.Size(96, 76)
        Me.BTN_7.TabIndex = 41
        Me.BTN_7.Text = "7"
        Me.BTN_7.UseVisualStyleBackColor = False
        '
        'BTN_6
        '
        Me.BTN_6.BackColor = System.Drawing.Color.Orange
        Me.BTN_6.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_6.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_6.FlatAppearance.BorderSize = 4
        Me.BTN_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_6.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_6.ForeColor = System.Drawing.Color.Black
        Me.BTN_6.Location = New System.Drawing.Point(183, 162)
        Me.BTN_6.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_6.Name = "BTN_6"
        Me.BTN_6.Size = New System.Drawing.Size(96, 76)
        Me.BTN_6.TabIndex = 40
        Me.BTN_6.Text = "6"
        Me.BTN_6.UseVisualStyleBackColor = False
        '
        'BTN_5
        '
        Me.BTN_5.BackColor = System.Drawing.Color.Orange
        Me.BTN_5.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_5.FlatAppearance.BorderSize = 4
        Me.BTN_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_5.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_5.ForeColor = System.Drawing.Color.Black
        Me.BTN_5.Location = New System.Drawing.Point(79, 162)
        Me.BTN_5.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_5.Name = "BTN_5"
        Me.BTN_5.Size = New System.Drawing.Size(96, 76)
        Me.BTN_5.TabIndex = 39
        Me.BTN_5.Text = "5"
        Me.BTN_5.UseVisualStyleBackColor = False
        '
        'BTN_4
        '
        Me.BTN_4.BackColor = System.Drawing.Color.Orange
        Me.BTN_4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_4.FlatAppearance.BorderSize = 4
        Me.BTN_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_4.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_4.ForeColor = System.Drawing.Color.Black
        Me.BTN_4.Location = New System.Drawing.Point(391, 78)
        Me.BTN_4.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_4.Name = "BTN_4"
        Me.BTN_4.Size = New System.Drawing.Size(96, 76)
        Me.BTN_4.TabIndex = 38
        Me.BTN_4.Text = "4"
        Me.BTN_4.UseVisualStyleBackColor = False
        '
        'BTN_3
        '
        Me.BTN_3.BackColor = System.Drawing.Color.Orange
        Me.BTN_3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_3.FlatAppearance.BorderSize = 4
        Me.BTN_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_3.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_3.ForeColor = System.Drawing.Color.Black
        Me.BTN_3.Location = New System.Drawing.Point(287, 78)
        Me.BTN_3.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_3.Name = "BTN_3"
        Me.BTN_3.Size = New System.Drawing.Size(96, 76)
        Me.BTN_3.TabIndex = 37
        Me.BTN_3.Text = "3"
        Me.BTN_3.UseVisualStyleBackColor = False
        '
        'BTN_2
        '
        Me.BTN_2.BackColor = System.Drawing.Color.Orange
        Me.BTN_2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_2.FlatAppearance.BorderSize = 4
        Me.BTN_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_2.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_2.ForeColor = System.Drawing.Color.Black
        Me.BTN_2.Location = New System.Drawing.Point(183, 78)
        Me.BTN_2.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_2.Name = "BTN_2"
        Me.BTN_2.Size = New System.Drawing.Size(96, 76)
        Me.BTN_2.TabIndex = 36
        Me.BTN_2.Text = "2"
        Me.BTN_2.UseVisualStyleBackColor = False
        '
        'BTN_1
        '
        Me.BTN_1.BackColor = System.Drawing.Color.Orange
        Me.BTN_1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_1.FlatAppearance.BorderSize = 4
        Me.BTN_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_1.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_1.ForeColor = System.Drawing.Color.Black
        Me.BTN_1.Location = New System.Drawing.Point(79, 78)
        Me.BTN_1.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_1.Name = "BTN_1"
        Me.BTN_1.Size = New System.Drawing.Size(96, 76)
        Me.BTN_1.TabIndex = 35
        Me.BTN_1.Text = "1"
        Me.BTN_1.UseVisualStyleBackColor = False
        '
        'LBL_CHRONO
        '
        Me.LBL_CHRONO.AutoSize = True
        Me.LBL_CHRONO.Font = New System.Drawing.Font("OCR A Extended", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CHRONO.Location = New System.Drawing.Point(660, 34)
        Me.LBL_CHRONO.Name = "LBL_CHRONO"
        Me.LBL_CHRONO.Size = New System.Drawing.Size(96, 25)
        Me.LBL_CHRONO.TabIndex = 51
        Me.LBL_CHRONO.Text = "CHRONO"
        '
        'lblNbClicks
        '
        Me.lblNbClicks.AutoSize = True
        Me.lblNbClicks.Font = New System.Drawing.Font("OCR A Extended", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbClicks.Location = New System.Drawing.Point(73, 437)
        Me.lblNbClicks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNbClicks.Name = "lblNbClicks"
        Me.lblNbClicks.Size = New System.Drawing.Size(278, 25)
        Me.lblNbClicks.TabIndex = 52
        Me.lblNbClicks.Text = "NOMBRE DE CLICKS : "
        '
        'LBL_NBCLICKS
        '
        Me.LBL_NBCLICKS.AutoSize = True
        Me.LBL_NBCLICKS.Font = New System.Drawing.Font("OCR A Extended", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NBCLICKS.Location = New System.Drawing.Point(356, 437)
        Me.LBL_NBCLICKS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_NBCLICKS.Name = "LBL_NBCLICKS"
        Me.LBL_NBCLICKS.Size = New System.Drawing.Size(26, 25)
        Me.LBL_NBCLICKS.TabIndex = 53
        Me.LBL_NBCLICKS.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(619, 105)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 297)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(79, 34)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(408, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 54
        '
        'BTN_EXE
        '
        Me.BTN_EXE.BackColor = System.Drawing.Color.Gold
        Me.BTN_EXE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_EXE.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTN_EXE.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXE.ForeColor = System.Drawing.Color.Tomato
        Me.BTN_EXE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_EXE.Location = New System.Drawing.Point(732, 421)
        Me.BTN_EXE.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_EXE.Name = "BTN_EXE"
        Me.BTN_EXE.Size = New System.Drawing.Size(138, 40)
        Me.BTN_EXE.TabIndex = 55
        Me.BTN_EXE.Text = "RESOUDRE"
        Me.BTN_EXE.UseVisualStyleBackColor = False
        '
        'BTN_13
        '
        Me.BTN_13.BackColor = System.Drawing.Color.Orange
        Me.BTN_13.Cursor = System.Windows.Forms.Cursors.Cross
        Me.BTN_13.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BTN_13.FlatAppearance.BorderSize = 4
        Me.BTN_13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_13.Font = New System.Drawing.Font("OCR A Extended", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_13.ForeColor = System.Drawing.Color.Black
        Me.BTN_13.Location = New System.Drawing.Point(16, 261)
        Me.BTN_13.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_13.Name = "BTN_13"
        Me.BTN_13.Size = New System.Drawing.Size(96, 76)
        Me.BTN_13.TabIndex = 47
        Me.BTN_13.Text = "13"
        Me.BTN_13.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Linen
        Me.Panel1.Controls.Add(Me.BTN_13)
        Me.Panel1.Controls.Add(Me.BTN_12)
        Me.Panel1.Controls.Add(Me.BTN_16)
        Me.Panel1.Location = New System.Drawing.Point(63, 68)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 354)
        Me.Panel1.TabIndex = 56
        '
        'Taquin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 485)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTN_EXE)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LBL_NBCLICKS)
        Me.Controls.Add(Me.lblNbClicks)
        Me.Controls.Add(Me.LBL_CHRONO)
        Me.Controls.Add(Me.BTN_15)
        Me.Controls.Add(Me.BTN_14)
        Me.Controls.Add(Me.BTN_11)
        Me.Controls.Add(Me.BTN_10)
        Me.Controls.Add(Me.BTN_9)
        Me.Controls.Add(Me.BTN_8)
        Me.Controls.Add(Me.BTN_7)
        Me.Controls.Add(Me.BTN_6)
        Me.Controls.Add(Me.BTN_5)
        Me.Controls.Add(Me.BTN_4)
        Me.Controls.Add(Me.BTN_3)
        Me.Controls.Add(Me.BTN_2)
        Me.Controls.Add(Me.BTN_1)
        Me.Controls.Add(Me.LBL_TEMPS)
        Me.Controls.Add(Me.BTN_ABANDON)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LBL_NOM)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Taquin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taquin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents LBL_NOM As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_ABANDON As Button
    Friend WithEvents LBL_TEMPS As Label
    Friend WithEvents BTN_16 As Button
    Friend WithEvents BTN_15 As Button
    Friend WithEvents BTN_14 As Button
    Friend WithEvents BTN_12 As Button
    Friend WithEvents BTN_11 As Button
    Friend WithEvents BTN_10 As Button
    Friend WithEvents BTN_9 As Button
    Friend WithEvents BTN_8 As Button
    Friend WithEvents BTN_7 As Button
    Friend WithEvents BTN_6 As Button
    Friend WithEvents BTN_5 As Button
    Friend WithEvents BTN_4 As Button
    Friend WithEvents BTN_3 As Button
    Friend WithEvents BTN_2 As Button
    Friend WithEvents BTN_1 As Button
    Friend WithEvents LBL_CHRONO As Label
    Friend WithEvents lblNbClicks As Label
    Friend WithEvents LBL_NBCLICKS As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BTN_EXE As Button
    Friend WithEvents BTN_13 As Button
    Friend WithEvents Panel1 As Panel
End Class
