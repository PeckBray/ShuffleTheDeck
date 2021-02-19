Option Strict On
Option Explicit On
Module ShuffleTheDeck

    Sub Main()
        'Create array with each card assigned to a number and a value if the card has already been used during the shuffle
        Dim deck = New Object(12, 2) {
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
            {13, "King of Clubs", False}
            }

        Dim card As Integer = 0
        Dim bool As Boolean = False
        Dim userInput As String
        Dim cardsDrawn As Integer
        Console.WriteLine("Press ""enter"" to draw a card from the deck. Enter ""q"" to quit the program. Enter ""s"" to shuffle cards back into the deck.")
        While userInput <> "q"
            userInput = Console.ReadLine()
            If userInput = "s" Then

            ElseIf userInput = "debug" Then
                For i = LBound(deck) To UBound(deck)
                    For j = 0 To 2
                        Console.Write("")
                    Next
                Next
            Else
                While bool = False
                    card = GetRandomNumber(UBound(deck))
                    bool = CBool(deck(card, 2))
                    If bool = False Then
                        deck(card, 2) = True
                        bool = True
                        Console.WriteLine($" your card is {deck(card, 1)}!")
                        cardsDrawn += 1
                    Else
                        bool = False
                    End If

                End While
            End If
            bool = False
            If cardsDrawn = UBound(deck) + 1 Then
                For i = LBound(deck) To UBound(deck)
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
