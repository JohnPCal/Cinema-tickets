Imports System

Module Cinema
    Sub Main()
        Dim screenStr, customerStr, menuInput As String
        Dim customerNo, screenNo, cinemaCapacity, currentCapacity, ScreenOne, ScreenTwo, ScreenThree, ScreenFour, menuInt As Integer
        Dim pricePer, discount, total As Double
        Dim screenselect, customerValid, confirmClose As Boolean

        confirmClose = False
        cinemaCapacity = 150

        'example capacity
        ScreenOne = 0
        ScreenTwo = 0
        ScreenThree = 0
        ScreenFour = 0

        Do Until confirmClose = True

            screenselect = False
            customerValid = False

            'Menu
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("            ********************************
            **      Deja View Cinema      **
            ********************************
                          
New customer:")
            Console.ForegroundColor = ConsoleColor.White

            If currentCapacity = cinemaCapacity Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("SORRY, WE AREFULLY BOOKED")
                Console.ForegroundColor = ConsoleColor.White
                confirmClose = True
                Console.Read()
                End
            End If

            Console.WriteLine("1. Book seats
2. Display summary
3. Exit")
            menuInput = Console.ReadLine()
            If Integer.TryParse(menuInput, menuInt) Then

            End If

            Select Case menuInt

                Case 1

                    Do Until customerValid = True

                        Console.WriteLine("")
                        Console.Write("Please enter the number of people attending: ")
                        customerStr = Console.ReadLine()

                        If Integer.TryParse(customerStr, customerNo) And currentCapacity < cinemaCapacity Then
                            customerValid = True

                            If customerNo > cinemaCapacity Then
                                Console.WriteLine("Maximum capacity is 150")
                                Threading.Thread.Sleep(2000)
                                customerValid = False
                            End If

                        ElseIf currentCapacity >= cinemaCapacity Then

                            Console.WriteLine("")
                            Console.WriteLine("Sorry there are not enough seats")
                            Threading.Thread.Sleep(2000)
                            customerValid = False
                        Else
                            Console.WriteLine("This is not a valid entry")
                        End If

                    Loop

                    'validation for screen
                    Do Until screenselect = True

                        Console.ForegroundColor = ConsoleColor.White
                        Console.Write("Please enter the screen number: ")
                        screenStr = Console.ReadLine

                        If Integer.TryParse(screenStr, screenNo) Then

                        End If

                        Select Case screenNo
                            Case 1
                                If currentCapacity < cinemaCapacity Then
                                    ScreenOne = ScreenOne + customerStr
                                    pricePer = 5.0
                                    screenselect = True
                                End If
                            Case 2
                                If currentCapacity < cinemaCapacity Then
                                    ScreenTwo = ScreenTwo + customerStr
                                    pricePer = 7.0
                                    screenselect = True
                                End If
                            Case 3
                                If currentCapacity < cinemaCapacity Then
                                    ScreenThree = ScreenThree + customerStr
                                End If
                                pricePer = 4.5
                                screenselect = True
                            Case 4
                                If currentCapacity <> cinemaCapacity Then
                                    ScreenFour = ScreenFour + customerStr
                                    pricePer = 5.0
                                    screenselect = True
                                End If

                            Case Else
                                Console.WriteLine("Invalid screen number, 1-4 only")
                                screenselect = False
                        End Select

                        currentCapacity = ScreenOne + ScreenTwo + ScreenThree + ScreenFour

                        If currentCapacity > cinemaCapacity Then
                            Console.ForegroundColor = ConsoleColor.Red
                            Console.WriteLine("Capacity limit exceeded")
                            Console.ForegroundColor = ConsoleColor.White
                            Console.ReadKey()
                            End

                        End If
                    Loop

                    'validation for cutomer
                    customerValid = False

                    Console.WriteLine("")
                    Console.Clear()

                    If customerNo >= 10 Then
                        discount = 4.0
                    End If

                    'calculation
                    total = pricePer * customerNo - discount

                    'final output
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("            ********************************
            **      Deja View Cinema      **
            ********************************
                          
Entry ticket:")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.WriteLine("Time of entry " & Now.Date & " / " & Now.Hour & ":" & Now.Minute)
                    Console.WriteLine("Enter screen " & screenNo)
                    Console.WriteLine("Number in party: " & customerNo)
                    Console.WriteLine("Entry cost per person: £" & pricePer)
                    Console.WriteLine("Entry cost before discount: £" & total + discount)
                    Console.WriteLine("Discount amount: £" & discount)
                    Console.ForegroundColor = ConsoleColor.Yellow
                    Console.WriteLine("____________
|   £" & total & "    |
============")

                Case 2
                    Console.WriteLine("Total bookings for tonight: " & currentCapacity & "/" & cinemaCapacity)
                    Console.WriteLine("Bookings for screen 1: " & screenOne)
                    Console.WriteLine("Bookings for screen 2: " & ScreenTwo)
                    Console.WriteLine("Bookings for screen 3: " & ScreenThree)
                    Console.WriteLine("Bookings for screen 4: " & ScreenFour)

                Case 3
                    confirmClose = True
                    End

                Case Else
                    Console.WriteLine("Invalid choice, 1-3")

            End Select

        Loop

        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("AT CAPACITY")
        Console.ForegroundColor = ConsoleColor.White

        'John Calverley
    End Sub
End Module
