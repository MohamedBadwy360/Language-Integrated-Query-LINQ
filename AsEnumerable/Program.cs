using LINQ.Shared.V8;

namespace AsEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;

            var todayShippings = shippings.Where(s => s.ShippingDate == DateTime.Today);
            todayShippings.Process("Today's shippings using ShippingList's Where");

            var todayShippings02 = shippings.AsEnumerable().Where(s => s.ShippingDate == DateTime.Today);
            todayShippings02.Process("Today's shippings using IEnumerable's Where");
        }
    }
}
