using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // On Dimensional Array of String
            string[] courseName = { "C# course", "Javascript", "Database and SQL", "Version Control", "Data Science and AI", "Azure DevOps" };
            Console.Write("Select a number from 0 to 5 to choose a course: ");
            int n = Convert.ToInt32(Console.ReadLine());
            // Error handler
            if ( n > 5) {
                Console.WriteLine("The number you choose is not from 0 to 5");
                Console.ReadKey();
                return;
                
            }
            Console.WriteLine($"Course choosen - {courseName[n]}");
            
            // One Dimensional Array of Integer
            int[] age = {  24, 35, 12, 73, 42, 54};
            Console.Write("Choose a number from 0 to 5 to guess your age: ");
            int m = Convert.ToInt32(Console.ReadLine());
            // Error handler
            if (m > 5)
            {
                Console.WriteLine("The number you choose is not from 0 to 5");
                Console.ReadKey();
                return;

            }
            Console.WriteLine($"You are {age[m]} years old.");

            // List of String
            List<string> groceryList = new List<string>() { "Banana", "Baking soda", "mixed berries" };
            groceryList.Add("chicken breast");
            groceryList.Add("Milk");
            groceryList.Add("Eggs");
            // Get number from user
            Console.Write("Choose a number from 0 to 5 to buy an item at the grocery: ");
            int l = Convert.ToInt32(Console.ReadLine());
            // Error handler
            if (l > 5)
            {
                Console.WriteLine("The number you choose is not from 0 to 5");
                Console.ReadKey();
                return;

            }
            Console.WriteLine($"You choose {groceryList[l]} to buy at the grocery store.");

            Console.WriteLine("Press any key to terminate the program:");
            Console.ReadKey();
        }
    }
}
