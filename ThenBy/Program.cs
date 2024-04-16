using LINQ.Shared.V1;
using LINQ.Shared.V2;

namespace ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = RepositoryV2.LoadEmployees();

            var sortedEmpThenAsc = employees.OrderBy(e => e.Name).ThenBy(e => e.Salary);
            var sortedEmpThenDesc = employees.OrderBy(e => e.Name).ThenByDescending(e => e.Salary);

            sortedEmpThenAsc.Print("sortedEmpThenAsc");
            sortedEmpThenDesc.Print("sortedEmpThenDesc");
        }
    }
}
