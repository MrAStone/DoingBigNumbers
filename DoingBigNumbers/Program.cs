using System.Numerics;
namespace DoingBigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = 1;
            for(int i = 1; i <= 100; i++)
            {
                n = BigInteger.Multiply(n, i);
            }
            Console.WriteLine(n.ToString());
        }
    }
}
