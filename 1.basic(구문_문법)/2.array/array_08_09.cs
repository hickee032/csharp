using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_08 {
    internal class Array_08_09 {
        static void Main(string[] args) {
            /*
             문제 8

            실행결과와 같이 되도록 프로그램을 작성하시오.

            --------------------------------------------------------------------------
            멤버변수	
            --------------------------------------------------------------------------
            타입		변수명		설명
            int[]		code		{-9, -55, 73, 116, 101, 205, 1000}초기화
            int[]		arr		10개방 생성
            --------------------------------------------------------------------------

            조건 : arr배열의 값들은 code배열에 있는 값으로만 존재함
                   아울러, 난수를 발생시켜 대입토록 한다.

            실행결과
            출력되는 값은 code배열에 있는 값으로만 구성됨
            arr배열 값 출력
            [-55, 1000, 1000, -9, 73, -9, 116, -55, 1000, 1000]
             
             */

            /*
            int[] code = new int[] { -9, -55, 73, 116, 101, 205, 1000 };
            int[] arr = new int[10];

            Random random= new Random();

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = code[random.Next(code.Length)];
            }

            Console.WriteLine("code 배열 요소  : " + string.Join(", ", code));
            Console.WriteLine("arr 배열 요소  : "+ string.Join(", ", arr));
            */

            /*
             문제 9

            배열과 반복문을 이용하여 키보드로부터 입력된 정수의
            돈의 액수를 오만원권,만원권,오천원권,천원권,오백원동전,
            백원 동전, 오십원동전, 십원동전, 일원동전이 각각 몇개로
            변환되는지를 출력해보는 프로그램을 작성하시오.

            조건 : 돈의 단위를 String 1차원배열로 만듬.

            String[] a = new String[]{"50000", "10000", "5000","1000","100", "50", "10", "5", "1"};

            실행결과
            금액을 입력하시오>>568324
            50000원권 11매
            10000원권 1매
            5000원권 1매
            1000원권 3매
            100원짜리 동전 3개
            10원짜리 동전 2개
            1원짜리 동전 4개

             */

            string[] starr = new string[] { "50000", "10000", "5000", "1000", "100", "50", "10", "5", "1" };

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < starr.Length; i++) {

                if(input > int.Parse(starr[i])) {

                    if (i >=4) {
                        Console.WriteLine(starr[i] + " 동전 " + input / int.Parse(starr[i]) + "개");
                    }
                    else { 
                    Console.WriteLine(starr[i]+" 원권 "+input / int.Parse(starr[i])+"매");
                    }
                    input = input % int.Parse(starr[i]);
                }
            }
        }
    }
}
