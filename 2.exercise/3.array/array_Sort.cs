using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sort {
    internal class Program {
        static void Main(string[] args) {

            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = i+1;
            }

            Console.WriteLine("기본 arr = [" + string.Join(",", arr)+"]");

            //랜덤으로 섞기
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++) {

                int n = rand.Next(arr.Length);

                int tmp = arr[i];
                arr[i] = arr[n];
                arr[n] = tmp;
            }

            Console.WriteLine("섞은 후 arr = [" + string.Join(",", arr) + "]");

            //sort 
            Array.Sort(arr);

            Console.WriteLine("정렬 후 arr = [" + string.Join(",", arr) + "]");

            Array.Reverse(arr);
            Console.WriteLine("정렬 내림차순 arr : [" + string.Join(",", arr) + "]");


            for (int i = 0; i < arr.Length; i++) {
                for (int j = 0; j <= arr.Length - 1; j++) {
                    if (arr[i] > arr[j]) {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            Console.WriteLine("for 정렬1 arr : [" + string.Join(",", arr) + "]");

            for (int i = 0; i < arr.Length; i++) {
                for (int j = 0; j <= arr.Length - 1; j++) {
                    if (arr[i] < arr[j]) {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            Console.WriteLine("for 정렬2 arr : [" + string.Join(",", arr) + "]");

        }
    }
}
