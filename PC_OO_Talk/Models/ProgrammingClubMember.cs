using System;
using System.Collections.Generic;

namespace PC_OO_Talk
{
    public partial class ProgrammingClubMember
    {
        public ProgrammingClubMember()
        {

        }

        public ProgrammingClubMember(int id, string firstName, string lastName, DateTime birthDate, string major, string favoriteColor)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Major = major;
            FavoriteColor = favoriteColor;
        }

        public void IntroduceYourself()
        {
            String message = $"Hello! My Name is {FirstName} {LastName}! I was born on {BirthDate.ToShortDateString()}" +
                             $" and my major is {Major}. My favorite color is {FavoriteColor}.";
            Console.WriteLine(message);
        }

          
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Major { get; set; }
        public string FavoriteColor { get; set; }
    }
}
