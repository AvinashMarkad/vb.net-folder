Imports System.Console
Module Module1

    Sub Main()

        Dim ary() As Single = {3.5, 4, 4.5, 5, 5.5, 6, 6.5, 7, 7.5, 8, 8.5}

        For i = 0 To 10
            WriteLine(ary(i))
        Next

        For Each j In ary
            WriteLine(ary(j))
        Next

        ReadKey()

    End Sub

End Module
