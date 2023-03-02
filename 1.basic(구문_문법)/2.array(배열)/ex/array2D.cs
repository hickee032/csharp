using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2D_01 {
    internal class Array2D_01 {
        static void Main(string[] args) {
            //2차원 배열 초기화 1
            int[,] arr2Int = { { 1, 2, 3 }, { 4, 5, 6 } }; //3차원 배열의 경우는  int arr[,,]

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write(arr2Int[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //GetLength() --바깥쪽 0 안쪽 1 (2차원배열)
            for (int i = 0; i < arr2Int.GetLength(0); i++) {
                for (int j = 0; j < arr2Int.GetLength(1); j++) {
                    Console.Write(arr2Int[i, j] + "\t");
                }
                Console.WriteLine();
            }

                Console.WriteLine("-----------------------------------");

            //2차원 배열 초기화 2
            //readonly (런타임(프로그램 실행 시점) 시점) , const(컴파일 시점) 상수변수 (고정된 값 : 바뀌지 않음 ) 반드시 상수 값(스칼라)이 필요함
            const int SIZE_ROW = 2; //행
            const int SIZE_COL = 3; //열

            int[,] arr2Int2 = new int[SIZE_ROW, SIZE_COL] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < SIZE_ROW; i++) {
                for (int j = 0; j < SIZE_COL; j++) {
                    Console.Write(arr2Int2[i, j] + "\t");
                }
                Console.WriteLine();
            }

                Console.WriteLine("-----------------------------------");

            //2차원 배열 초기화 3
            string[][] arrStr = new string[2][];
            //string[][] arrStr1 = new string[2][3]; --이렇게 쓸수는 없다
            arrStr[0] = new string[] { "Kim", "Pack", "Hong" };
            arrStr[1] = new string[] { "Lee" }; //가변적인 2차원 배열 형태

            for (int i = 0; i < arrStr.Length; i++) {
                for (int j = 0; j < arrStr[i].Length; j++) {
                    Console.Write(arrStr[i][j] + "\t");
                }
                Console.WriteLine();
            }

                Console.WriteLine("-----------------------------------");

            //2차원 배열 초기화 4
            int[][] arrInt4= new int[2][];
            for (int i = 0; i < arrInt4.Length; i++) {
                arrInt4[i] = new int[i + 1];
                for (int j = 0; j < arrInt4[i].Length; j++) {
                    arrInt4[i][j] = 10 + j;
                    Console.Write(arrInt4[i][j] + "\t");
                }
                Console.WriteLine();
            }

                Console.WriteLine("-----------------------------------");

            //3행 4열로 바꾸기
            int[][] arrInt5 = new int[3][];
            for (int i = 0; i < arrInt5.Length; i++) {
                arrInt5[i] = new int[i + 2];
                for (int j = 0; j < arrInt5[i].Length; j++) {
                    arrInt5[i][j] = 10 + j;
                    Console.Write(arrInt5[i][j] + "\t");
                }
                Console.WriteLine();
            }

                Console.WriteLine("-----------------------------------");

            int[][] arrInt6 = new int[3][];
            for (int i = 0; i < arrInt6.Length; i++) {
                arrInt6[i] = new int[4];
                for (int j = 0; j < arrInt6[i].Length; j++) {
                    arrInt6[i][j] = 10 + j;
                    Console.Write(arrInt6[i][j] + "\t");
                }
                Console.WriteLine();
            }

                Console.WriteLine("-----------------------------------");

            //2차월 배열 foreach 사용 
            //int [,] 는 사용할수 없다 c#만 가능
            int[][] arr2Each = {
                new int[] {1,2,3},
                new int[] {4,5,6},
            };

            foreach (int[] arr in arr2Each) {
                foreach(int n in arr) {
                    Console.Write(n + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
