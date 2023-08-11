using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_SumFor {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= n; i++) {
                sum=sum+i;
            }

            Console.WriteLine(sum);
            

        }
    }
}
