using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap01_Q7 {
    internal class chap01_Q7 {
        static void Main(string[] args) {

            // 가우스 (1+10)*5
            int result = 0;
            Console.WriteLine("1부터 n까지의 합을 구합니다");
            Console.Write("n의 값 : ");
            int input = int.Parse(Console.ReadLine());

            if ((input % 2) != 0) {
                Console.WriteLine("나누기" + input / 2);
                result = ((1 + (input-1)) * (input / 2))+input;
            }
            else {
                result = (1 + input) * (input / 2);
            }

            

            Console.WriteLine(result);


        }
    }
}
