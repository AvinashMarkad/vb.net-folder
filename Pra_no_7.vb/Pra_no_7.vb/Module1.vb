Imports System.Console
Module Module1

    Sub Main()

        Dim ary() As Integer = {1, 2, 3, 4, 5, 6}

        WriteLine("in array numbers print using for loop")

        For i = 0 To 5
            WriteLine(ary(i))
        Next

        WriteLine("in array numbers print using for each loop")

        For Each j In ary
            WriteLine(ary(j))
        Next

        ReadKey()


    End Sub

End Module
