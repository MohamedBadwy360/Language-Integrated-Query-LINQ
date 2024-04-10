using LINQ.Shared.V4;

namespace GroupingData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunGrouping();
            //RunGroupingQuerySyntax();
            RunToLookup();
        }

        private static void RunGrouping()
        {
            var employees = Repository.LoadEmployees();

            //IEnumerable<IGrouping<string, Employee>> group0 = employees.GroupBy(e => e.Department);

            var groups = employees.GroupBy(e => e.Department);

            foreach (var group in groups)
            {
                group.Print($"Employees in {group.Key} Department");
            }
        }

        private static void RunGroupingQuerySyntax()
        {
            var employees = Repository.LoadEmployees();

            var groups = from emp in employees
                         group emp by emp.Department;
                         
            foreach (var group in groups)
            {
                group.Print($"Employees in {group.Key} Department");
            }
        }

        private static void RunToLookup()
        {
            var employees = Repository.LoadEmployees();

            var groups = employees.ToLookup(e => e.Department);

            foreach (var group in groups)
            {
                group.Print($"Employees in {group.Key} Department");
            }
        }
    }
}
