using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap02_Q3 {

    class ArrSum {
        public int ArrSumof(int[] a) {
            int result = 0;

            for (int i = 0; i < a.Length; i++) {
                result += a[i];
            }
            return result;
        }
    }

    internal class Program {
        static void Main(string[] args) {

            ArrSum sum = new ArrSum();
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int n = sum.ArrSumof(a);
            Console.WriteLine(n);

        }
    }
}
