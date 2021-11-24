using System;
using Casino;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var logo = @"
                     ______________________________________
                     /   _______________________________    \
                    |   |            __ __              |   |
                    | _ |    /\     ) _) /''''',        |   |
                    |(.)|   <  >    \ ) // '  `,        |   |
                    | ` |    \/       \/// ~ |~:    +   |   |
                    |   |             ///*\  ' :    |   |   |
                    |   |            ///***\_~.'    |   |   |
                    |   |  .'.    __///````,,..\_   |   |   |
                    |   |   ` \ _/* +_\#\\~\ooo/ \  |   |   |
                    |   |     |/:\ + *\_\#\~\so/!!\ |   |   |
                    |   |    _\_::\ * + \-\#\\o/!!!\|   |   |
                    |   |   / <_=::\ + */_____@_!!!_|   |   |
                    |   |  <__/_____\ */( /\______ _|   |   |
                    |   |   |_   _ __\/_)/* \   ._/  >  |   |
                    |   |   | !!! @     /* + \::=_>_/   |   |
                    |   |   |\!!!/o\\#\_\ + * \::_\     |   |
                    |   |   | \!!/os\~\#_\_* + \:/|     |   |
                    |   |   |  \_/ooo\~\\#_\+_*/- \     |   |
                    |   |   |    \''``,,,,///      .`.  |   |
                    |   |   |     ,.- ***///        '   |   |
                    |   |   |    : ~  \*///             |   |
                    |   |   +    : |   \//\             |   |
                    |   |        ,~  ~ //_( \     /\    | ; |
                    |   |        ,'  ` /_(__(    <  >   |(_)|
                    |   |         `````           \/    |   |
                    |   |_______________________________|   |
                     \______________________________________/

";
            bool validAnswer = false;

            Console.WriteLine(logo);

            DateTime dateTime = new DateTime();

            string file_path = @"c:\users\precisionm4800\desktop\c-sharp-projects-techacademy\logs\log.txt";
            //File.ReadAllText(File_path);

            Console.WriteLine("Welcome to the Grand Hotel and Casino.\nLet's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            //Check the input from the user
            while (!validAnswer) 
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only. no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                
                using (StreamWriter file = new StreamWriter(file_path, true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            //End Program
            Console.ReadKey();
        } 
    
    }
}
