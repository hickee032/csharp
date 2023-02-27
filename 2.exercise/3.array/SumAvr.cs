using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAvr {
    internal class Program {
        static void Main(string[] args) {
            /*
            int sum = 0;
            double avr = 0.0;

            int[] arr = { 20, 34, 22, 14, 36, 23, 67 };

            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];

            }
            avr = sum / arr.Length;
            Console.WriteLine("합계 : " + sum);
            Console.WriteLine("평균 : " + avr);
            */

            int[] arr1 = new int[100];
            for (int i = 0; i < arr1.Length; i++) {
                arr1[i] = i + 1;
            }

            Console.Write("숫자를 입력");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr1.Length; i++) {
                if (arr1[i] % n == 0) {

                    Console.WriteLine(arr1[i]);
                }
            }
        }
    }
}
