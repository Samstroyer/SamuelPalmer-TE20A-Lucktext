using System;

namespace Lucktext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There are 2 'puzzles', press the number of the puzzle you want.");
            string option = Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (option == "1")
            {
                puzzle1();
            }
            else if (option == "2")
            {
                puzzle2();
            }
            else
            {
                Console.WriteLine("That is not a puzzle! Try again lol.");
            }

            Console.ReadLine();
        }
        private static void puzzle1()
        {
            // 2 nouns, 1 verb, 1 action
            Console.WriteLine("Enter a name");
            string noun1 = Console.ReadLine();

            Console.WriteLine("Enter another name");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Enter a verb -present");
            string verb = Console.ReadLine();

            Console.WriteLine("Enter an action");
            string action = Console.ReadLine();

            Console.WriteLine($"{noun1} was once a living creature doing {verb}. {noun1} was friends with {noun2} and they loved {verb} together. One day {noun2} felt something was off and said it to {noun1}. It was a disturbance in the force they could feel. With their {action} powers they were able to find out what it was, it was the anti-{action}. {noun1} and {noun2} fought in an epic battle against anti-{action} that is still remembered today to secure the well being of {action}.");
        }
        private static void puzzle2()
        {
            // 5 nouns, 1 RIP thing, 1 weapon
            Console.WriteLine("Enter a name (1/5)");
            string noun1 = Console.ReadLine();

            Console.WriteLine("Enter another name (2/5)");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Enter another name (3/5)");
            string noun3 = Console.ReadLine();

            Console.WriteLine("Enter another name (4/5)");
            string noun4 = Console.ReadLine();

            Console.WriteLine("Enter another name (5/5)");
            string noun5 = Console.ReadLine();

            Console.WriteLine("Enter a unsuspecting way to die");
            string death = Console.ReadLine();

            Console.WriteLine("Enter a weapon name");
            string weapon = Console.ReadLine();

            Console.WriteLine($"There was once a group of 5 people, {noun1}, {noun2}, {noun3}, {noun4} and {noun5}. One day they were out scavaging and found a {weapon}, for the safety of their group they hid the {weapon} in a very secret location well knowing that it could otherwise be the end of their group. But that is what the dark lord {noun3} wanted! He had put the {weapon} where it was most dangerous, in his own hands, hoping the group would die so that he could conquer on his own. One day when the other members of the group was gone he picked up the weapon from its secret place. Ever since the group died of {death} by {noun3} the universe has been ruled by the lawless dark lord {noun3}!");
        }
    }
}
