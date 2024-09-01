using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{

    // accessible within this assembly but not from another 
    internal class Person : People
    {
        private string privateName; 
        public string PrivateName 
        { 
            get 
            { return privateName = "Regular";  }
            private set
            { privateName = value;  }
        }

        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        // accessible within this class
        private int id;
        // accessible for all classes
        public string name;
        // accessible within this class or in a class that is inherited from that class
        protected int age;

        public static string status = "Regular";

        public void ShowName(string name) {
            Console.WriteLine(this.name);
            this.name = name;
            Console.WriteLine(name);
        }

        public override void abstractPeople()
        {
            Console.WriteLine("Abstract method");
        }
    }
}
