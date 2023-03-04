using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Array {
    internal class Arrcal {

       private double avr;
       private int sum;

        
       public int sumArr(int[] arr) {

            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }
            return sum;
        }
        public double avrArr(int[] arr) {
            sum = 0;
            avr = (double)(sumArr(arr) / arr.Length);

            return avr;
        }

        public double getAvr() {
            return avr;
        }
        public int getSum() {
            return sum;
        }



    }
}
