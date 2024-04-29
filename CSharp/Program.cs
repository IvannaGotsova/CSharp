namespace CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Console.WriteLine("-----------------------------------------------------------");
            Strings strings = new Strings();
            strings.PrintStrings();
            strings.ManipulationStringArrays();
            strings.FormatStrings();
            
            Console.WriteLine("-----------------------------------------------------------");
            DateTimes dateTimes = new DateTimes();
            dateTimes.PrintDateTimes();
            dateTimes.FormatDateTimes();
        }
    }
}
