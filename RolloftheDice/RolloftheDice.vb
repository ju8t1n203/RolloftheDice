Option Compare Text
Option Explicit On
Option Strict On
'Justin Bell
'RCET0235
'Fall 2024
'Roll of the Dice
'https://github.com/ju8t1n203/RolloftheDice

Imports System.Data.OleDb

Module RolloftheDice

    Sub Main()
        Dim header() As String = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}
        Dim values As Integer
        Dim totals(11) As Integer
        Dim userInput As String

        Do
            Console.Clear()

            'makes top heading
            For i = 0 To 10
                Console.Write($"| {header(i)} ")
            Next

            Console.Write("|")
            Console.WriteLine()
            Console.WriteLine(StrDup(48, "-"))

            'creates two dice rolls 1000 times
            For i = 0 To 1000
                values = GetRandomNumber(2, 12)
                totals(values - 2) += 1
            Next

            'displays number of times a number is rolled
            For i = 0 To 10
                Console.Write($"|{totals(i)} ")
            Next

            Console.Write("|")
            Console.WriteLine()
            Console.WriteLine("press enter to add more rolls or press ""Q"" to close window.")
            userInput = Console.ReadLine

            If userInput = "Q" Then
                Exit Do
            End If

        Loop
    End Sub

    'random number generator
    Function GetRandomNumber(min%, max%) As Integer
        Dim randomNumber%
        Randomize(DateTime.Now.Millisecond)
        randomNumber = CInt(Math.Floor(Rnd() * (max - min + 1))) + min
        Return randomNumber%
    End Function


End Module
