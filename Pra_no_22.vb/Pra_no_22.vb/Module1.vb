Module Module1
    Class A
        Sub show()

            Console.WriteLine("This is class A")
        End Sub
    End Class
    Class B
        Inherits A
        Shadows Sub show()
            Call MyBase.show()
            Console.WriteLine("This is class B")
        End Sub
    End Class
    Class C
        Inherits B
        Shadows Sub show()
            Call MyBase.show()
            Console.WriteLine("This is class C")
        End Sub
    End Class
    Sub Main()

        ' Dim obj As New A
        'obj.show()
        'Dim obj2 As New B
        'obj2.show()
        Dim obj3 As New C
        obj3.show()
        Console.ReadLine()
    End Sub

End Module
