using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
using System;


namespace CSharp
{

    //public class Number
    //{
    //    public event EventHandler CorrectNumber;
    //    public void CheckNumber()
    //    {
    //        int number = 0;

    //        for (int i = number; i < 100000; i++)
    //        {
    //            if (i == 22)
    //            {
    //                CorrectNumber?.Invoke(this, EventArgs.Empty);
    //            }
    //        }

    //    }
    //}

    //public class RightNumber
    //{
    //    public void DoSomething(object sender, EventArgs e)
    //    {
    //        Console.WriteLine("TWENTY TWO");
    //    }
    //}

    public class Program
    {
        //private enum StatusPerson
        //{
        //    Student = 1,
        //    Teacher = 2,
        //    Director = 3
        //}

        //public struct StructExample(int one, int two)
        //{
        //    public int one = one;
        //    public int two = two;
        //}

        //private delegate void MethodsOne();
        //private static Action MethodsTwo;
        //private static Func<int> MethodsThree;


        //public delegate void EnterKeyPressedEventHandler(object sender, EventArgs e);
        //public static event EnterKeyPressedEventHandler EnterKeyPressed;

        //public delegate void ReachNumberEventHandler(object sender, EventArgs e, int number);
        //public static event ReachNumberEventHandler NumberReached;

        //public delegate void ReachParticularSeconds(object sender, EventArgs e, int seconds);
        //public static event ReachParticularSeconds SecondsReached;


        //public delegate int SumDelegateExample(int numberOne, int numberTwo);

        //public delegate string TextDelegateExample(string name);


        //static void Sum(int one, int two)
        //{
        //    Console.WriteLine(one + two);
        //}

        //static void Sum(int one, int two, int three)
        //{
        //    Console.WriteLine(one + two + three);
        //}

        //static void Sum(double one, double two)
        //{
        //    Console.WriteLine(one + two);
        //}

        static void Main(string[] args)
        {

            Console.WriteLine("Write first number!");
            int numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Write second number!");
            int numberTwo = int.Parse(Console.ReadLine());

            int result;

            try
            {
                result = numberOne / numberTwo;
                Console.WriteLine($"Result is: {result}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.TargetSite);
            }
            finally
            {
                Console.WriteLine("Finally!!!");
            }

            //int numberOne = 22;
            //int numberTwo = 44;
            //int numberThree = 55;
            //double numberFour = 2.5;
            //double numberFive = -5.5;

            //Console.WriteLine(Math.Abs(numberFive));
            //Console.WriteLine(Math.Pow(numberFour, Math.Abs(numberFive)));
            //Console.WriteLine(Math.Round(numberFour));
            //Console.WriteLine(Math.Round(numberFive));
            //Console.WriteLine(Math.PI);
            //Console.WriteLine(Math.Max(numberOne, numberTwo));
            //Console.WriteLine(Math.Min(numberOne, numberTwo));
            //Console.WriteLine(Math.Ceiling(numberFour));
            //Console.WriteLine(Math.Floor(numberFour));
            //Console.WriteLine(Math.Sign(numberOne));
            //Console.WriteLine(Math.Sign(numberTwo));
            //Console.WriteLine(Math.E);
            //Console.WriteLine(Math.Tau);
            //Console.WriteLine(Math.Cbrt(numberFive));
            //Console.WriteLine(Math.Clamp(numberOne, numberTwo, numberThree));
            //Console.WriteLine(Math.CopySign(numberFour, numberFive));
            //Console.WriteLine(Math.Exp(numberFive));

            //Sum(numberOne, numberTwo);
            //Sum(numberOne, numberTwo, numberThree);
            //Sum(numberFour, numberFive);

            //char charExample = 'a';
            //int intExample = 1;
            //long longExampole = 1000000000000000000;
            //float floatExample = 1f;
            //double doubleExample = 1.1;

            //Console.WriteLine("Float to Double");
            //double doubleExampleImplicit = floatExample;
            //Console.WriteLine(doubleExampleImplicit);

            //Console.WriteLine("Double to Float");
            //float floatExampleImplicit = (float)doubleExample;
            //Console.WriteLine(floatExampleImplicit);

            //Console.WriteLine("Char to Double");
            //double doubleExampleImplicit2 = charExample;
            //Console.WriteLine(doubleExampleImplicit2);

            //Console.WriteLine("Float to Char");
            //char charExampleImplicit = (char)floatExample;
            //Console.WriteLine(charExampleImplicit);

            //Console.WriteLine("Char to Long");
            //long longExampleImplicit = charExample;
            //Console.WriteLine(longExampleImplicit);

            //Console.WriteLine("Long to Char");
            //long longExampleImplicit2 = (char)floatExample;
            //Console.WriteLine(longExampleImplicit2);

            //Console.WriteLine("Int to Double");
            //double doubleExampleImplicit3 = intExample;
            //Console.WriteLine(doubleExampleImplicit3);

            //Console.WriteLine("Double to Int");
            //int intExampleImplicit = (int)doubleExample;
            //Console.WriteLine(intExampleImplicit);

            //Console.WriteLine("Int to String");
            //Console.WriteLine(Convert.ToString(intExample));

            //Console.WriteLine("Double to String");
            //Console.WriteLine(Convert.ToString(doubleExample));

            //Console.WriteLine("Int to Double");
            //Console.WriteLine(Convert.ToDouble(floatExample));

            //Console.WriteLine("Float to Int");
            //Console.WriteLine(Convert.ToInt64(floatExample));

            //Console.WriteLine("Write first number!");
            //int numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Write second number!");
            //int numberTwo = int.Parse(Console.ReadLine());

            //int result;

            //try
            //{
            //    result = numberOne / numberTwo;
            //    Console.WriteLine($"Result is: {result}");

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally 
            //{
            //    Console.WriteLine("Finally!!!");
            //}

            //Console.WriteLine("End of the program!");

            //GenericsExample<string> genericsExampleString = new GenericsExample<string>();
            //genericsExampleString.genericsExampleMethod("Some string");

            //GenericsExample<int> genericsExampleInt = new GenericsExample<int>();
            //genericsExampleInt.genericsExampleMethod(2);

            //GenericsExample<bool> genericsExampleBool = new GenericsExample<bool>();
            //genericsExampleBool.genericsExampleMethod(false);

            //SecondsReached += OnSecondsReached;

            //Console.WriteLine("Choose seconds!");
            //int seconds = int.Parse(Console.ReadLine());

            //int counter = 0;

            //while (counter <= 10)
            //{
            //    Thread.Sleep(seconds * 1000);
            //    SecondsReached?.Invoke(null, EventArgs.Empty, seconds);
            //    counter++;
            //}

            //TextDelegateExample textDelegateExample = TextDelegateMethod;
            //Console.WriteLine("Write your name.");
            //string name = Console.ReadLine();
            //Console.WriteLine(textDelegateExample.Invoke(name));
        }

        //private class GenericsExample<T>
        //{

        //    private T genericsExampleField;

        //    public void genericsExampleMethod(T genericsExampleField)
        //    {
        //        Console.WriteLine(genericsExampleField.GetType());
        //    }
        //}


        //static string TextDelegateMethod(string name)
        //{
        //    return $"Hello {name}!";
        //}

        //private static void OnSecondsReached(object sender, EventArgs e, int seconds)
        //{
        //    Console.WriteLine($"You reached {seconds} seconds!");
        //}


        //    NumberReached += OnNumberReached;

        //    Console.WriteLine("Choose a number!");

        //    int stopNumber = int.Parse(Console.ReadLine());
        //    int startNumber = 0;

        //    while(stopNumber >= startNumber) 
        //    {
        //        Console.WriteLine(startNumber);

        //        if (stopNumber == startNumber)
        //        {
        //            NumberReached?.Invoke(null, EventArgs.Empty, stopNumber);
        //            break;
        //        }

        //        startNumber++;
        //    }
        //}

        //private static void OnNumberReached(object sender, EventArgs e, int number)
        //{
        //    Console.WriteLine($"You reached the number {number}!");
        //}

        //    EnterKeyPressed += OnEnterKeyPressed;

        //    Console.WriteLine("Press any key!");

        //    while (true)
        //    {
        //        ConsoleKeyInfo keyToCheck = Console.ReadKey(true);
        //        Console.WriteLine(keyToCheck.Key);

        //        if (keyToCheck.Key == ConsoleKey.Enter)
        //        {
        //            EnterKeyPressed?.Invoke(null, EventArgs.Empty);
        //            break;
        //        }
        //        Console.WriteLine("Wrong key was pressed!");
        //    }
        //}

        //private static void OnEnterKeyPressed(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Right key was pressed!");
        //}


        //number.CheckNumber();


        //Person person = new Person(1, "Ivan", 33);
        //person.city = "Sofia";

        //string city = "";

        //switch (person.name)
        //{
        //    case "Ivan" when person.city == "Plovdiv" :
        //        city = "Plovdiv";
        //        break;
        //    case "Ivan" when person.city == "Sofia":
        //        city = "Sofia";
        //        break;
        //    case "Ivan" when person.city == "Varna":
        //        city = "Plovdiv";
        //        break;
        //    case "Ivan" when person.city == "":
        //        city = "Other";
        //        break;
        //    case "" when person.city == "Plovdiv":
        //        city = "Plovdiv";
        //        break;
        //    case "" when person.city == "Sofia":
        //        city = "Sofia";
        //        break;
        //    case "" when person.city == "Varna":
        //        city = "Plovdiv";
        //        break;
        //    case "" when person.city == "":
        //        city = "Other";
        //        break;
        //}

        //Console.WriteLine(person.city);

        //Number number = new Number();
        //RightNumber rightNumber = new RightNumber();
        //number.CorrectNumber += rightNumber.DoSomething;
        //number.CheckNumber();


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

        //Dictionary<int, string> dictionaryExample = new Dictionary<int, string>()
        //{
        //    {0, "Zero" },
        //    {1, "One" },
        //    {2, "Two" },
        //    {3, "Three" },
        //    {4, "Four" }
        //};

        //foreach (KeyValuePair<int, string> keyValuePair in dictionaryExample)
        //{
        //    Console.WriteLine($"{keyValuePair.Key}, {keyValuePair.Value}");
        //}

        //printNumbers(1, 3, 5, 7, 9, 2, 4, 6, 8);

        //void printNumbers(params int[] numbers)
        //{
        //    foreach (var item in numbers)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //Person person = new Person(1, "Ivan", 33);
        //Console.WriteLine(person.name);

        //Person personTwo = person;
        //personTwo.name = "Test";
        //Console.WriteLine(personTwo.name);
        //Console.WriteLine(person.name);


        //printNumbers();

        //void printNumbers(int number = 1)
        //{
        //    Console.WriteLine(number);
        //}


        //printNumbers2();

        //void printNumbers2(int[] numbers = null)
        //{
        //    if (numbers == null)
        //    {
        //        numbers = new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8 };
        //    }

        //    foreach (var item in numbers)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}


        //StructExample structExample = new StructExample();

        //Console.WriteLine(structExample.one);
        //Console.WriteLine(structExample.two);

        //structExample.one = 11;
        //structExample.two = 12;


        //Console.WriteLine(structExample.one);
        //Console.WriteLine(structExample.two);

        //Person person = new Person(1, "Ivan", 33);
        //Student student = new Student(1, "Ivan", 33);
        //Teacher teacher = new Teacher(1, "Ivan", 33);
        //Director director = new Director(1, "Ivan", 33);

        //Console.WriteLine(person.ToString());
        //Console.WriteLine(student.ToString());
        //Console.WriteLine(teacher.ToString());
        //Console.WriteLine(director.ToString());


        //Person person = new Person(1, "Ivan", 33);
        //person.noAbstractPeople();
        //person.abstractPeople();

        //Person person = new Person(1, "Ivan", 33);
        //person.Write();
        //person.Read();


        //IWritable writable = new Student(1, "Ivan", 33);
        //IReadable readable = new Teacher(2, "Petar", 33);

        //Console.WriteLine(writable.GetType() == typeof(Person));
        //Console.WriteLine(readable.GetType() == typeof(Person));

        //Console.WriteLine(writable is Person);
        //Console.WriteLine(readable is Person);

        //Person directorOne = writable as Person;
        //Person directorTwo = readable as Person;

        //Console.WriteLine(directorOne.GetType());
        //Console.WriteLine(directorTwo.GetType());

        //Console.WriteLine(directorOne is Person);
        //Console.WriteLine(directorTwo is Person);


        //void oneMethod() 
        //{
        //    Console.WriteLine("One method");
        //}

        //void twoMethod()
        //{
        //    Console.WriteLine("Two method");
        //}

        //void threeMethod()
        //{
        //    Console.WriteLine("Third method");
        //}

        //MethodsOne methodsOne;

        //methodsOne = oneMethod;
        //methodsOne += twoMethod;
        //methodsOne += threeMethod;

        //methodsOne();

        //MethodsTwo = (() =>
        //{
        //    oneMethod();
        //    twoMethod();
        //    threeMethod();
        //});

        //MethodsTwo();

        //Func<int, int, int> MethodsThree = (int a, int b) =>
        //{
        //    return a + b;
        //};

        //Console.WriteLine(MethodsThree(2, 2 ));

    }
}
