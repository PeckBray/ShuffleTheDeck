'Brayden Peck
'RCET0265
'Spring 2021
'Shuffle the Deck
'https://github.com/PeckBray/ShuffleTheDeck
Option Strict On
Option Explicit On
Module ShuffleTheDeck

    Sub Main()
        'Create array with each card assigned to a number and a value if the card has already been used during the shuffle
        Dim deck = New Object(51, 2) {
            {1, "Ace of Clubs", False},
            {2, "Two of Clubs", False},
            {3, "Three of Clubs", False},
            {4, "Four of Clubs", False},
            {5, "Five of Clubs", False},
            {6, "Six of Clubs", False},
            {7, "Seven of Clubs", False},
            {8, "Eight of Clubs", False},
            {9, "Nine of Clubs", False},
            {10, "Ten of Clubs", False},
            {11, "Jack of Clubs", False},
            {12, "Queen of Clubs", False},
            {13, "King of Clubs", False},
            {14, "Ace of Hearts", False},
            {15, "Two of Hearts", False},
            {16, "Three of Hearts", False},
            {17, "Four of Hearts", False},
            {18, "Five of Hearts", False},
            {19, "Six of Hearts", False},
            {20, "Seven of Hearts", False},
            {21, "Eight of Hearts", False},
            {22, "Nine of Hearts", False},
            {23, "Ten of Hearts", False},
            {24, "Jack of Hearts", False},
            {25, "Queen of Hearts", False},
            {26, "King of Hearts", False},
            {27, "Ace of Diamonds", False},
            {28, "Two of Diamonds", False},
            {29, "Three of Diamonds", False},
            {30, "Four of Diamonds", False},
            {31, "Five of Diamonds", False},
            {32, "Six of Diamonds", False},
            {33, "Seven of Diamonds", False},
            {34, "Eight of Diamonds", False},
            {35, "Nine of Diamonds", False},
            {36, "Ten of Diamonds", False},
            {37, "Jack of Diamonds", False},
            {38, "Queen of Diamonds", False},
            {39, "King of Diamonds", False},
            {40, "Ace of Spades", False},
            {41, "Two of Spades", False},
            {42, "Three of Spades", False},
            {43, "Four of Spades", False},
            {44, "Five of Spades", False},
            {45, "Six of Spades", False},
            {46, "Seven of Spades", False},
            {47, "Eight of Spades", False},
            {48, "Nine of Spades", False},
            {49, "Ten of Spades", False},
            {50, "Jack of Spades", False},
            {51, "Queen of Spades", False},
            {52, "King of Spades", False}
            }

        Dim card As Integer
        Dim bool As Boolean = False
        Dim userInput As String
        Dim cardsDrawn As Integer
        Dim cardsDealt As Integer
        Console.WriteLine($"Press ""enter"" to draw a card from the deck. {vbNewLine}Enter ""q"" to quit the program. {vbNewLine}Enter ""s"" to shuffle cards back into the deck.")
        While userInput <> "q"
            userInput = Console.ReadLine()
            If userInput = "s" Then

            ElseIf userInput = "debug" Then
                For i = LBound(deck) To UBound(deck)
                    Console.WriteLine(StrDup(30, "-"))
                    Console.Write(CStr(deck(i, 0)).PadLeft(3) & "|")
                    Console.Write(CStr(deck(i, 1)).PadRight(18) & "|")
                    Console.Write(CStr(deck(i, 2)).PadLeft(5) & "|")
                    Console.WriteLine()
                Next
                Console.WriteLine(StrDup(30, "-"))
                Console.WriteLine($"Total number of cards dealt is: {cardsDealt}.")
                Console.WriteLine($"Total number of cards drawn this shuffle is: {cardsDrawn}.")
            ElseIf userInput = "q" Then

            Else
                While bool = False
                    card = GetRandomNumber(UBound(deck))
                    bool = CBool(deck(card, 2))
                    If bool = False Then
                        deck(card, 2) = True
                        bool = True
                        Console.WriteLine($" your card is {deck(card, 1)}!")
                        cardsDrawn += 1
                        cardsDealt += 1
                    Else
                        bool = False
                    End If
                End While
                bool = False
            End If

            If cardsDrawn = UBound(deck) + 1 Then
                For i = LBound(deck) To UBound(deck)

                    If CBool(deck(i, 2)) = False Then
                        Console.WriteLine($"{deck(i, 1)} was not dealt")
                    End If
                    deck(i, 2) = False
                Next
                Console.WriteLine("Deck has been shuffled")
                cardsDrawn = 0
            ElseIf userInput = "s" Then

                For i = LBound(deck) To UBound(deck)
                    deck(i, 2) = False
                Next
                Console.WriteLine("Deck has been shuffled")
                cardsDrawn = 0
            End If
        End While
    End Sub

    Function ShuffleDeck(deck As Array) As Object

        For i = LBound(deck) To UBound(deck)
            'deck(i, 2) = False
        Next
        Return (deck)
    End Function

    ''' <summary>
    ''' this function will return a random number between 1 and a maximum number that is input
    ''' </summary>
    ''' <param name="maxNumber"></param>
    ''' <returns></returns>
    Function GetRandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function

End Module
