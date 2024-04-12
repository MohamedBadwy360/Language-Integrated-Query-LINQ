using LINQ.Shared.V6;

namespace Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var q = QuestionBank.PickOne();

            var questions = Enumerable.Repeat(q, 10);
            questions.ToQuiz();
        }
    }
}
