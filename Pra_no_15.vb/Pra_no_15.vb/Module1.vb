Module Module1

    Sub Main()
        procedure(100, 200)
    End Sub

    Sub procedure(a As Integer, b As Integer)

        ' Dim a, b, sum As Integer

        ' Console.WriteLine("Enter the value of a :")
        'a = Console.ReadLine()

        'Console.WriteLine("Enter the value of b :")
        'b = Console.ReadLine()
        Dim sum As Integer
        sum = a + b

        Console.WriteLine("Addition of a and b :" & sum)

        Console.ReadLine()

    End Sub

End Module
