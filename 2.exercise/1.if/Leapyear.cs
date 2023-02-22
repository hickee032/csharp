using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_01 {
    internal class Leapyear {
        static void Main(string[] args) {

            Console.WriteLine("---------------------------");
            Console.WriteLine("윤년 구분 프로그램");
            Console.WriteLine("---------------------------");

            Console.WriteLine("년도를 입력하세요");
            Console.Write("입력");

            int input = int.Parse(Console.ReadLine());

            if (input % 4 == 0 && input % 100 != 0 || input % 400 == 0) {
                Console.WriteLine(input + "년도는 윤년입니다");
            }
            else {
                Console.WriteLine(input + "년도는 윤년아닙니다");
            }

        }
    }
}
