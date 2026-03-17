Imports System

Module Program

    Sub Main(args As String())
        ' criei o variavels
       dim base As Double
       dim altura As Double
       dim area As Double
       ' criei isso para colocar o valor dentro de cada variavel
       Console.Writeline("Digite á base")
        base = Console.ReadLine()
       Console.Writeline("Digite á altura") 
        altura = Console.ReadLine()
        ' depois eu peguei o  a ultima variavel e dps coloquei a base vezes a altura com isso eu peguei o resultado e colequei pra mensagem aparecer
        area = base * altura
       Console.Writeline("A área do retãngulo é " & area)
       
       
    End Sub
End Module
