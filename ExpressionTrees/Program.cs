using System.Linq;
using System.Linq.Expressions;

namespace ExpressionTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> IsEven = num => num % 2 == 0;

            Console.WriteLine(IsEven(10));
            Console.WriteLine(IsEven.Invoke(10));


            // ================================================================================
            // Expression
            Expression<Func<int, bool>> IsEvenExpression = num => num % 2 == 0;
            var IsEvenV2 = IsEvenExpression.Compile();  // Compile Ecpression to a delegate that describe this lambda expression
            Console.WriteLine(IsEvenV2(10));


            // ================================================================================
            // Decompose ExpressionTree
            Expression<Func<int, bool>> IsNegativeExpression = num => num < 0;

            ParameterExpression parameter = IsNegativeExpression.Parameters[0];
            BinaryExpression operation = (BinaryExpression)IsNegativeExpression.Body;
            ParameterExpression left = (ParameterExpression)operation.Left;
            ConstantExpression right = (ConstantExpression)operation.Right;

            Console.WriteLine($"\nDecompose Expression Tree: {parameter.Name} => {left.Name} {operation.NodeType} {right.Value}");


            // ================================================================================
            // Build Expression Tree from scratch using API
            // num => num % 2 != 0
            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
            ConstantExpression zeroParam = Expression.Constant(0, typeof(int));
            ConstantExpression twoParam = Expression.Constant(2, typeof(int));
            BinaryExpression moduloBinaryExpression = Expression.Modulo(numParam, twoParam);
            BinaryExpression IsOddBinaryExpression = Expression.NotEqual(moduloBinaryExpression, zeroParam);

            Expression<Func<int, bool>> IsOddExpression = Expression.Lambda<Func<int, bool>>(IsOddBinaryExpression,
                new ParameterExpression[] { numParam });

            var IsOdd = IsOddExpression.Compile();
            Console.WriteLine($"9 is odd? {IsOdd(9)}");
        }
    }
}
