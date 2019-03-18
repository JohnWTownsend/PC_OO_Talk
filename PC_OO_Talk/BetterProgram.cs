using System;
using System.Collections.Generic;

namespace PC_OO_Talk
{
    class BetterProgram
    {
        static void Main(string[] args)
        {
            List<ProgrammingClubMember> programmingClubMembers = new List<ProgrammingClubMember>();
            var john = new ProgrammingClubMember(1, "John", "Townsend", new DateTime(1997, 4, 28), "Computer Science/Math", "Chartreuse");
            var collin = new ProgrammingClubMember(2, "Collin", "Rumpca", new DateTime(2018, 3, 18), "Game Design", "Gray");
            var jarod = new ProgrammingClubMember(3, "Jarod", "Keene", new DateTime(2018, 3, 19), "Cyber Ops", "White");
            var brendan = new ProgrammingClubMember(4, "Brendan", "Hansen", new DateTime(2018, 3, 20), "Literature", "Blue");

            programmingClubMembers.Add(john);
            programmingClubMembers.Add(collin);
            programmingClubMembers.Add(jarod);
            programmingClubMembers.Add(brendan);

            //Let's print off each person and and all their attributes

            foreach(var member in programmingClubMembers)
            {
                member.IntroduceYourself();
            }
            
            //What else can we do to make this better?
            //How can we make our ProgrammingClubMembers more unique? Maybe some inheritance? 
            //Should we make another class? Should we make our class more specific or general? 


            //Let's maybe use a DB
           
        }
    }
}
