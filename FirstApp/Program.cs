using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FirstApp
{
    class Program
    {

        delegate int Squarer(int x);
        delegate int TestSecond();
        static void Main(string[] args)
        {
            WriteLine("Hello, World!");
            Squarer d = CalcSqr;
            d += CalcSqrt;
            d(15);
            var cookie = new CookieOfLuck();
            Console.WriteLine($"Please read the prediction for today: \"{cookie.NextMessage()}\"");
        }

        static int CalcSqr(int x)
        {
            var result = x * x;
            WriteLine($"calculating... {x} * {x} = {result}");
            return result;
        }

        static int CalcSqrt(int x)
        {
            var result = Convert.ToInt32(Math.Sqrt(x));
            WriteLine($"calculating... Sqrt ({x}) = {result}");
            return result;
        }
    }
}
