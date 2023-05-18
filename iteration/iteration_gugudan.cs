using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gugudan {
    internal class Gugudan {
        static void Main(string[] args) {

            /*
            Console.WriteLine("----------------------");
            Console.WriteLine("구구단 프로그램");
            Console.WriteLine("----------------------");
            Console.Write("단수를 입력 : ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++) {
                Console.WriteLine(n +" X "+i +" = "+n*i);
            }
            */
            Console.WriteLine("----------------------");
            Console.WriteLine("구구단 프로그램 (전부 뜸)");
            Console.WriteLine("----------------------");

            for (int i = 1; i < 10; i++) {
                for (int j = 2; j < 10; j++) {

                    Console.Write($"{j}" + "x" + $"{i}" + "=" + $"{j * i}\t");
                }
                Console.WriteLine();
            }





        }
    }
}
