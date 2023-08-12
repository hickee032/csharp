using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_SumFor2 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            do {
                Console.WriteLine("n의 값 : "+n);
                n++;
            } while (n <=0);

            int sum = 0;

            for (int i = 1; i <= n; i++) {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
