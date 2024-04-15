using LINQ.Shared.V8;

namespace Cast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            var groundShippings = shippings.Where(s => s.GetType() == typeof(GroundShipping)).Cast<GroundShipping>();

            groundShippings.Process("Ground Shippings");
        }
    }
}
