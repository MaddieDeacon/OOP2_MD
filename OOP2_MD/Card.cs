using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MD
{
    class Card
    {
        public static string card_type(Card card) //(new) method to return the card's name
        {
            string suit = string.Empty;
            string value;
            string card_name;
            switch (card.Suit)//defines the suits 
            {
                case 1:
                    suit = "Hearts";

                    break;
                case 2:
                    suit = "Clubs";
                    break;
                case 3:
                    suit = "Dimonds";
                    break;
                case 4:
                    suit = "Spades";
                    break;
            }
            switch (card.Value)//defines the values for picture cards 
            {
                case 1:
                    value = "Ace";
                    break;
                case 11:
                    value = "Jack";
                    break;
                case 12:
                    value = "Queen";
                    break;
                case 13:
                    value = "King";
                    break;
                default:
                    value = (card.Value).ToString();
                    break;
            }
            card_name = value + " of " + suit; //creates the output of the cards requested 
            return card_name;
        }

  
        public int Value { get; set; }
        public int Suit { get; set; }
    }
   
       


}
