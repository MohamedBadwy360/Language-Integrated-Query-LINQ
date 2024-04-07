using LINQ.Shared;

namespace OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apricote", "banana", "orange", "mango", "apple", "grape", "strewberry" };

            var orderedFruits = fruits.OrderBy(f => f);

            //var orderedFruitsQuerySyntax = from fruit in fruits
            //                               orderby fruit
            //                               select fruit;

            var orderedFruitsDescending = fruits.OrderByDescending(f => f);

            //var orderedFruitsDescendingQuerySyntax = from fruit in fruits
            //                                         orderby fruit descending
            //                                         select fruit;

            var orderedFruitsAscByLength = fruits.OrderBy(f => f.Length);

            //var orderedFruitsAscByLengthQuerySyntax = from fruit in fruits
            //                                          orderby fruit.Length
            //                                          select fruit;

            var orderedFruitsDescByLength = fruits.OrderByDescending(f => f.Length);

            //var orderedFruitsDescByLengthQuerySynatax = from fruit in fruits
            //                                            orderby fruit.Length descending
            //                                            select fruit;

            orderedFruits.Print("Ordered Fruits Ascending");
            orderedFruitsDescending.Print("Ordered Fruits Descending");
            orderedFruitsAscByLength.Print("Ordered Fruits Ascending by Length");
            orderedFruitsDescByLength.Print("Ordered Fruits Descending by Length");

        }
    }
}
