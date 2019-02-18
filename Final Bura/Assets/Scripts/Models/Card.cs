public enum Rank { SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE }
public enum Suit { HEART, SPADE, CLUB, DIAMOND }

public class Card
{
    private int _rank;
    private Suit _suit;
    private int _scoreValue;

    public Card(string cardName)
    {
        string rankCharacter = cardName[0].ToString();
        string suitCharacter = cardName[1].ToString();
        this.SetRank(rankCharacter);
        this.SetSuit(suitCharacter);
    }

    public void SetRank(string rank)
    {
        switch (rank)
        {
            case "6":
                this._rank = 6;
                this._scoreValue = 0;
                break;
            case "7":
                this._rank = 7;
                this._scoreValue = 0;
                break;
            case "8":
                this._rank = 8;
                this._scoreValue = 0;
                break;
            case "9":
                this._rank = 9;
                this._scoreValue = 0;
                break;
            case "10":
                this._rank = 10;
                this._scoreValue = 10;
                break;
            case "J":
                this._rank = 11;
                this._scoreValue = 2;
                break;
            case "Q":
                this._rank = 12;
                this._scoreValue = 3;
                break;
            case "K":
                this._rank = 13;
                this._scoreValue = 4;
                break;
            case "A":
                this._rank = 14;
                this._scoreValue = 11;
                break;
            default:
                break;
        }
    }

    public int getRank()
    {
        return this._rank;
    }

    public void SetSuit(string suit)
    {
        switch (suit)
        {
            case "H":
                this._suit = Suit.HEART;
                break;
            case "C":
                this._suit = Suit.CLUB;
                break;
            case "D":
                this._suit = Suit.DIAMOND;
                break;
            case "S":
                this._suit = Suit.SPADE;
                break;
            default:
                break;
        }
    }

    public Suit GetSuit()
    {
        return this._suit;
    }

    public void SetScoreValue(int scoreValue)
    {
        this._scoreValue = scoreValue;
    }

    public int GetScoreValue()
    {
        return this._scoreValue;
    }

}
