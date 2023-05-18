using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_02 {
    internal class Student {
        static void Main(string[] args) {


            int[] std = null;
            int n = 0;
            int sum = 0;
            double avr = 0.0;

            while (true) {


                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1.학생수 2.점수입력 3.점수리스트 4.분석 5.종료");
                Console.WriteLine("-------------------------------------------");
                Console.Write("입력 >>");

                int select = int.Parse(Console.ReadLine());

                if (select == 1) {
                    Console.Write("학생수를 입력 >>");
                    n = int.Parse(Console.ReadLine());
                    std = new int[n];
                }
                else if (select == 2) {
                    Console.WriteLine("점수를 입력 >>");

                    for (int i = 0; i < n; i++) {
                        std[i] = int.Parse(Console.ReadLine());
                    }
                }
                else if (select == 3) {
                    Console.WriteLine("점수리스트를 출력 >>");
                    for (int i = 0; i < std.Length; i++) {
                        Console.WriteLine((i + 1) + "번 학생의 점수 : " + std[i]);
                    }
                }
                else if (select == 4) {
                    Console.WriteLine("분석 결과를 출력 >>");

                    for (int i = 0; i < std.Length; i++) {
                        sum += std[i];
                    }
                    avr = sum / std.Length;
                    Console.WriteLine("점수의 총 합계 : " + sum);
                    Console.WriteLine("평균 점수 : " + avr);
                }
                else if (select == 5) {
                    Console.WriteLine("종료");
                    Environment.Exit(0);
                }
                else {
                    Console.WriteLine("잘못된 숫자 입력입니다");
                }

            }

        }
    }
}
