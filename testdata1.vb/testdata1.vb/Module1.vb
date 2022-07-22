Imports System.Data.OleDb
Imports System.Console

Module Module1
    Dim myconnection As OleDbConnection
    Dim mycommand As OleDbCommand
    Dim dr As OleDbDataReader

    Sub Main()
        myconnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\marka\Documents\Database1.accdb")
        'myconnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\marka\Documents\Database1.accdb")
        myconnection.Open()
        mycommand = New OleDbCommand("Select * from table1", myconnection)
        dr = mycommand.ExecuteReader
        Do While dr.Read()


            WriteLine("Roll no    " & dr(0))
            WriteLine("Name   " & dr(1))
            WriteLine(" Branch name    " & dr(2))

        Loop

        dr.Close()
        myconnection.Close()
        ReadKey()
    End Sub

    ' Private Sub OleDbConnection(p1 As String)
    'Throw New NotImplementedException
    ' End Sub

End Module
