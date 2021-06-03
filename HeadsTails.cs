using System;

namespace HeadsTails
{
    class Program
    {
        // Basic heads / tails coin flipper
        static void Main(string[] args)
        {
            Flip();

            Console.ReadLine();
        }

        static string Flip()
        {
            // returns either "Heads" or "Tails" with equal probability
            Random rand = new Random();
            int choice = rand.Next(0, 2);
            string side;

            if (choice == 0)
            {
                side = "Heads";
            }
            else
            {
                side = "Tails";
            }

            return side
        }
    }
}
