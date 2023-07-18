using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cat {

    public string Name;

    public Cat() {
        Console.WriteLine("생성자의 호출 1");
    }
    public Cat(string name) {
        Console.WriteLine("생성자의 호출 2");
        Console.WriteLine("고양이의 이름은 "+ name + "입니다");
    }
    public Cat(string name, int weight) {
        Console.WriteLine("생성자의 호출 3");
        Console.WriteLine("고양이의 이름은 " + name + "입니다");
        Console.WriteLine("몸무게는 " + weight + "입니다");
    }

    //소멸자 - 강제로 사용 할경우 오류가 발생할 확률이 높아짐
    ~Cat() {
        Console.WriteLine(Name + "사라짐");
    }
}



namespace class_overloading {
    internal class Program {
        static void Main(string[] args) {

            Cat myCat= new Cat();
            Cat myCat1 = new Cat("꼬비");
            Cat myCat2 = new Cat("은비", 10);
        }
    }
}
