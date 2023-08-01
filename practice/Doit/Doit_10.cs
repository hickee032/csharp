using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_pr {
    internal class Array_pr {
        static void Main(string[] args) {

            int[] array1 = new int[3];
            array1[0] = 10;
            array1[1] = 20;
            array1[2] = 30;

            int[] array2 = new int[] {1,2,3};
            int[] array3 = { 4, 5, 6 };

            Console.WriteLine(array1[0]);

            Console.WriteLine(array2);

            Console.WriteLine(array3);

            for (int i = 0; i < array1.Length; i++) {
                Console.WriteLine(array1[i]);
            }

            Console.WriteLine("array3");

            foreach (int i in array3) {
                Console.WriteLine(i);
            }
        }
    }
}
