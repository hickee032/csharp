using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace chap02_Q4 {
    internal class Program {

        static void Copy(int[] a, int[] b) {

            for (int i = 0; i < a.Length; i++) {
                b[i] = a[i];
            }
        }

        static void Main(string[] args) {

            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            int[] b = new int[7];
            Copy(a, b);

            Console.WriteLine(string.Join(", ", b));
        }
    }
}
