Module Module1

    Sub Main()

        add(100, 200)
        Console.ReadLine()
    End Sub

    Function add(ByRef a As Integer, ByRef b As Integer) As Integer

        'Console.WriteLine("Enter the value of a :")
        'a = Console.ReadLine
        'Console.WriteLine("Enter the value of b :")
        'b = Console.ReadLine

        Dim sum As Integer

        sum = a + b

        Console.WriteLine("Addition of a and b :" & sum)

        Return sum

    End Function


End Module
