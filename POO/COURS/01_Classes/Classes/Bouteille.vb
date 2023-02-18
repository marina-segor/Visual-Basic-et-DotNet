Public Class Bouteille
    Public Property Volume As Double

    Protected volumeMax As Double

    Private id As Integer

    ' Accessible dans le même assemby
    Friend contenu As String

    ' Sub -> ne renvoie aucun résultat
    Public Sub Remplir(quantite As Double)
        Volume += quantite
        ' Volume = Volume + quantite
    End Sub

    Public Sub Vider(quantite As Double)
        Volume -= quantite
        ' Volume = Volume - quantite
    End Sub

    ' Function -> Renvoie un résultat avec le mot clé Return
    ' Une fonction est typée : type de retour attendu
    Public Function VolumeEnGramme() As Double
        Return Volume * 1000
    End Function


End Class
