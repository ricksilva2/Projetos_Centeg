Imports System
Public Class Gato
 Public Raca As String
 Public acoes As String

Public Sub Miar()
    Console.WriteLine("Miauu")
End Sub
End Class    
Module Program
    Sub Main(args As String())
        Dim Gato As new Gato()
        Gato.Raca = "Tigreso"
        Gato.acoes = "arranhar"
        Console.WriteLine(Gato.Raca)
        Console.WriteLine(Gato.acoes)
        Gato.Miar()
    End Sub
End Module
