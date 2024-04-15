using LINQ.Shared.V8;

namespace OfType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

            var groundShippings = shippings.OfType<GroundShipping>();

            groundShippings.Process("Ground Shippings");
        }
    }
}
