using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIt_Algorithm {
    internal class chap01_max3 {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("a의 값 = " + a);
            Console.WriteLine("b의 값 = " + b);
            Console.WriteLine("c의 값 = " + c);

            int max = a;

            if(b > max) { max= b; }
            if(c > max) { max= c; }

            Console.WriteLine("Max Number is " + max);
        }
    }
}
