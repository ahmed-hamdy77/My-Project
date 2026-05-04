namespace project._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = {
            115,182,191,31,196,1099,5,172,10,179,83,21,20,21,
            186,177,195,193,188,199,62,109,105,183,110
        };

            Array.Sort(data);
            int n = data.Length;

            int q1 = data[n / 4];
            int q3 = data[(3 * n) / 4];

            int iqr = q3 - q1;

            int lower = q1 - (int)(1.5 * iqr);
            int upper = q3 + (int)(1.5 * iqr);

            Console.WriteLine("Outliers:");

            for (int i = 0; i < n; i++)
            {
                if (data[i] < lower || data[i] > upper)
                {
                    Console.WriteLine(data[i]);
                }
            }
        }
    }
}
