

namespace ConsoleAppCs
{
    public static class Methods
    {
        public static void SayHi(string firstName)
        {
            Console.WriteLine($"Hello {firstName}!");
            Console.WriteLine("I hope you are having a good day.");
        }

        public static void Add(double x, double y)
        {
            Console.WriteLine($"The value of {x} + {y} = {x + y}");
        }

        public static void AddAll(double[] values)
        {
            double result = 0;

            foreach (double value in values)
            {
                result += value;
            }

            Console.WriteLine($"The total is {result}");
        }

    }
}
