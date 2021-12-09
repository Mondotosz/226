using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercises
{
    public class PartyBuddy : Person
    {
        public PartyBuddy(string name, DateTime birthdate) : base(name, birthdate)
        {

        }

        public bool CanDrinkAlcohol()
        {
            return (DateTime.Now - _birthdate).Days / 365.25 >= 21;
        }
    }
}
