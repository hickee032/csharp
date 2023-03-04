using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Array {
    internal class Program {
        static void Main(string[] args) {
            int[] arr = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10 };

            Arrcal ac= new Arrcal();

            Console.WriteLine($"배열의 합 : {ac.sumArr(arr)}");
            Console.WriteLine($"배열의 평균 : {ac.avrArr(arr)}");


        }
    }
}
