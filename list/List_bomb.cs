using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_02 {
    internal class Bomb_List {
        static void Main(string[] args) {

            Random rand = new Random();
            
            string[] strBomb = new string[2] { "B", "#" };
            
            List<string> list = new List<string>();

            Console.WriteLine("길이를 입력하세요");
            int range = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < range; i++) {
                list.Add(strBomb[rand.Next(strBomb.Length)]);
            }

            int n = list.Count;

            int[] bombCnt = new int[n];

            for (int i = 0; i < n; i++) {
                if (i == 0) {
                    for (int j = i; j <=  i+1; j++) {
                        if (list[j].Equals("B")) {
                            bombCnt[i] += 1;
                        }
                    }
                }
                if (i ==(n-1)) {
                    for (int j = i-1; j <= i; j++) {
                        if (list[j].Equals("B")) {
                            bombCnt[i] += 1;
                        }
                    }
                }
                if (i != (n - 1) && i!=0) {
                    for (int j = i-1; j < i + 2; j++) {
                        if (list[j].Equals("B")) {
                            bombCnt[i] += 1;
                        }
                    }
                }
              
            }

            Console.WriteLine(string.Join(",", list));
            Console.WriteLine(string.Join(",", bombCnt));

        }
    }
}
