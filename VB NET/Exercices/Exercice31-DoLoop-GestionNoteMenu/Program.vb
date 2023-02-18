Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 31 #
        ' ###############



        Dim maxNote As Double = 0, minNote = 20, moyNote = 0, noteTmp = 0
        Dim choixMenu As String
        Dim nbNote As Integer = 0


        Do
            Console.WriteLine(vbCrLf & " --- Gestion Notes avec Menu --- " & vbCrLf)
            Console.WriteLine(vbTab & "1----Saisir les notes")
            Console.WriteLine(vbTab & "2----La plus grande note")
            Console.WriteLine(vbTab & "3----La plus petite note")
            Console.WriteLine(vbTab & "4----La moyenne des notes")
            Console.WriteLine(vbTab & "0----Quitter" & vbCrLf)

            Console.ForegroundColor = ConsoleColor.DarkCyan
            Console.Write(" Faites votre choix => ")
            Console.ForegroundColor = ConsoleColor.White
            choixMenu = Console.ReadLine()


            While choixMenu <> "1" AndAlso choixMenu <> "2" AndAlso choixMenu <> "3" AndAlso choixMenu <> "4" AndAlso choixMenu <> "0"
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Erreur de saisie...")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write("Faites votre choix : ")
                choixMenu = Console.ReadLine()
            End While

            Console.Clear()

            Select Case choixMenu
                Case "1"
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine(vbCrLf & " ------ Saisir les notes ------")
                    Console.WriteLine(" (999 pour stoper la saisie)")
                    Console.WriteLine()
                    Console.ForegroundColor = ConsoleColor.White
                    Do
                        Console.Write(" Merci de saisir la note " & nbNote & " (sur /20) : ")
                        noteTmp = 0
                        If Integer.TryParse(Console.ReadLine(), noteTmp) Then
                            If noteTmp = 999 Then
                                Exit Do
                            ElseIf noteTmp > 20 Or noteTmp < 0 Then
                                Console.ForegroundColor = ConsoleColor.Red
                                Console.WriteLine(vbTab & vbTab & " Erreur de saisie, la note est sur 20 !")
                                Console.ForegroundColor = ConsoleColor.White
                                Continue Do
                            Else
                                moyNote += noteTmp
                                If noteTmp > maxNote Then maxNote = noteTmp
                                If noteTmp < minNote Then minNote = noteTmp
                                nbNote += 1
                            End If
                        Else
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine(vbTab & " Erreur de saisie, merci de saisir un chiffre/nombre! ")
                            Console.ForegroundColor = ConsoleColor.White
                            Continue Do
                        End If
                    Loop While noteTmp <> 999
                    Console.Write(vbCrLf & " Appuyez sur Enter pour retourner au menu principal...")
                    Console.ReadKey()
                    Console.Clear()

                Case "2"
                    If nbNote >= 1 Then
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine(vbCrLf & " ------ La plus grande note ------" & vbCrLf)
                        Console.WriteLine(" La note la plus grande est : " & maxNote & "/20" & vbCrLf)
                        Console.ForegroundColor = ConsoleColor.White
                    Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine(vbCrLf & " ------ La plus grande note ------" & vbCrLf)
                        Console.WriteLine(" Veuillez saisir des notes avant..." & vbCrLf)
                        Console.ForegroundColor = ConsoleColor.White
                    End If
                    Console.Write(vbCrLf & " Appuyez sur Enter pour retourner au menu principal...")
                    Console.ReadKey()
                    Console.Clear()
                Case "3"
                    If nbNote >= 1 Then
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine(vbCrLf & " ------ La plus petite note ------" & vbCrLf)
                        Console.WriteLine(" La note la plus petite est : " & minNote & "/20" & vbCrLf)
                        Console.ForegroundColor = ConsoleColor.White
                    Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine(vbCrLf & " ------ La plus petite note ------" & vbCrLf)
                        Console.WriteLine(" Veuillez saisir des notes avant..." & vbCrLf)
                        Console.ForegroundColor = ConsoleColor.White
                    End If
                    Console.Write(vbCrLf & " Appuyez sur Enter pour retourner au menu principal...")
                    Console.ReadKey()
                    Console.Clear()
                Case "4"
                    If nbNote >= 1 Then
                        Console.ForegroundColor = ConsoleColor.Cyan
                        Console.WriteLine(vbCrLf & " ------ La moyenne des notes ------" & vbCrLf)
                        moyNote = Math.Round(moyNote / nbNote, 1)
                        Console.WriteLine(" La moyenne est de : " & moyNote & "/20" & vbCrLf)
                        Console.ForegroundColor = ConsoleColor.White
                    Else
                        Console.ForegroundColor = ConsoleColor.Red
                        Console.WriteLine(vbCrLf & " ------ La moyenne des notes ------" & vbCrLf)
                        Console.WriteLine(" Veuillez saisir des notes avant..." & vbCrLf)
                        Console.ForegroundColor = ConsoleColor.White
                    End If
                    Console.Write(vbCrLf & " Appuyez sur Enter pour retourner au menu principal...")
                    Console.ReadKey()
                    Console.Clear()
                Case "0"
                    'Fermer une console
                    Environment.Exit(0)
            End Select

        Loop While choixMenu <> "0"


        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
