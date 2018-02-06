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
            Squarer d = CalcX4;
            d += CalcSqrt;
            d(15);
        }

        static int CalcX2(int x) => 2 * x;

        static int CalcX4(int x)
        {
            var result = CalcX2(CalcX2(x));
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
