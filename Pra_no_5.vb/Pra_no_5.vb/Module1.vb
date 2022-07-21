Imports System.Console
Module Module1

    Sub Main()

        Dim c As Char
        WriteLine("Enter any character to check vowel or not :")
        c = ReadLine()

        Select Case c

            Case "a", "e", "i", "o", "u"
                WriteLine("Character is vowel")

            Case Else
                WriteLine("Character is not vowel")

        End Select

        ReadLine()

    End Sub

End Module
