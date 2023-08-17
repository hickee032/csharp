using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace chap01_PrintStar2 {
    internal class chap01_TwoDigits {
        static void Main(string[] args) {

            int n = 0;

            do {
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("n : "+n);

            } while (n <10 || n >99);

            Console.WriteLine("n > " + n);
        }
    }
}
