using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int f1=0, f2=1, f3;
            int sum = 1;
            Console.WriteLine("Nhap n= ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tinh tong " + n + " so hang dau tien cua day Fibonacci");
            for (int i = 2; i < n; i++)
            {
                f3 = f1 + f2;
                sum = sum + f3;
                f1 = f2;
                f2 = f3;
            }
            Console.WriteLine("" + sum);
            Console.ReadKey();

            int m, number;
            Console.WriteLine("Tim cac so nguyen to nho hon m\n");
            Console.WriteLine("Nhap vao gia tri m=");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (number = 1; number <= m; number++)
            {
                int dem = 0;
                for (int i = 1; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 1)
                {
                    Console.WriteLine(+number + " La so nguyen to\n");
                }
            }
            Console.ReadKey();
        }
    }
}
