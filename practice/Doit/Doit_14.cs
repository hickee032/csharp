using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable_pr {
    internal class Program {
        static void Main(string[] args) {
            Hashtable ht = new Hashtable();
            //키와 값이 필요
            ht["apple"] = "사과";
            ht["banana"] = "바나나";
            ht["orange"] = "오렌지";

            Console.WriteLine(ht["apple"]);
            Console.WriteLine(ht["banana"]);
            Console.WriteLine(ht["orange"]);

        }
    }
}
