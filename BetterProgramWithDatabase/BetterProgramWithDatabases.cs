using Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BetterProgramWithDatabase
{
    class BetterProgramWithDatabases
    {
        static void Main(string[] args)
        {
            PC_OOContext pcOOContext = new PC_OOContext();

            List<ProgrammingClubMember> programmingClubMembers = pcOOContext.ProgrammingClubMembers.Select(x => x).ToList();

            //Let's print off each person and and all their attributes

            foreach (var member in programmingClubMembers)
            {
                member.IntroduceYourself();
            }

        }
    }
}
