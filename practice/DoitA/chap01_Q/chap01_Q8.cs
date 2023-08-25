using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_Q8 {

    class sumof {
        public static int Sumof(int a, int b) {
            int sum = 0;

            if (a > b) {
                for (int i = b; i <= a; i++) {
                    sum += i;
                }
            }
            else if(a<b) {
                for (int i = a; i <= b; i++) {
                    sum += i;
                }
            }
            else {
                sum = 0;
            }

            return sum;
        }
    }


    internal class chap01_Q8 {
        static void Main(string[] args) {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            sumof sumof = new sumof();
            Console.WriteLine(sumof.Sumof(a, b));
            
        }
    }
}
