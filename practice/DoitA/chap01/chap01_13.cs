using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_PrintStar {
    internal class chap01_PrintStar1 {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());

            do {
                Console.WriteLine("n : " + n);
            } while (n<=0);

            do {
                Console.WriteLine("w : "+ w);
            } while (w<=0||w>n);

            for (int i = 0; i < n; i++) {
                Console.Write("*");
                if (i%w == w-1) {
                    Console.WriteLine();
                }
            }
            if (n%w !=0) {
                Console.WriteLine();
            }
        }
    }
}
