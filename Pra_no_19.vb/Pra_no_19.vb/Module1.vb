Module Module1

    Class A

        Sub mtd1()

            Console.WriteLine("This is SUPER class")

        End Sub
    End Class

    Class B
            Inherits A

            Sub mtd2()

                Console.WriteLine("This is SUB class")

            End Sub



        End Class

    Sub Main()

        Dim obj As B = New B()
        obj.mtd1()
        obj.mtd2()
        Console.ReadLine()
    End Sub

End Module
