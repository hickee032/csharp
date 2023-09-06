using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap02_MaxofArray {

    class MaxofArray {
        public int maxof(int[] a) {
            int max = a[0];

            for (int i = 1; i < a.Length; i++) {
                if (a[i]>max) {
                    max = a[i];
                }
            }

            return max;
        }
    }

    internal class chap02_MaxofArray {
        static void Main(string[] args) {

            MaxofArray mx = new MaxofArray();

            Console.WriteLine("키의 최대값을 구합니다");
            Console.Write("사람 수 : ");
            int input = int.Parse(Console.ReadLine());

            int[] height = new int[input];

            for (int i = 0; i < input; i++) {
                Console.Write("height["+i+"] : ");
                height[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(mx.maxof(height));
            


        }
    }
}
