using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Random {
    internal class Array_Name {
        static void Main(string[] args) {


            //빈배열 (20)을 생성 아래의 이름을 랜덤으로 추가
            string[] name = new string[] { "kim", "hong", "pack", "lee", "cho", "son" };
            string[] arr = new string[20];
            int[] count = new int[name.Length];


            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = name[rand.Next(name.Length)];
            }

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine($"{arr[i]}");
            }


            for (int i = 0; i < name.Length; i++) {
                for (int j = 0; j < arr.Length; j++) {

                    if (name[i] == arr[j]) {
                        count[i] += 1;
                    }
                }
            }

            for (int i = 0; i < count.Length; i++) {

                Console.WriteLine($"{name[i]}" + " : " + $"{count[i]}");
            }



        }
    }
}
