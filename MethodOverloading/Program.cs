namespace MethodOverloading
{
    public class Program
    {
        
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isMoney)
        {
            var sum = a + b;

            if (isMoney && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isMoney && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 1, false));
        }
    }
}
