using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Lib {
  public class Deck {
    private Card[] cards;

    /// <summary>默认构造器</summary>
    public Deck() {
      cards = new Card[52];
      for (int suitVal = 0; suitVal < 4; suitVal++) {
        for (int rankVal = 1; rankVal < 14; rankVal++) {
          cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
        }
      }
    }

    public Card GetCard(int cardNum) {
      if (cardNum >= 0 && cardNum <= 51)
        return cards[cardNum];
      else
        throw new ArgumentOutOfRangeException("cardNum", cardNum, "value must be between 0 and 51.");
    }

    /// <summary>洗牌</summary>
    public void Shuffle() {
      Card[] newDeck = new Card[52];
      bool[] assigned = new bool[52];
      Random sourceGen = new Random();
      for (int i = 0; i < 52; i++) {
        int destCard = 0;
        bool foundCard = false;
        while (!foundCard) {
          destCard = sourceGen.Next(52);
          if (!assigned[destCard])
            foundCard = true;
        }
        assigned[destCard] = true;
        newDeck[destCard] = cards[i];
      }
      newDeck.CopyTo(cards, 0);
    }
  }
}
