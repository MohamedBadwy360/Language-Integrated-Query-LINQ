using LINQ.Shared.V6;

namespace Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = Enumerable.Range(1, 10);

            foreach (var i in range)
            {
                Console.Write($" {i}");
            }

            var questions = QuestionBank.GetQuestionRange(range);
            questions.ToQuiz();
        }
    }
}
