using LINQ.Shared;

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
