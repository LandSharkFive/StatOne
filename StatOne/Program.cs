namespace StatOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] dx = { 1, 2, 4, 5, 6, 8, 9, 10, 21, 46 };
            double[] dy = { 1, 3, 5, 4, 6, 9, 10, 10, 22, 46 };

            Console.WriteLine("Count = {0}", dx.Count());
            Console.WriteLine("Average = {0}", dx.Average());
            Console.WriteLine("Range = {0}", dx.Range());
            Console.WriteLine("Variance = {0}", dx.Variance());
            Console.WriteLine("Standard Deviation = {0}", dx.StandardDeviation());
            Console.WriteLine();

            Console.WriteLine("XMean = {0}", dx.Average());
            Console.WriteLine("YMean = {0}", dy.Average());
            double yIntercept = 0;
            double slope = Util.GetSlopeIntercept(dx, dy, out yIntercept);
            Console.WriteLine("Slope = {0}", slope);
            Console.WriteLine("YIntercept = {0}", yIntercept);
            Console.WriteLine("XIntercept = {0}", Util.GetXIntercept(slope, yIntercept));   
            Console.WriteLine("X = 1, Y = {0}", Util.GetY(1, slope, yIntercept));
            Console.WriteLine("X = 2, Y = {0}", Util.GetY(2, slope, yIntercept));
            Console.WriteLine("X = 3, Y = {0}", Util.GetY(3, slope, yIntercept));
            double r = Util.Correlation(dx, dy);
            Console.WriteLine("R = {0}", r);
            double r2 = Util.RSquared(r);
            Console.WriteLine("R2 = {0}", r2);
            Console.WriteLine("Pearson = {0}", Util.Pearson(dx, dy));
            Console.WriteLine("X2 = {0}", Util.ChiSquared(dx.ToArray(), dy.ToArray()));
        }
    }
}