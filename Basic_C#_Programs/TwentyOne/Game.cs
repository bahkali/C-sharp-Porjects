using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }

        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        //All inheritance class must implement this method play()
        //abstract method isn't implemented here
        public abstract void Play();
        // Virtual give the child class to change
        // the implementation or use the base implementation
        public virtual void ListPlayer()
        { 
            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }


    }
}
