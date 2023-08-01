using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_pr {
    internal class Program {
        static void Main(string[] args) {

            Stack st = new Stack();
            //추가
            st.Push(1);
            st.Push(2);
            st.Push(3);

            //삭제
            while (st.Count>0) {
                Console.WriteLine(st.Pop());
                //역순으로 출력 queue 반대
            }

        }
    }
}
