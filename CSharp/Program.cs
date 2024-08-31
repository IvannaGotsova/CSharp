using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp
{
    public class Program
    {
        //private enum StatusPerson
        //{
        //    Student = 1,
        //    Teacher = 2,
        //    Director = 3
        //}

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Console.WriteLine("-----------------------------------------------------------");
            //Strings strings = new Strings();
            //strings.PrintStrings();
            //strings.ManipulationStringArrays();
            //strings.FormatStrings();

            //Console.WriteLine("-----------------------------------------------------------");
            //DateTimes dateTimes = new DateTimes();
            //dateTimes.PrintDateTimes();
            //dateTimes.FormatDateTimes();

            //int age = 35;
            //Console.WriteLine(age);
            //Console.WriteLine(++age);
            //Console.WriteLine(age++);
            //Console.WriteLine(age);
            //Console.WriteLine(--age);
            //Console.WriteLine(age--);
            //Console.WriteLine(age);
            //Console.WriteLine();

            //Console.WriteLine("Number: " + 1 + 1);
            //Console.WriteLine(1 + 1 + "Number");

            //bool isTrue = true;
            //Console.WriteLine(isTrue);
            //madeFalse();
            //Console.WriteLine(isTrue);
            //madeTrue();
            //Console.WriteLine(isTrue);


            //void madeTrue()
            //{
            //    isTrue = true;
            //}

            //void madeFalse()
            //{
            //    isTrue = false;
            //}

            //Person person = new Person(1, "Test Name", 33);
            //Console.WriteLine(Person.status);
            //Person.status = "Irregular";
            //Console.WriteLine(Person.status);

            //person.ShowName("New Test Name");

            //StatusPerson statusPerson = StatusPerson.Student;
            //Console.WriteLine(statusPerson);

            //int[,] multiArray = { { 1, 2, 3, }, { 4, 5, 6 }, { 7, 8, 9 } };

            //for (int i = 0; i < multiArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < multiArray.GetLength(1); j++)
            //    {
            //        Console.WriteLine(multiArray[i,j]);
            //    }
            //}

            //Console.WriteLine();

            //int[][] jaggedArray = new int[3][];

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    jaggedArray[i] = new int[i + 10];

            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        jaggedArray[i][j] = i + j;
            //        Console.WriteLine(jaggedArray[i][j]);
            //    }
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write(j + 1 + " ");
            //    }

            //    Console.WriteLine();
            //}

            //printNumber(1);

            //void printNumber (int number) 
            //{
            //    if (number == 22)
            //    {
            //        return;
            //    }
            //    Console.WriteLine (number + 1);
            //    printNumber(number + 1);
            //}

            Stack<int> stackExample = new Stack<int>();

            stackExample.Push(1);
            stackExample.Push(2);
            stackExample.Push(3);
            stackExample.Push(4);
            stackExample.Push(5);
            stackExample.Push(6);
            stackExample.Push(7);
            stackExample.Push(8);
            stackExample.Push(9);
            stackExample.Push(10);

            stackExample.Pop();

            foreach (var item in stackExample)
            {
                Console.WriteLine(item);
            }

        }
    }
}
