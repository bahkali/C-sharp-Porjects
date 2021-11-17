using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //deck = Shuffle(deck);
            deck = Shuffle(deck, 3);
            foreach( Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
                
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadKey();
        }

        public static Deck Shuffle (Deck deck)
        {
            Random random = new Random();
            List<Card> TempList = new List<Card>();

            while (deck.Cards.Count > 0)
            {
                // get a random number in deck range
                int randomIndex = random.Next(0, deck.Cards.Count);
                // the card at that index to the temp list
                TempList.Add(deck.Cards[randomIndex]);
                // Remove the card from the deck
                deck.Cards.RemoveAt(randomIndex);
            }
            // Transfer all the shuffle card to the empty deck card  than return it
            deck.Cards = TempList;
            return deck;
        }
    
        public static Deck Shuffle (Deck deck, int times)
        {
            for( int i = 0; i < times; i++)
            {
                deck = Shuffle(deck);
            }
            return deck;
        }
    
    }
}
