using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Teacher : Person
    {
        public Teacher(int id, string name, int age) : base(id, name, age)
        {
        }

        public override string ToString()
        {
            return "I am Teacher";
        }
    }
}
