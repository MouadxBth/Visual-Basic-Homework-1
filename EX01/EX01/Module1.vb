Module Module1

    Sub Main()
        Dim number, index, max_pos, max As Integer

        index = 0
        max_pos = 0
        max = 0

        Do
            Console.WriteLine("Enter the number you want:")
            number = Console.ReadLine()
            If number > max Then
                max = number
                max_pos = index
            End If
            Console.WriteLine("The current largest given number is: " & max)
            Console.WriteLine("It's position is: " & max_pos)
            index += 1
        Loop Until number = 0
    End Sub

End Module
