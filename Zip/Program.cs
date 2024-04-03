namespace Zip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colorNames = { "Red", "Green", "Blue" };
            string[] colorNumbers = { "FFF", "EEE", "NNN" };

            var colors = colorNames.Zip(colorNumbers, (name, hex) => $"{name} ({hex})");

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
