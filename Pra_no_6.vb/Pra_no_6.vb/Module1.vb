Imports System.Console
Module Module1

    Sub Main()
        Dim i, j As Integer
        i = 10
        j = 1

        WriteLine("Numbers from 10 to 1 using do loop :")

        Do
            WriteLine(i)
            i = i - 1
        Loop While (i >= 1)

        WriteLine("Numbers from 1 to 10 using while loop :")
        While (j <= 10)
            WriteLine(j)
            j = j + 1

        End While
        ReadKey()

    End Sub
End Module



