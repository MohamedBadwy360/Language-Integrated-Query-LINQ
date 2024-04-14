using LINQ.Shared.V6;

namespace Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunMethod3();
        }

        static void RunMethod1()
        {
            var question1 = QuestionBank.PickOne();
            var question2 = QuestionBank.PickOne();
            var question3 = QuestionBank.PickOne();

            var quiz1 = new List<Question>(new[] {question1, question2, question3 });
            var quiz2 = new List<Question>(new[] {question1, question2, question3 });

            bool equal = quiz1.SequenceEqual(quiz2);

            Console.WriteLine($"Quiz#1 and Quiz#2 {(equal ? "are" : "are not")} equal.");
        }

        static void RunMethod2()
        {
            var someQuestions = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));

            var quiz1 = someQuestions;
            var quiz2 = someQuestions;

            bool equal = quiz1.SequenceEqual(quiz2);

            Console.WriteLine($"Quiz#1 and Quiz#2 {(equal ? "are" : "are not")} equal.");
        }

        static void RunMethod3()
        {
            var quiz1 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));
            var quiz2 = QuestionBank.GetQuestionRange(Enumerable.Range(1, 4));

            bool equal = quiz1.SequenceEqual(quiz2);

            Console.WriteLine($"Quiz#1 and Quiz#2 {(equal ? "are" : "are not")} equal.");
        }
    }
}
