using LINQ.Shared.V8;

namespace ToLookup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            ILookup<string, Shipping> lookup = shippings.ToLookup(s => s.UniqueId);
            lookup["ABC005"].First().Start();

            ILookup<DateTime, Shipping> lookup02 = shippings.ToLookup(s => s.ShippingDate);

            DateTime date = new DateTime(2024, 4, 15, 0, 0, 0);
            lookup02[date].Process($"Shippings On Date {date.ToString("dddd, MMMM dd yyyy")}");
        }
    }
}
