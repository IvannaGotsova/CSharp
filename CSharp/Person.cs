using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{

    // accessible within this assembly but not from another 
    internal class Person
    {
        // accessible within this class
        private int id;
        // accessible for all classes
        public string name;
        // accessible within this class or in a class that is inherited from that class
        protected int age;
    }
}
