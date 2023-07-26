using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_pr {
    internal class Program {
        static void Main(string[] args) {

            ArrayList al = new ArrayList();

            //추가
            al.Add(1);
            al.Add("hello");
            al.Add(3.3);
            al.Add(true);

            //출력
            foreach (var item in al) {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //삭제
            al.Remove("hello");

            foreach (var item in al) {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }
    }
}
