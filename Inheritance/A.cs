using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
    public class A {
        private int numVal = 10;
        public class B : A {

            public int GetVal() { 
                return numVal; 
            }

        }
    }
    public class C : A {

        //사용 불가
        /*
       public int GetVal() {
               return numval;
           }
        */
    }

    public class accessExample {
        public static void Main(string[] args) {

            var b = new A.B();
            Console.WriteLine(b.GetVal());


        }
    }

}
