using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_01 {
    internal class Array_01 {
        static void Main(string[] args) {

            //1차원배열의 초기화 1

            int[] arrInt = { 10, 20, 30 };
            //배열의 이름에는 주소
            for (int i = 0; i < arrInt.Length; i++) {
                //arrInt.Length 배열의 길이
                Console.Write($"{arrInt[i]}\t");
            }
            Console.WriteLine();

            //1차원배열의 초기화 2

            char[] arrCh = new char[] { 'a', 'b', 'c', 'd', 'e' };
            /*new : 배열공간을 생성, 메모리에 별도로 할당 - 힙
                    객체지향언어에서 객체를 생성한다 - 클래스 개념*/
            
            //int[] arrInt = { 10, 20, 30 }; -- 배열 변수를 선언했다
            //char[] arrCh = new char[] { 'a', 'b', 'c', 'd', 'e' }; --배열 객체를 생성했다
            // 위에 둘 차이라고 보면 new 를 사용하면 메모리에 할당 -- 가비지 컬렉션 
            
            for (int i = 0; i < arrCh.Length; i++) {
                //arrInt.Length 배열의 길이
                Console.Write($"{arrCh[i]}\t");
            }
            Console.WriteLine();

            //1차원배열의 초기화 3
            
            //빈배열을 생성할경우 반드시 아래와 같이 사용
            string[] arrStr = new string[5];
            //Random 클래스 객체 생성
            Random rand = new Random();
            string[] name = new string[] { "KIM", "PACK", "HONG" };

            for (int i = 0; i < arrStr.Length; i++) {

               //arrStr[i] = name[rand.Next(name.Length)];
                int n = rand.Next(name.Length);
                arrStr[i] = name[n];

                Console.WriteLine($"arr {i} : "+ $"{arrStr[i]}\t");
            }
        }
    }
}
