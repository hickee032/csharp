using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_04 {
    internal class CoinExchange {
        static void Main(string[] args) {

            //동전교환 프로그램
            Console.WriteLine("동전교환 프로그램");
            Console.Write("금액을 입력");
            int input = int.Parse(Console.ReadLine());

            int[] arr = { 500, 100, 50, 10 };

            for (int i = 0; i < arr.Length; i++) {

                int total = input / arr[i];
                input = input % arr[i];
                Console.WriteLine(arr[i] + "원 " + "동전 :" + total + "개 ");
            }
            Console.WriteLine("잔돈 : " + input);

        }
    }
}
