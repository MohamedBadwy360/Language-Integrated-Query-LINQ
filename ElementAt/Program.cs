using LINQ.Shared.V6;

namespace ElementAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;

            var questionAt10 = questions.ElementAt(10);
            //var questionAt300 = questions.ElementAt(300);     // ArgumentOutOfRangeException

            var questionAt300 = questions.ElementAtOrDefault(300);

            Console.WriteLine(questionAt300);
        }
    }
}
