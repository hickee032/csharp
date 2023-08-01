using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OpenCording {
    internal class ForFactorial01 {
        static void Main(string[] args) {

            int fact = 0;

            for (int i = 1; i <= 4; i++) {
                Console.Write($"{i}!->");
                fact = 1;
                for (int j = 1; j <=i ; j++) {
                    fact = fact * j; //1* (1 * 2 * 3 * 4)
                }

                Console.WriteLine($"{fact,2}");

            }

        }
    }
}
