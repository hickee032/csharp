using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Score {
    internal class stdSore {
        int kor,math,eng;

        int sum;
        double avr;
        string grade;


        public int getSum(int kor,int math,int eng) {
            sum= 0;
            sum= kor+math+eng;
            return sum;
        }

        public double getAvr(int kor, int math, int eng) {
            avr = 0.0;
            avr = getSum(kor,math,eng)/3.0;
            return avr;
        }

        public string getGrade(double a) {

            string grade = " ";

            if ((90 <= a )&&( a <= 100)) {

                grade = "A";
            }
            else if ((80 <= a) && (a < 90)) {

                grade = "B";
            }
            else if ((70 <= a) && (a < 80)) {

                grade = "C";
            }
            else if ((60 <= a) && (a < 70)) {

                grade = "D";
            }
            else {
                grade = "F";
            }
            return grade;
        }

    }
}
