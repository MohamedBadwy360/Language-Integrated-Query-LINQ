using LINQ.Shared;

namespace OrderBy.Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<EmployeeV2> employees = RepositoryV2.LoadEmployees();
            IOrderedEnumerable<EmployeeV2> sortedEmps = employees.OrderBy(e => e, new EmployeeComparer());

            sortedEmps.Print("sortedEmps");
        }
    }
}
