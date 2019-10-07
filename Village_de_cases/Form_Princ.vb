Public Class Form_Princ
    'Création de la collection
    Dim Ensemble As New Collection
    Private Sub Btn_Quitter_Click(sender As Object, e As EventArgs) Handles Btn_Quitter.Click
        Me.Close()
    End Sub
    Private Sub casAcocher_change(sender As Object, e As EventArgs)
        'Affiche dans le journal d'événements, l'action effectuée avec le checkbox cliqué
        Dim indice As Integer
        For i = 1 To Ensemble.Count
            If Ensemble.Item(i).Equals(sender) Then
                indice = i
            End If
        Next i
        If sender.checked = True Then
            Txt_Res.Text += "la case n°" & indice & " a été cochée." & vbCrLf
        Else
            Txt_Res.Text += "la case n°" & indice & " a été décochée." & vbCrLf
        End If

    End Sub

    Private Sub Form_Princ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cration d'une nouvelle collection
        'Création des contrôles checkbox dans le GroupBox Gbx_Grouper
        For index = 1 To 11
            Dim caseAcocher As New CheckBox
            Ensemble.Add(caseAcocher)
            With Ensemble.Item(index)
                .Name = "Case" & index
                .Text = "Case" & index
                .Top = 50 + index * 20
                .Left = 30
            End With
            'Association de l'événement clique de chaque checkbox à la procédure casACocher_change 
            AddHandler caseAcocher.Click, AddressOf casAcocher_change
            'on ajoute le checkbox au groupBox
            Gbx_Grouper.Controls.Add(Ensemble.Item(index))
        Next
    End Sub
    Private Sub Btn_Total_Click(sender As Object, e As EventArgs) Handles Btn_Total.Click
        'Compte le nombre de checkbox cochés sur action du bouton total
        Dim inombresCases As Integer = 0
        For i = 1 To Ensemble.Count
            If Ensemble.Item(i).checked = True Then
                inombresCases += 1
            End If
        Next i
        MsgBox("Il y a " & inombresCases & " cases cochées)", MsgBoxStyle.DefaultButton1)
    End Sub
End Class
