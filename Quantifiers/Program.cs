using LINQ.Shared.V3;

namespace Quantifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunAny();
            //RunAll();
            //RunQuerySyntax();
            RunContains();
        }

        private static void RunAny()
        {
            Console.WriteLine("============");
            Console.WriteLine("Run Any");
            Console.WriteLine("============");

            var employees = Repository.LoadEmployees();

            // if any employee name starts with some sequence of letter
            string input1 = "jac";
            bool result1 = employees.Any(e => e.Name.StartsWith(input1, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"find employee with name starts with '{input1}' result: {result1}");

            // if any employee employee salary less tham 1000
            int input2 = 10_000;
            bool result2 = employees.Any(e => e.Salary < input2);
            Console.WriteLine($"find employee with name starts with '{input2}' result: {result2}");
        }

        private static void RunAll()
        {
            Console.WriteLine("============");
            Console.WriteLine("Run All");
            Console.WriteLine("============");

            var employees = Repository.LoadEmployees();

            // if all employees have email defined
            bool result1 = employees.All(e => !string.IsNullOrWhiteSpace(e.Email));
            Console.WriteLine($"if all employees have email defined: {result1}");

            // if all employees have C# skill
            bool result2 = employees.All(e => e.Skills.Any(s => s == "C#"));
            Console.WriteLine($"if all employees have C# skill: {result2}");
        }

        private static void RunQuerySyntax()
        {
            Console.WriteLine("============");
            Console.WriteLine("Run Query Syntax");
            Console.WriteLine("============");

            var employees = Repository.LoadEmployees();

            var query1 = from emp in employees
                         where emp.Skills.Any(s => s == "C++")
                         select emp;
            query1.Print("Employees with C++ skill");


            var query2 = from emp in employees
                         where emp.Skills.All(s => s.Length >= 3)
                         select emp;
            query2.Print("Employees having skills 3 chars or more");
        }

        private static void RunContains()
        {
            Console.WriteLine("============");
            Console.WriteLine("Run Contains");
            Console.WriteLine("============");

            var employees = Repository.LoadEmployees();

            bool result1 = employees.Any(e => e.Name.Contains("ee"));

            // if any employee contains 'ee' in his/her name
            Console.WriteLine($"if any employee contains 'ee' in his/her name: {result1}");

            var e = new Employee { Email = "Cole.Cochran@example.com" };
            bool result2 = employees.Contains(e);
            Console.WriteLine($"if any employee contains \"{e.Email}\" in his/her name: {result2}");
        }
    }
}
