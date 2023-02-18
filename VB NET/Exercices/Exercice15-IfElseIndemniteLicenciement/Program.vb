Imports System
Imports System.Text

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 15 #
        ' ###############

        Console.OutputEncoding = Encoding.UTF8
        Console.WriteLine(vbCrLf & " --- Quelle sera le montant de l'indemnit� de licenciement ? --- " & vbCrLf)


        ' #  D�claration des variables globale � la classe
        Dim salaire As Integer, age, anciennete
        Dim indemnite As Double = 0


        ' #  R�cup�ration saisies utilisateur

        Console.Write(" Merci de saisir le dernier salaire (en �): ")
        salaire = Convert.ToInt32(Console.ReadLine())

        Console.Write(" Merci de saisir votre �ge : ")
        age = Convert.ToInt32(Console.ReadLine())

        Console.Write(" Merci de saisir le nombre d'ann�es d'anciennet� : ")
        anciennete = Convert.ToInt32(Console.ReadLine())



        ' #  Indemnit� li�e � l'anciennet�
        Console.WriteLine(" ")

        If anciennete >= 1 And anciennete <= 10 Then
            indemnite += anciennete * salaire / 2
        ElseIf (anciennete > 10) Then
            indemnite += 10 * salaire / 2
            indemnite += (anciennete - 10) * salaire
        End If


        ' #  Indemnit� li�e � l'age du salari�
        If anciennete >= 1 And age > 45 Then
            If age >= 50 Then
                indemnite += 5 * salaire
            Else
                indemnite += 2 * salaire
            End If
        End If


        ' #  Affichage de r�sultats
        Console.WriteLine(" Votre indemnit� est de : " + indemnite.ToString + " �" & vbCrLf)




        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
