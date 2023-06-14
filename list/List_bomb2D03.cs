using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_02 {
    internal class Program {
        static void Main(string[] args) {
            //* 지뢰 . 빈공간
            //좌우로 지뢰찾기
            string[] bomb = {
                "B","E","B","B","B","E","E"
            };
            Console.WriteLine(string.Join("|", bomb));

            int[] count = new int[bomb.Length];

            //[B|E|B|B|B|E|E]
            // 1 2 2 3 2 1 0

            for (int i = 0; i < bomb.Length; i++) {

                if (i == 0) {
                    for (int j = i; j < i+2; j++) {
                        if (bomb[j].Equals("B")) {
                            count[i]++;
                        }
                    }
                }
                else if (i == (bomb.Length - 1)) {
                    for (int j = i-1; j < i+1; j++) {
                        if (bomb[j].Equals("B")) {
                            count[i]++;
                        }
                    }
                }
                else {
                    for (int j = i - 1; j < i + 2; j++) {
                        if (bomb[j].Equals("B")) {
                            count[i]++;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(",", count));
        }
    }
}
