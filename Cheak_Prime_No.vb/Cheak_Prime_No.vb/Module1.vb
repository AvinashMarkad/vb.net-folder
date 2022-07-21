Imports System.Console
Module Module1

    Sub Main()

        Dim a, i, temp As Integer
        temp = 0

        WriteLine("Enter any number to cheak Prime or Not Prime")
        i = ReadLine()

        For a = 2 To i - 1 Step 1
            If (i Mod a = 0) Then
                temp = temp + 1
            End If
        Next
        If (temp = 0) Then
            WriteLine("Given is Prime Number")

        Else
            WriteLine("Given Number is Not Prime Number")

        End If
        ReadLine()
    End Sub

End Module
