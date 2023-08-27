using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_Q10 {

    class digitNum {
        public int digit(int a) {
            int n = 0;
                
            if(a /10 == 0) {
                Console.WriteLine(":::::"+n/10);
                n = 1;
            }
            else {
                if (a / 10 < 10) {
                    n = 2;
                }
                else if(a / 10 < 100) {
                    n = 3;
                }
                else if(a / 10 < 1000) {
                    n = 4;
                }
            }
            return n;
        }
    }


    internal class chap01_Q10 {
        static void Main(string[] args) {
            
            int a = int.Parse(Console.ReadLine());

            digitNum dn = new digitNum();
            Console.WriteLine(dn.digit(a));
            


        }
    }
}
