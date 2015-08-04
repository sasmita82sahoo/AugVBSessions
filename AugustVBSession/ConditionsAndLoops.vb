Module ConditionsAndLoops
    Function Run(num As Integer, age As Decimal, name As String) As Boolean
        'Implementation
        'If condition
        If num = 10 Then
            'Do something
            Console.WriteLine("The number value is" & num)
        ElseIf num > 10 Then
            'Do something else
            Console.WriteLine("The value is greeater than 10")
        Else
            'do something else
            Console.WriteLine("Above conditions were false, and the number is neither 10 nor greater than 10")
        End If


        'Nested if
        If name = "Ruchi" Then
            If num = 10 Then
                'Do something
                Console.WriteLine("The number value is" & num)
            ElseIf num > 10 Then
                'Do something else
                Console.WriteLine("The value is greeater than 10")
            Else
                'do something else
                Console.WriteLine("Above conditions were false, and the number is neither 10 nor greater than 10")
            End If
        End If

        'Select
        Select Case age
            Case 17
                'Do something
                Console.WriteLine("Don't serve beer, Too young!")
            Case 25
                Console.WriteLine("Serve a max of 2 pints")
            Case 20 To 24
                Console.WriteLine("Serve 1 pint only!")
            Case Is < 20
                Console.WriteLine("less than 20")
            Case Else
                Console.WriteLine("For others, better luck next time!")
        End Select

        Dim var As String
        var = 60
        Select Case var
            Case 20

            Case 12

            Case Else

        End Select

        'looping statements
        'Dim counter As Integer
        For index = 1 To 10 Step 1 'default
            'do something
            Console.WriteLine(index)
        Next
        Console.ReadLine()

        'For counter As Integer = 1 To 10

        'Next

        'For index = 1 To 10

        'Next

        For counter = 1 To 5 Step 0.25
            'do something
            Console.WriteLine(counter)
        Next
        Console.ReadLine()

        For value = 5 To 1 Step -1
            Console.WriteLine(value)
        Next

        'Combination of if and for
        For index1 = 1 To 5
            For index2 = 1 To 10
                Console.WriteLine(index2)
                If True Then

                End If
            Next
        Next

        If True Then
            For index = 1 To 10
                'do something for these many no. of times
            Next
        End If

        'While
        While num = 9
            'Do something
            Console.WriteLine(num)
            num = num - 1
        End While
        Console.ReadLine()

        Dim number As Integer = 1
        'Do While
        Do
            Console.WriteLine(number)
            'This will be run at least once!
            number = number + 1
        Loop While number = 3

        'Option 1
        'print 1 
        'print 2

        'option 2
        'print 1
        'print 2
        'print 3

        'option 3
        'print 1

        Console.ReadLine()
        Return True
    End Function
End Module
