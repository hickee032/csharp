using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_01 {
    internal class Operation {
        static void Main(string[] args) {
            /*
            int a = 100;
            int b = 100;
            int c = a+b;
            Console.WriteLine(c);
            
            int a = 1;
            int total = 0;
            for (int i = 0; i < 100; i++) {
                total+= a+i;
            }
            Console.WriteLine(total);
            */

            int a = 3;
    
            for (int i = 1; i < 10; i++) {

                Console.WriteLine(a +" x " +i + " = "+a*i);
                Console.WriteLine("{0} x {1} = {2}", a, i, a * i);
            }

        }
    }
}
