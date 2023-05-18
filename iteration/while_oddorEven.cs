using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddorEven {
    internal class OddorEven {
        static void Main(string[] args) {

            Console.WriteLine("홀짝 판단 프로그램");

            while (true) {
                Console.WriteLine("숫자 입력 : ");

                try {
                    int n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0) {
                        Console.WriteLine(n + "은 짝수 입니다.");
                    }
                    else {
                        Console.WriteLine(n + "은 홀수 입니다.");
                    }
                }

                catch (Exception) {
                    Console.WriteLine("숫자가 아닙니다.");
                    Console.WriteLine("숫자를 입력하세요");
                }
            }
        }
    }
}
