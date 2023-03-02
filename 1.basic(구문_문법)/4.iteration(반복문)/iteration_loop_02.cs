using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_02 {
    internal class Loop_02 {
        static void Main(string[] args) {

            string str = "홍길동";
            foreach (var st in str) {
                Console.WriteLine(st);
            }

            bool b = false;

            //무한반복문
            //while (true) { };
            //for (;;); //접근할수 없는 코드             

            //이중반복문
            int num = 1;
            for (int i = 0; i < 3; i++) {           //행--3행
                for (int j = 0; j < 2; j++) {       //열--2열
                    Console.Write($"{num++}\t");
                }
                Console.WriteLine();
            }

            for (int i = 1; i < 10; i++) {
                for (int j = 2; j < 10; j++) {

                    Console.Write($"{j}" + "x" + $"{i}" + "=" + $"{j * i}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------");

            for (int i = 1; i < 10; i++) {
                for (int j = 9; j > 1; j--) {

                    Console.Write($"{j}" + "x" + $"{i}" + "=" + $"{j * i}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
