Imports System

Module Program
    Sub Main(args As String())

        ' ######################
        ' # CONVERTION DE TYPE #
        ' ######################

        ' # FUNCTION #    # CONVERTI EN #
        '   CBool()          Boolean
        '   CByte()          Byte
        '   CChar()          Char
        '   CDate()          Date
        '   CDbl()           Double
        '   CDec()           Decimal
        '   CInt()           Integer
        '   CLng()           Long
        '   CObj()           Object
        '   CShort()         Short
        '   CSng()           Single
        '   CStr()           String

        Console.OutputEncoding = Text.Encoding.UTF8

        ' ##
        ' # Exemples Convertion Decimal => Entier (CInt())
        ' ##

        Dim Pi As Decimal = 3.14 ' crée la variable Pi qui vaut 3.14

        Dim Pi_Entier As Integer = CInt(Pi) ' retournera 3 (entier le plus proche)
        Console.WriteLine("Valeur approximative de π : " & Pi)
        Console.WriteLine("Valeur de π converti en entier (Integer) : " & Pi_Entier)

        ' ##
        ' # Exemples Convertion Entier => Chaine (CStr())
        ' ##

        Dim a As Integer = 15 ' crée la variable a qui vaut 15

        Dim a_caractere As String = CStr(a) ' retournera " 15 " en chaine de caractères
        Console.WriteLine("Affichage de a comme entier : " & a.ToString())
        Console.WriteLine("Affichage de a converti en chaine : " & a_caractere)


        Console.WriteLine("Appuyez sur ENTER pour fermer le programme...")
        Console.Read()
    End Sub
End Module
