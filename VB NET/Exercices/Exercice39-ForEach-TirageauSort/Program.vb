Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 39 #
        ' ###############


#Region "Declaration of variables"
        Dim Origine As String() = New String() {"Ahmad", "Anuradha", "Dorian", "Gil Christ", "Marina", "Medhi", "Mossaab", "Nourou", "Olivier", "Rashid", "Serena", "Tahya", "Yehia", "Yassine", "Nicolas"}
        Dim Tiree As String() = New String(Origine.Length) {}
        Dim compteur As Integer = 0
        Dim chaine As String = ""
        Dim r As New Random()
        Dim choix As String
#End Region

        Do
            Console.WriteLine(vbCrLf & vbTab & " --- Le grand tirage au sort --- " & vbCrLf)

            Console.WriteLine(vbTab & "1-- Effectuer un tirage ")
            Console.WriteLine(vbTab & "2-- Liste des personnes déjà tirées")
            Console.WriteLine(vbTab & "3-- Liste des personnes restantes")
            Console.WriteLine(vbCrLf & vbTab & "0--- Quitter")

            choix = "-1"
            While Not {"0", "1", "2", "3"}.Contains(choix)
                Console.Write(vbCrLf & vbTab & "Votre choix (0,1,2,3) => ")
                choix = Console.ReadLine()
            End While

            Console.Clear()

            Select Case choix
                Case "1"
                    If compteur < Origine.Length Then
                        Dim element As String
                        Dim index As Integer

                        chaine = ""
                        Do
                            index = r.Next(Origine.Length)
                            element = Origine(index)
                        Loop While element Is Nothing

                        For Each c As Char In element
                            chaine += "*"
                        Next

                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine(vbCrLf & $" **********************************{chaine}")
                        Console.WriteLine($" ***** L'heureux gagnant est {element} *****")
                        Console.WriteLine($" **********************************{chaine}" & vbCrLf)
                        Console.ForegroundColor = ConsoleColor.White

                        Tiree(compteur) = element
                        compteur += 1
                        Origine(index) = Nothing
                    Else
                        compteur = 0
                        For i As Integer = 0 To Origine.Length - 1
                            Origine(i) = Tiree(i)
                            Tiree(i) = Nothing
                        Next
                    End If
                Case "2"
                    chaine = ""
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine(vbCrLf & " *******************************************")
                    Console.WriteLine(" ***** Liste des personnes déjà tirées *****")
                    Console.WriteLine(" *******************************************" & vbCrLf)

                    Console.ForegroundColor = ConsoleColor.White
                    If compteur > 0 Then
                        For Each nom As String In Tiree
                            If nom IsNot Nothing Then
                                Console.WriteLine(" " & chaine & nom)
                                chaine &= " "
                            End If
                        Next
                    Else
                        Console.WriteLine(vbCrLf & vbCrLf & " Aucune personne dans la liste," & vbCrLf & vbCrLf & vbTab & "Veuillez faire un tirage..." & vbCrLf & vbCrLf)
                    End If
                    Console.ForegroundColor = ConsoleColor.DarkGray
                    Console.WriteLine(vbCrLf & " Appuyez sur ENTREE pour retourner au menu principal...")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.Read()
                    Console.Clear()
                    Exit Select
                Case "3"
                    chaine = ""
                    Console.ForegroundColor = ConsoleColor.Cyan
                    Console.WriteLine(vbCrLf & " *************************************************")
                    Console.WriteLine(" ***** N'ont pas encore fait de correction : *****")
                    Console.WriteLine(" *************************************************" & vbCrLf)
                    Console.ForegroundColor = ConsoleColor.White
                    For Each nom As String In Origine
                        If nom IsNot Nothing Then
                            Console.WriteLine(" " & chaine & nom)
                            chaine &= "   "
                        End If
                    Next
                    Console.ForegroundColor = ConsoleColor.DarkGray
                    Console.WriteLine(vbCrLf & " Appuyez sur ENTREE pour retourner au menu principal...")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.Read()
                    Console.Clear()
                    Exit Select
            End Select
        Loop Until choix = "0"
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.ForegroundColor = ConsoleColor.White
        Console.Read()
    End Sub
End Module
