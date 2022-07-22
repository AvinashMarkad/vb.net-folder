Module Module1

    Sub Main()

        Try
            Console.WriteLine("Enter the value of A :")
            Dim A As Integer = Console.ReadLine()

            Console.WriteLine("Enter the value of B :")
            Dim B As Integer = Console.ReadLine()

            Dim r As Integer = A \ B

            Console.WriteLine("Result of Division :" & r)

        Catch ex As DivideByZeroException

            Console.WriteLine("Can't Enter 'ZERO'")

        Finally
            Console.WriteLine("END program")

        End Try

        Console.ReadLine()

    End Sub

End Module
