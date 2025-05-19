<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4Memory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4Memory))
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.labelSubtitle = New System.Windows.Forms.Label()
        Me.labelNom = New System.Windows.Forms.Label()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbNom = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTitle
        '
        Me.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.Location = New System.Drawing.Point(72, 9)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(191, 42)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "4 Memory"
        '
        'labelSubtitle
        '
        Me.labelSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelSubtitle.AutoSize = True
        Me.labelSubtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSubtitle.Location = New System.Drawing.Point(108, 51)
        Me.labelSubtitle.Name = "labelSubtitle"
        Me.labelSubtitle.Size = New System.Drawing.Size(119, 13)
        Me.labelSubtitle.TabIndex = 1
        Me.labelSubtitle.Text = "un jeu de concentration"
        '
        'labelNom
        '
        Me.labelNom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelNom.AutoSize = True
        Me.labelNom.Location = New System.Drawing.Point(11, 9)
        Me.labelNom.Name = "labelNom"
        Me.labelNom.Size = New System.Drawing.Size(93, 13)
        Me.labelNom.TabIndex = 2
        Me.labelNom.Text = "Entrez votre nom :"
        '
        'btnJouer
        '
        Me.btnJouer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnJouer.Location = New System.Drawing.Point(127, 151)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(75, 23)
        Me.btnJouer.TabIndex = 4
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOptions.Location = New System.Drawing.Point(127, 180)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(75, 23)
        Me.btnOptions.TabIndex = 5
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnScores
        '
        Me.btnScores.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnScores.Location = New System.Drawing.Point(127, 209)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(75, 23)
        Me.btnScores.TabIndex = 6
        Me.btnScores.Text = "Podium"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnQuitter.Location = New System.Drawing.Point(127, 238)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitter.TabIndex = 7
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbNom)
        Me.Panel1.Controls.Add(Me.labelNom)
        Me.Panel1.Location = New System.Drawing.Point(36, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 33)
        Me.Panel1.TabIndex = 8
        '
        'cbNom
        '
        Me.cbNom.FormattingEnabled = True
        Me.cbNom.Location = New System.Drawing.Point(110, 5)
        Me.cbNom.Name = "cbNom"
        Me.cbNom.Size = New System.Drawing.Size(147, 21)
        Me.cbNom.TabIndex = 3
        '
        'Form4Memory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 287)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.labelSubtitle)
        Me.Controls.Add(Me.labelTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4Memory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "4 Memory - Un jeu de concentration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelTitle As Label
    Friend WithEvents labelSubtitle As Label
    Friend WithEvents labelNom As Label
    Friend WithEvents btnJouer As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnScores As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbNom As ComboBox
End Class
