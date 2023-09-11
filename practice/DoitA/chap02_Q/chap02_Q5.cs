using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap02_Q5 {
    internal class chap02_Q5 {

        static void Copy(int[] a, int[] b) {
            int count = a.Length-1;

            for (int i = 0; i < a.Length; i++) {
                Console.WriteLine(count);
                b[i] = a[count];
                count--;
            }
        }


        static void Main(string[] args) {


            int[] a = { 1, 2, 3, 4, 5, 6 };
            int[] b = new int[6];

            Copy(a, b);

            Console.WriteLine(string.Join(", ", b));
        }
    }
}
