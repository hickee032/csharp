using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_Q9 {

    class Sub {

        public int Subof(int a, int b) {
            int result = 0;

            if (a == b) {
                Console.WriteLine("a보다 큰값을 입력하세요");
            }
            else if (b < a) {
                Console.WriteLine("a보다 큰값을 입력하세요");
            }
            else {
                result = a - b;
            }
            return result;
        }
    }
    internal class chap01_Q9 {
        static void Main(string[] args) {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Sub su = new Sub();
            Console.WriteLine(su.Subof(a, b));
        }
    }
}
