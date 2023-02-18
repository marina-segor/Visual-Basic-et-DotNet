Public Class Chien

    Public Shared nombreChiens As Integer

    Public Shared Property NomLatin As String

    Public Property Nom As String

    Public Sub New(nom As String)
        nombreChiens += 1
        Me.Nom = nom
    End Sub

    Public Shared Function AgeHumainVersChien(ageHumain As Integer)
        Return ageHumain * 5 ' Ce calcul n'est pas représentatif de la réalité
    End Function


End Class
