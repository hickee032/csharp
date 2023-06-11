using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink {
    internal class Drink {
        static void Main(string[] args) {


            Console.WriteLine("--------------");
            Console.WriteLine("음료수 자판기");
            Console.WriteLine("--------------");
            Console.WriteLine("1.콜라 2100원");
            Console.WriteLine("2.사이다 2000원");
            Console.WriteLine("3.환타 1500원");
            Console.WriteLine("4.암바사 1700원");
            Console.WriteLine("5.웰치스 1800원");
            Console.WriteLine("--------------");
            Console.Write("음료수를 선택 >");

            int n = 0;
            int money = 0;
            int change = 0;

            try {
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception) {

                Console.WriteLine("잘못된 번호를 입력하였습니다.");
                Console.WriteLine("프로그램을 종료 합니다.");
                Environment.Exit(1);
                throw;
            }

            switch (n) {
                case 1:
                    Console.WriteLine("콜라를 선택하셨습니다.");
                    Console.WriteLine("음료수 금액을 입력 >");
                    money = int.Parse(Console.ReadLine());
                    if (money < 2100) {
                        Console.WriteLine("구입할수 없습니다.");
                    }
                    else {
                        change = money - 2100;
                        Console.WriteLine("거스름돈은 {0,0:N0}원 입니다.", change);
                        Console.WriteLine("거스름돈은 {0:#,0}원 입니다.", change);
                    }
                    break;
                case 2:
                    Console.WriteLine("사이다를 선택하셨습니다.");
                    Console.WriteLine("음료수 금액을 입력 >");
                    money = int.Parse(Console.ReadLine());
                    if (money < 2000) {
                        Console.WriteLine("구입할수 없습니다.");
                    }
                    else {
                        change = money - 2000;
                        Console.WriteLine("거스름돈은 {0:C0}원 입니다.", change);
                    }
                    break;
                case 3:
                    Console.WriteLine("환타를 선택하셨습니다.");
                    Console.WriteLine("음료수 금액을 입력 >");
                    money = int.Parse(Console.ReadLine());
                    if (money < 1500) {
                        Console.WriteLine("구입할수 없습니다.");
                    }
                    else {
                        change = money - 1500;
                        Console.WriteLine("거스름돈은 {0:C0}원 입니다.", change);
                    }
                    break;
                case 4:
                    Console.WriteLine("암바사를 선택하셨습니다.");
                    Console.WriteLine("음료수 금액을 입력 >");
                    money = int.Parse(Console.ReadLine());
                    if (money < 1700) {
                        Console.WriteLine("구입할수 없습니다.");
                    }
                    else {
                        change = money - 1700;
                        Console.WriteLine("거스름돈은 {0:C0}원 입니다.", change);
                    }
                    break;
                case 5:
                    Console.WriteLine("웰치스를 선택하셨습니다.");
                    Console.WriteLine("음료수 금액을 입력 >");
                    money = int.Parse(Console.ReadLine());
                    if (money < 1800) {
                        Console.WriteLine("구입할수 없습니다.");
                    }
                    else {
                        change = money - 1800;
                        Console.WriteLine("거스름돈은 {0:C0}원 입니다.", change);
                    }
                    break;
            }
        }
    }
}
