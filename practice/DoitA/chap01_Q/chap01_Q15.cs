using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//왼쪽 위 직각

namespace chap01_Q15 {

    class Tri {

        public void TriangleLU(int n) {

            for (int i = 1; i <= n; i++) {

                for (int j = i; j <= n; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();  
            }
            
        }
    }

    internal class chap01_Q15 {
        static void Main(string[] args) {
            Tri tr = new Tri();
            tr.TriangleLU(5);
        }

        
    }
}
