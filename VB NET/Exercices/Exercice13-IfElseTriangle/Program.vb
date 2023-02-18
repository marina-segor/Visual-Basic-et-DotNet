Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 13 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Quelle est la nature du triangle ABC ? --- " & vbCrLf)

        ' #  Récupération des saisies utilisateur

        Console.Write(" Entrez la longeur du segment AB (en cm) : ")
        Dim longeurAB As Double = Convert.ToDouble(Console.ReadLine())
        Console.Write(" Entrez la longeur du segment BC (en cm) : ")
        Dim longeurBC As Double = Convert.ToDouble(Console.ReadLine())
        Console.Write(" Entrez la longeur du segment CA (en cm) : ")
        Dim longeurAC As Double = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine(" ")


        ' #  If... Else Imbriquées

        If longeurAB = longeurBC And longeurAB = longeurAC Then
            Console.WriteLine(" Le triangle est équilatéral." & vbCrLf)
        Else
            If (longeurAB = longeurAC) Then
                Console.WriteLine(" Le triangle est isocèle en A mais n'est pas équilatéral." & vbCrLf)
            Else
                If (longeurAB = longeurBC) Then
                    Console.WriteLine(" Le triangle est isocèle en B mais n'est pas équilatéral." & vbCrLf)
                Else
                    If (longeurBC = longeurAC) Then
                        Console.WriteLine(" Le triangle est isocèle en C mais n'est pas équilatéral." & vbCrLf)
                    Else
                        Console.WriteLine(" Le triangle n'est isocèle ni en A, ni en B, ni en C." & vbCrLf)
                    End If
                End If
            End If
        End If



        ' #  If... Else If ... Else
        If longeurAB = longeurBC And longeurAB = longeurAC Then
            Console.WriteLine(" Le triangle est équilatéral." & vbCrLf)
        ElseIf (longeurAB = longeurAC) Then
            Console.WriteLine(" Le triangle est isocèle en A mais n'est pas équilatéral." & vbCrLf)
        ElseIf (longeurAB = longeurBC) Then
            Console.WriteLine(" Le triangle est isocèle en B mais n'est pas équilatéral." & vbCrLf)
        ElseIf (longeurBC = longeurAC) Then
            Console.WriteLine(" Le triangle est isocèle en C mais n'est pas équilatéral." & vbCrLf)
        Else
            Console.WriteLine(" Le triangle n'est isocèle ni en A, ni en B, ni en C." & vbCrLf)
        End If


        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
