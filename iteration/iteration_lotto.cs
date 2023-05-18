using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto {
    internal class Program {
        static void Main(string[] args) {

            Random random= new Random();
            int[] arr = new int[6];

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(1,45);
                for (int j = 0; j < i; j++) {
                    if (arr[i] == arr[j]) {
                        //Console.WriteLine(string.Join(",", arr));
                        i--;
                    }
                    //Console.WriteLine(string.Join(",", arr));
                }
            }
            Console.WriteLine("1.로또 번호는 : " + string.Join(",",arr));

            Array.Sort(arr);
            Console.WriteLine("1.로또 번호는 : " + string.Join(",", arr));
            Array.Reverse(arr);
            Console.WriteLine("1.로또 번호는 : " + string.Join(",", arr));

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
