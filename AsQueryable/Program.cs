using LINQ.Shared.V8;

namespace AsQueryable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;

            var todayShippings = shippings.Where(s => s.ShippingDate == DateTime.Today);
            todayShippings.Process("Today's shippings using ShippingList's Where");
            //Console.WriteLine(todayShippings.Expression);     // Not available for IEnumerable


            IQueryable<Shipping> todayShippings02 = shippings.AsQueryable().Where(s => s.ShippingDate == DateTime.Today);
            todayShippings02.Process("Today's shippings using IQueryable<T> Where");

            Console.WriteLine(todayShippings02.Expression);
        }
    }
}
