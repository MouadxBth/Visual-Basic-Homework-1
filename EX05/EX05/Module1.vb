Module Module1

    Sub Main()
        Dim number, power, index, result As Integer

        Do
            Console.WriteLine("Enter the power:")
            power = Console.ReadLine()

            If power < 0 Then
                Console.WriteLine("Cannot take a negative power!")
            End If
        Loop While power < 0

        Console.WriteLine("Enter the number you want:")
        number = Console.ReadLine()

        For index = 0 And result = 0 To power * 2 Step 2
            result += number ^ index
        Next

        Console.WriteLine("The result of the sum is: " & result)
        Console.ReadKey()
    End Sub

End Module
