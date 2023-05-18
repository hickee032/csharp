using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_03 {
    internal class MaxMin {
        static void Main(string[] args) {

            /*
           Console.WriteLine("5개의 숫자를 입력하세요");

           int[] arr = new int[5];
           int max = 0;
           int min = 0;


           for (int i = 0; i < arr.Length; i++) {
               arr[i] = int.Parse(Console.ReadLine());
           }

           for (int i = 0; i < arr.Length; i++) {
               max = arr[0];
               min = arr[0];

               if (min > arr[i]) {
                   min = arr[i];
               }

               if (max < arr[i]) { 
                   max= arr[i];
               }
           }

           Console.WriteLine("min" + min);
           Console.WriteLine("max" + max);
           */

            int min = 0;
            int max = 0;


            for (int i = 0; i < 5; i++) {

                int n = int.Parse(Console.ReadLine());

                if (i == 0) {
                    min = n;
                    max = n;
                }
                if (min > n) {
                    min = n;
                }
                if (max < n) {
                    max = n;
                }
            }

            Console.WriteLine("min" + min);
            Console.WriteLine("max" + max);
        }
    }
}
