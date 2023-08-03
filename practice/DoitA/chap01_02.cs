using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_Median {
    internal class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            //1,2,3
            
            if (a >= b) {
                if(b >=c) {
                    Console.WriteLine("중앙값 : " + b);
                }
                else {
                    Console.WriteLine("중앙값 : " + a);
                }
            }
            //2,3
            else {
                if (b > c) {
                    if (a > c) {
                        Console.WriteLine("중앙값 : " + c);
                    }
                    else {
                        Console.WriteLine("중앙값 : " + b);
                    }
                }
                else {
                    Console.WriteLine("중앙값 : " + b);
                }
            }

        }
    }
}
