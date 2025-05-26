<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormScores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormScores))
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.cbJoueurSelectionne = New System.Windows.Forms.ComboBox()
        Me.lbJoueurs = New System.Windows.Forms.ListBox()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnCroissant = New System.Windows.Forms.Button()
        Me.btnDecroissant = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRetour
        '
        Me.btnRetour.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRetour.Location = New System.Drawing.Point(245, 449)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(75, 23)
        Me.btnRetour.TabIndex = 0
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'cbJoueurSelectionne
        '
        Me.cbJoueurSelectionne.FormattingEnabled = True
        Me.cbJoueurSelectionne.Location = New System.Drawing.Point(12, 12)
        Me.cbJoueurSelectionne.Name = "cbJoueurSelectionne"
        Me.cbJoueurSelectionne.Size = New System.Drawing.Size(224, 21)
        Me.cbJoueurSelectionne.TabIndex = 1
        '
        'lbJoueurs
        '
        Me.lbJoueurs.FormattingEnabled = True
        Me.lbJoueurs.Location = New System.Drawing.Point(12, 39)
        Me.lbJoueurs.Name = "lbJoueurs"
        Me.lbJoueurs.Size = New System.Drawing.Size(224, 420)
        Me.lbJoueurs.TabIndex = 2
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(245, 12)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(75, 23)
        Me.btnStats.TabIndex = 3
        Me.btnStats.Text = "Voir les stats"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'btnCroissant
        '
        Me.btnCroissant.Location = New System.Drawing.Point(242, 61)
        Me.btnCroissant.Name = "btnCroissant"
        Me.btnCroissant.Size = New System.Drawing.Size(75, 23)
        Me.btnCroissant.TabIndex = 4
        Me.btnCroissant.Text = "Croissant"
        Me.btnCroissant.UseVisualStyleBackColor = True
        '
        'btnDecroissant
        '
        Me.btnDecroissant.Location = New System.Drawing.Point(242, 90)
        Me.btnDecroissant.Name = "btnDecroissant"
        Me.btnDecroissant.Size = New System.Drawing.Size(75, 23)
        Me.btnDecroissant.TabIndex = 5
        Me.btnDecroissant.Text = "Décroissant"
        Me.btnDecroissant.UseVisualStyleBackColor = True
        '
        'FormScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 484)
        Me.Controls.Add(Me.btnDecroissant)
        Me.Controls.Add(Me.btnCroissant)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.lbJoueurs)
        Me.Controls.Add(Me.cbJoueurSelectionne)
        Me.Controls.Add(Me.btnRetour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormScores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scores des joueurs"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRetour As Button
    Friend WithEvents cbJoueurSelectionne As ComboBox
    Friend WithEvents lbJoueurs As ListBox
    Friend WithEvents btnStats As Button
    Friend WithEvents btnCroissant As Button
    Friend WithEvents btnDecroissant As Button
End Class
