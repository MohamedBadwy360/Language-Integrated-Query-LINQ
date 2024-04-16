using LINQ.Shared.V1;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apricote", "banana", "orange", "mango", "apple", "grape", "strewberry" };

            var fruitsReversed = fruits.Reverse();

            fruitsReversed.Print("fruitsReversed");
        }
    }
}
