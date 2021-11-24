using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }

        public int Balance { get; set; }

        public void Deal (List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            // Append text to file
            string file_path = @"c:\users\precisionm4800\desktop\c-sharp-projects-techacademy\logs\log.txt";
            using (StreamWriter file = new StreamWriter(file_path, true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }

            Deck.Cards.RemoveAt(0);
        }
    }
}
