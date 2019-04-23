using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, number;
            Console.WriteLine("Tim cac so nguyen to nho hon n\n");
            Console.WriteLine("Nhap vao gia tr n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (number=1; number<= n; number ++)
            {
                int dem = 0;
                for(int i=1; i<= number/2; i++)
                {
                    if(number % i == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 1)
                {
                    Console.WriteLine(+number+" La so nguyen to\n");
                }
            }
            Console.ReadKey();
        }

    }
}