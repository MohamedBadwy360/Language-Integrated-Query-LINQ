using LINQ.Shared.V6;

namespace Empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // immediate execution
            var questions = new List<Question>();
            // 1
            // .....
            // 1000
            foreach (var q in questions)
            {
                Console.WriteLine(q);
            }

            // deffered execution
            var questions2 = Enumerable.Empty<Question>();
            // 1
            // .....
            // 1000
            foreach (var q in questions)
            {
                Console.WriteLine(q);
            }
        }
    }
}
