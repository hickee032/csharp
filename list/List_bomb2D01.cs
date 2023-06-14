using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb2D_01 {
    internal class Bomb2D_01 {
        static void Main(string[] args) {

            Console.Write("X의 값 : ");
            int inputX = int.Parse(Console.ReadLine());
            Console.Write("Y의 값 : ");
            int inputY = int.Parse(Console.ReadLine());

            Random random = new Random();
            string[] bomb = { "B", "#" };

            //지뢰찾기 맵
            string[,] Loc = new string[inputX, inputY];
            //지뢰의 개수를 저장
            int[,] count = new int[inputX, inputY];

            for (int i = 0; i < inputX; i++) {
                for (int j = 0; j < inputY; j++) {
                    Loc[i, j] = bomb[random.Next(bomb.Length)];
                }
            }

            for (int i = 0; i < inputX; i++) {
                for (int j = 0; j < inputY; j++) {

                    Console.Write(Loc[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("=====");

            
            for (int i = 0; i < inputX; i++) {
                for (int j = 0; j < inputY; j++) {
                    if (Loc[i,j].Equals("B")) {
                        count[i,j]++;
                        //위
                        if (i-1 >=0) {
                            count[i - 1, j]++;
                            if (j-1>=0) {
                                count[i - 1, j - 1]++;
                            }
                            if (j + 1 < inputY) {
                                count[i - 1, j + 1]++;
                            }
                        }
                        //아래    
                        if (i + 1 < inputX) {
                            count[i + 1, j]++;
                            if (j - 1 >= 0) {
                                count[i + 1, j - 1]++;
                            }
                            if (j + 1 < inputY) {
                                count[i + 1, j + 1]++;
                            }
                        }
                        //좌우
                        if (j - 1 >= 0) {
                            count[i, j - 1]++;
                        }
                        if (j + 1 < inputY) {
                            count[i, j + 1]++;
                        }
                    }
                   
                }
            }


            for (int i = 0; i < inputX; i++) {
                for (int j = 0; j < inputY; j++) {

                    Console.Write(count[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
