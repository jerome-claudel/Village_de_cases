<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Princ
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
        Me.Gbx_Grouper = New System.Windows.Forms.GroupBox()
        Me.Txt_Res = New System.Windows.Forms.TextBox()
        Me.Lbl_Evenements = New System.Windows.Forms.Label()
        Me.Btn_Total = New System.Windows.Forms.Button()
        Me.Btn_Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Gbx_Grouper
        '
        Me.Gbx_Grouper.Location = New System.Drawing.Point(24, 33)
        Me.Gbx_Grouper.Name = "Gbx_Grouper"
        Me.Gbx_Grouper.Size = New System.Drawing.Size(262, 407)
        Me.Gbx_Grouper.TabIndex = 0
        Me.Gbx_Grouper.TabStop = False
        Me.Gbx_Grouper.Text = "Restez groupir!"
        '
        'Txt_Res
        '
        Me.Txt_Res.Location = New System.Drawing.Point(307, 125)
        Me.Txt_Res.Multiline = True
        Me.Txt_Res.Name = "Txt_Res"
        Me.Txt_Res.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Res.Size = New System.Drawing.Size(270, 420)
        Me.Txt_Res.TabIndex = 1
        '
        'Lbl_Evenements
        '
        Me.Lbl_Evenements.AutoSize = True
        Me.Lbl_Evenements.Location = New System.Drawing.Point(319, 91)
        Me.Lbl_Evenements.Name = "Lbl_Evenements"
        Me.Lbl_Evenements.Size = New System.Drawing.Size(110, 13)
        Me.Lbl_Evenements.TabIndex = 2
        Me.Lbl_Evenements.Text = "Journal d'événements"
        '
        'Btn_Total
        '
        Me.Btn_Total.Location = New System.Drawing.Point(69, 459)
        Me.Btn_Total.Name = "Btn_Total"
        Me.Btn_Total.Size = New System.Drawing.Size(183, 50)
        Me.Btn_Total.TabIndex = 3
        Me.Btn_Total.Text = "Total"
        Me.Btn_Total.UseVisualStyleBackColor = True
        '
        'Btn_Quitter
        '
        Me.Btn_Quitter.Location = New System.Drawing.Point(69, 527)
        Me.Btn_Quitter.Name = "Btn_Quitter"
        Me.Btn_Quitter.Size = New System.Drawing.Size(183, 50)
        Me.Btn_Quitter.TabIndex = 4
        Me.Btn_Quitter.Text = "Quitter"
        Me.Btn_Quitter.UseVisualStyleBackColor = True
        '
        'Form_Princ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 608)
        Me.Controls.Add(Me.Btn_Quitter)
        Me.Controls.Add(Me.Btn_Total)
        Me.Controls.Add(Me.Lbl_Evenements)
        Me.Controls.Add(Me.Txt_Res)
        Me.Controls.Add(Me.Gbx_Grouper)
        Me.Name = "Form_Princ"
        Me.Text = "Un village de cases"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gbx_Grouper As GroupBox
    Friend WithEvents Txt_Res As TextBox
    Friend WithEvents Lbl_Evenements As Label
    Friend WithEvents Btn_Total As Button
    Friend WithEvents Btn_Quitter As Button
End Class
