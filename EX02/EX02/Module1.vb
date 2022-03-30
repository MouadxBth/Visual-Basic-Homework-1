Module Module1

    Sub Main()
        Dim number, index As Integer

        Console.WriteLine("Enter the number you want:")
        number = Console.ReadLine()

        For index = 1 To 10
            Console.WriteLine(number + index)
        Next
        Console.ReadKey()
    End Sub

End Module
