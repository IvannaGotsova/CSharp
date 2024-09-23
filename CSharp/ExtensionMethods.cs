using System;
using System.Collections.Generic;
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


    }
}
