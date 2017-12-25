using System;
using System.Linq;

namespace FizzBizzWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, string> func = n =>
             {
                 if (n%15==0)
                 {
                     return "FizzBizz"; 
                 }
                 if (n%3==0)
                 {
                     return "Fizz";
                 }
                 if (n%5==0)
                 {
                     return "Bizz";
                 }
                 return n.ToString();
             };
            Enumerable.Range(1,100).ToList().ForEach(i => Console.WriteLine(func(i)));
            Console.WriteLine("おわり");
        }
    }
}
