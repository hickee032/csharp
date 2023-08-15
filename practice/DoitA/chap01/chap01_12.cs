using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_Alternative1 {
    internal class chap01_Alternative1 {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("+ - 를 번갈아 "+ n +" 만큼 출력");

            for (int i = 0; i < n; i++) {
                if (i%2 ==0) {
                    Console.Write("+");
                }
                else {
                    Console.Write("-");
                }
            }



        }
    }
}
