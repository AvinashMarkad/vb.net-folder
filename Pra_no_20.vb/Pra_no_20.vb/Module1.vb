Module Module1
    Class pra20

        Sub show(ByVal a As Integer)

            Dim num1 As Integer = a
            Dim num2 As Integer = a
            Dim sum As Integer
            sum = num1 + num2
            Console.WriteLine("This is first Method")
            Console.WriteLine(" value of given number :" & sum)

        End Sub

        Sub show(ByVal x As Integer, ByVal y As Integer)

            Dim num3 As Integer = x
            Dim num4 As Integer = y
            Dim num5 As Integer
            num5 = num3 + num4
            Console.WriteLine("This is second method")
            Console.WriteLine("Addition of x and y :" & num5)

        End Sub
    End Class

    Sub Main()
        Dim obj As New pra20

        obj.show(15)
        obj.show(50, 50)
        Console.ReadLine()

    End Sub
End Module
