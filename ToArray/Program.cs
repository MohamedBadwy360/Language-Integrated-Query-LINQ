using LINQ.Shared.V8;

namespace ToArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;
            var shippingsArray = shippings.ToArray();
            Console.WriteLine($"Shippings Count = {shippingsArray.Length}");
            Console.WriteLine("First Shipping:");
            shippingsArray[0].Start();
        }
    }
}
