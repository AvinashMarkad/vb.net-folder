Namespace p2


    Public Class Class1

        Sub show()

            Dim a, b As String

            a = InputBox("Enter UserName")
            b = InputBox("Enter Password")

            If (a = "avi@3719") Then

                If (b = "avi3719") Then

                    MsgBox("Password is correct")

                Else
                    MsgBox("Sorry try again")

                End If
            Else
                MsgBox("Sorry try again")
            End If

        End Sub


    End Class

End Namespace
