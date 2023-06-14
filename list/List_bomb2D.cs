using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_03 {
    internal class Bomb2D_List {
        static void Main(string[] args) {

            Random random= new Random();
            string[] bomb = { "B", "#" };

            Console.Write("X 의 값 : ");
            int inputX= int.Parse(Console.ReadLine());  //2

            Console.Write("Y 의 값 : ");
            int inputY = int.Parse(Console.ReadLine()); //3

            string[,] bombLoc = new string[inputX, inputY];
            int[,] count = new int[inputX, inputY];

            for (int i = 0; i < inputX; i++) {
                for (int j = 0; j < inputY; j++) {
                    bombLoc[i, j] = bomb[random.Next(bomb.Length)];
                }
            }

            for (int i = 0; i < inputX; i++) {
                for (int j = 0; j < inputY; j++) {
                    Console.Write(bombLoc[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < inputX; i++) {
                for (int j = 0; j < inputY; j++) {

                    if (i == 0) {
                        for (int x = i; x <= i + 1; x++) {

                            if (j == 0) {
                                for (int y = j ; y <= j+1; y++) {
                                    if (bombLoc[x,y].Equals("B")) {
                                        count[i, j] += 1;
                                    }
                                }
                            }

                            if (j == (inputY - 1)) {
                                for (int y = j - 1; y <= j; y++) {
                                    if (bombLoc[x, y].Equals("B")) {
                                        count[i, j] += 1;
                                    }
                                }
                            }

                            if(j != (inputY - 1) && j != 0) {
                                for (int y = j-1; y <= j+1; y++) {
                                    if (bombLoc[x, y].Equals("B")) {
                                        count[i, j] += 1;
                                    }
                                }
                            } 
                        }
                    }
                    if (i == (inputX-1)) {
                        for (int x = i-1; x <= i; x++) {

                            if (j == 0) {
                                for (int y = j; y <= j + 1; y++) {
                                    if (bombLoc[x, y].Equals("B")) {
                                        count[i, j] += 1;
                                    }
                                }
                            }

                            if (j == (inputY - 1)) {
                                for (int y = j - 1; y <= j; y++) {
                                    if (bombLoc[x, y].Equals("B")) {
                                        count[i, j] += 1;
                                    }
                                }
                            }

                            if (j != (inputY - 1) && j != 0) {
                                for (int y = j - 1; y <= j + 1; y++) {
                                    if (bombLoc[x, y].Equals("B")) {
                                        count[i, j] += 1;
                                    }
                                }
                            }
                        }
                    }
                    if (i != 0 && i != (inputX - 1)) {
                        for (int x = i-1; x <= i + 1; x++) {

                            if (j == 0) {
                                for (int y = j; y <= j+1; y++) {
                                    if (bombLoc[x, y].Equals("B")) {
                                        count[i, j] += 1;
                                    }
                                }
                            }
                            if (j == (inputY - 1)) {
                                for (int y = j - 1; y <= j; y++) {
                                    if (bombLoc[x, y].Equals("B")) {
                                        count[i, j] += 1;
                                    }
                                }
                            }
                            if (j != (inputY - 1) && j != 0) {

                                for (int y = j - 1; y <= j + 1; y++) {

                                    if (bombLoc[x, y].Equals("B")) {
                                        count[i, j] += 1;
                                    }
                                }
                            }
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
