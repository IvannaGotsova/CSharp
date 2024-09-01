using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Director : Person
    {
        public Director(int id, string name, int age) : base(id, name, age)
        {
        }

        public override string ToString()
        {
            return "I am Director";
        }
    }
}
