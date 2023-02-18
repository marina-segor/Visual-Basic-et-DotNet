Public Class Salarie

    ' propriété auto-implémentée en lecture uniquement
    Public ReadOnly Property SalarieId As Integer = 1

    ' propriété auto-implémentée lecture/écriture
    Public Property Prenom As String
    Public Property Nom As String

    ' Déclaration d'un attribut en privé
    Private _Salaire As Double

    ' Déclaration d'une propriété en lecture/écriture pour le salaire
    Public Property Salaire() As Double
        Get
            Return _Salaire
        End Get
        ' Implémentation d'une vérification lors de l'affectation
        Set(ByVal montant As Double)
            If montant > _Salaire Then
                _Salaire = montant
            End If
        End Set
    End Property

    ' Utilisation d'une procédure comme Setter
    Public Sub SetSalaire(montant As Double)
        If montant > _Salaire Then
            _Salaire = montant
        End If
    End Sub

    ' Utilisation d'une fonction comme Getter
    Public Function GetSalaire() As Double
        Return _Salaire
    End Function

    Private _Age As Integer
    Public Property Age() As Integer
        Get
            Return _Age
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                _Age = value
            Else
                Console.WriteLine("Veuillez saisir un âge > 0")
            End If
        End Set
    End Property

    ' utilsation d'une procédure pour afficher les informations du salarié
    Public Sub AfficherInformation()
        Console.WriteLine($"Identité: {Prenom} {Nom}") ' Utilisation des propriétés
        Console.WriteLine($"ID: {SalarieId}")
        Console.WriteLine($"Salaire: {_Salaire}") ' Utilisation de l'attribut privé
        Console.WriteLine($"Age: {Age}")
    End Sub

End Class
