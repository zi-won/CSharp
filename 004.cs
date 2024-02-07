using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_조건문_실습1_두_개의_정수를_입력_받아_큰_수를_출력
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 정수를 입력하세요.");
            string input = Console.ReadLine();
            int num1;
            if(int.TryParse(input, out num1)==false)
            {
                Console.WriteLine("정수를 입력하지 않았습니다.");
                return;
            }
            Console.WriteLine("두 번째 정수를 입력하세요."); ;
            int num2;
            if(int.TryParse((string)input, out num2)==false) 
            {
                Console.WriteLine("정수를 입력하지 않았습니다.");
                return;
            }
            if(num1>num2)
            {
                Console.WriteLine("{0}이 {1}보다 큽니다.", num1, num2);
            }
            else if(num1 == num2)
            {
                Console.WriteLine("두 수는 모두 {0}입니다.", num1);
            }
            else
            {
                Console.WriteLine("{0}이 {1}보다 큽니다.", num2, num1);
            }
        }
    }
}
