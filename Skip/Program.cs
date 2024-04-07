using LINQ.Shared.V3;

namespace Skip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var emps = employees.Skip(10);
            emps.Print("Skip First 10 employees");

            var emps02 = employees.SkipWhile(e => e.Salary != 214400);
            emps02.Print("Skip while salary != 214400");

            var emp03 = employees.SkipLast(10);
            emp03.Print("Skip Last 10 elements.");

        }
    }
}
