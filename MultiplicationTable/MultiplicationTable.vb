Option Explicit On
Option Strict On

'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Multiplication Table
'https://github.com/AftaAnfi/Multiplication-Table.git
Module MultiplicationTable

    Dim readInputString As String
    Dim readInputInteger As Integer
    Dim runProgram As Boolean = True

    Sub Main()

        While runProgram
            Console.Clear()

            'Ask user for size
            Console.WriteLine("How big of a multiplication table would you like?")
            Console.WriteLine("Enter number now or press Q to quit")

            'Read Input
            readInputString = Console.ReadLine()

            'If input is q, exit application after 2 seconds
            If readInputString = "Q" Or readInputString = "q" Then
                Console.WriteLine("Exiting application...")
                Console.WriteLine("Have a good day!")
                System.Threading.Thread.Sleep(2000)
                End
            End If

            'Once input is entered, make sure input is an integer and less than 17
            Try
                readInputInteger = CInt(readInputString)

                'Make sure input integer is less than 17 to format table
                If readInputInteger > 16 Then
                    Console.WriteLine("Enter a number less than 17.")
                Else
                    'run multiplication table code
                    FormatTable(readInputInteger)
                End If

                'Input is invalid so return to start of program to ask for input
            Catch ex As Exception
                Console.WriteLine($"That wasn't a number, you entered {readInputString}, try again.")
            End Try

            'Allow user to read table / redo a table
            Console.WriteLine("Press enter to continue...")
            Console.ReadLine()
        End While

    End Sub

    'Sub to format all the values of the table in the console
    Sub FormatTable(tablesize As Integer)

        Console.Clear()
        Console.WriteLine($"Enjoy your {tablesize} x {tablesize} table.")

        For i = 0 To tablesize
            For j = 0 To tablesize

                'multiply the 2 values to display in a row of text to console
                If (j * i) <> 0 Then

                    'add padding to give space between values
                    Console.Write((j * i).ToString.PadLeft(5))

                End If
            Next
            Console.WriteLine()
            Console.WriteLine()
        Next
    End Sub
End Module
