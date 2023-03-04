using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_SingleTone {
    internal class Program {
        static void Main(string[] args) {

            SingleTest sg1 = SingleTest.getInstance();

            SingleTest sg2 = SingleTest.getInstance();

            SingleTest sg3 = new SingleTest();
            SingleTest sg4 = new SingleTest();

            Console.WriteLine("주소값 : " + sg1.GetHashCode());
            Console.WriteLine($"SingleTest01 getData : {sg1.getData()}");
            Console.WriteLine("주소값 : " + sg2.GetHashCode());
            Console.WriteLine($"SingleTest01 getData : {sg2.getData()}");

            Console.WriteLine("주소값 : " + sg3.GetHashCode());
            Console.WriteLine($"SingleTest01 getData : {sg3.getData()}");
            Console.WriteLine("주소값 : " + sg4.GetHashCode());
            Console.WriteLine($"SingleTest01 getData : {sg4.getData()}");

        }
    }
}
