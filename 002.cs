using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_숫자_출력_포멧
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iv = 12345;
            double dv = 12345.6789;
            double dv2 = 0.23;

            // D : 10진수
            Console.WriteLine("{0:D}", 12345);
            Console.WriteLine(iv.ToString("D"));

            // E : 지수
            Console.WriteLine("{0:E}", 12345.6789);
            Console.WriteLine(dv.ToString("E"));

            // F : 고정 소수점
            Console.WriteLine("{0:F}", dv);
            Console.WriteLine(dv.ToString());

            // G : 일반
            Console.WriteLine("{0:G}", dv);
            Console.WriteLine(dv.ToString("G"));
            Console.WriteLine("{0:G}", 0.00000023);

            // N : 숫자
            Console.WriteLine("{0:N}", 123456789);

            // P : 백분율
            Console.WriteLine("{0:P}", dv2);
            Console.WriteLine(dv2.ToString("P"));

            // X : 16진수
            Console.WriteLine("0x{0:X}", iv);
            Console.WriteLine("0x{0}", iv.ToString("X"));
        }
    }
}
