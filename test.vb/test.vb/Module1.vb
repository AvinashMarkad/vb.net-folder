Module Module1

    Class Shadow

        Shared x As Integer = 1

        Shared Shadows Sub Main()

            Dim x As Integer = 10

            Console.WriteLine("main: x" & x)

            Console.WriteLine("main sahdow x:" & Shadow.x)

            Console.ReadLine()
        End Sub
    End Class


End Module
