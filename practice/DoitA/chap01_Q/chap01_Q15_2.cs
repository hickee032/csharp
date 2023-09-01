using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_Q15_2 {

    class Tri {

        public void TriangleLU(int n) {
            for (int i = 1; i <= n; i++) {
                for (int j = n; j >0; j--) {
                    if (i<j) {
                        Console.Write(" ");
                    }
                    else { 
                        Console.Write("*"); 
                    }
                }
                Console.WriteLine();
            }
            
        }
    }

    internal class chap01_Q15_2 {
        static void Main(string[] args) {
            Tri tr = new Tri();
            tr.TriangleLU(5);


        }
    }
}
