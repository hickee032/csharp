using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Score {
    internal class Program {
        static void Main(string[] args) {

            Random rand = new Random();
            stdSore sc = new stdSore();

            int[,] score = new int[5,3];


            for (int i = 0; i < score.GetLength(0); i++) {
                for (int j = 0; j < score.GetLength(1); j++) {
                    score[i, j] = rand.Next(40, 100);
                }
            }

            for (int i = 0; i < score.GetLength(0); i++) {

                Console.WriteLine(i + "번 학생의 합계" + sc.getSum(score[i, 0], score[i, 1], score[i, 2]));
                Console.WriteLine(i + "번 학생의 평균" + "{0:.00}",sc.getAvr(score[i, 0], score[i, 1], score[i, 2]));
                Console.WriteLine(i + "번 학생의 등급" + sc.getGrade(sc.getAvr(score[i, 0], score[i, 1], score[i, 2])));
            }
        }
    }
}
