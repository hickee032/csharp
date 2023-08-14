using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_SumVerboss2 {
    internal class chap01_SumVerboss2 {
        static void Main(string[] args) {
            
            int sum = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++) {
                Console.Write(i+" + ");
                sum += i;
            }

            Console.Write(n+" = ");
            sum += n;
            Console.WriteLine(sum);
        }
    }
}
