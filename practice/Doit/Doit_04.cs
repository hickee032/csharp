using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person {
    public string Name;
    public string Birthday;
    public string Gender;

    public void Eat() {
        Console.WriteLine(Name + "이(가) 아침을 먹습니다. ");
    }
    public void Walk() {
        Console.WriteLine(Name + "이(가) 걷는다 ");
    }
    public void Run() {
        Console.WriteLine(Name + "이(가) 뛴다 ");
    }
}

namespace class_instance {
    internal class Program {
        static void Main(string[] args) {

            Person p1= new Person();
            p1.Name = "미미";
            p1.Eat();



        }
    }
    
}
