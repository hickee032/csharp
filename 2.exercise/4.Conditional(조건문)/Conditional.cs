using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_conditional {
    internal class Conditional {
        static void Main(string[] args) {
            
            for(; ;) {
                Console.WriteLine();
                Console.WriteLine("MENU");
                Console.WriteLine();
                Console.WriteLine("1.치즈버거");
                Console.WriteLine("2.치킨버거");
                Console.WriteLine("3.빅맥버거");
                Console.WriteLine("Q 종료");
                Console.WriteLine("선택 : ");
                string input = Console.ReadLine(); ;

                if (input == "Q" || input == "q") {
                    Console.WriteLine("종료합니다.");
                    Environment.Exit(0);
                }
                else if(input == "1") {
                    Console.WriteLine("치즈버거를 선택");
                }
                else if (input == "2") {
                    Console.WriteLine("치킨버거를 선택");
                }
                else if (input == "3") {
                    Console.WriteLine("빅맥버거를 선택");
                }
                else {
                    Console.WriteLine("오류가 발생");
                }   
            } 
            
            while (true) {

                Console.WriteLine("번호를 선택하세요");

                string input  = Console.ReadLine();

                switch (input) {
                    case "1":
                        Console.WriteLine("1번 선택");
                        break;
                    case "2":
                        Console.WriteLine("2번 선택");
                        break;
                    case "3":
                        Console.WriteLine("3번 선택");
                        break;
                    case "q":
                        Console.WriteLine("q번 선택");
                        break;
                    case "Q":
                        Console.WriteLine("Q번 선택");
                        break;
                    default:
                        break;
                }
           
              }
            

            //점수를 입력받아 점수에 따라 A~F

            //정수 입력
            int input = int.Parse(Console.ReadLine());

            if (90 < input && input <= 100) {
                Console.WriteLine("A학점");
            }
            else if (80 < input && input <= 89) {
                Console.WriteLine("B학점");
            }
            else if (70 < input && input <= 79) {
                Console.WriteLine("C학점");
            }
            else if (60 < input && input <= 69) {
                Console.WriteLine("D학점");
            }
            else {
                Console.WriteLine("F학점");
            }



        }
    }
}
