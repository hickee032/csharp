using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch {
    internal class Program {
        static void Main(string[] args) {
            /*
            Console.WriteLine("나눌 숫자를 입력");
            int div = int.Parse(Console.ReadLine());
            Console.WriteLine(10 / div);
            //예외가 발생함
            */

            Console.WriteLine("나눌 숫자를 입력");
            int div = int.Parse(Console.ReadLine());

            try {
                Console.WriteLine(10 / div);
            }
            catch(Exception e) {
                Console.WriteLine("0으로 나눌수 없음"); ;
                Console.WriteLine("예외메세지 - " + e.Message);
            }
           
        }
    }
}
