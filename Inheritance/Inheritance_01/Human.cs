using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_02 {
    internal class Human {

        private string name;
        private int age;

        public Human(string aName,int aAge) {
            this.name = aName;
            this.age = aAge;
        }
        public virtual void intro() {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"나이 : {age}");
        }
    }

    internal class Student : Human {

        protected int stNum;
        public Student (string aNname,int aAge, int aStNum) : base(aNname, aAge) {

            this.stNum = aStNum;
        }
        public override void intro() {
            base.intro();
            Console.WriteLine($"학번 : {stNum}");
        }
        public void study() {
            Console.WriteLine("Study");
        }
    }
}
