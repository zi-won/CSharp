using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_문자열_출력_포멧
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("테스트 1:{0}, {1}, {2}", "Hello", 23.7, 10);
            Console.WriteLine("테스트 2:{0}, {2}, {1}", "Hello", 23.7, 10);

            // 배지
            Console.WriteLine("테스트 3:{0, 10}, {0, -10)끝", 1234);

            // 포멧 문자열
            Console.WriteLine("테스트 4:0x{0:X}, {0:E}, {0,N}", 12345678);
        }
    }
}
