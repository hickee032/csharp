using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SciCalculator {
    internal class SciCalculator {
        static void Main(string[] args) {

            //3*(2+1)-4

            string fm = Console.ReadLine(); // 식 입력
            char[] charFm = fm.ToCharArray(); //하나씩 저장

            Stack<int> scNum = new Stack<int>(); //숫자 저장
            Stack<char> scOper = new Stack<char>(); //숫자 저장
            //List<char> oper = new List<char>(); // 연산자 저장

            List<int> caNum = new List<int>();

            List<char> braNum = new List<char>(); // () 숫자 저장
            Queue<char> braOper = new Queue<char>();

            for (int i = 0; i < charFm.Length; i++) {

                //Console.WriteLine("charFm[i]"+charFm[i]);
                if (charFm[i].Equals('(')) {
                    //문자열 검색
                    do {
                        braNum.Add(charFm[i]);
                        
                        i++;
                    } while (charFm[i].Equals(')'));
                }
                else {
                    Console.WriteLine("check1 : " + i + " : " + charFm[i]);
                    if (char.IsNumber(charFm[i])) {
                        scNum.Push(int.Parse(charFm[i].ToString()));
                    }
                    if (!(char.IsNumber(charFm[i]))) {
                        scOper.Push(charFm[i]);
                    }
                }

            }
            Console.WriteLine($"scNum 내부 : " + string.Join(" : ", scNum.ToArray()));
            Console.WriteLine($"scOper 내부 : " + string.Join(" : ", scOper.ToArray()));
            Console.WriteLine($"braNum 내부 : " + string.Join(" : ", braNum.ToArray()));
            Console.WriteLine($"braOper 내부 : " + string.Join(" : ", braNum.ToArray()));

        }


        static int calculate(char a,int n,int m) {
            int cal = 0;
            switch (a) {
                case '+': cal = n+m; break;
                case '-': cal = n-m; break;
                case '*': cal = n*m; break;
                case '/': cal = n/m; break;
            }
            return cal;
        }
    }
}
