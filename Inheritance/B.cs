using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_01 {
    internal class Parent {

        public int num;

        public Parent() {
            Console.WriteLine("부모 클래스 생성자 호출");
        }
    }
    internal class Child : Parent {
        
        public Child(int num) { 
            this.num = num;
            Console.WriteLine("자식 클래스 생성자 호출");
        }

        public void outNum() {
            Console.WriteLine("num의 값은 {0}", num);
        }

        class Program {
            static void Main(string[] args) {

                Child cd = new Child(10);
                cd.outNum();
            }
        }
    
    }
}
