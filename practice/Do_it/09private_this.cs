using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cat {

    private string name;

    public void SetName(string name) {
        this.name = name;
    }


    public string GetName() { 
        return this.name;
    }
}

namespace private_this {
    internal class Program {
        static void Main(string[] args) {
            Cat myCat= new Cat();
            myCat.SetName("Molli");
            Console.WriteLine("my cat name is"+myCat.GetName());

        }
    }
}
