using System;

class Card
{
    private string face;
    private string suit;

    public string Face
    {
        get
        {
            return face;
        }
    }
    public string Suit
    {
        get
        {
            return suit;
        }
    }

    public Card(string cardFace, string cardSuit)
    {
        face = cardFace;
        suit = cardSuit;
    }

    public override string ToString()
    {
        return face + " of " + suit;
    }

}
