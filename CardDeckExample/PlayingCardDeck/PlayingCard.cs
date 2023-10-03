﻿using System;
namespace CardDeckExample
{
	public class PlayingCard
	{
		public PlayingCard(CardValue value, CardSuit suit)
		{
			Value = value;
			Suit = suit;
		}

		public CardSuit Suit { get; private set; }
		public CardValue Value { get; private set; }

		public override string ToString()
		{
			return $"{Value} of {Suit}";
		}

	}
}
