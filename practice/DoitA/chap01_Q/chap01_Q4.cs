using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_Q4 {
    class Median {
        public int Med4(int a, int b, int c, int d) {
            int n = 0;

            if (a >= b) {
                if (b >= c) {
                    if (c >= d) {
                        return c;
                    }
                }
                else if (a <= c) {
                    if (a <= d) {
                        return a;
                    }
                }
                else if (b <= c) {
                    if (b <= d) {
                        return b;
                    }
                }
                else {
                    return d;
                }
            }
            else if (a > d) {
                return a;
            }
            else if (b > d) {
                return c;
            }
            else if (c > d) {
                return d;
            }
            return b;
        }
    }
    internal class chap01_Q4 {
        static void Main(string[] args) {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Median md = new Median();
            int n = md.Med4(a, b, c, d);

            Console.WriteLine(n);

        }
    }
}
