using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {/// <summary>
    /// ввод данных
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            int m = Input("m= ");
            int c = Input("c= ");
            int C=Centimeters(m, c);
            int r = Input("r= ");
            int k = Input("k= ");
            int K=Kop(r, k);
            int L=Little(m, c, r);
            int x = Input("x= ");
            int y = Input("y= ");
            int a = Input("a= ");
            int b = Input("b= ");
            int min = Min(x, y);
            int calc = Calc(a, b);
            double z = Func(7) + Func(11) + Func(15);
            double i = Function();
            Console.WriteLine($"всего копеек: {K}");
            Console.WriteLine($"всего сантиметров: {C}");
            Console.WriteLine($"наибольшее число: {L}");
            Console.WriteLine($"результат: {calc}");
            Console.WriteLine($"уравнение={z:F1}");
            Console.WriteLine($"уравнение={i:F1}");
            Console.Read();
        }
        /// <summary>
        /// ввод данных
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// задача 1
        /// </summary>
        /// <param name="m"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int Centimeters(int m, int c)
        {
            return m * 100 + c;
        }
        /// <summary>
        /// задача 2
        /// </summary>
        /// <param name="r"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int Kop(int r, int k)
        {
            return r * 100 + k;
        }
        /// <summary>
        /// задача 3 
        /// </summary>
        /// <param name="m"></param>
        /// <param name="c"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int Little(int m, int c, int r)
        { 
            if (m>=c && c>=r)
            {
                return m;
            }
            else if (m<=c && c>=r)
            {
                return c;
            }
            else 
            {
                return r;
            }
        }
        /// <summary>
        /// задача 4 поиск наименьшего
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Min(int x, int y)
        {
            return(x > y) ? x : y;
        }
        /// <summary>
        /// задача 4 вычисление
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Calc(int a,int b)
        {
            return Min(2 * a, b + a) + Min(2 * a - b, b);
        }
        /// <summary>
        /// задача 5
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static double Func(int v)
        {
            return (Math.Sqrt(v) + v) / 3;
        }
        /// <summary>
        /// задача 6
        /// </summary>
        /// <returns></returns>
        public static double Function()
        {
            double num1 = 15 + Math.Sqrt(8);
            double den1 = 8 + Math.Sqrt(15);
            double number1 = num1 / den1;
            double num2 = 6 + Math.Sqrt(12);
            double den2 = 12 + Math.Sqrt(6);
            double number2 = num2 / den2;
            double num3 = 7 + Math.Sqrt(21);
            double den3 = 21 + Math.Sqrt(7);
            double number3 = num3 / den3;
            double number = number1 + number2 + number3;
            return number;
        }
    }
}
