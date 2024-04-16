using LINQ.Shared.V1;
using LINQ.Shared.V2;

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
