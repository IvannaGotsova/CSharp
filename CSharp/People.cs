using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal abstract class People
    {
        public abstract void abstractPeople();

        public void noAbstractPeople()
        {
            Console.WriteLine("No abstract method");
        }

    }
}
