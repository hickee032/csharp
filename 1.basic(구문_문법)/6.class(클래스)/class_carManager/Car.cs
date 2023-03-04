using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CarMG {
    internal class Car {

        private string model;
        private string color;
        private int year;
        private string mFac;

        public Car(string model,string color, int year,string mFac) { 
        
            this.model = model;
            this.color = color;
            this.year = year;
            this.mFac = mFac;
        }

        public void carInfo() {
            Console.WriteLine($"모델명 : {model}");
            Console.WriteLine($"색상 : {color}");
            Console.WriteLine($"연도 : {year}");
            Console.WriteLine($"제조사 : {mFac}");
        }

        #region Getter
        public string getModel() {
            return model;
        }
        public string getColor() {
            return color;
        }
        public int getYear() {
            return year;
        }
        public string getFac() {
            return mFac;
        }
        #endregion

        #region Setter
        public void modelSet(string model) {
            this.model = model;
        }
        public void colorSet(string color) {
            this.color = color;
        }
        public void yearSet(int year) {
            this.year = year;
        }
        public void mFacSet(string mFac) {
            this.mFac = mFac;
        }
        #endregion

    }
}
