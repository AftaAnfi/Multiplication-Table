Option Explicit On
Option Strict On

Module MultiplicationTable

    Dim readInputString As String
    Dim readInputInteger As Integer
    Dim runProgram As Boolean = True

    Sub Main()

        While runProgram
            Console.Clear()

            Console.WriteLine("How big of a multiplication table would you like?")
            Console.WriteLine("Enter number now or press Q to quit")


            readInputString = Console.ReadLine()

            If readInputString = "Q" Or readInputString = "q" Then
                Console.WriteLine("Exiting application...")
                Console.WriteLine("Have a good day!")
                System.Threading.Thread.Sleep(2000)
                End
            End If

            Try
                readInputInteger = CInt(readInputString)
                FormatTable(readInputInteger)
                'run multiplication table code
            Catch ex As Exception
                Console.WriteLine($"That wasn't a number, you entered {readInputString}, try again.")
            End Try
            Console.WriteLine("Press enter to continue...")
            Console.ReadLine()
        End While


    End Sub

    Sub FormatTable(tablesize As Integer)

        For i = 0 To tablesize

            For j = 0 To tablesize

                If (j * i) <> 0 Then

                    Console.Write((j * i).ToString.PadLeft(5))

                End If

            Next

            Console.WriteLine()

        Next

    End Sub




End Module
