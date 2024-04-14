
using LINQ.Shared.V6;

namespace Aggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunMethod1();
            //RunMethod2();
            RunMethod3();
        }

        private static void RunMethod1()
        {

            string[] names = new string[] { "Ali", "Mohamed", "Galal", "Samir", "Elsaid" };

            // Ali,Mohamed,.....
            //string output = "";
            //foreach (string name in names)
            //{
            //    output += $"{name},";
            //}
            //Console.WriteLine(output.TrimEnd(','));

            // Another Way
            //string output = string.Join(',', names);
            //Console.WriteLine(output);

            // Using Aggregate
            string commaSeparatedNames = names.Aggregate((a, b) => $"{a},{b}");
            Console.WriteLine(commaSeparatedNames);
        }

        private static void RunMethod2()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);

            // using Aggregate
            int total = numbers.Aggregate(0, (a, b) => a + b);
            Console.WriteLine(total);
        }

        private static void RunMethod3()
        {
            var quiz = QuestionBank.All;

            Question longestQuestionTitle = quiz[0];

            Question longestQuestion = quiz.Aggregate(longestQuestionTitle,
                (longest, next) => longest.Title.Length < next.Title.Length ? next : longest,
                question => question);

            Console.WriteLine($"Longest Question:\n {longestQuestion}");
        }
    }
}
