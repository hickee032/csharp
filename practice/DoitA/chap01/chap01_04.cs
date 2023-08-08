using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_judgesign {
    internal class chap01_judgesign {
        static void Main(string[] args) {

            int input = int.Parse(Console.ReadLine());

            if (input>0) {
                Console.WriteLine("양수");
            }
            else if (input < 0) {
                Console.WriteLine("음수");
            }
            else {
                Console.WriteLine("0 입니다");
            }


        }
    }
}
