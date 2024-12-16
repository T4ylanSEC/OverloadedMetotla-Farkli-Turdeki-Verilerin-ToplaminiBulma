using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedMetotla_Farkli_Turdeki_Verilerin_ToplaminiBulma
{
    class Program
    {
        static int CalculateSum(int a, int b)
        {
            return a + b;
        }

        static double CalculateSum(double a, double b)
        {
            return a + b;
        }

        static int CalculateSum(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {

            int sum1 = CalculateSum(1012, 113);
            Console.WriteLine("İki int Sayının Toplamı: " + sum1);

            double sum2 = CalculateSum(456.118, 412.86);
            Console.WriteLine("İki double Sayının Toplamı: " + sum2);

            int sum3 = CalculateSum(48, 156, 64);
            Console.WriteLine("Üç int Sayının Toplamı: " + sum3);

            Console.ReadKey();
            
        }
    }
}