Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 13 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Quelle est la nature du triangle ABC ? --- " & vbCrLf)

        ' #  R�cup�ration des saisies utilisateur

        Console.Write(" Entrez la longeur du segment AB (en cm) : ")
        Dim longeurAB As Double = Convert.ToDouble(Console.ReadLine())
        Console.Write(" Entrez la longeur du segment BC (en cm) : ")
        Dim longeurBC As Double = Convert.ToDouble(Console.ReadLine())
        Console.Write(" Entrez la longeur du segment CA (en cm) : ")
        Dim longeurAC As Double = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine(" ")


        ' #  If... Else Imbriqu�es

        If longeurAB = longeurBC And longeurAB = longeurAC Then
            Console.WriteLine(" Le triangle est �quilat�ral." & vbCrLf)
        Else
            If (longeurAB = longeurAC) Then
                Console.WriteLine(" Le triangle est isoc�le en A mais n'est pas �quilat�ral." & vbCrLf)
            Else
                If (longeurAB = longeurBC) Then
                    Console.WriteLine(" Le triangle est isoc�le en B mais n'est pas �quilat�ral." & vbCrLf)
                Else
                    If (longeurBC = longeurAC) Then
                        Console.WriteLine(" Le triangle est isoc�le en C mais n'est pas �quilat�ral." & vbCrLf)
                    Else
                        Console.WriteLine(" Le triangle n'est isoc�le ni en A, ni en B, ni en C." & vbCrLf)
                    End If
                End If
            End If
        End If



        ' #  If... Else If ... Else
        If longeurAB = longeurBC And longeurAB = longeurAC Then
            Console.WriteLine(" Le triangle est �quilat�ral." & vbCrLf)
        ElseIf (longeurAB = longeurAC) Then
            Console.WriteLine(" Le triangle est isoc�le en A mais n'est pas �quilat�ral." & vbCrLf)
        ElseIf (longeurAB = longeurBC) Then
            Console.WriteLine(" Le triangle est isoc�le en B mais n'est pas �quilat�ral." & vbCrLf)
        ElseIf (longeurBC = longeurAC) Then
            Console.WriteLine(" Le triangle est isoc�le en C mais n'est pas �quilat�ral." & vbCrLf)
        Else
            Console.WriteLine(" Le triangle n'est isoc�le ni en A, ni en B, ni en C." & vbCrLf)
        End If


        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
