using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_array_02 {
    internal class array_03 {
        static void Main(string[] args) {

            /* 문제3
                배열의 요소 수와 각 요소의 값을 입력하면 실행결과와 같이 
                각 요소의 값을 표시하는 프로그램을 작성하시오.

                -------------------------------------------
                멤버변수	
                -------------------------------------------
                타입		변수명		설명
                int[]		num		사용자 입력
                int 		count		사용자 입력

                출력결과는 Array.toString()을 이용하시오.
                -------------------------------------------


                실행결과
                요소 수 : 4
                num[0] = 5
                num[1] = 7
                num[2] = 8
                num[3] = 10
                num = [ 5, 7, 8, 10 ]
            */
          
            int input = int.Parse(Console.ReadLine());

            int[] arr = new int[input];

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine("arr["+i+"] = " + arr[i] );
            }
            Console.WriteLine();
            Console.WriteLine("arr = [{0}]",string.Join(",",arr));
            

           


        }
    }
}
