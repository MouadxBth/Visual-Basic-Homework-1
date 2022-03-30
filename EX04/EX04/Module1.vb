Module Module1

    Sub Main()
        Dim number, index, result As Integer

        Do
            Console.WriteLine("Enter the number you want:")
            number = Console.ReadLine()
            If number < 0 Then
                Console.WriteLine("Cannot calculate the factorial of a negative number!")
            End If
        Loop While number < 0

        result = 1
        index = number
        While index > 1
            result *= index
            index -= 1
        End While
        Console.WriteLine(number & "! = " & result)
        Console.ReadKey()
    End Sub

End Module
