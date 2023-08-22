using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_Q3 {
    internal class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine(Min4(a, b, c, d));    
        }

        static int Min4(int a,int b,int c,int d) {
            int n = a;
            if (n > b) {
                n = b;
                if (n>c) {
                    n = c;
                }
                if (n>d) {
                    n = d;
                }
            }

            return n;
        }
    }
}
