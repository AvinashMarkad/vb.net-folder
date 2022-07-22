Imports System.Console
Module Module1

    Sub Main()

        Dim a, b, c, s As Single

        WriteLine("Enter the value of a :")
        a = ReadLine()
        WriteLine("Enter the value of b :")
        b = ReadLine()

        WriteLine("Press 1.For add")
        WriteLine("Press 2.For sub")
        WriteLine("Press 3.For mul")
        WriteLine("Press 4.For div")
        s = ReadLine()

        Select Case s
            Case 1
                c = a + b

                WriteLine("Add of a and b :" & c)

            Case 2
                c = a - b

                WriteLine("Sub of a and b :" & c)

            Case 3
                c = a * b

                WriteLine("Mul of a and b :" & c)

            Case 4
                c = a / b

                WriteLine("Div of a and b :" & c)

            Case Else
                WriteLine("Chooce the correct case")

        End Select

        ReadLine()

    End Sub

End Module
