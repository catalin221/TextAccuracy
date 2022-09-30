using Faker;
using System.Net;

namespace TextAccuracy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateText.RandomText() + '\n');
            
        }
    }
}