using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @operator {
    internal class Program {
        static void Main(string[] args) {
            int num = 0;
            Console.WriteLine(num++);
            Console.WriteLine(num);
            Console.WriteLine(num--);
            Console.WriteLine(num);

            bool result;
            int num1 = 3;
            int num2 = 4;

            result= num1 > num2;
            Console.WriteLine(result);

            result= num1 < num2;
            Console.WriteLine(result);

            result= num1 >= num2;
            Console.WriteLine(result);

            result= num1 <= num2;
            Console.WriteLine(result);
        }
    }
}
