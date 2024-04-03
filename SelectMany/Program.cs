using LINQTut04.Shared;

namespace SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunExample01();
            RunExample02();
        }

        private static void RunExample01()
        {
            string[] sentences =
            {
                "I love asp.net",
                "Hi, Mohamed",
                "We play tennis"
            };

            var words = sentences.SelectMany(s => s.Split(" "));

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        private static void RunExample02()
        {
            var employees = Repository.LoadEmployees();

            var skills = employees.SelectMany(e => e.Skills).Distinct();

            //var skills02 = (from employee in employees
            //                from skill in skills
            //                select skill).Distinct();

            foreach (var skill in skills)
            {
                Console.WriteLine(skill);
            }
        }
    }
}
