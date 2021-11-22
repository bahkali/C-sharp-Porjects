using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        //All inheritance class must implement this method play()
        //abstract method isn't implemented here
        public abstract void Play();
        // Virtual give the child class to change
        // the implementation or use the base implementation
        public virtual void ListPlayer()
        { 
            foreach(string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
