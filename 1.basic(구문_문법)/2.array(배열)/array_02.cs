using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_array_01 {
    internal class array_01_02 {
        static void Main(string[] args) {

            /*
              배열수를 입력 받아 초기화하여 값을 출력 
 
                타입		변수명		설명
               int[]		num		    count로 배열생성
                int 		count		사용자입력	
                -------------------------------------------

                실행결과
                배열수 입력:10
                num[0] = 0
                num[1] = 0
                num[2] = 0
                num[3] = 0
                num[4] = 0
                num[5] = 0
                num[6] = 0
                num[7] = 0
                num[8] = 0
                num[9] = 0
           */

            /*
            Console.WriteLine("배열수를 입력");
            int input = int.Parse(Console.ReadLine());

            int [] array  = new int[input];

            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine("array["+i+"] : " + array[i]);

            }
             */

            /*
문제 2
요소수를 입력받아 1이상 10이하의 난수를 발생시켜 
출력하는 프로그램을 작성하시오

타입		변수명		설명
int		num		사용자 입력
int[]		arr		num으로 배열방 생성
-------------------------------------------

실행결과
요소수 입력:9
난수가 대입된것을 출력합니다.
arr[0] = 8
arr[1] = 7
arr[2] = 5
arr[3] = 8
arr[4] = 9
arr[5] = 6
arr[6] = 7
arr[7] = 2
arr[8] = 9
             */

            int input = int.Parse(Console.ReadLine());

            int[] array = new int[input];

            Random rand = new Random();

            for (int i = 0; i < array.Length; i++) {
                array[i] = rand.Next(1, 10);
            }
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine("array[" + i + "] : " + array[i]);
                
            }
        }
    }
}
