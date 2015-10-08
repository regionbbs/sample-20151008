Module Module1

    Sub Main()

        Dim a As Integer = Val(Console.ReadLine)
        Dim b As Integer = Val(Console.ReadLine)

        Console.WriteLine(Add(a, b))
        Console.ReadLine()

    End Sub

    Function Add(a As Integer, b As Integer) As Integer

        Return a + b

    End Function


End Module
