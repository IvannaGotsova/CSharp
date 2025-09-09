using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Second : First
    {
        public override void Greeting()
        {
            Console.WriteLine("Hello from First and Second");
        }
    }
}
