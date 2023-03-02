using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_01 {
    internal class Loop_01 {
        static void Main(string[] args) {
            //반복문
            //for, while, do-while c언어와 문법 동일
            //foreach 향상된 for문

            string[] arr = { "홍길동", "김길동", "박길동" };
            int[] arr1 = { 10, 20, 30 };
            
            //문자열
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }

            foreach (string i in arr) {
                Console.WriteLine(i);
            }

            //숫자
            for (int i = 0; i < arr1.Length; i++) {
                Console.WriteLine(arr1[i]);
            }

            foreach (int i in arr1) {
                Console.WriteLine(i);
            }

            foreach (var i in arr1) {
                Console.WriteLine(i);
            }
        }
    }
}
