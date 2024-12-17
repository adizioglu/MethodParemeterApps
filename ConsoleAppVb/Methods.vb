Namespace ConsoleAppCs
    Public Module Methods
        Public Sub SayHi(firstName As String)
            Console.WriteLine($"Hello {firstName}!")
            Console.WriteLine("I hope you are having a good day.")
        End Sub

        Public Sub Add(x As Double, y As Double)
            Console.WriteLine($"The value of {x} + {y} = {x + y}")
        End Sub

        Public Sub AddAll(values As Double())
            Dim result As Double = 0

            For Each value As Double In values
                result += value
            Next

            Console.WriteLine($"The total is {result}")
        End Sub
    End Module
End Namespace
