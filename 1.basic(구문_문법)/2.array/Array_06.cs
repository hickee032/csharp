using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_array_06 {
    internal class Array_06 {
        static void Main(string[] args) {
            /*
             문제 6

            요소수값을 입력받아, 아래와 같이 출력하는
            프로그램을 작성하시오.
            단, 배열에 들어가는 수는 Random()메서드를 이용한다.
            Random()메서드를 이용하기 위해서는 java.util.* 을 임포트 한다.

            실행결과

            요소 수: 8
            a[0] : ****
            a[1] : *******
            a[2] : ******
            a[3] : **
            a[4] : ***
            a[5] : *
            a[6] : ******
            a[7] : ********
             */

            Random rand = new Random();

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("길이 입력");
            int[] arr = new int[input];

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = i + 1;
            }

            for (int i = 0; i < arr.Length; i++) {

                int n = rand.Next(arr.Length);

                int tmp = arr[0];
                arr[0] = arr[n];
                arr[n] = tmp;

            }

            for (int i = 0; i < arr.Length; i++) {
                Console.Write("arr[" + i + "] : ");
                for (int j = 0; j < arr[i]; j++) {
                    if (j == arr[i] - 1) {
                        Console.WriteLine("*");
                    }
                    else {
                        Console.Write("*");
                    }

                }
            }
        }
    }
}
