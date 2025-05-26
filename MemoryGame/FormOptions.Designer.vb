<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOptions))
        Me.rbBalatro = New System.Windows.Forms.RadioButton()
        Me.rbSkyrim = New System.Windows.Forms.RadioButton()
        Me.gbCartes = New System.Windows.Forms.GroupBox()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.gbTemps = New System.Windows.Forms.GroupBox()
        Me.rb90 = New System.Windows.Forms.RadioButton()
        Me.rb60 = New System.Windows.Forms.RadioButton()
        Me.rb30 = New System.Windows.Forms.RadioButton()
        Me.gbCartes.SuspendLayout()
        Me.gbTemps.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbBalatro
        '
        Me.rbBalatro.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbBalatro.AutoSize = True
        Me.rbBalatro.Checked = True
        Me.rbBalatro.Location = New System.Drawing.Point(6, 19)
        Me.rbBalatro.Name = "rbBalatro"
        Me.rbBalatro.Size = New System.Drawing.Size(91, 17)
        Me.rbBalatro.TabIndex = 0
        Me.rbBalatro.TabStop = True
        Me.rbBalatro.Text = "Cartes Balatro"
        Me.rbBalatro.UseVisualStyleBackColor = True
        '
        'rbSkyrim
        '
        Me.rbSkyrim.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rbSkyrim.AutoSize = True
        Me.rbSkyrim.Location = New System.Drawing.Point(6, 42)
        Me.rbSkyrim.Name = "rbSkyrim"
        Me.rbSkyrim.Size = New System.Drawing.Size(89, 17)
        Me.rbSkyrim.TabIndex = 1
        Me.rbSkyrim.Text = "Cartes Skyrim"
        Me.rbSkyrim.UseVisualStyleBackColor = True
        '
        'gbCartes
        '
        Me.gbCartes.Controls.Add(Me.rbBalatro)
        Me.gbCartes.Controls.Add(Me.rbSkyrim)
        Me.gbCartes.Location = New System.Drawing.Point(12, 12)
        Me.gbCartes.Name = "gbCartes"
        Me.gbCartes.Size = New System.Drawing.Size(311, 105)
        Me.gbCartes.TabIndex = 2
        Me.gbCartes.TabStop = False
        Me.gbCartes.Text = "Choix des cartes"
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(248, 252)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(75, 23)
        Me.btnRetour.TabIndex = 3
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'gbTemps
        '
        Me.gbTemps.Controls.Add(Me.rb90)
        Me.gbTemps.Controls.Add(Me.rb60)
        Me.gbTemps.Controls.Add(Me.rb30)
        Me.gbTemps.Location = New System.Drawing.Point(12, 138)
        Me.gbTemps.Name = "gbTemps"
        Me.gbTemps.Size = New System.Drawing.Size(200, 100)
        Me.gbTemps.TabIndex = 4
        Me.gbTemps.TabStop = False
        Me.gbTemps.Text = "Choix du temps"
        '
        'rb90
        '
        Me.rb90.AutoSize = True
        Me.rb90.Location = New System.Drawing.Point(6, 66)
        Me.rb90.Name = "rb90"
        Me.rb90.Size = New System.Drawing.Size(120, 17)
        Me.rb90.TabIndex = 2
        Me.rb90.Text = "90 secondes (facile)"
        Me.rb90.UseVisualStyleBackColor = True
        '
        'rb60
        '
        Me.rb60.AutoSize = True
        Me.rb60.Checked = True
        Me.rb60.Location = New System.Drawing.Point(6, 43)
        Me.rb60.Name = "rb60"
        Me.rb60.Size = New System.Drawing.Size(143, 17)
        Me.rb60.TabIndex = 1
        Me.rb60.TabStop = True
        Me.rb60.Text = "60 secondes (par défaut)"
        Me.rb60.UseVisualStyleBackColor = True
        '
        'rb30
        '
        Me.rb30.AutoSize = True
        Me.rb30.Location = New System.Drawing.Point(7, 20)
        Me.rb30.Name = "rb30"
        Me.rb30.Size = New System.Drawing.Size(127, 17)
        Me.rb30.TabIndex = 0
        Me.rb30.Text = "30 secondes (difficile)"
        Me.rb30.UseVisualStyleBackColor = True
        '
        'FormOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 287)
        Me.Controls.Add(Me.gbTemps)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.gbCartes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.gbCartes.ResumeLayout(False)
        Me.gbCartes.PerformLayout()
        Me.gbTemps.ResumeLayout(False)
        Me.gbTemps.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rbBalatro As RadioButton
    Friend WithEvents rbSkyrim As RadioButton
    Friend WithEvents gbCartes As GroupBox
    Friend WithEvents btnRetour As Button
    Friend WithEvents gbTemps As GroupBox
    Friend WithEvents rb90 As RadioButton
    Friend WithEvents rb60 As RadioButton
    Friend WithEvents rb30 As RadioButton
End Class
