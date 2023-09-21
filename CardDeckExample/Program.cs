using CardDeckExample.PlayingCardDeck;
namespace CardDeckExample;

class Program
{
    static void Main(string[] args)
    {
        CardDeck deck = new();

        Console.WriteLine($"Number of cards is {deck.DrawPile.Count}");
        foreach (PlayingCard card in deck.DrawPile)
        {
            Console.WriteLine(card);
            Console.WriteLine($"Numerical value for card-value is {(int)card.Value}");

            if (card.Value == CardValue.Ace && card.Suit == CardSuit.Spades)
            {
                // new comment
                // another comment
			}

        }
    }
}

