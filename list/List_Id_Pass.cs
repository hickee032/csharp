using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_02_PR {
    internal class List_Id_Pass {
        static void Main(string[] args) {
            List<string> id = new List<string> {
                "kim","pack","lee","jung"
            };
            List<string> pass = new List<string> {

                "1111","2222","3333","4444"
            };

            while (true) {

                Console.Write("아이디를 입력 : ");
                string inputId = Console.ReadLine();

                int indexFind = id.FindIndex(x => x.Equals(inputId));

                if (indexFind == -1) {

                    Console.WriteLine("아이디가 없습니다.");

                    while (true) {
                        Console.WriteLine("가입하겠습니까? Y/N");

                        string signup = Console.ReadLine();

                        if (signup.Equals("Y")|| signup.Equals("y")) {

                            Console.WriteLine("가입창으로 이동합니다");
                            break;
                        }
                        else if (signup.Equals("N")|| signup.Equals("n")) {
                            Console.WriteLine("프로그램을 종료합니다");
                            Environment.Exit(0);
                        }
                        else {
                            Console.WriteLine("잘못된 입력입니다");
                            Console.WriteLine("다시입력하세요");
                        }
                    }
                }
                else {
                    while (true) {

                        Console.Write("비밀번호를 입력");
                        string inputPass = Console.ReadLine();
                        if (inputPass.Equals(pass[indexFind])) {
                            Console.WriteLine("로그인 성공");
                            break;

                        }
                        else {
                            Console.WriteLine("비밀번호 틀림");
                            Console.WriteLine("다시입력하세요");
                        }

                    }
                    
                }

            }
        }
    }
}
