using SequenceEngine;
using System;
using System.Diagnostics;
using System.Drawing;
using static SequenceEngine.Card;

namespace SequencePlay
{
  //public enum CardSuit
  //{
  //  Spades = 1,
  //  Hearts,
  //  Diamonds,
  //  Clubs,
  //  Wild
  //}

  //public enum CardRank
  //{
  //  Ace = 1,
  //  Deuce,
  //  Three,
  //  Four,
  //  Five,
  //  Six,
  //  Seven,
  //  Eight,
  //  Nine,
  //  Ten,
  //  Jack,
  //  Queen,
  //  King,
  //  Wild
  //}

  public static class CardImageHelper
  {
    public static Image GetCardImage(Board_Square bs)
    {
      return GetCardImage(bs.Face, bs.Suit, bs.IsFrozen, bs.TokenColor);
    }

    internal static Image GetCardImage(Card card)
    {
      return GetCardImage(card.Face, card.Suit);
    }

    public static Image GetCardImage(CardType_Enum Face, SuitType_Enum Suit, bool isFrozen = false, TokenColor_Enum color = TokenColor_Enum.None)
    {
      double x, y;
      bool Visible = true;

      if (Visible)
      {
        //if (card.Rank == CardRank.Eight && (card.Suit == CardSuit.Spades || card.Suit == CardSuit.Clubs))
        //{
        //}
        int Number = Convert.ToInt32(Face);

        //Define the card position in the cards image
        if (Number < 10)
        {
          Number++;
          y = (Number - 1) % 2;
          x = (Number - 1) / 2;

          switch (Suit)
          {
            case SuitType_Enum.Spades:
              y += 6;
              break;
            case SuitType_Enum.Hearts:
              y += 0;
              break;
            case SuitType_Enum.Diamonds:
              y += 2;
              break;
            case SuitType_Enum.Clubs:
              y += 4;
              break;
          }
        }
        else if (Number == 14) //wild
        {
          x = 6;
          y = 9;
        }
        else // face cards
        {
          int number = (Number + 11);

          switch (Suit)
          {
            case SuitType_Enum.Spades:
              number += 6;
              break;
            case SuitType_Enum.Hearts:
              number += 9;
              break;
            case SuitType_Enum.Diamonds:
              number += 3;
              break;
            //case Card.SuitType_Enum.Clubs:
            //  number += 0;
            //  break;
          }

          y = (number % 2) + 8;
          x = number / 2;
        }
      }
      else
      {
        x = 7;  //Show back of the card
        y = 5;
      }

      if (Face == CardType_Enum.Queen || Face == CardType_Enum.King)
      {
        x -= 11;
      }
      if (Face == CardType_Enum.OneEyedJack)
      {
        //1IJ Spades: 3_8
        //1IJ Diamonds: 1_9
        x = 3;
        y = 8;
        if (Suit == SuitType_Enum.Diamonds)
        {
          x = 1;
          y = 9;
        }
      }
      if (Face == CardType_Enum.TwoEyedJack)
      {
        //2IJ Hearts: 4_9
        //2Ij Clubs: 0_8
        x = 0;
        y = 8;
        if (Suit == SuitType_Enum.Hearts)
        {
          x = 4;
          y = 9;
        }
      }
      string imageName = (isFrozen ? (color == TokenColor_Enum.Green ? "green" : "blue") : "card") + x.ToString() + "_" + y.ToString();
      //Debug.Assert(imageName.StartsWith("card"));
      Image image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
      return image;
    }

    internal static Image GetPlayedImage(Board_Square bs)
    {
      Image image = null;
      if (bs.TokenColor == TokenColor_Enum.Green)
      {
        image = (Image)Properties.Resources.ResourceManager.GetObject("tokengreen");
        if (bs.IsFrozen)
        {
          //image = (Image)Properties.Resources.ResourceManager.GetObject("tokengreensmall");
          image = GetCardImage(bs);
        }
      }
      else // blue
      {
        image = (Image)Properties.Resources.ResourceManager.GetObject("tokenblue");
        if (bs.IsFrozen)
        {
          //image = (Image)Properties.Resources.ResourceManager.GetObject("tokenbluesmall");
          image = GetCardImage(bs);
        }
      }
      return image;
    }
  }
}