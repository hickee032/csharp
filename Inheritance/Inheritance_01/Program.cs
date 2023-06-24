using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_02 {
    internal class Program {
        static void Main(string[] args) {
            Student kim = new Student("JiMin",25,980111);
            kim.intro();
            kim.study();

        }
    }
}
