using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_while {
    internal class Program {
        static void Main(string[] args) {
            /*
            for(초기화, 조건식 , 반복식)
                {
                    //실행코드 }
            while (조건식) {

            }
            */


            for (int i = 1; i < 11; i++) {
                Console.WriteLine(i);
            }
            
            int num = 0;
            while (num < 11) {
                Console.WriteLine(num++);
            }

            int n = 10;
            while (true) {
                Console.WriteLine(n);
                n--;
                if (n<1) {
                    break;
                }

            }

        }
    }
}
