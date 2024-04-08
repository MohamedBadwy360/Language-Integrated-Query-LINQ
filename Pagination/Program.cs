using LINQ.Shared.V3;

namespace Pagination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int page = 1;
            int size = 10;

            Console.WriteLine("Enter result in page: ");
            if (int.TryParse(Console.ReadLine(), out int resultInPage))
            {
                size = resultInPage;
            }

            Console.WriteLine("Enter Page No. : ");
            if (int.TryParse(Console.ReadLine(), out int pageNo))
            {
                page = pageNo;
            }

            var employees = Repository.LoadEmployees();

            var result = employees.Paginate(page, size);

            int resultCount = result.Count();

            var startRecord = (page - 1) * size + 1;

            var endRecord = (resultCount < size) ? (startRecord + resultCount - 1) : (page * size);

            result.Print($"Showing Employees from {startRecord} - {endRecord}");
        }
    }
}
