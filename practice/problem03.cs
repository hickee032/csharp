using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem03 {
    internal class Program {
        static void Main(string[] args) {

            string input = Console.ReadLine();
            char a = char.Parse(input);

            if (a.Equals('+')) {
                Console.WriteLine(a);
            }
            else {

                Console.WriteLine('X');
            }

            


        }
    }
}
