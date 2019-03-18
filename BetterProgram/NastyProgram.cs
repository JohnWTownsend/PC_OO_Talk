using System;

namespace PC_OO_Talk
{
    class NastyProgram
    {
        static void Main(string[] args)
        {
            string[] FirstNames = { "John", "Collin", "Jarod", "Brendan" };
            string[] LastNames = { "Townsend", "Rumpca", "Keene", "Hansen" };
            DateTime[] BirthDates = { new DateTime(1997,4,28), new DateTime(2018,3,18), new DateTime(2018, 3, 19), new DateTime(2018, 3, 20) };
            string[] Majors = { "Computer Science/Math", "Game Design", "Cyber Ops", "Literature" };
            string[] FavoriteColors = {"Chartreuse", "Gray", "White", "Blue"};

            //Let's print off each person and and all their attributes
            for(int i = 0; i < FirstNames.Length; i++)
            {
                Console.Write(FirstNames[i] + " ");
                Console.Write(LastNames[i] + " ");
                Console.Write(BirthDates[i].ToShortDateString() + " ");
                Console.Write(Majors[i] + " ");
                Console.Write(FavoriteColors[i] + " ");
                Console.WriteLine();
            }
            Console.Read();
            

            //Is this a good approach?
            //Can we make it better?

        }
    }
}
