using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_Q15_4 {
    class Tri {

        public void TriangleLU(int n) {
            for (int i = 0; i < n; i++) {

                for (int j = 0; j < i; j++) {
                    Console.Write(" ");
                }
                for (int j = 2*n-1; j > 2*i; j--) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
    internal class chap01_Q15_4 {
        static void Main(string[] args) {

            Tri tr = new Tri();
            tr.TriangleLU(5);

        }
    }
}
