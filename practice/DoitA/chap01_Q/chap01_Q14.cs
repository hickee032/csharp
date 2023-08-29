using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//직각 이등변 삼각형

namespace chap01_Q14 {

    class triangleLB {

        public void triangle(int n) {

            for (int i = 1; i <= n; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write("*");
                }

                Console.WriteLine();
            }      
        }

    }

    internal class chap01_Q14 {
        static void Main(string[] args) {

            triangleLB tl = new triangleLB();

            tl.triangle(5);


        }
    }
}
