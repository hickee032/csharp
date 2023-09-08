using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap02_ReverseArray {

    class ReverseArr {

        public void ReverseArray(int[] a, int idx1, int idx2) {
            Console.WriteLine("*ReverseArray");
            int t = a[idx1];
            a[idx1] = a[idx2];
            a[idx2] = t;

        }

        public void Reverse(int[] a) {
            for (int i = 0; i < a.Length/2; i++) {
                ReverseArray(a, i, a.Length - i - 1);
            }
        }
    }

    internal class chap02_ReverseArray {
        static void Main(string[] args) {

            ReverseArr ra = new ReverseArr();

            Console.WriteLine("요소수 : ");
            int input = int.Parse(Console.ReadLine());
            int[] x = new int[input];

            for (int i = 0; i < input; i++) {
                Console.Write("x[" + i + "] : ");
                x[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(", ", x));

            ra.Reverse(x);

            Console.WriteLine(string.Join(", ", x));
        }
    }
}
