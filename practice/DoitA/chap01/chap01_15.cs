using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_Multi99Table {
    internal class chap01_Multi99Table {
        static void Main(string[] args) {
            Console.WriteLine("구구단");

            for (int i = 1; i < 10; i++) {
                for (int j = 1; j < 10; j++) {
                    Console.Write(i * j);
                }
                Console.WriteLine();
            }

        }
    }
}
