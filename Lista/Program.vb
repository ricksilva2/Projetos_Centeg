Imports System

Module Program
    Sub Main(args As String())
        Dim materias As new List(Of String)

        materias.Add("Portugues")
        materias.Add("matematica")
        materias.Add("ingles")   
        
        For each dado In materias
        Console.WriteLine(dado)
        Next
    End Sub
End Module
