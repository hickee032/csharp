using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_arrary_03 {
    internal class array_04 {
        static void Main(string[] args) {

            /*문제 4
                아래와 같이 출력되도록 프로그램을 작성하시오.

                --------------------------------------------------------------------------
                멤버변수	
                --------------------------------------------------------------------------
                타입		변수명		설명
                int[]		score		{79, 88, 91, 33, 100, 55, 95} 으로 초기화
                int 		max
                int		min 
                --------------------------------------------------------------------------

                실행결과
                최대값 :100
                최소값 :33
             */

            int[] score = { 79, 88, 91, 33, 100, 55, 95 };

            int min = score[0];
            int max = score[0];

            for (int i = 0; i < score.Length; i++) {

                if (min > score[i]) {
                    min = score[i];
                }
                if (max < score[i]) {
                    max= score[i];
                }
            }

            Console.WriteLine("최소값 : " + min);
            Console.WriteLine("최대값 : " + max);



        }
    }
}
