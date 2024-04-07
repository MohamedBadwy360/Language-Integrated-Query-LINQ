using LINQ.Shared.V3;

namespace Take
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var emps = employees.Take(10);
            emps.Print("Take First 10 employees");

            var emps02 = employees.TakeWhile(e => e.Salary != 214400);
            emps02.Print("Take while salary != 214400");

            var emp03 = employees.TakeLast(10);
            emp03.Print("Take Last 10 elements.");
        }
    }
}
