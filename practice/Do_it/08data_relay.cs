using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cat {
    public string Name;
    public Cat(string name) {
        Name = name;
        Console.WriteLine("My cat name is "+ name);
    }
}

namespace data_relay {
    internal class Program {
        static void Main(string[] args) {
            Cat mycat = new Cat("CoCo");
            mycat.Name= "mimi";
            Console.WriteLine(mycat.Name);
        }
    }
}
