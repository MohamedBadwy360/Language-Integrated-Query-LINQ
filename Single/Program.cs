using LINQ.Shared.V6;

namespace Single
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;

            //var question = questions.Single(x => x.Title.Contains("245"));  // InvalidOperationException
            //var question = questions.SingleOrDefault(x => x.Title.Contains("245"));  // InvalidOperationException
            //var question = questions.Single(x => x.Title.Length == 0);  // InvalidOperationException
            var question = questions.SingleOrDefault(x => x.Title.Length == 0); 

            if (question is null)
            {
                Console.WriteLine("Question is null.");
            }
        }
    }
}
