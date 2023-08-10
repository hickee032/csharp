using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_SumWhile {
    internal class Program {
        static void Main(string[] args) {
            //1부터 n
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int sum = 0;

            while (i<=n) {
                sum+= i;
                i++;
            }
            Console.WriteLine("합 : "+sum);
        }
    }
}
