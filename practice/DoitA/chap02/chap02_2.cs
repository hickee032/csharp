using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap02_IntArrayInit {
    internal class chap02_IntArrayInit {
        static void Main(string[] args) {

            int[] arr = {1, 2,3,4,5};

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine("arr["+i+"] : "+ arr[i]);
            }
        }
    }
}
