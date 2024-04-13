using LINQ.Shared.V6;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;

            var firstQuestion = questions.First();

            //var someQuestion = questions.First(x => x.Title.Length == 0);   //InvalidOperationException
            var someQuestion = questions.FirstOrDefault(x => x.Title.Length == 0);

            if (someQuestion is null)
            {
                Console.WriteLine("someQuestion is null.\n");
            }

            Console.WriteLine(firstQuestion);
        }
    }
}
