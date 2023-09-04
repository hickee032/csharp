using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap02_intArray {
    internal class chap02_intArray {
        static void Main(string[] args) {

            int[] arr = new int[5];

            arr[1] = 37;
            arr[2] = 51;
            arr[4] = arr[1]*2;

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
