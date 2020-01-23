using System;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            var insuredName = Policy.GetInstance.GetInsuredName();
            Console.WriteLine(insuredName);
            Console.ReadKey();
        }
    }
}
