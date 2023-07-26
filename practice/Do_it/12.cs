using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_pr {
    internal class Program {
        static void Main(string[] args) {

            Queue qu = new Queue();

            //추가
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);

            //제거
            while (qu.Count>0) {
                Console.WriteLine(qu.Dequeue());
            }

        }
    }
}
