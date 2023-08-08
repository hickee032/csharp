using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_judgeABC2 {
    internal class Program {
        static void Main(string[] args) {

            int input = int.Parse(Console.ReadLine());

            if (input == 1) {
                Console.WriteLine("A");
            }
            else if (input == 2) {
                Console.WriteLine("B");
            }
            else if (input ==3) {
                Console.WriteLine("C");
            }
            else if (input == 4) {
                Console.WriteLine("D"); 
            }
            else {
                Console.WriteLine("F");
            }
        }
    }
}
