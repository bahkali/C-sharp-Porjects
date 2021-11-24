using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            //Face lopp
            for (int i = 0; i < 13; i++)
            {
                //Suit Loop
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }

            }

        }
        public List<Card> Cards { get; set; }

      
        public void Shuffle( int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                Random random = new Random();
                List<Card> TempList = new List<Card>();

                while (Cards.Count > 0)
                {
                    // get a random number in deck range
                    int randomIndex = random.Next(0, Cards.Count);
                    // the card at that index to the temp list
                    TempList.Add(Cards[randomIndex]);
                    // Remove the card from the deck
                    Cards.RemoveAt(randomIndex);
                }
                // Transfer all the shuffle card to the empty deck card  than return it
                Cards = TempList;
            }
           
        }
    }
}
