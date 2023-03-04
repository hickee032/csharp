using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_SingleTone {
    internal class SingleTest {

        private static SingleTest inst;
        private int data;

       static Random rd = new Random();

        public SingleTest() {

            data = rd.Next(1,100);
        }
        public static SingleTest getInstance() {

            if (inst == null) {
                inst = new SingleTest();
            }
            return inst;        
        }
        public int getData() {
            return data;
        }
    }
}
