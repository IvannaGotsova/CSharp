using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


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

            //Stack<int> stackExample = new Stack<int>();

            //stackExample.Push(1);
            //stackExample.Push(2);
            //stackExample.Push(3);
            //stackExample.Push(4);
            //stackExample.Push(5);
            //stackExample.Push(6);
            //stackExample.Push(7);
            //stackExample.Push(8);
            //stackExample.Push(9);
            //stackExample.Push(10);

            //stackExample.Pop();

            //foreach (var item in stackExample)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<int> queueExample = new Queue<int>();

            //queueExample.Enqueue(1);
            //queueExample.Enqueue(2);
            //queueExample.Enqueue(3);
            //queueExample.Enqueue(4);
            //queueExample.Enqueue(5);
            //queueExample.Enqueue(6);
            //queueExample.Enqueue(7);
            //queueExample.Enqueue(8);
            //queueExample.Enqueue(9);
            //queueExample.Enqueue(10);

            //queueExample.Dequeue();

            //foreach (var item in queueExample)
            //{
            //    Console.WriteLine(item);
            //}


            //HashSet<int> numbers = new HashSet<int>() { 1, 2, 3, 3, 4, 5, 6, 6, 6, 7, 8, 9};

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //List<int> sortedList = new List<int> { 1, 11, 1, 2, 3, 4, 1, 2, 2, 1, 2, 3, 4, 5, 6, 3, 3, 3, 13, 1, 4, 14, 11, 15, 13, 16, 21, 22, 21, 6, 7, 8, 9, 10, 11, 12, 0 };

            //sortedList.Sort();

            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine(item);
            //}

            Dictionary<int, string> dictionaryExample = new Dictionary<int, string>()
            {
                {0, "Zero" },
                {1, "One" },
                {2, "Two" },
                {3, "Three" },
                {4, "Four" }
            };

            foreach (KeyValuePair<int, string> keyValuePair in dictionaryExample)
            {
                Console.WriteLine($"{keyValuePair.Key}, {keyValuePair.Value}");
            }
        }
    }
}
