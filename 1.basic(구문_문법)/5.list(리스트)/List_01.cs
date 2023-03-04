using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_01 {
    internal class List_01 {
        static void Main(string[] args) {


            //컬렉션 클래스 (제네릭 클래스) - 자료구조
            //1차원 배열(선형구조) - 변수를 넣기위해서는 빈공간을 미리 확보해놔야한다

            //1. List 리스트 - 데이터를 넣을때마다 공간을 확보 (C 에서 동적할당) Linked List 라고도 함
            //List * 클래스 <string * 변수타입 (제네릭)> list = new List<string> { "Kim","Pack","Hong"};
            List<string> list = new List<string> { "Kim", "Pack", "Hong" };

            //축약된 방식
            var list2 = new List<string> { "Kim2", "Pack2", "Hong2" };

            //list 에 데이터를 추가
            list.Add("추가1"); //add는 맨뒤에 넣어짐
            list.Add("추가2");

            //foreach
            foreach (var n in list) {
                Console.Write(n + "\t");
            }
            Console.WriteLine();

            //for
            for (int i = 0; i < list.Count; i++) {
                Console.Write(list[i] + "\t");
                //Console.Write($"{list[i]}\t");
            }
            Console.WriteLine();

            Console.WriteLine(string.Join("\t", list));

            list.Insert(2, "Lee");

            foreach (var n in list) {
                Console.Write(n + "\t");
            }
            Console.WriteLine();


            //list 에 데이터를 삭제
            list.Remove("Pack");
            //list안에 두개의 Pack가 존재할경우 첫번째 것이 지워진다 (앞쪽에 있는 것이 지워짐)

            foreach (var n in list) {
                Console.Write(n + "\t");
            }
            Console.WriteLine();

        }
    }
}
