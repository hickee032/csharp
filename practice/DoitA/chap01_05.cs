using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_judgeABC {
    internal class Program {
        static void Main(string[] args) {

            int input = int.Parse(Console.ReadLine());

            if (input==1) {
                Console.WriteLine("A");
            }
            else if(input==2) {
                Console.WriteLine("B");
            }
            else {
                Console.WriteLine("C");
            }

        }
    }
}
