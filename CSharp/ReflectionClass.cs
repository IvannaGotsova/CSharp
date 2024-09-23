using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class ReflectionClass
    {
        public string ReflectionString;
        public int ReflectionInt;

        public ReflectionClass(string reflectionString, int reflectionInt)
        {
            ReflectionString = reflectionString;
            ReflectionInt = reflectionInt;
        }

        public void ReflectionMethosString(string example)
        {
            Console.WriteLine(example);
        }

        public void ReflectionMethosInt(int example)
        {
            Console.WriteLine(example);
        }
    }
}
