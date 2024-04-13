using LINQ.Shared.V6;

namespace Last
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;

            var lastQuestion = questions.Last();

            //var someQuestion = questions.Last(x => x.Title.Length == 0);   //InvalidOperationException
            var someQuestion = questions.LastOrDefault(x => x.Title.Length == 0);

            if (someQuestion is null)
            {
                Console.WriteLine("someQuestion is null.\n");
            }

            Console.WriteLine(lastQuestion);
        }
    }
}
