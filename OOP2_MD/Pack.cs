using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MD
{
    class Pack
    {
        static List<Card> pack; //creates the pack of cards as a list 

        public Pack()
        {
            //Creates the pack
            pack = new List<Card>();
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    pack.Add(new Card { Suit = i, Value = j }); 
                }
            }
        }

        public static void FisherShuffle() //a shuffle 
        {
            
                    Console.WriteLine("Shuffling Cards.... Using Fisher-Yates shuffle"); //lets the user know it being shuffled and the type of shuffle 
                    Random R = new Random();
                    int k;
                    Card temp;
                    for (int i = pack.Count - 1; i > 0; i--)
                    {
                        k = R.Next(i + 1);
                        temp = pack[i];
                        pack[i] = pack[k];
                        pack[k] = temp;
                
                    }
            Thread.Sleep(2000); //a wait for asethic 
            Console.WriteLine("PACK SHUFFLE COMPLETE :)"); //lets the user know shuffle is done 
        }
       
        public static Card deal()
        {
            //Deals one card
            return pack.First();
        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            IEnumerable<Card> enumerable = pack.Take(amount);
            List<Card> cards = enumerable.ToList();
            return cards;
        }
    }
}


