using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Lec {
    internal class Program {
        static void Main(string[] args) {
            Entry kim = new Entry("Java", "윈도우", "고급 알고리즘");
            kim.Announce();
            kim.ShowStudent();
        }
    }
}
