using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Third : Second
    {
        public override void Greeting()
        {
            Console.WriteLine("Hello from First, Second and Third");
        }
    }
}
