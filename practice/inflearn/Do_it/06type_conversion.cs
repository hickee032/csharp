using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_conversion {
    internal class Program {
        static void Main(string[] args) {
            /*
             * overflow
            sbyte value = 128;
            //상수 값으로 변환할수 없다 
            Console.WriteLine(value);
            */

            /*
            sbyte value1 = 64;
            sbyte value2 = 64;
            sbyte value3 = value1 + value2;

            //암시적으로 'int' 형식을 'sbyte' 형식으로 변환할 수 없습니다. 
            //명시적 변환이 있습니다.캐스트가 있는지 확인하세요

            Console.WriteLine(value3);
            */

            sbyte value1 = 64;
            sbyte value2 = 64;
            int value3 = value1 + value2;
            Console.WriteLine(value3);
        }
    }
}
