using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Max3Func {

    public int Max3Fun(int a, int b, int c) {
        int max = a;
        if (b > max) {
            max = b;
        }
        if (c > max) {
            max = c;
        }

        return max;
    }

}

namespace chap01_max3Function {

    internal class chap01_max3Function {
        static void Main(string[] args) {
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Max3Func mf = new Max3Func();
            
            Console.WriteLine(mf.Max3Fun(a, b, c));

        }

        
    }
    
}
