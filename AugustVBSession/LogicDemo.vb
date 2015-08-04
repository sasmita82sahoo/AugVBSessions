Module LogicDemo
    'Logic
    '   Functions
    '       They return a value
    '   Subroutines
    '       Do not return a value

    'Lifecycle of a logic block
    '   Declare
    '       Keyword function / sub       
    '       Name
    '       function - return type
    '       sub - no return type
    '   Implement
    '       Actual logic / body
    '   Call
    '       calling from another logic block

    'Module level variable
    Dim modVar As Integer

    'accessible outside the module
    Public varForAll As Integer

    'Declare a function
    Function DoThis() As Integer
        'body
        DoThisAsWell()
        'rtr
        modVar = 20
        Return 0
    End Function

    'Declare a subroutine
    Sub DoThisAsWell()
        'rtr is a local variable and its scope is limited within this subroutine
        Dim rtr As Integer = DoThis()
        modVar = 10
        'body
    End Sub

    'Signature
    '   Name
    '   type of parameters
    '   number of parameters
    '   sequence of parameters
    '   return type
    '   security
    Function Calculate(int As Integer, flag As Boolean) As Integer
        Return 10
    End Function

    Sub MySub()
        'Fails on runtime
        ' Dim num As Integer = Calculate("Ruchira", 10, True) 
        Dim num As Integer = Calculate(10, True)
    End Sub

    'Function overloading
    Function Calculate(int As Integer, flag As Boolean, str As String) As Integer
        Return 10
    End Function

    Function Calculate(x As Integer, y As Double) As Boolean
        Return False
    End Function

    Function Calculate(x As String, z As Integer) As Boolean
        Return False
    End Function

    Private Function newFunc() As Boolean
        Return True
    End Function
End Module
