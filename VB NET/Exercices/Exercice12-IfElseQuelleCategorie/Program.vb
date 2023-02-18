Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 12 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Quelle cat�gorie pour mon enfant ? --- " & vbCrLf)

        Console.Write(" Entrez l'�ge de votre enfant : ")

        Dim age As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine(" ")

        ' #  Avec If...Else... Imbriqu�es
        If age < 3 Then
            Console.WriteLine(vbCrLf & " Votre enfant est trop jeune pour pratiquer !")
        Else
            If (age >= 3 And age <= 6) Then
                Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie ""Baby"" !")
            Else

                If (age >= 7 And age <= 8) Then
                    Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie ""Poussin"" !")
                Else

                    If (age >= 9 And age <= 10) Then
                        Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie ""Pupille"" !")
                    Else

                        If (age >= 11 And age <= 12) Then
                            Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie ""Minime"" !")
                        Else

                            If (age >= 13 And age <= 17) Then
                                Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie ""Cadet"" !")
                            Else
                                Console.WriteLine(vbCrLf & " Mais ce n'est plus un enfant !")
                            End If
                        End If
                    End If
                End If
            End If
        End If



        ' #  Avec If...Else If... Else... (borne haute / borne basse)
        If age < 3 Then
            Console.WriteLine(vbCrLf & " Votre enfant est trop jeune")
        ElseIf age >= 3 And age <= 6 Then
            Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Baby")
        ElseIf age >= 7 And age <= 8 Then
            Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Poussin")
        ElseIf age >= 9 And age <= 10 Then
            Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Pupille")
        ElseIf age >= 11 And age <= 12 Then
            Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Minime")
        ElseIf age >= 13 And age < 18 Then
            Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Cadet")
        ElseIf age >= 18 Then
            Console.WriteLine(" Ce n'est plus un enfant !")
        End If


        ' #  Avec If...Else If... Else... Avec progression des valeur croissante (sans borne bass)
        If age < 3 Then
            Console.WriteLine(vbCrLf & " Votre enfant est trop jeune")
        ElseIf age <= 6 Then
            Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Baby")
        ElseIf age <= 8 Then
            Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Poussin")
        ElseIf age <= 10 Then
            Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Pupille")
        ElseIf age <= 12 Then
            Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Minime")
        ElseIf age < 18 Then
            Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Cadet")
        ElseIf age >= 18 Then
            Console.WriteLine(" Ce n'est plus un enfant !")
        End If


        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
