Module Module1

    Sub Main()
        lastlines()
    End Sub
    Sub lastlines()
        Dim linex, liney, linez, x As String
        Dim count, count2 As Integer
        count = 0
        count2 = 0
        linex = ""
        liney = ""
        linez = ""
        x = ""
        FileOpen(1, My.Application.Info.DirectoryPath & "\myfile.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, x)
            count = count + 1
        End While
        FileClose(1)
        FileOpen(1, My.Application.Info.DirectoryPath & "\myfile.txt", OpenMode.Input)
        For count2 = 1 To count - 3
            Input(1,x)
        Next
        Input(1, linex)
        Input(1, liney)
        Input(1, linez)
        FileClose(1)
        Console.WriteLine(linex)
        Console.WriteLine(liney)
        Console.WriteLine(linez)
        Console.ReadKey()



    End Sub

End Module
