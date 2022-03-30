Module Module1

    Sub Main()
        Dim choice, number As Integer

        Do
            Console.WriteLine("Choose an option:")
            Console.WriteLine("1) Square a number")
            Console.WriteLine("2) Square root of a number:")
            choice = Console.ReadLine()

            If choice < 1 Or choice > 2 Then
                Console.WriteLine("Invalid choice!")
            End If
        Loop Until choice >= 1 And choice <= 2

        Console.WriteLine("Enter the number you want:")
        number = Console.ReadLine()
        If choice = 1 Then
            Console.WriteLine(number & " squarred is " & number ^ 2)
        ElseIf choice = 2 Then
            If number < 0 Then
                Console.WriteLine("Cannot calculate the square root of a negative number!")
            Else
                Console.WriteLine("Square root of " & number & " is " & number ^ (1 / 2))
            End If
        End If
        Console.ReadKey()
    End Sub

End Module
