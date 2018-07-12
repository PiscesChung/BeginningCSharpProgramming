using System;
using System.Collections.Generic;
using System.Text;

namespace Card_Lib {
  public class Card {
    public readonly Suit suit;
    public readonly Rank rank;
    public Card(Suit newSuit, Rank newRank) {
      suit = newSuit;
      rank = newRank;
    }

    private Card() {

    }

    public override string ToString() => $"The {rank} of {suit}s.";

    public string Show() {
      var suitEx = GetSuitEx();
      var rankEx = getRankEx();
      return suitEx + rankEx;
    }

    private string getRankEx() {
      var rankEx = "";
      switch (rank) {
        case Rank.Ace:
          rankEx = " A";
          break;
        case Rank.Deuce:
          rankEx = " 2";
          break;
        case Rank.Three:
          rankEx = " 3";
          break;
        case Rank.Four:
          rankEx = " 4";
          break;
        case Rank.Five:
          rankEx = " 5";
          break;
        case Rank.Six:
          rankEx = " 6";
          break;
        case Rank.Seven:
          rankEx = " 7";
          break;
        case Rank.Eight:
          rankEx = " 8";
          break;
        case Rank.Nine:
          rankEx = " 9";
          break;
        case Rank.Ten:
          rankEx = "10";
          break;
        case Rank.Jack:
          rankEx = " J";
          break;
        case Rank.Queen:
          rankEx = " Q";
          break;
        case Rank.King:
          rankEx = " K";
          break;
        default:
          break;
      }
      return rankEx;
    }

    private string GetSuitEx() {
      var suitEx = "";
      switch (suit) {
        case Suit.Club:
          suitEx = "黑桃";//♠
          break;
        case Suit.Diamond:
          suitEx = "方块";//♦
          break;
        case Suit.Heart:
          suitEx = "红心";//♥
          break;
        case Suit.Spade:
          suitEx = "梅花";//♣
          break;
        default:
          break;
      }
      return suitEx;
    }
  }
}
