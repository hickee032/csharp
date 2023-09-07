using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap02_ArrayRand {

    class ArrayRand {

        public int ArrRand(int[] a) {
            int max = a[0];
            for (int i = 1; i < a.Length; i++) {
                if (a[i]>max) {
                    max = a[i];
                }
            }
            return max;
        }
    }

    internal class chap02_ArrayRand {
        static void Main(string[] args) {

            ArrayRand ar = new ArrayRand();

            Random random= new Random();

            int input = int.Parse(Console.ReadLine());

            int[] height = new int[input];

            for (int i = 0; i < input; i++) {
                height[i] = 100 + random.Next(90);
                Console.WriteLine("height["+i+"] : " + height[i]);
            }

            Console.WriteLine(ar.ArrRand(height));
        }
    }
}
