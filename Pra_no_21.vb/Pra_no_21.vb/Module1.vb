Module Module1
    Class Pra21
        Sub show()

            Console.WriteLine("This is first method")

        End Sub

    End Class
    Class Pra211
        Inherits Pra21
        Shadows Sub show()
            Call MyBase.show()

            Console.WriteLine("This is second method")

        End Sub
    End Class
    Sub Main()

        Dim obj As New Pra211
        obj.show()
        Console.ReadLine()
    End Sub

End Module
