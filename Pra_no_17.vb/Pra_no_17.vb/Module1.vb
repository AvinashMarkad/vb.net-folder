Module Module1
    Public Class person
        Private friendlist As New Collection
        Public Property friends(ByVal Index As Integer) As String

            Get
                Return friendlist(Index)
            End Get
            Set(ByVal value As String)
                friendlist.Add(value)
            End Set
        End Property
    End Class
    Sub Main()


        Dim p1 As person = New person

        p1.friends(1) = "Samir"
        p1.friends(2) = "Avinash"

        Console.WriteLine("My first friend name : " & p1.friends(1))
        Console.WriteLine("My second friend name : " & p1.friends(2))
        Console.ReadKey()

    End Sub

End Module
