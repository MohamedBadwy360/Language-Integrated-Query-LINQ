using LINQ.Shared.V8;

namespace ToDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            Dictionary<string, Shipping> dictionary = shippings.ToDictionary(s => s.UniqueId);
            dictionary["ABC005"].Start();

            Dictionary<DateTime, List<Shipping>> dictionary02 = shippings.GroupBy(s => s.ShippingDate)
                .ToDictionary(s => s.Key, s => s.ToList());
            DateTime date = new DateTime(2024, 4, 15, 0, 0, 0);
            dictionary02[date].Process($"Shippings On Date {date.ToString("dddd, MMMM dd yyyy")}");
        }
    }
}
