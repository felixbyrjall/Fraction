using System;
namespace CardDeckExample.PlayingCardDeck
{
	public class CardDeck
	{
		public CardDeck()
		{
			DrawPile = new();

			for (int i = 0; i < 4; i++)
			{
				for (int j = 1; j < 14; j++)
				{
					DrawPile.Add(new( (CardValue)j, (CardSuit)i) );
				}
			}
		}

		public List<PlayingCard> DrawPile { get; set; }
		public List<PlayingCard> DiscardPile { get; set; }

	}
}

