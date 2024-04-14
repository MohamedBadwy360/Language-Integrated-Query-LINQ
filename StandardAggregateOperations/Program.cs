
using LINQ.Shared.V6;

namespace StandardAggregateOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunCount();
            //RunMax();
            //RunMaxBy();
            //RunMin();
            //RunMinBy();
            //RunSum();
            RunAverage();
        }

        private static void RunAverage()
        {
            var quiz = QuestionBank.All;

            var average = quiz.Average(q => q.Title.Length);
            Console.WriteLine($"Average of questions title length = {average.ToString("#.##")}");
        }

        private static void RunSum()
        {
            var quiz = QuestionBank.All;

            int totalTitleLength = quiz.Sum(q => q.Title.Length);
            Console.WriteLine($"Total Title Length = {totalTitleLength}");
        }

        private static void RunMax()
        {
            var quiz = QuestionBank.All;

            var maxTitleLength = quiz.Max(q =>  q.Title.Length);
            Console.WriteLine($"Max Title Length: {maxTitleLength}");
        }
        private static void RunMaxBy()
        {
            var quiz = QuestionBank.All;

            var maxQuestionWithTitleLength = quiz.MaxBy(q => q.Title.Length);
            Console.WriteLine($"Question with Max Title Length:\n {maxQuestionWithTitleLength}");
        }
        private static void RunMin()
        {
            var quiz = QuestionBank.All;

            var minTitleLength = quiz.Min(q => q.Title.Length);
            Console.WriteLine($"Min Title Length: {minTitleLength}");
        }
        private static void RunMinBy()
        {
            var quiz = QuestionBank.All;

            var minQuestionWithTitleLength = quiz.MinBy(q => q.Title.Length);
            Console.WriteLine($"Question with Min Title Length:\n {minQuestionWithTitleLength}");
        }
        private static void RunCount()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));

            int count = quiz.Count();

            Console.WriteLine($"Total Quiz Question's Count = {count}");
            Console.WriteLine($"Total Questions with Title Length > 100 = {quiz.Count(q => q.Title.Length > 100)}");
            Console.WriteLine($"Total Questions with Title Length > 100 = {quiz.Where(q => q.Title.Length > 100).Count()}");
            Console.WriteLine($"Total Questions with Title Length > 100 using LongCount = {quiz.LongCount(q => q.Title.Length > 100)}");
        }
    }
}
