Imports System.Data.OleDb
Module Module1

    Dim con As OleDbConnection
    Dim comd As OleDbCommand
    Dim dr As OleDbDataReader

    Sub Main()

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\marka\Documents\Database5.accdb")
        con.Open()

        comd = New OleDbCommand("select *from Table1", con)

        dr = comd.ExecuteReader

        While dr.Read()

            Console.WriteLine("Roll no " & dr(0))
            Console.WriteLine("Name " & dr(1))
            Console.WriteLine("Branch " & dr(2))

        End While
        dr.Close()
        con.Close()
        Console.ReadLine()

    End Sub

End Module
