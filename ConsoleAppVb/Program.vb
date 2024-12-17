Imports System

Module Program
    Sub Main(args As String())

        Console.Write("What is your name: ")
        Dim name As String = Console.ReadLine()

        ConsoleAppCs.Methods.SayHi(name)

        ConsoleAppCs.Methods.Add(5, 3)

        Dim vals As Double() = {2, 5, 6, 21, 52, 98}
        ConsoleAppCs.Methods.AddAll(vals)

    End Sub
End Module
