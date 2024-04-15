using LINQ.Shared.V9;

namespace CustomLINQMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.Employees;
            //employees.Print("All Employees");

            // Pagination
            
            //int page = 2;
            //int pageSize = 30;
            //var page1 = employees.Skip((page - 1) * pageSize).Take(pageSize);

            var page1 = employees.Paginate();
            var page2 = employees.Paginate(2);
            page1.Print("Page #1");
            page2.Print("Page #2");

            var page3 = employees.Paginate2(3, null);
            page3.Print("Page #3");

            var page1x7Covered = employees.WhereWithPaginate(e => e.HasHealthInsurance, 1, 7);
            page1x7Covered.Print("Page #1 [7 Emps Covered]");

            var randomCoveredEmployee = employees.Random(e => e.HasHealthInsurance);

            Console.WriteLine("\nRandom Covered Employee\n");
            Console.WriteLine(randomCoveredEmployee);
        }
    }
}
