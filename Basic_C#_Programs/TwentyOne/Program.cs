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

            Game game = new TwentyOne();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            game = game + player;


            //Game game = new Game() { Dealer = "Jesse", Name = "TwentyOne" };
            //TwentyOne game = new TwentyOne();
            //game.Players = new List<Player>() { "Jesse", "Bill", "Joe"};
            //game.ListPlayer();
            //game.Play();
            
            deck.Shuffle(3);
            foreach( Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
                
            }
            Console.WriteLine(deck.Cards.Count);
           
            Console.ReadKey();
        } 
    
    }
}
