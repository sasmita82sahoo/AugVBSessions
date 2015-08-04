Module Module1

    Sub Main()
        'Comments
        'What is a Program?
        ' Data <---> Logic
        '   Data
        '       Variables -- change value overtime
        '           Native
        '               Fixed size
        '               stack (faster)
        '               no need to dispose
        '           Reference /Object type
        '               vary in size
        '               heap(slower)
        '               dispose them explicitly
        '       Constants -- whose value remains fixed
        '           Pi etc.

        'Calling a sub from LogicDemo
        'LogicDemo.MySub()
        'Calculate(10, True)
        'MySub()
        'DoThis()
        'DoThisAsWell()

        ConditionsAndLoops.Run(9, 15, "Bunny")

        'Lifecycle of a variable
        ' Declare
        ' Use 
        ' Dispose

        'Declare
        '   Dim
        '   Name
        '   Type
        Dim flag As Boolean ' 2 bytes
        Dim num As Integer ' 4 bytes
        Dim precision As Single ' 4 bytes
        Dim doubleprecision As Double ' 8 bytes
        Dim accuracy As Decimal ' 16 bytes
        Dim name As String ' depends on length of string

        ' Assign/ Use
        flag = True
        num = 10
        precision = 1.12234234
        doubleprecision = 1.12351275386823
        accuracy = 1.25
        name = "Ruchira"

        Console.WriteLine(flag)
        Console.WriteLine(num)
        Console.ReadLine()

        'integer operations
        Dim leftInt As Integer
        Dim rightInt As Integer
        Dim sumOfnums As Integer
        Dim prodOfnums As Integer
        Dim subOfnums As Integer
        Dim remainder As Integer
        Dim quotient As Integer

        leftInt = 20
        rightInt = 30
        sumOfnums = leftInt + rightInt
        prodOfnums = leftInt * rightInt
        subOfnums = rightInt - leftInt
        quotient = Math.DivRem(rightInt, leftInt, remainder)

        Console.WriteLine(leftInt)
        Console.WriteLine(rightInt)
        Console.WriteLine(sumOfnums)
        Console.WriteLine(prodOfnums)
        Console.WriteLine(quotient)
        Console.WriteLine(remainder)
        Console.ReadLine()

        'string operations
        Dim message1 As String
        Dim message2 As String
        Dim resultMsg As String

        message1 = "Hurray! This is VB session day 1"
        message2 = " and we are confident of learning on day 1 !"

        'concatenation
        ' resultMsg = message1 + message2 ' avoid this 
        resultMsg = message1 & message2
        'Console.WriteLine(resultMsg)
        Console.WriteLine("Value of resultMsg is:" & message1 & " " & message2)

        Dim position As Integer
        position = InStr(resultMsg.ToUpper(), "VB")
        Console.WriteLine(position)
        Console.ReadLine()

        Dim position2 As Integer
        position2 = InStr(position + 1, resultMsg, "day")
        Console.WriteLine(position2)
        Console.ReadLine()

        Dim leftPortion As String
        Dim rightportion As String
        leftPortion = Left(resultMsg, 27)
        rightportion = Right(resultMsg, 30)
        Console.WriteLine(leftPortion)
        Console.WriteLine(rightportion)
        Console.ReadLine()

        'Conversion of variables from one type to another
        Dim number As Integer
        Dim numAsString As String
        number = 10
        numAsString = number.ToString()
        numAsString = CStr(number)

        'str into integers
        'CInt

        Dim str As String
        Dim strAsDouble As Double
        str = "1.273"
        strAsDouble = CDbl(str)

        'Reference variable
        Dim myColl As New Collection ' capable to hold native type variables
        myColl.Add("1")
        myColl.Add(20)
        myColl.Add("name")
        myColl.Add(True)
        Console.WriteLine("myColl has following items: {0},{1},{2}, {3}", myColl.Item(1), myColl.Item(2), myColl.Item(3), myColl.Item(4))
        Console.ReadLine()

        'myColl.Remove(1)
        'myColl.Remove(2)
        'myColl.Remove(3)
        'myColl.Remove(4)

        'Fails on runtime
        ' Console.WriteLine("myColl has following items: {0}", myColl.Item(0))
        Console.WriteLine("myColl has following items: {0},{1},{2}", myColl.Item(1), myColl.Item(2), myColl.Item(3))
        Console.ReadLine()

        'Dispose
        myColl = Nothing
    End Sub

End Module
