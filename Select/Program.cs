using LINQ.Shared.V1;

namespace Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample01();
            RunExample02();
            RunExample03();
        }

        private static void RunExample01()
        {
            List<string> words = new List<string> { "i", "love", "asp.net"};

            var result = words.Select(w => w.ToUpper());

            // Query Syntax
            //var result02 = from w in words
            //               select w.ToUpper();

            foreach (string word in result)
            {
                Console.WriteLine(word);
            }
        }

        private static void RunExample02()
        {
            // Mathematical Operation
            List<int> numbers = new List<int> { 1, 3, 5, 6 };

            var result = numbers.Select(n => n * n);

            // Query Syntax
            //var result02 = from n in numbers
            //               select n * n;

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }

        private static void RunExample03()
        {
            var employees = Repository.LoadEmployees();

            var result = employees.Select(e => new { Name = e.FirstName, TotalSkill = e.Skills.Count });

            foreach (var employee in result)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
