Public Class WaterTank

    Public Shared PoidsAVide As Integer

    Public Shared CapaciteMaximale As Integer

    Public Shared NiveauDeRemplissage As Integer

    Public Property Citerne As String

    Public Property Remplir As String

    Public Property Vider As String

    Public Property PoidsTotal As String


    Public Sub New(citerne As String)
        PoidsAVide = 50
        CapaciteMaximale = 100
        NiveauDeRemplissage = 40
        Me.Citerne = citerne
        Remplir += 1
        Vider -= 1

    End Sub


End Class
