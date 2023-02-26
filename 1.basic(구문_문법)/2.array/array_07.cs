using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Array_07 {
    internal class Array_07 {
        static void Main(string[] args) {

            /*
             문제 7
                실행결과와 같이 되도록 프로그램을 작성하시오.
                --------------------------------------------------------------------------
                멤버변수	
                --------------------------------------------------------------------------
                타입		변수명		설명
                int[]		ball		20개의방 생성
                --------------------------------------------------------------------------
                조건 : 배열의 i번째 요소와 임의의 요소에 
                       저장된 값을 서로 바꿔서 값을 섞은후
                       내림차순으로 정렬 후 0~5번 인덱스의 값만 
                       출력하도록 한다. 

                실행결과
                0~19번 방까지의 값 출력


                ball배열의 앞에서부터 6개만 출력(값을 섞은 후, 내림차순 소팅한 결과)
                ball[0]=20
                ball[1]=19
                ball[2]=18
                ball[3]=17
                ball[4]=16
                ball[5]=15
             */

            int[] arr = new int[20];

            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = i+1;
            }

            Console.WriteLine("섞기 전 arr : [" + string.Join(",", arr) + "]");

            //무작위로 섞음
            for (int i = 0; i < arr.Length; i++) {

                int n = rand.Next(arr.Length);

                int tmp  = arr[i];
                arr[i] = arr[n];
                arr[n] = tmp;
            }

            Console.WriteLine("섞은 후 arr : ["+string.Join(",",arr)+"]");

            //sorting
            Array.Sort(arr);
            Console.WriteLine("정렬 오름차순 arr : [" + string.Join(",", arr) + "]");

            Array.Reverse(arr);
            Console.WriteLine("정렬 내림차순 arr : [" + string.Join(",", arr) + "]");

            for (int i = 0; i < 6; i++) {

                Console.WriteLine("arr ["+i+"] : "+arr[i]);
            }

        }
    }
}
