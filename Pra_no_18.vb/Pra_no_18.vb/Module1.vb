Module Module1
    Class line

        Sub New()
            Console.WriteLine("This is first printing statement")
        End Sub

        Protected Overrides Sub finalize()
            Console.WriteLine("This is second printing statments")
        End Sub

        Shared Shadows Sub Main()
            Dim line1 As New line
            line1.finalize()
            Console.ReadLine()
        End Sub
    End Class
End Module
