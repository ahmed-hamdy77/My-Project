namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] data = {
            115,182,191,31,196,1099,5,172,10,179,83,21,20,21,
            186,177,195,193,188,199,62,109,105,183,110
        };

            int n = data.Length;

            Array.Sort(data);

            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += data[i];

            double mean = sum / n;

            double mode = data[0];
            int maxCount = 1;

            for (int i = 0; i < n; i++)
            {
                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (data[i] == data[j])
                        count++;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    mode = data[i];
                }
            }

            double median = data[n / 2];

            double variance = 0;
            for (int i = 0; i < n; i++)
                variance += Math.Pow(data[i] - mean, 2);

            variance /= n;

            double p20 = data[(int)(0.2 * n)];

            double p50 = median;

            double q1 = data[n / 4];

            double q2 = median;

            double q3 = data[(3 * n) / 4];

            double range = data[n - 1] - data[0];

            double iqr = q3 - q1;

            double std = Math.Sqrt(variance);

            double sumDev = 0;
            for (int i = 0; i < n; i++)
                sumDev += (data[i] - mean);

            Console.WriteLine("Mean = " + mean);
            Console.WriteLine("Mode = " + mode);
            Console.WriteLine("Median = " + median);
            Console.WriteLine("Variance = " + variance);
            Console.WriteLine("P20 = " + p20);
            Console.WriteLine("P50 = " + p50);
            Console.WriteLine("Third quartile = " + q1);
            Console.WriteLine("Second Quartile = " + q2);
            Console.WriteLine("Third Quartile = " + q3);
            Console.WriteLine("Range = " + range);
            Console.WriteLine("Interquartile Range = " + iqr);
            Console.WriteLine("Standard Division = " + std);
            Console.WriteLine("Summation of Divisions = " + sumDev);
        }
    }
} 
