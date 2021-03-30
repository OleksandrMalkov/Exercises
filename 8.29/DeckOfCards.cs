using System;

class DeckOfCards
{
    private Card[] deck;
    private int currentCard;
    private const int NUMBER_OF_CARDS = 52;
    private Random randomNumbers;
    private Card[] pokerHand;

    public DeckOfCards()
    {
        string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six",
            "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

        deck = new Card[NUMBER_OF_CARDS];
        currentCard = 0;
        randomNumbers = new Random();

        for (int count = 0; count < deck.Length; ++count)
            deck[count] = new Card(faces[count % 13], suits[count / 13]);
    }

    public void Shuffle()
    {
        currentCard = 0;

        for (int first = 0; first < deck.Length; ++first)
        {
            int second = randomNumbers.Next(NUMBER_OF_CARDS);

            Card temp = deck[first];
            deck[first] = deck[second];
            deck[second] = temp;
        }
    }
    public Card DealCard()
    {
        if (currentCard < deck.Length)
            return deck[currentCard++];
        else
            return null;
    }

    public void GetPokerHand()
    {
        pokerHand = new Card[5];
        for (int i = 0; i < 5; i++)
        {
            pokerHand[i] = deck[i];
            Console.Write("{0}\n", pokerHand[i]);
        }
    }
    public void DefiniteHand()
    {
        int a = 0, b = 0, c = 0;
        int pair = 0, threeOfKind = 0, fourOfKind = 0, flush = 0, straight = 0;
        int[] cards = new int[13];

        while (a < 4)                                                //Pair definite
        {
            if (pokerHand[a].Face == pokerHand[a + 1].Face)
                pair++;
            a++;
        }
        while (b < 3)                                                //three of kind definite
        {
            if (pokerHand[b].Face == pokerHand[b + 1].Face && pokerHand[b].Face == pokerHand[b + 2].Face)
                threeOfKind++;
            b++;
        }
        while (c < 2)                                               //four of kind definite
        {
            if (pokerHand[c].Face == pokerHand[c + 1].Face && pokerHand[c].Face == pokerHand[c + 2].Face && pokerHand[c].Face == pokerHand[c + 3].Face)
                fourOfKind++;
            c++;
        }
        if (pokerHand[0].Suit == pokerHand[1].Suit                  //flush definite
            && pokerHand[0].Suit == pokerHand[2].Suit
            && pokerHand[0].Suit == pokerHand[3].Suit
            && pokerHand[0].Suit == pokerHand[4].Suit)
            flush++;
        for (int i = 0; i < pokerHand.Length; i++)                  //straight definite
        {
            switch (pokerHand[i].Face)
            {
                case "Ace":
                    cards[0]++;
                    break;
                case "Deuce":
                    cards[1]++;
                    break;
                case "Three":
                    cards[2]++;
                    break;
                case "Four":
                    cards[3]++;
                    break;
                case "Five":
                    cards[4]++;
                    break;
                case "Six":
                    cards[5]++;
                    break;
                case "Seven":
                    cards[6]++;
                    break;
                case "Eight":
                    cards[7]++;
                    break;
                case "Nine":
                    cards[8]++;
                    break;
                case "Ten":
                    cards[9]++;
                    break;
                case "Jack":
                    cards[10]++;
                    break;
                case "Queen":
                    cards[11]++;
                    break;
                case "King":
                    cards[12]++;
                    break;
            }
        }
        for (int e = 0; e < 8; e++)
        {
            if (cards[e] == 1 && cards[e + 1] == 1 && cards[e + 2] == 1 && cards[e + 3] == 1 && cards[e + 4] == 1)
                straight++;
        }

        Console.WriteLine();
        if (fourOfKind == 1)                                                        //output result
            Console.WriteLine("Your combination is: \nFour of kind");
        if (flush == 1)
            Console.WriteLine("Your combination is: \na Flush");
        if (straight == 1 && flush == 0)
            Console.WriteLine("Your combination is: \na Straight");
        if ((threeOfKind == 1) && (fourOfKind == 0))
            Console.WriteLine("Your combination is: \nThree of kind");
        if ((pair == 2) && (threeOfKind == 0))
            Console.WriteLine("Your combination is: \nFour of kind");
        if ((pair == 1) && (threeOfKind == 0) && (fourOfKind == 0))
            Console.WriteLine("Your combination is: \na Pair");
        if ((pair == 1) && (threeOfKind == 1))
            Console.WriteLine("Your combination is: \na Full House");
        if((pair == 0) && (threeOfKind == 0) && (fourOfKind == 0) &&( flush == 0)&& (straight == 0))
            Console.WriteLine("Your combination is: \na High Card");
    }
}

