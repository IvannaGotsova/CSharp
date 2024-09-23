using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal static class PersonExtensions
    {
        public static bool IsGradeGood(this Person person, int grade)
        {
            return grade >= 100;
        }

        public static void StatusInformation(this Person person)
        {
            if (Person.status == "Regular") 
            {
                Console.WriteLine(Person.status);
            }
        }

        public static void GradePromotion (this Person person)
        {
            person.grade += 10;
        }

        public static string ShowCity(this Person person)
        {
            if (person.city == null)
            {
                return "No city!";
            }
            return person.city;
        }
    }
}
