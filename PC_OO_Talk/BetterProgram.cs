using System;
using System.Collections.Generic;
using System.Linq;

namespace PC_OO_Talk
{
    class BetterProgram
    {
        static void Main(string[] args)
        {
            List<ProgrammingClubMember> programmingClubMembers = new List<ProgrammingClubMember>();
            programmingClubMembers.Add(new ProgrammingClubMember(1,"John","Townsend",new DateTime(1997,4,28),"Computer Science/Math", "Chartreuse"));
            programmingClubMembers.Add(new ProgrammingClubMember(2,"Collin","Rumpca",new DateTime(2018,3,18),"Game Design", "Gray"));
            programmingClubMembers.Add(new ProgrammingClubMember(3,"Jarod","Keene",new DateTime(2018,3,19),"Cyber Ops", "White"));
            programmingClubMembers.Add(new ProgrammingClubMember(4,"Brendan","Hansen",new DateTime(2018,3,20),"Literature", "Blue"));

            //Let's print off each person and and all their attributes

            foreach(var member in programmingClubMembers)
            {
                member.IntroduceYourself();
            }
            
            //What else can we do to make this better?
            //How can we make our ProgrammingClubMembers more unique? Maybe some inheritance? 
            //Should we make a 
           
        }
    }
}
