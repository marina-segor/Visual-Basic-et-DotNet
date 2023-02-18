Imports System

Module Program
    Sub Main(args As String())

#Region "Fonctionnement Console"

        ' #####################
        ' # M�thode Affichage #
        ' #####################


        ' # M�thode Write de la Class console pour afficher une chaine sans retour � la ligne ensuite
        Console.Write("Bla")
        Console.Write("Bla")
        Console.Write("Bla")

        ' # M�thode WriteLine de la Class console pour afficher une chaine avec retour � la ligne ensuite
        Console.WriteLine("Prise en main de la console (ConsoleWriteline)...")

        ' ###################################
        ' # R�cup�ration saisie Utilisateur #
        ' ###################################

        Dim prenom As String

        ' # Read() R�cuper le flux entrant standard et le retourne
        ' prenom = Console.Read() ' A eviter

        ' # ReadLine() R�cuper le flux entrant standard et le retourne une chaine de caract�re (String)
        Console.Write("Veuillez saisir votre pr�nom : ")
        prenom = Console.ReadLine()
        Console.WriteLine(prenom)
        Console.Write("Saisis ton �ge d'aujourd'hui et je te dis quel �ge tu auras dans un an : ")

        Dim age As Integer

        age = Convert.ToInt32(Console.ReadLine())

        age += 1

        Console.Write("Votre age est de : ")
        Console.WriteLine(age)
        Console.Write("Type de la variable age : ")
        Console.WriteLine(age.GetType().ToString)

#End Region

#Region "Concat�nation"
        Console.WriteLine(vbTab & "Mon pr�nom est " + prenom + " et mon age est de " + age.ToString + " ans." & vbCrLf) ' Concat�nation avec op�rateur + applique a un typre chaine
        Console.WriteLine(vbTab & "Mon pr�nom est " & prenom & " et mon age est de " & age & " ans." & vbCrLf) ' Concat�nation avec op�rateur & (issu du VB)
        Console.WriteLine(vbTab & "Mon pr�nom est {0} et mon age est de {1} ans." & vbCrLf, prenom, age) ' Sucharge de la m�thode WRITELINE
        Console.WriteLine(vbTab & $"Mon pr�nom est {prenom} et mon age est de {age} ans." & vbCrLf) ' Litteraux de Gabarits


#End Region


#Region "coloration police d'affichage"
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.WriteLine("Je suis en bleu")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("je suis red")
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine("je suis cyaan")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("je suis blanc")

#End Region

#Region "Les caract�res sp�ciaux"

        Console.WriteLine("c:\repertoire\monFichier.vb")


#End Region

#Region "Mise en forme Console"
        ' vbTab pour faire une tabulation
        ' vbCrLf pour retourner � la ligne
#End Region

#Region "DateTime"
        Dim DateTime As Date = DateTime.Now

        Console.WriteLine(vbCrLf & "On est le {0:d} et il est {0:t}", DateTime)


#End Region


        Console.WriteLine("Appuyez sur une touche pour fermer le programme...")
        Console.ReadKey()
    End Sub
End Module

