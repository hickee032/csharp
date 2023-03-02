using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_10 {
    internal class Array_10 {
        static void Main(string[] args) {
            /*
            문제 10

            배열요소의 순서를 역순으로 표시하는 프로그램을 작성하시오
            역시 Math.Random메서드를 이용하여 먼저 해당하는 배열에 
            랜덤값으로 치환하고 그것을 출력하고 역순으로 출력하시오.

            실행결과
            요소수 : 7  사용자로부터 입력
            a[0] = 22
            a[1] = 57
            a[2] = 11
            a[3] = 32
            a[4] = 91
            a[5] = 68
            a[6] = 70

            위의 배열을 역순 출력함.
            a[0] = 70
            a[1] = 68
            a[2] = 91
            a[3] = 32
            a[4] = 11
            a[5] = 57
            a[6] = 22
             
             */

            int input = int.Parse(Console.ReadLine());
            int[] arr = new int[input];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1, 100);
            }

            Console.WriteLine("arr 배열 = ["+string.Join(",",arr)+"]");

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine("arr["+i+"] = " + arr[i]);  
            }

            Console.WriteLine("Array.Reverse 사용");
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine("arr[" + i + "] = " + arr[i]);
            }

            for (int i = 0; i < arr.Length/2; i++) {
                
                int tmp  = arr[i];
                arr[i] = arr[arr.Length-i - 1];
                arr[arr.Length -i - 1] = tmp;
            }


            Console.WriteLine("arr 배열 = [" + string.Join(",", arr) + "]");

        }
    }
}
