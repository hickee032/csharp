using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_Q13 {

    class Square {
        public void foursquare(int n) {

            for (int i = 1; i <= n; i++) {

                for (int j = 1; j <= n; j++) {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }
        }
    }

    internal class Program {
        static void Main(string[] args) {

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("개수 : "+a);

            Square sq = new Square();
            sq.foursquare(a);

        }
    }
}
