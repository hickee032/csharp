using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_SumVerboss {
    internal class chap01_SumVerboss {
        static void Main(string[] args) {
            
            Console.WriteLine("1부터 n까지의 합 ?");

            int n = int.Parse(Console.ReadLine());
            int sum = 0;



            for (int i = 1; i <= n; i++) {

                if (i<n) {
                    Console.Write(i+" + ");
                    sum += i;
                }
                else {
                    Console.Write(i + " = ");
                    sum += i;
                    
                }
            }

            Console.WriteLine(sum);
        }
    }
}
