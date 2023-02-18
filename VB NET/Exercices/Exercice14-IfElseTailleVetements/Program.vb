Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 14 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Quelle taille dois-je prendre ? --- " & vbCrLf)


        ' #  Récupération des saisies utilisateur

        Console.Write(" Entrez votre taille (en cm) : ")
        Dim taille As Integer = Convert.ToInt32(Console.ReadLine())
        Console.Write(" Entrez votre poids (en kg) : ")
        Dim poids As Integer = Convert.ToInt32(Console.ReadLine())



        ' #  Structure conditionelle pour affichage des résultats

        Console.WriteLine(" ")
        If taille >= 145 And taille < 172 And poids >= 43 And poids <= 47 Or
            taille >= 145 And taille < 169 And poids >= 48 And poids <= 53 Or
            taille >= 145 And taille < 166 And poids >= 54 And poids <= 59 Or
            taille >= 145 And taille < 163 And poids >= 60 And poids <= 65 Then
            Console.WriteLine(" Prennez la taille 1." & vbCrLf)
        ElseIf taille >= 169 And taille < 183 And poids >= 48 And poids <= 53 Or
            taille >= 166 And taille < 178 And poids >= 54 And poids <= 59 Or
            taille >= 163 And taille < 175 And poids >= 60 And poids <= 65 Or
            taille >= 160 And taille < 172 And poids >= 66 And poids <= 71 Then
            Console.WriteLine(" Prennez la taille 2." & vbCrLf)
        ElseIf taille >= 178 And taille <= 183 And poids >= 54 And poids <= 59 Or
            taille >= 175 And taille <= 183 And poids >= 60 And poids <= 65 Or
            taille >= 172 And taille <= 183 And poids >= 66 And poids <= 71 Or
            taille >= 163 And taille <= 183 And poids >= 72 And poids <= 77 Then
            Console.WriteLine(" Prennez la taille 3." & vbCrLf)
        Else
            Console.WriteLine(" Aucune taille ne vous correspond." & vbCrLf)
        End If




        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
