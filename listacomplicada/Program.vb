Imports System

Module Program
    Sub Main(args As String())
        Dim alunos As New list (Of String)
        Dim quantidade as Integer
        Dim nome as String
        
        Console.WriteLine("Quantos alunos vais cadastrar?")
        quantidade = Integer.Parse(Console.ReadLine())

        For i as Integer = 1 to quantidade
            Console.Write("Digeite o nome do Aluno: ")
           nome =  Console.ReadLine()
            alunos.Add(nome)
        Next
        
        for each aluno In alunos
            Console.WriteLine(aluno)
        Next    
        


        Console.Write("Digite o nome do aluno: ")

    End Sub
End Module
