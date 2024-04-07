using LINQ.Shared.V3;

namespace Chunck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var chuncks = employees.Chunk(10).ToList();

            for (int i = 0; i < chuncks.Count; i++)
            {
                chuncks[i].Print($"Chunck[{i + 1}]");
            }
        }
    }
}
