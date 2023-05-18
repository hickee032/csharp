using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddFor {
    internal class AddFor {
        static void Main(string[] args) {

            int result = 0;

            Console.WriteLine("-------------------");
            Console.WriteLine("합을 구하는 프로그램");
            Console.WriteLine("-------------------");

            Console.Write("숫자1 : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("숫자2 : ");
            int m = int.Parse(Console.ReadLine());

            if (n > m) {
                int tmp = n;
                n = m;
                m = tmp;
            }

            for (int i = n; i <= m; i++) {
                result += i;
            }
            Console.WriteLine("결과는 {0}", result);
        }
    }
}
