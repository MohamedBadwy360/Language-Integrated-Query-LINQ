using LINQ.Shared.V8;

namespace ToList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            var shippingsList = shippings.ToList();

            Console.WriteLine($"Shippings Count = {shippingsList.Count}");
            Console.WriteLine("\nFirst Shipping:");
            shippingsList[0].Start();
            shippingsList.First().Start();
        }
    }
}
