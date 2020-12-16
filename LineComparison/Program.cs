using System;

namespace LineComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation program on Master Branch");
            LineComparison lineComparison = new LineComparison();

            lineComparison.PointValues();
            double lineLength = lineComparison.GetLength();
            Console.WriteLine("Length of first Line according to points is= " + lineLength);
        }
    }
}
