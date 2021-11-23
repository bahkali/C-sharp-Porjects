using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
       Two,
       Three,
       Four,
       Five,
       Six,
       Seven,
       Eight,
       Nine,
       Ten,
       Jack,
       Queen, 
       king,
       Ace
    }
}
