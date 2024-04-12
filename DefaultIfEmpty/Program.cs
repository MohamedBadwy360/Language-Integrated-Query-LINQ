using LINQ.Shared.V6;

namespace DefaultIfEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = Enumerable.Empty<Question>();
            var question = questions.DefaultIfEmpty(Question.Default);

            question.ToQuiz();
        }
    }
}
